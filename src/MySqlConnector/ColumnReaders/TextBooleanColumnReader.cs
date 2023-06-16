namespace MySqlConnector.ColumnReaders;
using System.Buffers.Text;
using MySqlConnector.Protocol.Payloads;
using MySqlConnector.Protocol.Serialization;
using MySqlConnector.Utilities;

internal sealed class TextBooleanColumnReader : IColumnReader
{
	internal static TextBooleanColumnReader Instance { get; } = new TextBooleanColumnReader();

	public object ReadValue(ReadOnlySpan<byte> data, ColumnDefinitionPayload columnDefinition)
	{
		return data[0] != (byte) '0';
	}

	public int ReadInt32(ReadOnlySpan<byte> data, ColumnDefinitionPayload columnDefinition)
	{
		return data[0] != (byte) '0' ? 1 : 0;
	}
}
