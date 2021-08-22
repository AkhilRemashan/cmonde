import "dart:io";


void main() {

  print("Enter a number: ");
  String num1 = stdin.readLineSync();

  print("Enter another number: ");
  String num2 = stdin.readLineSync();

  print(double.parse(num1) + double.parse(num2));

}