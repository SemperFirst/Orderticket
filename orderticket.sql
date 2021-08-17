/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50545
Source Host           : localhost:3300
Source Database       : orderticket

Target Server Type    : MYSQL
Target Server Version : 50545
File Encoding         : 65001

*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for t_order
-- ----------------------------
DROP TABLE IF EXISTS `t_order`;
CREATE TABLE `t_order` (
  `order_id` char(5) NOT NULL,
  `username` varchar(10) NOT NULL,
  `idNum` char(18) NOT NULL,
  `startDay` date NOT NULL,
  `ticketNO` char(4) NOT NULL,
  `startPlace` varchar(10) NOT NULL,
  `startTime` time NOT NULL,
  `destination` varchar(10) NOT NULL,
  `achieveDay` date NOT NULL,
  `achieveTime` time NOT NULL,
  `price` float NOT NULL,
  `ticket_id` char(5) NOT NULL,
  `user_id` char(5) NOT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_order
-- ----------------------------

-- ----------------------------
-- Table structure for t_ticket
-- ----------------------------
DROP TABLE IF EXISTS `t_ticket`;
CREATE TABLE `t_ticket` (
  `ticket_id` char(5) NOT NULL,
  `ticketNO` char(4) NOT NULL,
  `startDay` date NOT NULL,
  `startPlace` varchar(10) NOT NULL,
  `startTime` time NOT NULL,
  `destination` varchar(10) NOT NULL,
  `achieveDay` date NOT NULL,
  `achieveTime` time NOT NULL,
  `price` float NOT NULL,
  `ticketNum` int(11) NOT NULL,
  PRIMARY KEY (`ticket_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_ticket
-- ----------------------------
INSERT INTO `t_ticket` VALUES ('00001', 'G123', '2021-09-07', '南京', '19:00:00', '镇江', '2021-09-07', '21:00:00', '30', '100');
INSERT INTO `t_ticket` VALUES ('00002', 'C120', '2021-07-02', '南京', '09:00:00', '上海', '2021-07-03', '10:00:00', '40', '75');
INSERT INTO `t_ticket` VALUES ('00003', 'F110', '2021-08-09', '上海', '20:00:00', '杭州', '2021-08-09', '22:00:00', '50', '50');
INSERT INTO `t_ticket` VALUES ('00004', 'F110', '2021-07-05', '广州', '08:00:00', '上海', '2021-07-05', '20:00:00', '80', '90');
INSERT INTO `t_ticket` VALUES ('00005', 'G102', '2021-07-07', '杭州', '10:00:00', '南京', '2021-07-07', '13:00:00', '90', '100');

-- ----------------------------
-- Table structure for t_user
-- ----------------------------
DROP TABLE IF EXISTS `t_user`;
CREATE TABLE `t_user` (
  `user_id` char(5) NOT NULL,
  `username` varchar(10) NOT NULL,
  `idNum` char(18) NOT NULL,
  `password` varchar(10) NOT NULL,
  `sex` char(2) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_user
-- ----------------------------
INSERT INTO `t_user` VALUES ('00001', 'dodo', '441881199410083124', '123456', '女');
INSERT INTO `t_user` VALUES ('00002', 'momo', '441881199410083125', '123456', '男');
