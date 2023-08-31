double[] array = new double[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++){
    array[i] = rnd.Next(100);
}
for (int i = 0; i < 8; i++){
    Console.Write(array[i] + "  ");
}