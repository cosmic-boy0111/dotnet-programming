namespace training_basic_csharp {
    class ChessBoardBlock {
        public static int BlockSize { get; set; }
    }
    class Program {
        static void Main() {
            ChessBoardBlock.BlockSize = 100;
            int blockSize = ChessBoardBlock.BlockSize;
        }
    }
}
