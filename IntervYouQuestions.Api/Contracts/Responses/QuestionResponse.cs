namespace IntervYouQuestions.Api.Contracts.Responses;

public record QuestionResponse(
    int QuestionId,
    string Type,
    string Text,
    string Difficulty,
    int TopicId,
    TopicResponse? Topic
    //IEnumerable<QuestionOptionResponse>? QuestionOptions, 
    //IEnumerable<ModelAnswerResponse>? ModelAnswers 
    );