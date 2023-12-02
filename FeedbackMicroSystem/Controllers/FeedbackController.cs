using FeedbackMicroSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackMicroSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        /// <summary>
        /// Método para buscar dados de Reviews na API do Ifood
        /// </summary>
        /// <returns>Objeto com todas as informações sobre as avaliações de uma determinada loja</returns>
        [HttpGet]
        public IActionResult GetReviews()
        {
            List<Feedback> feedback = new List<Feedback>
            {
                new Feedback
                {
                    Id = "1",
                    Comment = "Chegou rápido e a comida estava deliciosa!",
                    CreatedAt = DateTime.Parse("2023-01-01T12:00:00.000Z"),
                    CustomerName = "João",
                    Discarded = false,
                    Moderated = false,
                    Published = true,
                    Order = new Order
                    {
                        Id = "a1",
                        CreatedAt = DateTime.Parse("2023-01-01T10:30:00.000Z")
                    },
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = "q1",
                            Type = "CHOICE",
                            Title = "Do que você mais gostou?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a1", Title = "Saborosa" },
                                new Answer { Id = "a2", Title = "Boa aparência" }
                            }
                        },
                        new Question
                        {
                            Id = "q2",
                            Type = "BINARY",
                            Title = "Você gostou da entrega?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a1", Title = "Sim, gostei" }
                            }
                        },
                        new Question
                        {
                            Id = "q3",
                            Type = "RATING",
                            Title = "O que você achou da comida?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a1", Title = "5" }
                            }
                        }
                    },
                    Score = 5.0,
                    SurveyId = "s1"
                },
                new Feedback
                {
                    Id = "2",
                    Comment = "A entrega demorou mais do que o esperado.",
                    CreatedAt = DateTime.Parse("2023-01-02T14:30:00.000Z"),
                    CustomerName = "Maria",
                    Discarded = false,
                    Moderated = false,
                    Published = true,
                    Order = new Order
                    {
                        Id = "a2",
                        CreatedAt = DateTime.Parse("2023-01-02T12:45:00.000Z")
                    },
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = "q1",
                            Type = "CHOICE",
                            Title = "Do que você mais gostou?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a1", Title = "Saborosa" },
                                new Answer { Id = "a2", Title = "Boa aparência" }
                            }
                        },
                        new Question
                        {
                            Id = "q2",
                            Type = "BINARY",
                            Title = "Você gostou da entrega?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a2", Title = "Não, não gostei" }
                            }
                        },
                        new Question
                    {
                        Id = "q3",
                        Type = "RATING",
                        Title = "O que você achou da comida?",
                        Answers = new List<Answer>
                        {
                            new Answer { Id = "a2", Title = "3" }
                        }
                    }
                    },
                    Score = 3.0,
                    SurveyId = "s2"
                },
                new Feedback
                {
                    Id = "3",
                    Comment = "Comida chegou quente e saborosa, mas a embalagem estava danificada.",
                    CreatedAt = DateTime.Parse("2023-01-03T18:45:00.000Z"),
                    CustomerName = "Carlos",
                    Discarded = false,
                    Moderated = false,
                    Published = true,
                    Order = new Order
                    {
                        Id = "a3",
                        CreatedAt = DateTime.Parse("2023-01-03T17:30:00.000Z")
                    },
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = "q1",
                            Type = "CHOICE",
                            Title = "Do que você mais gostou?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a1", Title = "Saborosa" },
                                new Answer { Id = "a3", Title = "Temperatura certa" }
                            }
                        },
                        new Question
                        {
                            Id = "q2",
                            Type = "BINARY",
                            Title = "Você gostou da entrega?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a1", Title = "Sim, gostei" }
                            }
                        },
                        new Question
                        {
                            Id = "q3",
                            Type = "RATING",
                            Title = "O que você achou da comida?",
                            Answers = new List<Answer>
                            {
                                new Answer { Id = "a3", Title = "4" }
                            }
                        }
                    },
                    Score = 4.0,
                    SurveyId = "s3"
                }
            };
            return Ok(feedback);
        }
    }
}