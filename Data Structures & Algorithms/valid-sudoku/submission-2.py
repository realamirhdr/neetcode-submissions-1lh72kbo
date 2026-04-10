class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for row in board:
            rowSet = set()
            for i in row:
                if i in rowSet:
                    return False
                if i == ".":
                    continue
                rowSet.add(i)

        for x in range(0, 9):
            colSet = set()
            for y in range(0, 9):
                if board[y][x] in colSet:
                    return False
                if board[y][x] == ".":
                    continue
                colSet.add(board[y][x])


        for y in range(0, 9, 3):
            for x in range(0, 9, 3):
                sq = set()
                for j in range(0, 3):
                    for i in range(0, 3):
                        if board[y + j][x + i] in sq:
                            return False
                        if board[y + j][x + i] == ".":
                            continue
                        sq.add(board[y + j][x + i])
                print(y, x)
        return True