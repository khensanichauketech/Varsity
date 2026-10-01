titles <- read.csv("titles.csv")

# Removing observations where the IMDB score is missing.
titles_cleaned <- subset(titles,
                         imdb_score != "NA")

# Storing the cleaned IMDB scores in a separate vector.
titles_imdb_score <- titles_cleaned$imdb_score


# Question 1

# Finding the highest IMDB score.
Q1a <- max(titles_imdb_score)

# Finding the lowest IMDB score.
Q1b <- min(titles_imdb_score)

# Finding the 1st quartile of the IMDB scores.
Q1c <- quantile(titles_imdb_score, 0.25)

# Finding the 2nd quartile (median) of the IMDB scores.
Q1d <- median(titles_imdb_score)

# Finding the 3rd quartile of the IMDB scores.
Q1e <- quantile(titles_imdb_score, 0.75)

# The mean and five-number summary indicate that the distribution is skewed to the left.
Q1f <- "B"


# Question 2

# Finding the observation with the highest IMDB score.
highest_imdb_score <- subset(titles_cleaned,
                             imdb_score == Q1a)

# Accessing the title of the observation with the highest IMDB score.
Q2 <- highest_imdb_score$title


# Question 3

# Counting the number of titles with an IMDB score greater than 8.
Q3a <- 0

for (score in titles_imdb_score) {
  if (score > 8) {
    Q3a <- Q3a + 1
  }
}

# Counting the number of titles with an IMDB score of at least 8.
Q3b <- 0
count <- 0

for (score in titles_imdb_score) {
  if (score >= 8) {
    count <- count + 1
  }
}

# Calculating the proportion of titles with an IMDB score of at least 8.
Q3b <- count / length(titles_imdb_score)


# Question 4

# Creating a histogram using 50 breaks to investigate the distribution of IMDB scores.
hist(titles_imdb_score,
     main = "Distribution of the IMDB Rating",
     col = "limegreen",
     xlab = "IMDB Score",
     ylab = "Frequency",
     breaks = 50
)

# Investigating the effect of using 5 breaks.
hist(titles_imdb_score,
     main = "Distribution of the IMDB Rating",
     col = "blue",
     xlab = "IMDB Score",
     ylab = "Frequency",
     breaks = 5
)

# Investigating the effect of using 10 breaks.
hist(titles_imdb_score,
     main = "Distribution of the IMDB Rating",
     col = "yellow",
     xlab = "IMDB Score",
     ylab = "Frequency",
     breaks = 10
)

# Investigating the effect of using 50 breaks.
hist(titles_imdb_score,
     main = "Distribution of the IMDB Rating",
     col = "pink",
     xlab = "IMDB Score",
     ylab = "Frequency",
     breaks = 50
)

# Investigating the effect of using 100 breaks.
hist(titles_imdb_score,
     main = "Distribution of the IMDB Rating",
     col = "white",
     xlab = "IMDB Score",
     ylab = "Frequency",
     breaks = 100,
     border = "brown"
)


# Question 5

# Creating a subset containing only movie releases.
Q5 <- subset(titles,
             type == "MOVIE")


# Question 6

# Calculating the mean runtime of the movies.
Q6 <- mean(Q5$runtime)


# Question 7

# Calculating the standard deviation of the runtime of the movies.
Q7 <- sd(Q5$runtime)


# Question 8

# Calculating the lower and upper limits for runtimes within 1.2 standard deviations of the mean.
lower <- Q6 - 1.2 * Q7
upper <- Q6 + 1.2 * Q7

# Calculating the percentage of movie runtimes that fall within these limits.
Q8 <- mean(Q5$runtime >= lower & Q5$runtime <= upper) * 100


# Question 9

# Creating a side-by-side boxplot comparing the IMDB ratings of movies and TV shows.
boxplot(titles$imdb_score ~ titles$type,
        horizontal = TRUE,
        main = "Side-by-side Boxplot for the IMDB Ratings \n of Movies and TV Shows",
        xlab = "Rating (in decimal)",
        ylab = "Type",
        col = c("darkorange", "darkgreen"),
        cex.main = 1)

# Adding a legend to identify the movie and TV show boxplots.
legend("bottomleft",
       col = c("darkgreen", "darkorange"),
       lty = 2:3,
       legend = c("SHOW", "MOVIE"),
       cex = 0.5)


# Question 10

# Creating separate subsets for movie and TV show IMDB scores.
movie_imdb <- subset(titles_cleaned,
                     type == "MOVIE")

shows_imdb <- subset(titles_cleaned,
                     type == "SHOW")

# Comparing the five-number summaries to determine which boxplot has the larger IQR.
summary(movie_imdb$imdb_score) # IQR = 1.4
summary(shows_imdb$imdb_score) # IQR = 1.5

# The TV shows have the larger IQR, so their boxplot has the largest spread.
Q10 <- "B"


# Question 11

# Creating a two-way contingency table showing age certification by release type.
Q11 <- table(titles$age_certification, titles$type)


# Question 12

# The number of movies with a G age certification.
Q12 <- sum(Q5$age_certification == "G")


# Question 13

# A bar chart showing the number of releases for each age certification.
barplot(table(titles$age_certification),
        main = "Number of Releases by Age Certification",
        xlab = "Age Certification",
        ylab = "Number of Releases",
        col = "magenta")







