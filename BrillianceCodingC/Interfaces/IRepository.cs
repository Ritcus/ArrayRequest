using BrillianceCodingC.Models;


namespace BrillianceCodingC.Interfaces
{
    public interface IRepository
    {
        int[] Reverse(ArrayModel arrayModel);
        ArrayModel DeletePart(ArrayModel arrayModel);
    }
}
