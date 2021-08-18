import "dart:io";


String prompt(promptText){
  print(promptText);
  String answer = stdin.readLineSync();
  return answer;
}



void main() {

  String answer = "bob dylan";
  String guess = "";
  int guessCount = 0;

  while (guess != answer) {
  
    guess = prompt("Who wrote the song 'All along the watchtower'?");
    guessCount++;

  }

  print("Yay, right answer on ${guessCount} try!!");

}