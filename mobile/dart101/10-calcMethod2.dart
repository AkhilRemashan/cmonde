import "dart:io";


void main() {

  print("Enter a number: ");
  double num1 = double.parse(stdin.readLineSync());

  print("Enter another number: ");
  double num2 = double.parse(stdin.readLineSync());

  print(num1 + num2);

}