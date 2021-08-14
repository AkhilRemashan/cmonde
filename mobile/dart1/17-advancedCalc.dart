import "dart:io";


String prompt(String promptText) {
  print("Prompt is: ${promptText}");
  String answer = stdin.readLineSync();
  return answer;
}


double promtDouble() {
  print("Enter number: ");
  double myNum = double.parse(stdin.readLineSync());
  return myNum;
}


void main() {
  double num1 = promtDouble();
  double num2 = promtDouble();
  String op =  prompt("Enter an operation (+, -, *, /, %): ");

  if (op == "+") {
    print(num1 + num2);
  } else if (op == "-") {
    print(num1 - num2);
  } else if (op == "*") {
    print(num1 * num2);
  } else if (op == "/") {
    print(num1 / num2);
  } else if (op == "%") {
    print(num1 % num2);
  } else {
    print("Invalid operator :(");
  }
}