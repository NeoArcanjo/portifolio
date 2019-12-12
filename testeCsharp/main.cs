using System;

class MainClass {

  public static bool impar (int num) {
    if(num&1){
      return true;
    }else{
      return false;
    }
  }

  public static void Main (string[] args) {
    int[] nums = new int[] {1, 2, 3, 5, 8, 16, 15};
    for(int i = 0; i < nums.Length; i++){
      bool im = impar(nums[i]);
      Console.WriteLine(im);
    }
    Console.ReadKey();
  }
}