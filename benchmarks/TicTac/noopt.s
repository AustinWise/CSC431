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
save %sp, -96, %sp
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
be %icc, .L22939
nop
ba %icc, .L22947
nop
.L22939:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
ba %icc, .L23104
nop
.L22947:
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
be %icc, .L22955
nop
ba %icc, .L22963
nop
.L22955:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
ba %icc, .L23102
nop
.L22963:
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
be %icc, .L22971
nop
ba %icc, .L22979
nop
.L22971:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 8]
ba %icc, .L23099
nop
.L22979:
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
be %icc, .L22987
nop
ba %icc, .L22995
nop
.L22987:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 12]
ba %icc, .L23096
nop
.L22995:
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
be %icc, .L23003
nop
ba %icc, .L23011
nop
.L23003:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 16]
ba %icc, .L23093
nop
.L23011:
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
be %icc, .L23019
nop
ba %icc, .L23027
nop
.L23019:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 20]
ba %icc, .L23090
nop
.L23027:
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
be %icc, .L23035
nop
ba %icc, .L23043
nop
.L23035:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 24]
ba %icc, .L23087
nop
.L23043:
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
be %icc, .L23051
nop
ba %icc, .L23059
nop
.L23051:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 28]
ba %icc, .L23084
nop
.L23059:
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
be %icc, .L23067
nop
ba %icc, .L23075
nop
.L23067:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 32]
ba %icc, .L23081
nop
.L23075:
ba %icc, .L23081
nop
.L23081:
ba %icc, .L23084
nop
.L23084:
ba %icc, .L23087
nop
.L23087:
ba %icc, .L23090
nop
.L23090:
ba %icc, .L23093
nop
.L23093:
ba %icc, .L23096
nop
.L23096:
ba %icc, .L23099
nop
.L23099:
ba %icc, .L23102
nop
.L23102:
ba %icc, .L23104
nop
.L23104:
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
be %icc, .L23118
nop
ba %icc, .L23151
nop
.L23118:
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
be %icc, .L23127
nop
ba %icc, .L23146
nop
.L23127:
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
be %icc, .L23136
nop
ba %icc, .L23141
nop
.L23136:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23148
nop
.L23141:
ba %icc, .L23148
nop
.L23148:
ba %icc, .L23153
nop
.L23146:
ba %icc, .L23153
nop
.L23153:
ba %icc, .L23156
nop
.L23151:
ba %icc, .L23156
nop
.L23156:
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
be %icc, .L23163
nop
ba %icc, .L23196
nop
.L23163:
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
be %icc, .L23172
nop
ba %icc, .L23191
nop
.L23172:
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
be %icc, .L23181
nop
ba %icc, .L23186
nop
.L23181:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23193
nop
.L23186:
ba %icc, .L23193
nop
.L23193:
ba %icc, .L23198
nop
.L23191:
ba %icc, .L23198
nop
.L23198:
ba %icc, .L23201
nop
.L23196:
ba %icc, .L23201
nop
.L23201:
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
be %icc, .L23208
nop
ba %icc, .L23241
nop
.L23208:
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
be %icc, .L23217
nop
ba %icc, .L23236
nop
.L23217:
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
be %icc, .L23226
nop
ba %icc, .L23231
nop
.L23226:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23238
nop
.L23231:
ba %icc, .L23238
nop
.L23238:
ba %icc, .L23243
nop
.L23236:
ba %icc, .L23243
nop
.L23243:
ba %icc, .L23246
nop
.L23241:
ba %icc, .L23246
nop
.L23246:
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
be %icc, .L23253
nop
ba %icc, .L23286
nop
.L23253:
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
be %icc, .L23262
nop
ba %icc, .L23281
nop
.L23262:
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
be %icc, .L23271
nop
ba %icc, .L23276
nop
.L23271:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23283
nop
.L23276:
ba %icc, .L23283
nop
.L23283:
ba %icc, .L23288
nop
.L23281:
ba %icc, .L23288
nop
.L23288:
ba %icc, .L23291
nop
.L23286:
ba %icc, .L23291
nop
.L23291:
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
be %icc, .L23298
nop
ba %icc, .L23331
nop
.L23298:
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
be %icc, .L23307
nop
ba %icc, .L23326
nop
.L23307:
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
be %icc, .L23316
nop
ba %icc, .L23321
nop
.L23316:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23328
nop
.L23321:
ba %icc, .L23328
nop
.L23328:
ba %icc, .L23333
nop
.L23326:
ba %icc, .L23333
nop
.L23333:
ba %icc, .L23336
nop
.L23331:
ba %icc, .L23336
nop
.L23336:
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
be %icc, .L23343
nop
ba %icc, .L23376
nop
.L23343:
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
be %icc, .L23352
nop
ba %icc, .L23371
nop
.L23352:
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
be %icc, .L23361
nop
ba %icc, .L23366
nop
.L23361:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23373
nop
.L23366:
ba %icc, .L23373
nop
.L23373:
ba %icc, .L23378
nop
.L23371:
ba %icc, .L23378
nop
.L23378:
ba %icc, .L23381
nop
.L23376:
ba %icc, .L23381
nop
.L23381:
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
be %icc, .L23388
nop
ba %icc, .L23421
nop
.L23388:
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
be %icc, .L23397
nop
ba %icc, .L23416
nop
.L23397:
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
be %icc, .L23406
nop
ba %icc, .L23411
nop
.L23406:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23418
nop
.L23411:
ba %icc, .L23418
nop
.L23418:
ba %icc, .L23423
nop
.L23416:
ba %icc, .L23423
nop
.L23423:
ba %icc, .L23426
nop
.L23421:
ba %icc, .L23426
nop
.L23426:
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
be %icc, .L23433
nop
ba %icc, .L23466
nop
.L23433:
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
be %icc, .L23442
nop
ba %icc, .L23461
nop
.L23442:
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
be %icc, .L23451
nop
ba %icc, .L23456
nop
.L23451:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23463
nop
.L23456:
ba %icc, .L23463
nop
.L23463:
ba %icc, .L23468
nop
.L23461:
ba %icc, .L23468
nop
.L23468:
ba %icc, .L23471
nop
.L23466:
ba %icc, .L23471
nop
.L23471:
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
be %icc, .L23478
nop
ba %icc, .L23511
nop
.L23478:
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
be %icc, .L23487
nop
ba %icc, .L23506
nop
.L23487:
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
be %icc, .L23496
nop
ba %icc, .L23501
nop
.L23496:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23508
nop
.L23501:
ba %icc, .L23508
nop
.L23508:
ba %icc, .L23513
nop
.L23506:
ba %icc, .L23513
nop
.L23513:
ba %icc, .L23516
nop
.L23511:
ba %icc, .L23516
nop
.L23516:
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
be %icc, .L23523
nop
ba %icc, .L23556
nop
.L23523:
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
be %icc, .L23532
nop
ba %icc, .L23551
nop
.L23532:
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
be %icc, .L23541
nop
ba %icc, .L23546
nop
.L23541:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23553
nop
.L23546:
ba %icc, .L23553
nop
.L23553:
ba %icc, .L23558
nop
.L23551:
ba %icc, .L23558
nop
.L23558:
ba %icc, .L23561
nop
.L23556:
ba %icc, .L23561
nop
.L23561:
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
be %icc, .L23568
nop
ba %icc, .L23601
nop
.L23568:
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
be %icc, .L23577
nop
ba %icc, .L23596
nop
.L23577:
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
be %icc, .L23586
nop
ba %icc, .L23591
nop
.L23586:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23598
nop
.L23591:
ba %icc, .L23598
nop
.L23598:
ba %icc, .L23603
nop
.L23596:
ba %icc, .L23603
nop
.L23603:
ba %icc, .L23606
nop
.L23601:
ba %icc, .L23606
nop
.L23606:
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
be %icc, .L23613
nop
ba %icc, .L23646
nop
.L23613:
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
be %icc, .L23622
nop
ba %icc, .L23641
nop
.L23622:
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
be %icc, .L23631
nop
ba %icc, .L23636
nop
.L23631:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L23643
nop
.L23636:
ba %icc, .L23643
nop
.L23643:
ba %icc, .L23648
nop
.L23641:
ba %icc, .L23648
nop
.L23648:
ba %icc, .L23651
nop
.L23646:
ba %icc, .L23651
nop
.L23651:
sethi %hi(1), %l1
or %l1, %lo(1), %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
	.size    checkWinner, .-checkWinner
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l3
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %l2
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sub %l0, %l2, %l0
or %l0, 0, %l2
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
.L23690:
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
be %icc, .L23703
nop
ba %icc, .L23790
nop
.L23703:
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
be %icc, .L23715
nop
ba %icc, .L23736
nop
.L23715:
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
ba %icc, .L23760
nop
.L23736:
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
ba %icc, .L23760
nop
.L23760:
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
ba %icc, .L23690
nop
.L23790:
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

