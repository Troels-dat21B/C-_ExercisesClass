class ReversePolishNotation{

static void Main() {
        Stack<double> stack = new Stack<double>();
        string input = "3 4 + *";
        string[] tokens = input.Split();

        foreach (string token in tokens) {
            double value;

            if (double.TryParse(token, out value)) {
                stack.Push(value);
            } else {
                double operand2 = stack.Pop();
                double operand1 = stack.Pop();
                switch (token) {
                    case "+":
                        stack.Push(operand1 + operand2);
                        break;
                    case "-":
                        stack.Push(operand1 - operand2);
                        break;
                    case "*":
                        stack.Push(operand1 * operand2);
                        break;
                    case "/":
                        stack.Push(operand1 / operand2);
                        break;
                }
            }
        }

        Console.WriteLine("Result: {0}", stack.Pop());
    }

}