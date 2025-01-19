using MudBlazor;

namespace SignalChess.Client.Models;

public static class ChessTable
{
    public static List<DropItem> StartingPosition()
    {
        return new()
{
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessRook, Color = Color.Primary, Identifier = "00" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessKnight, Color = Color.Primary, Identifier = "01" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessBishop, Color = Color.Primary, Identifier = "02" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessQueen, Color = Color.Primary, Identifier = "03" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessKing, Color = Color.Primary, Identifier = "04" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessBishop, Color = Color.Primary, Identifier = "05" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessKnight, Color = Color.Primary, Identifier = "06" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessRook, Color = Color.Primary, Identifier = "07" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "10" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "11" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "12" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "13" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "14" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "15" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "16" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Primary, Identifier = "17" },

    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "60" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "61" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "62" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "63" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "64" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "65" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "66" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessPawn, Color = Color.Secondary, Identifier = "67" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessRook, Color = Color.Secondary, Identifier = "70" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessKnight, Color = Color.Secondary, Identifier = "71" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessBishop, Color = Color.Secondary, Identifier = "72" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessQueen, Color = Color.Secondary, Identifier = "73" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessKing, Color = Color.Secondary, Identifier = "74" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessBishop, Color = Color.Secondary, Identifier = "75" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessKnight, Color = Color.Secondary, Identifier = "76" },
    new DropItem(){ Icon = @Icons.Custom.Uncategorized.ChessRook, Color = Color.Secondary, Identifier = "77" },
};
    }
}
