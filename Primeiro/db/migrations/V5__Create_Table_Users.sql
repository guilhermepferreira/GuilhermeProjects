CREATE TABLE `users` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `user_name` varchar(255) NOT NULL UNIQUE,
  `password` varchar(255) NOT NULL,
  `full_name` varchar(255) NOT NULL,
  `refresh_token` varchar(255) NULL DEFAULT '0',
  `refresh_token_expire_time` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
)