namespace valid_sudoku;

class Program
{
    static void Main(string[] args)
    {
        var matrix =new char[][] {
            new char[] {'8','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}};
        Console.WriteLine(IsValidSudoku( matrix ));
    }

    public static bool IsValidSudoku(char[][] board) {
        IDictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        IDictionary<int, HashSet<char>> col = new Dictionary<int, HashSet<char>>();
        IDictionary<string, HashSet<char>> square = new Dictionary<string, HashSet<char>>();

        for(int i=0;i <9;i++)
        {
            for(int j=0; j<9;j++)
            {
                if(board[i][j] == '.') continue;
                string squareKey = (i/3) + "," + (j/3);

                if((rows.ContainsKey(i) && rows[i].Contains(board[i][j])) || 
                (col.ContainsKey(j) && col[j].Contains(board[i][j])) || 
                (square.ContainsKey(squareKey) && square[squareKey].Contains(board[i][j])))
                {
                    return false;
                }

                if(!rows.ContainsKey(i)) rows[i] = new HashSet<char>();
                if(!col.ContainsKey(j)) col[j] = new HashSet<char>();
                if(!square.ContainsKey(squareKey)) square[squareKey] = new HashSet<char>();

                rows[i].Add(board[i][j]);
                col[j].Add(board[i][j]);
                square[squareKey].Add(board[i][j]);
            }
        }

        return true;
    }
}
