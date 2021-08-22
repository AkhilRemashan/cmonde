import "dart:io";


void main() {

  print("Enter your name: ");
  String username = stdin.readLineSync();

  print("Hello ${username}");

}