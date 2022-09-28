using BrillianceCodingC.Interfaces;
using BrillianceCodingC.Models;


namespace BrillianceCodingC.Services
{
    public class RepositoryService : IRepository
    {
        public int[] DeletePart(ArrayModel arrayModel)
        {
            //Creating a new array cause array always has a fix length and it cannot be manipulated 
            int[] newArray = new int[arrayModel.productsIds.Length - 1];

            //Skipping the exact index where the data with the position number exists.
            for (int i = arrayModel.postion - 1; i < arrayModel.productsIds.Length - 1; i++)
                arrayModel.productsIds[i] = arrayModel.productsIds[i + 1];
            
            //As in the previous array the size will stay the same, hence, the last data will be duplicated, so adding the items to the new array with 1 less size on it. 
            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = arrayModel.productsIds[i];

            ArrayModel newArrayModel = new ArrayModel();
            newArrayModel.productsIds = newArray;
            newArrayModel.postion = arrayModel.postion;

            return newArrayModel.productsIds;
        }

        public int[] Reverse(ArrayModel arrayModel)
        {
            //Swaping the value from the first to the mid with last to the mid and stop the loop at before it gets to the middle one if it exists.
            for (int i = 1; i <= arrayModel.productsIds.Length / 2; i++)
            {
                int temp = arrayModel.productsIds[i - 1];
                arrayModel.productsIds[i - 1] = arrayModel.productsIds[arrayModel.productsIds.Length - i];
                arrayModel.productsIds[arrayModel.productsIds.Length - i] = temp;
            }

            return arrayModel.productsIds;
        }
    }
}
