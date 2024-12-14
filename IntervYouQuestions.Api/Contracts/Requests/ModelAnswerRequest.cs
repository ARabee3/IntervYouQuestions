namespace IntervYouQuestions.Api.Contracts.Requests;

public record ModelAnswerRequest(
    string Text,
    string KeyPoints,
    int QuestionId
);
