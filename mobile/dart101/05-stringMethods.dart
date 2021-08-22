void main() {

  String greeting = "Hello";

  String name = " Akhil";


  // string length
  print(greeting.length);

  // indexed character
  print(greeting[3]);

  // to uppercase
  print(greeting.toUpperCase());

  // to lowercase
  print(greeting.toLowerCase());

  // finding index position of perticular character in string
  print(greeting.indexOf("H")); 

  // check if the character exist in the perticular string
  print(greeting.contains("x"));

  // string concatination
  print(greeting + name);

  // string interpolation
  print("The greeting is: ${greeting + name}");



}