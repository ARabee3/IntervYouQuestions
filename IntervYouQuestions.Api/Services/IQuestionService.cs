namespace IntervYouQuestions.Api.Services;

public interface IQuestionService
{
    Task<IEnumerable<Question>> GetAllAsync();
    Task<Question?> GetAsync(int id);
    Task<Question> AddAsync(Question request);
    Task<Question> AddWithOptionAsync(QuestionWithOptionsRequest request);
    Task<Question> AddWithModelAnswerAsync(QuestionWithModelAnswerRequest request);
    Task<bool> UpdateAsync(int id, Question request);
    Task<bool> DeleteAsync(int id);
}
