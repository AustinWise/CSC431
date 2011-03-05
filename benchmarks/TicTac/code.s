	.section        ".text"
	.align 4
	.global cleanBoard
.type    cleanBoard, #function
cleanBoard:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 0]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 8]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 12]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 16]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 20]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 24]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 28]
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 32]
ret
restore
	.size    cleanBoard, .-cleanBoard
	.align 4
	.global printBoard
.type    printBoard, #function
printBoard:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 12], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 16], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 20], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 24], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 28], %l0
sethi %hi(.ConstantString0), %o0
or %o0, %lo(.ConstantString0), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 32], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    printBoard, .-printBoard
	.align 4
	.global printMoveBoard
.type    printMoveBoard, #function
printMoveBoard:
save %sp, -96, %sp
sethi %hi(123), %l0
or %l0, %lo(123), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(456), %l0
or %l0, %lo(456), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(789), %l0
or %l0, %lo(789), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
ret
restore
	.size    printMoveBoard, .-printMoveBoard
	.align 4
	.global placePiece
.type    placePiece, #function
placePiece:
save %sp, -104, %sp
mov %i2, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11824
nop
ba %icc, .L11832
nop
.L11824:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
ba %icc, .L11989
nop
.L11832:
mov %i2, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11840
nop
ba %icc, .L11848
nop
.L11840:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
ba %icc, .L11987
nop
.L11848:
mov %i2, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11856
nop
ba %icc, .L11864
nop
.L11856:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 8]
ba %icc, .L11984
nop
.L11864:
mov %i2, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11872
nop
ba %icc, .L11880
nop
.L11872:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 12]
ba %icc, .L11981
nop
.L11880:
mov %i2, %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11888
nop
ba %icc, .L11896
nop
.L11888:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 16]
ba %icc, .L11978
nop
.L11896:
mov %i2, %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11904
nop
ba %icc, .L11912
nop
.L11904:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 20]
ba %icc, .L11975
nop
.L11912:
mov %i2, %l1
sethi %hi(7), %l0
or %l0, %lo(7), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11920
nop
ba %icc, .L11928
nop
.L11920:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 24]
ba %icc, .L11972
nop
.L11928:
mov %i2, %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11936
nop
ba %icc, .L11944
nop
.L11936:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 28]
ba %icc, .L11969
nop
.L11944:
mov %i2, %l1
sethi %hi(9), %l0
or %l0, %lo(9), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L11952
nop
ba %icc, .L11960
nop
.L11952:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 32]
ba %icc, .L11966
nop
.L11960:
ba %icc, .L11966
nop
.L11966:
ba %icc, .L11969
nop
.L11969:
ba %icc, .L11972
nop
.L11972:
ba %icc, .L11975
nop
.L11975:
ba %icc, .L11978
nop
.L11978:
ba %icc, .L11981
nop
.L11981:
ba %icc, .L11984
nop
.L11984:
ba %icc, .L11987
nop
.L11987:
ba %icc, .L11989
nop
.L11989:
ret
restore
	.size    placePiece, .-placePiece
	.align 4
	.global checkWinner
.type    checkWinner, #function
checkWinner:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12002
nop
ba %icc, .L12035
nop
.L12002:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12011
nop
ba %icc, .L12030
nop
.L12011:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12020
nop
ba %icc, .L12025
nop
.L12020:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12032
nop
.L12025:
ba %icc, .L12032
nop
.L12032:
ba %icc, .L12037
nop
.L12030:
ba %icc, .L12037
nop
.L12037:
ba %icc, .L12040
nop
.L12035:
ba %icc, .L12040
nop
.L12040:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12047
nop
ba %icc, .L12080
nop
.L12047:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12056
nop
ba %icc, .L12075
nop
.L12056:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12065
nop
ba %icc, .L12070
nop
.L12065:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12077
nop
.L12070:
ba %icc, .L12077
nop
.L12077:
ba %icc, .L12082
nop
.L12075:
ba %icc, .L12082
nop
.L12082:
ba %icc, .L12085
nop
.L12080:
ba %icc, .L12085
nop
.L12085:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12092
nop
ba %icc, .L12125
nop
.L12092:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12101
nop
ba %icc, .L12120
nop
.L12101:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12110
nop
ba %icc, .L12115
nop
.L12110:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12122
nop
.L12115:
ba %icc, .L12122
nop
.L12122:
ba %icc, .L12127
nop
.L12120:
ba %icc, .L12127
nop
.L12127:
ba %icc, .L12130
nop
.L12125:
ba %icc, .L12130
nop
.L12130:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12137
nop
ba %icc, .L12170
nop
.L12137:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12146
nop
ba %icc, .L12165
nop
.L12146:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12155
nop
ba %icc, .L12160
nop
.L12155:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12167
nop
.L12160:
ba %icc, .L12167
nop
.L12167:
ba %icc, .L12172
nop
.L12165:
ba %icc, .L12172
nop
.L12172:
ba %icc, .L12175
nop
.L12170:
ba %icc, .L12175
nop
.L12175:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12182
nop
ba %icc, .L12215
nop
.L12182:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12191
nop
ba %icc, .L12210
nop
.L12191:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12200
nop
ba %icc, .L12205
nop
.L12200:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12212
nop
.L12205:
ba %icc, .L12212
nop
.L12212:
ba %icc, .L12217
nop
.L12210:
ba %icc, .L12217
nop
.L12217:
ba %icc, .L12220
nop
.L12215:
ba %icc, .L12220
nop
.L12220:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12227
nop
ba %icc, .L12260
nop
.L12227:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12236
nop
ba %icc, .L12255
nop
.L12236:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12245
nop
ba %icc, .L12250
nop
.L12245:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12257
nop
.L12250:
ba %icc, .L12257
nop
.L12257:
ba %icc, .L12262
nop
.L12255:
ba %icc, .L12262
nop
.L12262:
ba %icc, .L12265
nop
.L12260:
ba %icc, .L12265
nop
.L12265:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12272
nop
ba %icc, .L12305
nop
.L12272:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12281
nop
ba %icc, .L12300
nop
.L12281:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12290
nop
ba %icc, .L12295
nop
.L12290:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12302
nop
.L12295:
ba %icc, .L12302
nop
.L12302:
ba %icc, .L12307
nop
.L12300:
ba %icc, .L12307
nop
.L12307:
ba %icc, .L12310
nop
.L12305:
ba %icc, .L12310
nop
.L12310:
mov %i0, %l0
ldsw [%l0 + 0], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12317
nop
ba %icc, .L12350
nop
.L12317:
mov %i0, %l0
ldsw [%l0 + 12], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12326
nop
ba %icc, .L12345
nop
.L12326:
mov %i0, %l0
ldsw [%l0 + 24], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12335
nop
ba %icc, .L12340
nop
.L12335:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12347
nop
.L12340:
ba %icc, .L12347
nop
.L12347:
ba %icc, .L12352
nop
.L12345:
ba %icc, .L12352
nop
.L12352:
ba %icc, .L12355
nop
.L12350:
ba %icc, .L12355
nop
.L12355:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12362
nop
ba %icc, .L12395
nop
.L12362:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12371
nop
ba %icc, .L12390
nop
.L12371:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12380
nop
ba %icc, .L12385
nop
.L12380:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12392
nop
.L12385:
ba %icc, .L12392
nop
.L12392:
ba %icc, .L12397
nop
.L12390:
ba %icc, .L12397
nop
.L12397:
ba %icc, .L12400
nop
.L12395:
ba %icc, .L12400
nop
.L12400:
mov %i0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12407
nop
ba %icc, .L12440
nop
.L12407:
mov %i0, %l0
ldsw [%l0 + 16], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12416
nop
ba %icc, .L12435
nop
.L12416:
mov %i0, %l0
ldsw [%l0 + 28], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12425
nop
ba %icc, .L12430
nop
.L12425:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12437
nop
.L12430:
ba %icc, .L12437
nop
.L12437:
ba %icc, .L12442
nop
.L12435:
ba %icc, .L12442
nop
.L12442:
ba %icc, .L12445
nop
.L12440:
ba %icc, .L12445
nop
.L12445:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12452
nop
ba %icc, .L12485
nop
.L12452:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12461
nop
ba %icc, .L12480
nop
.L12461:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12470
nop
ba %icc, .L12475
nop
.L12470:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12482
nop
.L12475:
ba %icc, .L12482
nop
.L12482:
ba %icc, .L12487
nop
.L12480:
ba %icc, .L12487
nop
.L12487:
ba %icc, .L12490
nop
.L12485:
ba %icc, .L12490
nop
.L12490:
mov %i0, %l0
ldsw [%l0 + 8], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12497
nop
ba %icc, .L12530
nop
.L12497:
mov %i0, %l0
ldsw [%l0 + 20], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12506
nop
ba %icc, .L12525
nop
.L12506:
mov %i0, %l0
ldsw [%l0 + 32], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L12515
nop
ba %icc, .L12520
nop
.L12515:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12527
nop
.L12520:
ba %icc, .L12527
nop
.L12527:
ba %icc, .L12532
nop
.L12525:
ba %icc, .L12532
nop
.L12532:
ba %icc, .L12535
nop
.L12530:
ba %icc, .L12535
nop
.L12535:
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
or %l0, 0, %i0
ret
restore
	.size    checkWinner, .-checkWinner
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l3
or %l3, %lo(0), %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(-1), %l2
or %l2, %lo(-1), %l2
or %g0, 1, %o0
or %g0, 36, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l4
mov %l4, %o0
call cleanBoard
nop
.L12574:
or %l2, 0, %l5
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l5, %l4
movl %icc, 1, %l7
or %l1, 0, %l5
sethi %hi(8), %l4
or %l4, %lo(8), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movne %icc, 1, %l6
and %l7, %l6, %l5
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l5, %l4
be %icc, .L12587
nop
ba %icc, .L12674
nop
.L12587:
or %l0, 0, %l2
mov %l2, %o0
call printBoard
nop
or %l3, 0, %l4
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l5
or %l5, %lo(0), %l5
cmp %l4, %l2
move %icc, 1, %l5
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l5, %l2
be %icc, .L12599
nop
ba %icc, .L12620
nop
.L12599:
or %l3, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
add %l3, %l2, %l2
or %l2, 0, %l3
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l2
or %l2, 0, %l2
or %l0, 0, %l5
sethi %hi(1), %l4
or %l4, %lo(1), %l4
or %l2, 0, %l2
mov %l5, %o0
mov %l4, %o1
mov %l2, %o2
call placePiece
nop
ba %icc, .L12644
nop
.L12620:
or %l3, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sub %l3, %l2, %l2
or %l2, 0, %l3
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l2
or %l2, 0, %l2
or %l0, 0, %l5
sethi %hi(2), %l4
or %l4, %lo(2), %l4
or %l2, 0, %l2
mov %l5, %o0
mov %l4, %o1
mov %l2, %o2
call placePiece
nop
ba %icc, .L12644
nop
.L12644:
or %l0, 0, %l2
mov %l2, %o0
call checkWinner
nop
mov %o0, %l2
or %l2, 0, %l2
or %l1, 0, %l4
sethi %hi(1), %l1
or %l1, %lo(1), %l1
add %l4, %l1, %l1
or %l1, 0, %l1
ba %icc, .L12574
nop
.L12674:
or %l2, 0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.section        ".rodata"
	.align 8
.ConstantString0:
	.asciz  "%d "
	.align 8
.ConstantString1:
	.asciz  "%d\n"
	.align 8
.ConstantString2:
	.asciz  "%d"

