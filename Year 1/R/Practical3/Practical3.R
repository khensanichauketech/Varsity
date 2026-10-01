#####################
# Practical 3
# Name & Surname: Khensani Chauke
# Student number: u20557303
#####################

# Import the data
racing <- read.csv("RacingGameData.csv")

# Question 1
# Creating an indicator variable speed.
speed <- ifelse(racing$FinishTime < 25 , "fast", "slow")
Q1 <- speed
racing$speed <- speed

# Question 2
# Hypothesis test for a single proportion

#a
# Null hypothesis
Q2a <- "C"

#b
# Alternative hypothesis
Q2b <- "D"

#c
# Point estimate for the proportion of fast races
fast_races <- 0
slow_races <- 0
for(i in speed){
  if (i == "fast"){
    fast_races <- fast_races + 1
  } else {
    slow_races <- slow_races +1
  }
}
n <- fast_races + slow_races

Q2c <- fast_races / n

#d
# Standard error under the null hypothesis
p0 <- 0.55
se_racing <- sqrt(p0 * (1 - p0) / n)
Q2d <- se_racing

#e
# Test statistic value
Q2e <- (Q2c - p0) / Q2d

#f
# Decision and Conclusion
Q2f <- "D"


# Question 3
# Convert the `speed` variable such that the entries are 1s and 0s.
speed_ind <- ifelse(speed == "fast", 1, 0)

# Subset the data
Nightingale_1 <- subset(speed_ind, racing$Engine == "Nightingale")
Gauss_1 <- subset(speed_ind, racing$Engine == "Gauss")


#a
# Point estimate difference
p_night <- mean(Nightingale_1 == 1)
p_gauss <- mean(Gauss_1 == 1)

Q3a <- p_night - p_gauss

n_night <- length(Nightingale_1)
n_gauss <- length(Gauss_1)



#b
# Bootstrapping simulated differences in proportions
nsim <- 1000
set.seed(10)

boot_night <- rbinom(nsim, n_night, p_night) / n_night
boot_gauss <- rbinom(nsim, n_gauss, p_gauss) / n_gauss

Q3b <- boot_night - boot_gauss

#c
# Lower bound
Q3c <- quantile(Q3b, 0.05)

#d
# Upper bound
Q3d <- quantile(Q3b, 0.95)

# Question 4
# Subset data by type of Track
straightTrack <- subset(racing, Track == "StraightTrack")
ovalTrack <- subset(racing, Track == "OvalTrack")

X_straight <- sum(straightTrack$FinishTime < 25)
x_oval <- sum(ovalTrack$FinishTime < 25)

n_straight <- length(straightTrack$FinishTime)
n_oval <- length(ovalTrack$FinishTime)

p_straight <- X_straight / n_straight
p_oval <- x_oval / n_oval

#a
# The standard error
Q4a <- sqrt((p_straight *(1 - p_straight) / n_straight) + 
              (p_oval * (1 - p_oval) / n_oval))



#b
# The test statistic
Q4b <- ((p_straight - p_oval) - 0.25) / Q4a


#c
# Two-tailed p-value
Q4c <- 2 * (1 - pnorm(abs(Q4b)))

#d
#Decision
Q4d <- "A"



# Question 5

#a
# The null hypothesis : Independent
Q5a <- "A"

#b
# creating the Observed table
o_table <- table(racing$speed, racing$Engine)

# Creating the expected table
e_table <- outer(
  rowSums(o_table),
  colSums(o_table)
) / sum(o_table)

# The test statistic
Q5b <- sum(((o_table - e_table) ^ 2) / e_table)

#c
# P-value
df <- (nrow(o_table) - 1) * (ncol(o_table) - 1)
Q5c <- pchisq(Q5b, df, lower.tail = FALSE)


#d
#The expected count for Nightingale and fast
Q5d <- e_table["fast", "Nightingale"]



