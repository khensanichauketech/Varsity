#####################
# Practical 2
# Name & Surname: Khensani Chauke
# Student number: u20557303
#####################

# Import the data
racing <- read.csv("RacingGameData.csv")

# Question 1

# a) Calculate sample mean
Q1a <- mean(racing$FinishTime)

# b) Calculate sample standard deviation
Q1b <- sd(racing$FinishTime)

# c) Perform Shapiro test and extract p-value
Q1c <- shapiro.test(racing$FinishTime)$p.value

# d) Assign decision based on p-value at alpha = 0.05
if (Q1c < 0.05) {
  Q1d <- "D"
} else {
  Q1d <- "A"
}


# Question 2
mean_Q2 <- 27
sd_Q2 <- 4.5

# a) Probability that a randomly selected race is completed in less than 25 seconds
Q2a <- pnorm(25, mean = mean_Q2, sd = sd_Q2)

# b) Probability that a randomly selected race takes longer than 30 seconds
Q2b <- pnorm(30, mean = mean_Q2, sd = sd_Q2)

# c) 10th percentile of the finish times
Q2c <- qnorm(0.1, mean = mean_Q2, sd = sd_Q2)

# d) Z-score associated with a value/sample mean of 25 seconds
Q2d <- (25 - mean_Q2) / sd_Q2


# Question 3
n <- 40

# a) Calculate the standard error of the sample mean
Q3a <- sd_Q2 / sqrt(n)

# b) Calculate the probability that the sample mean finish time is less than 25 seconds
Q3b <- pnorm(25, mean = mean_Q2, sd = Q3a)

# Question 4

responses <- racing$FinishTime
n <- length(responses)

nsim <- 1000
set.seed(30)


sim <- matrix(NA, nrow = n, ncol = nsim)


for (i in 1:nsim) {
  sim[, i] <- sample(responses, n, replace = TRUE)
}

# Apply mean function across columns
boot_means <- apply(sim, 2, mean)

# a) Calculate mean of bootstrapped sample means
Q4a <- mean(boot_means)

alpha <- 0.05

# b) Calculate lower bound 
Q4b <- quantile(boot_means, alpha / 2)

# c) Calculate upper bound 
Q4c <- quantile(boot_means, 1 - alpha / 2)


# Question 5
# Subset the data
Bayes_1 <- subset(racing$FinishTime, racing$Engine == "Bayes")
Nightingale_1 <- subset(racing$FinishTime, racing$Engine == "Nightingale")

# a) Alternative hypothesis 
Q5a <- "C"

# b) Observed difference in sample means (x1 - x2)
Q5b <- mean(Bayes_1) - mean(Nightingale_1)

# Combined values for randomization
combined <- c(Bayes_1, Nightingale_1)
n1 <- length(Bayes_1)
n_total <- length(combined)

# c) Randomization test with 1000 permutations
set.seed(35)
nsim <- 1000
perm_diffs <- numeric(nsim)

for (i in 1:nsim) {
  shuffled <- sample(combined)
  m1 <- mean(shuffled[1:n1])
  m2 <- mean(shuffled[(n1 + 1):n_total])
  perm_diffs[i] <- m1 - m2
}

# Calculate two-sided p-value
Q5c <- mean(abs(perm_diffs) >= abs(Q5b))

# d) Decision rule at 5% level of significance (alpha = 0.05)
Q5d <- if (Q5c > 0.05) "A" else "B"

