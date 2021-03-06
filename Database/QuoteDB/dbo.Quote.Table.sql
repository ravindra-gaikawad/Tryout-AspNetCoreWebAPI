USE [QuoteDB]
GO
/****** Object:  Table [dbo].[Quote]    Script Date: 31-10-2018 13:22:56 ******/
DROP TABLE [dbo].[Quote]
GO
/****** Object:  Table [dbo].[Quote]    Script Date: 31-10-2018 13:22:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quote](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](4000) NOT NULL,
	[Author] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Quote] ON 

INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (1, N'Life isn’t about getting and having, it’s about giving and being.', N'Kevin Kruse', N'Motivational')
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (2, N'Whatever the mind of man can conceive and believe, it can achieve.', N'Napoleon Hill', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (3, N'Strive not to be a success, but rather to be of value.', N'Albert Einstein', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (5, N'I attribute my success to this: I never gave or took any excuse.', N'Florence Nightingale', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (6, N'You miss 100% of the shots you don’t take.', N'Wayne Gretzky', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (7, N'I’ve missed more than 9000 shots in my career. I’ve lost almost 300 games. 26 times I’ve been trusted to take the game winning shot and missed. I’ve failed over and over and over again in my life. And that is why I succeed.', N'Michael Jordan', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (8, N'The most difficult thing is the decision to act, the rest is merely tenacity.', N'Amelia Earhart', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (9, N'Every strike brings me closer to the next home run.', N'Babe Ruth', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (10, N'Definiteness of purpose is the starting point of all achievement.', N'W. Clement Stone', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (11, N'We must balance conspicuous consumption with conscious capitalism.', N'Kevin Kruse', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (12, N'Life is what happens to you while you’re busy making other plans.', N'John Lennon', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (13, N'We become what we think about.', N'Earl Nightingale', N'Motivational')
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (14, N'Twenty years from now you will be more disappointed by the things that you didn’t do than by the ones you did do, so throw off the bowlines, sail away from safe harbor, catch the trade winds in your sails.  Explore, Dream, Discover.', N'Mark Twain', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (15, N'Life is 10% what happens to me and 90% of how I react to it.', N'Charles Swindoll', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (16, N'The most common way people give up their power is by thinking they don’t have any.', N'Alice Walker', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (17, N'The mind is everything. What you think you become.', N'Buddha', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (18, N'The best time to plant a tree was 20 years ago. The second best time is now.', N'Chinese Proverb', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (19, N'An unexamined life is not worth living.', N'Socrates', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (20, N'Eighty percent of success is showing up.', N'Woody Allen', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (21, N'Your time is limited, so don’t waste it living someone else’s life.', N'Steve Jobs', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (22, N'Winning isn’t everything, but wanting to win is.', N'Vince Lombardi', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (23, N'I am not a product of my circumstances. I am a product of my decisions.', N'Stephen Covey', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (24, N'Every child is an artist.  The problem is how to remain an artist once he grows up.', N'Pablo Picasso', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (25, N'You can never cross the ocean until you have the courage to lose sight of the shore.', N'Christopher Columbus', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (26, N'I’ve learned that people will forget what you said, people will forget what you did, but people will never forget how you made them feel.', N'Maya Angelou', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (27, N'Either you run the day, or the day runs you.', N'Jim Rohn', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (28, N'Whether you think you can or you think you can’t, you’re right.', N'Henry Ford', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (29, N'The two most important days in your life are the day you are born and the day you find out why.', N'Mark Twain', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (30, N'Whatever you can do, or dream you can, begin it.  Boldness has genius, power and magic in it.', N'Johann Wolfgang von Goethe', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (31, N'The best revenge is massive success.', N'Frank Sinatra', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (32, N'People often say that motivation doesn’t last. Well, neither does bathing.  That’s why we recommend it daily.', N'Zig Ziglar', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (33, N'Life shrinks or expands in proportion to one’s courage.', N'Anais Nin', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (34, N'If you hear a voice within you say “you cannot paint,” then by all means paint and that voice will be silenced.', N'Vincent Van Gogh', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (35, N'There is only one way to avoid criticism: do nothing, say nothing, and be nothing.', N'Aristotle', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (36, N'Ask and it will be given to you; search, and you will find; knock and the door will be opened for you.', N'Jesus', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (37, N'The only person you are destined to become is the person you decide to be.', N'Ralph Waldo Emerson', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (38, N'Go confidently in the direction of your dreams.  Live the life you have imagined.', N'Henry David Thoreau', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (39, N'When I stand before God at the end of my life, I would hope that I would not have a single bit of talent left and could say, I used everything you gave me.', N'Erma Bombeck', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (40, N'Few things can help an individual more than to place responsibility on him, and to let him know that you trust him.', N'Booker T. Washington', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (41, N'Certain things catch your eye, but pursue only those that capture the heart.', N'Ancient Indian Proverb', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (42, N'Believe you can and you’re halfway there.', N'Theodore Roosevelt', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (43, N'Everything you’ve ever wanted is on the other side of fear.', N'George Addair', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (44, N'We can easily forgive a child who is afraid of the dark; the real tragedy of life is when men are afraid of the light.', N'Plato', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (45, N'Teach thy tongue to say, “I do not know,” and thous shalt progress.', N'Maimonides', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (46, N'Start where you are. Use what you have.  Do what you can.', N'Arthur Ashe', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (47, N'When I was 5 years old, my mother always told me that happiness was the key to life.  When I went to school, they asked me what I wanted to be when I grew up.  I wrote down ‘happy’.  They told me I didn’t understand the assignment, and I told them they didn’t understand life.', N'John Lennon', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (48, N'Fall seven times and stand up eight.', N'Japanese Proverb', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (49, N'When one door of happiness closes, another opens, but often we look so long at the closed door that we do not see the one that has been opened for us.', N'Helen Keller', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (50, N'Everything has beauty, but not everyone can see.', N'Confucius', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (51, N'How wonderful it is that nobody need wait a single moment before starting to improve the world.', N'Anne Frank', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (52, N'When I let go of what I am, I become what I might be.', N'Lao Tzu', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (53, N'Life is not measured by the number of breaths we take, but by the moments that take our breath away.', N'Maya Angelou', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (54, N'Happiness is not something readymade.  It comes from your own actions.', N'Dalai Lama', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (55, N'If you’re offered a seat on a rocket ship, don’t ask what seat! Just get on.', N'Sheryl Sandberg', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (56, N'First, have a definite, clear practical ideal; a goal, an objective. Second, have the necessary means to achieve your ends; wisdom, money, materials, and methods. Third, adjust all your means to that end.', N'Aristotle', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (57, N'If the wind will not serve, take to the oars.', N'Latin Proverb', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (58, N'You can’t fall if you don’t climb.  But there’s no joy in living your whole life on the ground.', N'Unknown', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (59, N'We must believe that we are gifted for something, and that this thing, at whatever cost, must be attained.', N'Marie Curie', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (60, N'Too many of us are not living our dreams because we are living our fears.', N'Les Brown', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (61, N'Challenges are what make life interesting and overcoming them is what makes life meaningful.', N'Joshua J. Marine', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (62, N'If you want to lift yourself up, lift up someone else.', N'Booker T. Washington', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (63, N'I have been impressed with the urgency of doing. Knowing is not enough; we must apply. Being willing is not enough; we must do.', N'Leonardo da Vinci', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (64, N'Limitations live only in our minds.  But if we use our imaginations, our possibilities become limitless.', N'Jamie Paolinetti', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (65, N'You take your life in your own hands, and what happens? A terrible thing, no one to blame.', N'Erica Jong', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (66, N'What’s money? A man is a success if he gets up in the morning and goes to bed at night and in between does what he wants to do.', N'Bob Dylan', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (67, N'I didn’t fail the test. I just found 100 ways to do it wrong.', N'Benjamin Franklin', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (68, N'In order to succeed, your desire for success should be greater than your fear of failure.', N'Bill Cosby', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (69, N'A person who never made a mistake never tried anything new.', N'Albert Einstein', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (70, N'The person who says it cannot be done should not interrupt the person who is doing it.', N'Chinese Proverb', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (71, N'There are no traffic jams along the extra mile.', N'Roger Staubach', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (72, N'It is never too late to be what you might have been.', N'George Eliot', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (73, N'You become what you believe.', N'Oprah Winfrey', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (74, N'I would rather die of passion than of boredom.', N'Vincent van Gogh', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (75, N'A truly rich man is one whose children run into his arms when his hands are empty.', N'Unknown', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (76, N'It is not what you do for your children, but what you have taught them to do for themselves, that will make them successful human beings.', N'Ann Landers', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (77, N'If you want your children to turn out well, spend twice as much time with them, and half as much money.', N'Abigail Van Buren', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (78, N'Build your own dreams, or someone else will hire you to build theirs.', N'Farrah Gray', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (79, N'The battles that count aren’t the ones for gold medals. The struggles within yourself–the invisible battles inside all of us–that’s where it’s at.', N'Jesse Owens', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (80, N'Education costs money.  But then so does ignorance.', N'Sir Claus Moser', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (81, N'I have learned over the years that when one’s mind is made up, this diminishes fear.', N'Rosa Parks', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (82, N'It does not matter how slowly you go as long as you do not stop.', N'Confucius', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (83, N'If you look at what you have in life, you’ll always have more. If you look at what you don’t have in life, you’ll never have enough.', N'Oprah Winfrey', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (84, N'Remember that not getting what you want is sometimes a wonderful stroke of luck.', N'Dalai Lama', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (85, N'You can’t use up creativity.  The more you use, the more you have.', N'Maya Angelou', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (86, N'Dream big and dare to fail.', N'Norman Vaughan', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (87, N'Our lives begin to end the day we become silent about things that matter.', N'Martin Luther King Jr.', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (88, N'Do what you can, where you are, with what you have.', N'Teddy Roosevelt', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (89, N'If you do what you’ve always done, you’ll get what you’ve always gotten.', N'Tony Robbins', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (90, N'Dreaming, after all, is a form of planning.', N'Gloria Steinem', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (91, N'It’s your place in the world; it’s your life. Go on and do all you can with it, and make it the life you want to live.', N'Mae Jemison', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (92, N'You may be disappointed if you fail, but you are doomed if you don’t try.', N'Beverly Sills', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (93, N'Remember no one can make you feel inferior without your consent.', N'Eleanor Roosevelt', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (94, N'Life is what we make it, always has been, always will be.', N'Grandma Moses', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (95, N'The question isn’t who is going to let me; it’s who is going to stop me.', N'Ayn Rand', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (96, N'When everything seems to be going against you, remember that the airplane takes off against the wind, not with it.', N'Henry Ford', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (97, N'It’s not the years in your life that count. It’s the life in your years.', N'Abraham Lincoln', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (98, N'Change your thoughts and you change your world.', N'Norman Vincent Peale', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (99, N'Either write something worth reading or do something worth writing.', N'Benjamin Franklin', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (100, N'Nothing is impossible, the word itself says, “I’m possible!”', N'Audrey Hepburn', NULL)
GO
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (101, N'The only way to do great work is to love what you do.', N'Steve Jobs', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (102, N'If you can dream it, you can achieve it.', N'Zig Ziglar', NULL)
INSERT [dbo].[Quote] ([Id], [Title], [Author], [Category]) VALUES (103, N'We cannot be always right, But we should be always right.', N'Ravindra Gaikawad', N'Leadership')
SET IDENTITY_INSERT [dbo].[Quote] OFF
