namespace csharp_programming {
    class Integer {
        int value;
        public int Value {
            get { return value; }
            set { this.value = value; }
        }


        int m_value;
        public int m_Value
        {
            get { return m_value; } 
            set { 
                if (value < 0)
                {
                    throw new ArgumentException("invalid height");
                }
                this.m_value = value;
            }
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.Value = 1;
            int n = i.Value;
            i.m_Value = n;
        }
    }
}
