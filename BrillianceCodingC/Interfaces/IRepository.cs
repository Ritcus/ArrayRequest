using BrillianceCodingC.Models;


namespace BrillianceCodingC.Interfaces
{
    public interface IRepository
    {
        int[] Reverse(ArrayModel arrayModel);
        int[] DeletePart(ArrayModel arrayModel);
    }
}
