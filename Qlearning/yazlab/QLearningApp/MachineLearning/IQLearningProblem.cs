namespace QLearningApp.MachineLearning
{
    public interface IQLearningProblem
    {
        //void Rmatrisiuret();
        int NumberOfStates { get; }
        int NumberOfActions { get; }
        int[] GetValidActions(int currentState, grafik2 g2);
        double GetReward(int currentState, int action);
        bool GoalStateIsReached(int currentState,int endState);
    }
}
