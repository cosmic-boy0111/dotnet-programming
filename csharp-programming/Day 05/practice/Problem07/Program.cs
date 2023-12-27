namespace csharp_programming
{
    internal class Program
    {

        public abstract class Expression
        {
            public abstract double Evaluate(Dictionary<string, int> d);
            public abstract Expression Differentiate();
        }

        public class ConstantExpression : Expression
        {
            public int Value { get; set; }

            public override double Evaluate(Dictionary<string, int> d)
            {
                return Value;
            }
            public override Expression Differentiate()
            {
                Expression result = new ConstantExpression() { Value = 0};
                return result;
            }

        }

        public class VariableExpression : Expression
        {
            public int Constant { get; set; }
            public string Variable { get; set; }
            public int Power { get; set; }


            public override double Evaluate(Dictionary<string, int> d)
            {
                
                return Constant * Math.Pow(d[Variable], Power);
            }

            public override Expression Differentiate()
            {
                Expression result;
                if(Power == 1)
                {
                    result = new ConstantExpression() {
                        Value = Constant
                    };
                    return result;
                }

                result = new VariableExpression()
                {
                    Constant = Constant * Power,
                    Variable = Variable,
                    Power = Power - 1
                };

                return result;

            }

            public class AdditionExpression : Expression
            {
                public Expression LeftOperand { get; set; }
                public Expression RightOperand { get; set; }

                public override double Evaluate(Dictionary<string, int> d)
                {
                    return LeftOperand.Evaluate(d) + RightOperand.Evaluate(d);
                }

                public override Expression Differentiate()
                {
                    Expression result = new AdditionExpression() { 
                        LeftOperand = LeftOperand.Differentiate(),
                        RightOperand = RightOperand.Differentiate()
                    };

                    return result;
                }
               
            }

            public class MultiplicationExpression : Expression
            {
                public Expression LeftOperand { get; set; }
                public Expression RightOperand { get; set; }
                public override double Evaluate(Dictionary<string, int> d)
                {
                    return LeftOperand.Evaluate(d) * RightOperand.Evaluate(d);
                }
                public override Expression Differentiate()
                {

                    Type var_ex_type = typeof(VariableExpression);
                    Type con_ex_type = typeof(ConstantExpression);
                    Type mult_ex_type = typeof(MultiplicationExpression);

                    Type left_op_type = LeftOperand.GetType();
                    Type right_op_type = RightOperand.GetType();

                    if(left_op_type == mult_ex_type)
                    {
                        LeftOperand = LeftOperand.Differentiate();
                    }

                    left_op_type = LeftOperand.GetType();

                    if(right_op_type == mult_ex_type)
                    {
                        RightOperand = RightOperand.Differentiate();
                    }

                    right_op_type = RightOperand.GetType();

                    if(left_op_type == con_ex_type)
                    {
                        Expression temp = LeftOperand;
                        LeftOperand = RightOperand;
                        RightOperand = temp;
                    }

                    Expression result;

                    if(left_op_type == var_ex_type && right_op_type == var_ex_type)
                    {
                        VariableExpression l1 = (VariableExpression)LeftOperand;
                        VariableExpression l2 = (VariableExpression)RightOperand;
                        result = new VariableExpression()
                        {
                            Constant = l1.Constant * l2.Constant,
                            Variable = l1.Variable,
                            Power = l1.Power + l2.Power
                        };
                        return result;
                    }

                    if (left_op_type == var_ex_type && right_op_type == con_ex_type)
                    {
                        VariableExpression l3 = (VariableExpression)LeftOperand;
                        ConstantExpression l4 = (ConstantExpression)RightOperand;
                        result = new VariableExpression()
                        {
                            Constant = l3.Constant * l4.Value,
                            Variable = l3.Variable,
                            Power = l3.Power
                        };
                        return result;
                    }

                    ConstantExpression l5 = (ConstantExpression)LeftOperand;
                    ConstantExpression l6 = (ConstantExpression)RightOperand;
                    result = new ConstantExpression()
                    {
                        Value = l5.Value * l6.Value,
                   };

                    return result;
                }
            }

            //public class MultiplicationExpression : Expression
            //{
            //    public Expression LeftOperand { get; set; }
            //    public Expression RightOperand { get; set; }

            //    public override double Evaluate(Dictionary<string, int> d)
            //    {
            //        return LeftOperand.Evaluate(d) * RightOperand.Evaluate(d);
            //    }
            //    public override Expression Differentiate()
            //    {
            //        Expression left = new MultiplicationExpression()
            //        {
            //            LeftOperand = LeftOperand,
            //            RightOperand = RightOperand.Differentiate()
            //        };

            //        Expression right = new MultiplicationExpression()
            //        {
            //            LeftOperand = RightOperand,
            //            RightOperand = LeftOperand.Differentiate()
            //        };

            //        Expression result = new AdditionExpression()
            //        {
            //            LeftOperand = left,
            //            RightOperand = right,
            //        };

            //        return result;

            //    }

            //}


            public static void Main()
            {
                VariableExpression e1 = new VariableExpression()
                {
                    Constant = 4,
                    Variable = "x",
                    Power = 2,
                };
                VariableExpression e2 = new VariableExpression()
                {
                    Constant = 3,
                    Variable = "x",
                    Power = 1,
                };
                ConstantExpression e3 = new ConstantExpression()
                {
                    Value = 2
                };

                AdditionExpression e4 = new AdditionExpression()
                {
                    LeftOperand = e1,
                    RightOperand = e2
                };

                AdditionExpression final_expression = new AdditionExpression()
                {
                    LeftOperand = e4,
                    RightOperand = e3
                };

                Dictionary<string, int> d = new Dictionary<string, int>();
                d.Add("x", 3);

                double result = final_expression.Evaluate(d);
                Expression x = final_expression.Differentiate();

                MultiplicationExpression e5 = new MultiplicationExpression()
                {
                    LeftOperand = e1,
                    RightOperand = e2
                };



                MultiplicationExpression mult_result = new MultiplicationExpression()
                {
                    LeftOperand = e5,
                    RightOperand = e3
                };

                result = mult_result.Evaluate(d);
                x = mult_result.Differentiate().Differentiate();

            
            }
            
        }


    }
}
