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
be %icc, .L11921
nop
ba %icc, .L11929
nop
.L11921:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
ba %icc, .L12086
nop
.L11929:
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
be %icc, .L11937
nop
ba %icc, .L11945
nop
.L11937:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
ba %icc, .L12084
nop
.L11945:
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
be %icc, .L11953
nop
ba %icc, .L11961
nop
.L11953:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 8]
ba %icc, .L12081
nop
.L11961:
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
be %icc, .L11969
nop
ba %icc, .L11977
nop
.L11969:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 12]
ba %icc, .L12078
nop
.L11977:
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
be %icc, .L11985
nop
ba %icc, .L11993
nop
.L11985:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 16]
ba %icc, .L12075
nop
.L11993:
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
be %icc, .L12001
nop
ba %icc, .L12009
nop
.L12001:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 20]
ba %icc, .L12072
nop
.L12009:
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
be %icc, .L12017
nop
ba %icc, .L12025
nop
.L12017:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 24]
ba %icc, .L12069
nop
.L12025:
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
be %icc, .L12033
nop
ba %icc, .L12041
nop
.L12033:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 28]
ba %icc, .L12066
nop
.L12041:
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
be %icc, .L12049
nop
ba %icc, .L12057
nop
.L12049:
mov %i0, %l1
mov %i1, %l0
stw %l0, [%l1 + 32]
ba %icc, .L12063
nop
.L12057:
ba %icc, .L12063
nop
.L12063:
ba %icc, .L12066
nop
.L12066:
ba %icc, .L12069
nop
.L12069:
ba %icc, .L12072
nop
.L12072:
ba %icc, .L12075
nop
.L12075:
ba %icc, .L12078
nop
.L12078:
ba %icc, .L12081
nop
.L12081:
ba %icc, .L12084
nop
.L12084:
ba %icc, .L12086
nop
.L12086:
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
be %icc, .L12100
nop
ba %icc, .L12133
nop
.L12100:
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
be %icc, .L12109
nop
ba %icc, .L12128
nop
.L12109:
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
be %icc, .L12118
nop
ba %icc, .L12123
nop
.L12118:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12130
nop
.L12123:
ba %icc, .L12130
nop
.L12130:
ba %icc, .L12135
nop
.L12128:
ba %icc, .L12135
nop
.L12135:
ba %icc, .L12138
nop
.L12133:
ba %icc, .L12138
nop
.L12138:
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
be %icc, .L12145
nop
ba %icc, .L12178
nop
.L12145:
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
be %icc, .L12154
nop
ba %icc, .L12173
nop
.L12154:
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
be %icc, .L12163
nop
ba %icc, .L12168
nop
.L12163:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12175
nop
.L12168:
ba %icc, .L12175
nop
.L12175:
ba %icc, .L12180
nop
.L12173:
ba %icc, .L12180
nop
.L12180:
ba %icc, .L12183
nop
.L12178:
ba %icc, .L12183
nop
.L12183:
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
be %icc, .L12190
nop
ba %icc, .L12223
nop
.L12190:
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
be %icc, .L12199
nop
ba %icc, .L12218
nop
.L12199:
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
be %icc, .L12208
nop
ba %icc, .L12213
nop
.L12208:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12220
nop
.L12213:
ba %icc, .L12220
nop
.L12220:
ba %icc, .L12225
nop
.L12218:
ba %icc, .L12225
nop
.L12225:
ba %icc, .L12228
nop
.L12223:
ba %icc, .L12228
nop
.L12228:
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
be %icc, .L12235
nop
ba %icc, .L12268
nop
.L12235:
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
be %icc, .L12244
nop
ba %icc, .L12263
nop
.L12244:
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
be %icc, .L12253
nop
ba %icc, .L12258
nop
.L12253:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12265
nop
.L12258:
ba %icc, .L12265
nop
.L12265:
ba %icc, .L12270
nop
.L12263:
ba %icc, .L12270
nop
.L12270:
ba %icc, .L12273
nop
.L12268:
ba %icc, .L12273
nop
.L12273:
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
be %icc, .L12280
nop
ba %icc, .L12313
nop
.L12280:
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
be %icc, .L12289
nop
ba %icc, .L12308
nop
.L12289:
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
be %icc, .L12298
nop
ba %icc, .L12303
nop
.L12298:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12310
nop
.L12303:
ba %icc, .L12310
nop
.L12310:
ba %icc, .L12315
nop
.L12308:
ba %icc, .L12315
nop
.L12315:
ba %icc, .L12318
nop
.L12313:
ba %icc, .L12318
nop
.L12318:
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
be %icc, .L12325
nop
ba %icc, .L12358
nop
.L12325:
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
be %icc, .L12334
nop
ba %icc, .L12353
nop
.L12334:
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
be %icc, .L12343
nop
ba %icc, .L12348
nop
.L12343:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12355
nop
.L12348:
ba %icc, .L12355
nop
.L12355:
ba %icc, .L12360
nop
.L12353:
ba %icc, .L12360
nop
.L12360:
ba %icc, .L12363
nop
.L12358:
ba %icc, .L12363
nop
.L12363:
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
be %icc, .L12370
nop
ba %icc, .L12403
nop
.L12370:
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
be %icc, .L12379
nop
ba %icc, .L12398
nop
.L12379:
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
be %icc, .L12388
nop
ba %icc, .L12393
nop
.L12388:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12400
nop
.L12393:
ba %icc, .L12400
nop
.L12400:
ba %icc, .L12405
nop
.L12398:
ba %icc, .L12405
nop
.L12405:
ba %icc, .L12408
nop
.L12403:
ba %icc, .L12408
nop
.L12408:
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
be %icc, .L12415
nop
ba %icc, .L12448
nop
.L12415:
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
be %icc, .L12424
nop
ba %icc, .L12443
nop
.L12424:
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
be %icc, .L12433
nop
ba %icc, .L12438
nop
.L12433:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12445
nop
.L12438:
ba %icc, .L12445
nop
.L12445:
ba %icc, .L12450
nop
.L12443:
ba %icc, .L12450
nop
.L12450:
ba %icc, .L12453
nop
.L12448:
ba %icc, .L12453
nop
.L12453:
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
be %icc, .L12460
nop
ba %icc, .L12493
nop
.L12460:
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
be %icc, .L12469
nop
ba %icc, .L12488
nop
.L12469:
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
be %icc, .L12478
nop
ba %icc, .L12483
nop
.L12478:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12490
nop
.L12483:
ba %icc, .L12490
nop
.L12490:
ba %icc, .L12495
nop
.L12488:
ba %icc, .L12495
nop
.L12495:
ba %icc, .L12498
nop
.L12493:
ba %icc, .L12498
nop
.L12498:
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
be %icc, .L12505
nop
ba %icc, .L12538
nop
.L12505:
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
be %icc, .L12514
nop
ba %icc, .L12533
nop
.L12514:
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
be %icc, .L12523
nop
ba %icc, .L12528
nop
.L12523:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12535
nop
.L12528:
ba %icc, .L12535
nop
.L12535:
ba %icc, .L12540
nop
.L12533:
ba %icc, .L12540
nop
.L12540:
ba %icc, .L12543
nop
.L12538:
ba %icc, .L12543
nop
.L12543:
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
be %icc, .L12550
nop
ba %icc, .L12583
nop
.L12550:
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
be %icc, .L12559
nop
ba %icc, .L12578
nop
.L12559:
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
be %icc, .L12568
nop
ba %icc, .L12573
nop
.L12568:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12580
nop
.L12573:
ba %icc, .L12580
nop
.L12580:
ba %icc, .L12585
nop
.L12578:
ba %icc, .L12585
nop
.L12585:
ba %icc, .L12588
nop
.L12583:
ba %icc, .L12588
nop
.L12588:
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
be %icc, .L12595
nop
ba %icc, .L12628
nop
.L12595:
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
be %icc, .L12604
nop
ba %icc, .L12623
nop
.L12604:
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
be %icc, .L12613
nop
ba %icc, .L12618
nop
.L12613:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L12625
nop
.L12618:
ba %icc, .L12625
nop
.L12625:
ba %icc, .L12630
nop
.L12623:
ba %icc, .L12630
nop
.L12630:
ba %icc, .L12633
nop
.L12628:
ba %icc, .L12633
nop
.L12633:
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
.L12672:
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
be %icc, .L12685
nop
ba %icc, .L12772
nop
.L12685:
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
be %icc, .L12697
nop
ba %icc, .L12718
nop
.L12697:
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
ba %icc, .L12742
nop
.L12718:
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
ba %icc, .L12742
nop
.L12742:
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
ba %icc, .L12672
nop
.L12772:
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

