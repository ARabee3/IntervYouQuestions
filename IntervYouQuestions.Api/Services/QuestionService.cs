namespace IntervYouQuestions.Api.Services;

public class QuestionService(InterviewModuleContext context) : IQuestionService
{
    private readonly InterviewModuleContext _context = context;

    public async Task<IEnumerable<Question>> GetAllAsync()
    {
        return await _context.Questions
            .Include(q => q.Topic) 
            .ThenInclude(t => t.Category)
            //.Include(q => q.QuestionOptions)
            //.Include(q => q.ModelAnswers)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Question?> GetAsync(int id)
    {
        return await _context.Questions
        .Include(q => q.Topic)
        .ThenInclude(t => t.Category)
        //.Include(q => q.QuestionOptions)
        //.Include(q => q.ModelAnswers)
        .AsNoTracking()
        .FirstOrDefaultAsync(q => q.QuestionId == id);
    }

    public async Task<Question> AddAsync(Question request)
    {
        await _context.Questions.AddAsync(request);
        await _context.SaveChangesAsync();
        return request;
    }

    public async Task<bool> UpdateAsync(int id, Question request)
    {
        var existingQuestion = await _context.Questions.FindAsync(id);
        if (existingQuestion is null) return false;

        existingQuestion.Type = request.Type;
        existingQuestion.Text = request.Text;
        existingQuestion.Difficulty = request.Difficulty;
        existingQuestion.TopicId = request.TopicId;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var question = await _context.Questions.FindAsync(id);
        if (question is null) return false;

        _context.Questions.Remove(question);
        await _context.SaveChangesAsync();
        return true;
    }
}
