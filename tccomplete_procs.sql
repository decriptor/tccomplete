SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

INSERT INTO `proc` (`db`, `name`, `type`, `specific_name`, `language`, `sql_data_access`, `is_deterministic`, `security_type`, `param_list`, `returns`, `body`, `definer`, `created`, `modified`, `sql_mode`, `comment`) VALUES 
(0x7463636f6d706c657465, 'sp_ResultDelete', 'PROCEDURE', 'sp_ResultDelete', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x746375696420696e74283131292c206275696420696e7428313129, '', 0x424547494e0d0a44454c4554452046524f4d20746364625f726573756c74730d0a5748455245202874657374636173655f756964203d2074637569642920414e4420286275696c645f756964203d2062756964293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-15 16:12:25', '', ''),
(0x7463636f6d706c657465, 'sp_ResultRetrieve', 'PROCEDURE', 'sp_ResultRetrieve', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x7275696420696e74283131292c20746375696420696e74283131292c206275696420696e74283131292c20726573756c74537461747573206d656469756d746578742c207570646174656462792074696e79746578742c207570646174654e6f746573206d656469756d746578742c2062756769642074696e79746578742c20636865636b6f75742074696d657374616d70, '', 0x424547494e0d0a53454c454354202a0d0a46524f4d20746364625f726573756c74730d0a574845524520282872756964204953204e554c4c29204f52202820756964203d2072756964292920414e442028287463756964204953204e554c4c29204f5220282074657374636173655f756964203d207463756964292920414e4420282862756964204953204e554c4c29204f5220286275696c645f756964203d2062756964292920414e44202828726573756c74537461747573204953204e554c4c29204f52202820737461747573203d20726573756c74537461747573292920414e44202828757064617465646279204953204e554c4c29204f522028757064617465645f6279203d20757064617465646279292920414e442028287570646174654e6f746573204953204e554c4c29204f5220287570646174655f6e6f746573203d207570646174654e6f746573292920414e442028286275676964204953204e554c4c29204f5220286275675f6964203d206275676964292920414e44202828636865636b6f7574204953204e554c4c29204f522028636865636b6f75745f74696d65203d20636865636b6f757429293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:34:57', '2006-08-16 21:46:15', '', ''),
(0x7463636f6d706c657465, 'sp_ResultUpdate', 'PROCEDURE', 'sp_ResultUpdate', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x746375696420696e74283131292c206275696420696e74283131292c20726573756c74537461747573206d656469756d746578742c207570646174656462792074696e79746578742c207570646174654e6f746573206d656469756d74657874, '', 0x424547494e0d0a55504441544520746364625f726573756c74730d0a53455420737461747573203d20726573756c745374617475732c20757064617465645f6279203d207570646174656462792c207570646174655f6e6f746573203d207570646174654e6f7465730d0a5748455245202874657374636173655f756964203d2074637569642920414e4420286275696c645f756964203d2062756964293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-15 16:39:46', '', ''),
(0x7463636f6d706c657465, 'sp_ResultCheckOut', 'PROCEDURE', 'sp_ResultCheckOut', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x746375696420696e74283131292c206275696420696e7428313129, '', 0x424547494e0d0a55504441544520746364625f726573756c74730d0a53455420636865636b6f75745f74696d65203d2043555252454e545f54494d455354414d500d0a5748455245202874657374636173655f756964203d2074637569642920414e4420286275696c645f756964203d2062756964293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-15 16:12:53', '', ''),
(0x7463636f6d706c657465, 'sp_ResultCheckIn', 'PROCEDURE', 'sp_ResultCheckIn', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x726573756c74494420696e74283131292c206e657753746174757320696e74283131292c207570646174656442792074696e79746578742c207570646174654e6f746573206d656469756d74657874, '', 0x424547494e0d0a55504441544520746364625f726573756c74730d0a53455420737461747573203d206e65775374617475732c20757064617465645f6279203d207570646174656442792c207570646174655f74696d65203d2043555252454e545f54494d455354414d502c207570646174655f6e6f746573203d207570646174654e6f7465732c20636865636b6f75745f74696d65203d204e554c4c0d0a57484552452028756964203d20726573756c744944293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-21 13:09:45', '', ''),
(0x7463636f6d706c657465, 'sp_ProjectRetrieve', 'PROCEDURE', 'sp_ProjectRetrieve', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x50726f6a65637455494420696e74283131292c2050726f6a6563744e616d652074696e7974657874, '', 0x424547494e0d0a53454c454354202a0d0a46524f4d20746364625f70726f6a656374730d0a574845524520282850726f6a656374554944204953204e554c4c29204f522028756964203d2050726f6a656374554944292920414e4420282850726f6a6563744e616d65204953204e554c4c29204f522028206e616d65203d2050726f6a6563744e616d6529293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:34:57', '2006-08-16 21:42:53', '', ''),
(0x7463636f6d706c657465, 'sp_ProjectUpdate', 'PROCEDURE', 'sp_ProjectUpdate', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x50726f6a65637455494420696e74283131292c204e657750726f6a6563744e616d652074696e79746578742c204e657750726f6a6563744465736372697074696f6e206d656469756d74657874, '', 0x424547494e0d0a55504441544520746364625f70726f6a656374730d0a534554206e616d65203d204e657750726f6a6563744e616d652c206465736372697074696f6e203d204e657750726f6a6563744465736372697074696f6e0d0a574845524520756964203d2050726f6a6563745549443b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-26 17:26:03', '', ''),
(0x7463636f6d706c657465, 'sp_ProjectInsert', 'PROCEDURE', 'sp_ProjectInsert', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x494e2050726f6a6563744e616d652074696e79746578742c20494e2050726f6a6563744465736372697074696f6e206d656469756d74657874, '', 0x424547494e0d0a494e5345525420494e544f20746364625f70726f6a65637473286e616d652c206465736372697074696f6e290d0a56414c554553202850726f6a6563744e616d652c2050726f6a6563744465736372697074696f6e293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-26 17:41:50', '', ''),
(0x7463636f6d706c657465, 'sp_UserLogin', 'PROCEDURE', 'sp_UserLogin', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x4c6f67696e55736572207661726368617228313030292c204c6f67696e5061737320766172636861722831303029, '', 0x424547494e0d0a53454c45435420557365726e616d652c20757365725f7269676874732c2061646d696e6973747261746f722c207265616c6e616d652c20746364625f66696c7465722c20746364625f6275696c642c20746364625f6275696c645f7269676874732c20746364625f74635f7269676874732c20746364625f6f735f7269676874732c20746364625f706173735f7269676874730d0a46524f4d206c6f67696e0d0a57484552452028557365726e616d65203d204c6f67696e557365722920414e44202850617373776f7264203d2050415353574f5244284c6f67696e5061737329293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-28 12:15:11', '', ''),
(0x7463636f6d706c657465, 'sp_ProjectDelete', 'PROCEDURE', 'sp_ProjectDelete', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x50726f6a6563745549442074696e79696e7428313129, '', 0x424547494e0d0a44454c4554452046524f4d20746364625f70726f6a656374730d0a574845524520756964203d2050726f6a6563745549443b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-26 17:31:23', '', ''),
(0x7463636f6d706c657465, 'sp_UserInsert', 'PROCEDURE', 'sp_UserInsert', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x6e616d65207661726368617228313030292c2070617373207661726368617228313030292c205573657252696768747320696e74283131292c2061646d696e2074696e79696e742831292c205265616c4e616d65207661726368617228313030292c205463646246696c74657220696e74283131292c20546364624275696c6420696e74283131292c20546364624275696c6452696768747320696e74283131292c2054636462544352696768747320696e74283131292c20546364624f5352696768747320696e74283131292c2054636462506173735269676874732074696e79696e74283429, '', 0x424547494e0d0a494e5345525420494e544f206c6f67696e28557365726e616d652c2050617373776f72642c20757365725f7269676874732c2061646d696e6973747261746f722c207265616c6e616d652c20746364625f66696c7465722c20746364625f6275696c642c20746364625f6275696c645f7269676874732c20746364625f74635f7269676874732c20746364625f6f735f7269676874732c20746364625f706173735f726967687473290d0a56414c55455320286e616d652c2050415353574f52442870617373292c20557365725269676874732c2061646d696e2c205265616c4e616d652c205463646246696c7465722c20546364624275696c642c20546364624275696c645269676874732c205463646254435269676874732c20546364624f535269676874732c205463646250617373526967687473293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-26 17:40:48', '', ''),
(0x7463636f6d706c657465, 'sp_UserUpdate', 'PROCEDURE', 'sp_UserUpdate', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x6f6c64557365724e616d65207661726368617228313030292c206e6577557365724e616d65207661726368617228313030292c205573657252696768747320696e74283131292c2061646d696e2074696e79696e742831292c205265616c4e616d65207661726368617228313030292c205463646246696c74657220696e74283131292c20546364624275696c6420696e74283131292c20546364624275696c6452696768747320696e74283131292c2054636462544352696768747320696e74283131292c20546364624f5352696768747320696e74283131292c2054636462506173735269676874732074696e79696e74283429, '', 0x424547494e0d0a555044415445206c6f67696e0d0a53455420557365726e616d65203d206e6577557365724e616d652c20757365725f726967687473203d20557365725269676874732c2061646d696e6973747261746f72203d2061646d696e2c207265616c6e616d65203d205265616c4e616d652c20746364625f66696c746572203d205463646246696c7465722c20746364625f6275696c64203d20546364624275696c642c20746364625f6275696c645f726967687473203d20546364624275696c645269676874732c20746364625f74635f726967687473203d205463646254435269676874732c20746364625f6f735f726967687473203d20546364624f535269676874732c20746364625f706173735f726967687473203d2054636462506173735269676874730d0a574845524520557365726e616d65203d206f6c64557365724e616d653b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-28 15:00:51', '', ''),
(0x7463636f6d706c657465, 'sp_UserDelete', 'PROCEDURE', 'sp_UserDelete', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x6e616d6520766172636861722831303029, '', 0x424547494e0d0a44454c4554452046524f4d206c6f67696e0d0a574845524520557365726e616d65203d206e616d653b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-26 17:58:43', '', ''),
(0x7463636f6d706c657465, 'sp_BuildInsert', 'PROCEDURE', 'sp_BuildInsert', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x494e2050726f6a65637455494420696e74283131292c20494e204275696c644e616d652074696e79746578742c20494e204275696c644465736372697074696f6e206d656469756d746578742c20494e204275696c64446174652074696d657374616d702c20494e204275696c64446973706c617920696e7428313129, '', 0x424547494e0d0a494e5345525420494e544f20746364625f6275696c64732870726f6a6563745f7569642c206e616d652c206465736372697074696f6e2c20646174652c20646973706c6179290d0a56414c554553202850726f6a6563745549442c204275696c644e616d652c204275696c644465736372697074696f6e2c204275696c64446174652c204275696c64446973706c6179293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-27 14:21:22', '', ''),
(0x7463636f6d706c657465, 'sp_BuildUpdate', 'PROCEDURE', 'sp_BuildUpdate', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x4275696c6455494420696e74283131292c20494e2050726f6a65637455494420696e74283131292c20494e204275696c644e616d652074696e79746578742c20494e204275696c644465736372697074696f6e206d656469756d746578742c20494e204275696c64446174652074696d657374616d702c20494e204275696c64446973706c617920696e7428313129, '', 0x424547494e0d0a55504441544520746364625f6275696c64730d0a5345542070726f6a6563745f756964203d2050726f6a6563745549442c206e616d65203d204275696c644e616d652c206465736372697074696f6e203d204275696c644465736372697074696f6e2c2064617465203d204275696c64446174652c20646973706c6179203d204275696c64446973706c61790d0a57484552452028756964203d204275696c64554944293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-27 14:25:08', '', ''),
(0x7463636f6d706c657465, 'sp_BuildDelete', 'PROCEDURE', 'sp_BuildDelete', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x4275696c6455494420696e7428313129, '', 0x424547494e0d0a44454c4554452046524f4d20746364625f6275696c64730d0a57484552452028756964203d204275696c64554944293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-27 14:28:14', '', ''),
(0x7463636f6d706c657465, 'sp_TestCaseInsert', 'PROCEDURE', 'sp_TestCaseInsert', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x50726f6a65637455494420696e74283131292c2054434f776e65722074696e79746578742c20544344656661756c745072696f7269747920696e74283131292c20544353686f7274446573632074696e79746578742c205443457463536574757020696e74283131292c20544345746352756e20696e74283131292c205443457463436c65616e20696e74283131292c205443596f7549442076617263686172283634292c20544344656665637449442076617263686172283135292c205443506173734661696c44657363206d656469756d746578742c20544353657475705374657073206d656469756d746578742c20544352756e5374657073206d656469756d746578742c205443436c65616e5374657073206d656469756d74657874, '', 0x424547494e0d0a494e5345525420494e544f20746364625f7465737463617365732870726f6a6563745f7569642c206f776e65722c2064656661756c745f7072696f726974792c2073686f72745f646573632c206574635f73657475702c206574635f72756e2c206574635f636c65616e2c20796f755f69642c206465666563745f69642c20706173735f6661696c5f646573632c2073657475705f73746570732c2072756e5f73746570732c20636c65616e5f7374657073290d0a56414c554553202850726f6a6563745549442c2054434f776e65722c20544344656661756c745072696f726974792c20544353686f7274446573632c20544345746353657475702c20544345746352756e2c205443457463436c65616e2c205443596f7549442c20544344656665637449442c205443506173734661696c446573632c205443536574757053746570732c20544352756e53746570732c205443436c65616e5374657073293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-27 14:38:30', '', ''),
(0x7463636f6d706c657465, 'sp_TestCaseUpdate', 'PROCEDURE', 'sp_TestCaseUpdate', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x544355494420696e74283131292c2050726f6a65637455494420696e74283131292c2054434f776e65722074696e79746578742c20544344656661756c745072696f7269747920696e74283131292c20544353686f7274446573632074696e79746578742c205443457463536574757020696e74283131292c20544345746352756e20696e74283131292c205443457463436c65616e20696e74283131292c205443596f7549442076617263686172283634292c20544344656665637449442076617263686172283135292c205443506173734661696c44657363206d656469756d746578742c20544353657475705374657073206d656469756d746578742c20544352756e5374657073206d656469756d746578742c205443436c65616e5374657073206d656469756d74657874, '', 0x424547494e0d0a55504441544520746364625f7465737463617365730d0a5345542070726f6a6563745f756964203d2050726f6a6563745549442c206f776e6572203d2054434f776e65722c2064656661756c745f7072696f72697479203d20544344656661756c745072696f726974792c2073686f72745f64657363203d20544353686f7274446573632c206574635f7365747570203d20544345746353657475702c206574635f72756e203d20544345746352756e2c206574635f636c65616e203d205443457463436c65616e2c20796f755f6964203d205443596f7549442c206465666563745f6964203d20544344656665637449442c20706173735f6661696c5f64657363203d205443506173734661696c446573632c2073657475705f7374657073203d205443536574757053746570732c2072756e5f7374657073203d20544352756e53746570732c20636c65616e5f7374657073203d205443436c65616e53746570730d0a57484552452028756964203d205443554944293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-27 14:42:37', '', ''),
(0x7463636f6d706c657465, 'sp_TestCaseRetrieve', 'PROCEDURE', 'sp_TestCaseRetrieve', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x746375696420696e74283131292c207075696420696e7428313129, '', 0x424547494e0d0a53454c454354202a0d0a46524f4d20746364625f7465737463617365730d0a57484552452028287463756964204953204e554c4c29204f522028756964203d207463756964292920414e4420282870756964204953204e554c4c29204f52202870726f6a6563745f756964203d207075696429293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:34:57', '2006-08-16 21:44:08', '', ''),
(0x7463636f6d706c657465, 'sp_TestCaseDelete', 'PROCEDURE', 'sp_TestCaseDelete', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x544355494420696e7428313129, '', 0x424547494e0d0a44454c4554452046524f4d20746364625f7465737463617365730d0a57484552452028756964203d205443554944293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-07-27 14:45:42', '', ''),
(0x7463636f6d706c657465, 'sp_BuildRetrieve', 'PROCEDURE', 'sp_BuildRetrieve', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x4275696c64494420696e74283131292c2050726f6a656374494420696e74283131292c204275696c644e616d652074696e7974657874, '', 0x424547494e0d0a53454c454354202a0d0a46524f4d20746364625f6275696c64730d0a57484552452028284275696c644944204953204e554c4c29204f522028756964203d204275696c644944292920414e442028282050726f6a6563744944204953204e554c4c29204f5220282070726f6a6563745f756964203d2050726f6a6563744944292920414e44202828204275696c644e616d65204953204e554c4c294f522028206e616d65203d204275696c644e616d6529290d0a4f52444552204259206e616d65204153433b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-24 14:07:56', '', ''),
(0x7463636f6d706c657465, 'sp_HistoryRetrieve', 'PROCEDURE', 'sp_HistoryRetrieve', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x526573756c7455494420696e74283131292c20486973746f727954696d652074696d657374616d702c20486973746f7279557365724e616d652074696e79746578742c20486973746f727953746174757320696e74283131292c20486973746f727944656665637449442074696e7974657874, '', 0x424547494e0d0a53454c454354202a0d0a46524f4d20746364625f686973746f72790d0a57484552452028526573756c74554944204953204e554c4c29204f522028726573756c74735f756964203d20526573756c745549442920414e442028486973746f727954696d65204953204e554c4c29204f52202874696d65203d20486973746f727954696d652920414e442028486973746f7279537461747573204953204e554c4c29204f522028737461747573203d20486973746f72795374617475732920414e442028486973746f72794465666563744944204953204e554c4c29204f5220286465666563745f6964203d20486973746f72794465666563744944293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-24 11:06:57', '', ''),
(0x7463636f6d706c657465, 'sp_ResultInsert', 'PROCEDURE', 'sp_ResultInsert', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x746375696420696e74283131292c206275696420696e74283131292c20726573756c74537461747573206d656469756d746578742c207570646174656462792074696e79746578742c207570646174654e6f746573206d656469756d746578742c2062756769642074696e79746578742c20636865636b6f75742074696d657374616d70, '', 0x424547494e0d0a494e5345525420494e544f20746364625f726573756c74732874657374636173655f7569642c206275696c645f7569642c207374617475732c20757064617465645f62792c207570646174655f6e6f7465732c206275675f69642c20636865636b6f75745f74696d65290d0a56414c554553202874637569642c20627569642c20726573756c745374617475732c207570646174656462792c207570646174654e6f7465732c2062756769642c20636865636b6f7574293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-15 15:46:01', '', ''),
(0x7463636f6d706c657465, 'sp_UserRetrieve', 'PROCEDURE', 'sp_UserRetrieve', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x557365727320766172636861722831303029, '', 0x424547494e0d0a53454c454354202a0d0a46524f4d206c6f67696e0d0a574845524520285573657273204953204e554c4c29204f522028557365726e616d65203d205573657273293b0d0a0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-28 12:19:32', '', ''),
(0x7463636f6d706c657465, 'sp_WorkListRetrieve', 'PROCEDURE', 'sp_WorkListRetrieve', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x7570646174656442792074696e7974657874, '', 0x424547494e0d0a53454c454354202a0d0a46524f4d20746364625f726573756c74730d0a57484552452028757064617465645f6279203d207570646174656442792920414e442028636865636b6f75745f74696d65204953204e4f54204e554c4c293b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-22 12:11:30', '', ''),
(0x7463636f6d706c657465, 'sp_UserChangePassword', 'PROCEDURE', 'sp_UserChangePassword', 'SQL', 'CONTAINS_SQL', 'NO', 'DEFINER', 0x757372207661726368617228313030292c207061737320766172636861722831303029, '', 0x424547494e0d0a555044415445206c6f67696e0d0a5345542050617373776f7264203d2050415353574f52442870617373290d0a574845524520557365726e616d65203d207573723b0d0a454e44, 0x74636462757365724025, '2007-04-18 23:36:10', '2006-08-28 15:44:20', '', '');
