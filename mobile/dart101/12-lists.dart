void main() {

  // declaring an array or a list
  List<int> favNums = [15, 45, 55, 91, 182];

  // changing value of list item using index position
  favNums[0] = 13;

  // appending/adding element to the end
  favNums.add(255);

  // removing element from the list
  favNums.remove(182);

  // printing a list
  print(favNums);

  // list length
  print(favNums.length);

  // using list items for different operations
  print(favNums[4] + favNums[0]);

  // finding index position of an element
  print(favNums.indexOf(91));

  // checking if an element exist inside a list
  print(favNums.contains(255));




}