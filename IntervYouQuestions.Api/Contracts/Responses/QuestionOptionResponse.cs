namespace IntervYouQuestions.Api.Contracts.Responses;

public record QuestionOptionResponse(
    int QuestionOptionId,
    string Text,
    bool IsCorrect,
    int QuestionId,
    QuestionResponse? Question
);
