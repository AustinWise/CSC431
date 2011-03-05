	.section        ".text"
	.align 4
	.global countTotal
.type    countTotal, #function
countTotal:
save %sp, -96, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i0, %l0
ldsw [%l0 + 4], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 8], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 12], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 16], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 20], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 24], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 28], %l0
add %l1, %l0, %l1
mov %i0, %l0
ldsw [%l0 + 32], %l0
add %l1, %l0, %l0
or %l0, 0, %l0
or %l0, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    countTotal, .-countTotal
	.align 4
	.global printRecursive
.type    printRecursive, #function
printRecursive:
save %sp, -104, %sp
mov %i1, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14107
nop
ba %icc, .L14113
nop
.L14107:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14139
nop
.L14113:
mov %i0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l0, %i1
mov %i0, %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14139
nop
.L14139:
	.size    printRecursive, .-printRecursive
	.align 4
	.global convertBinary
.type    convertBinary, #function
convertBinary:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14151
nop
ba %icc, .L14156
nop
.L14151:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14292
nop
.L14156:
mov %i0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14164
nop
ba %icc, .L14169
nop
.L14164:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14290
nop
.L14169:
mov %i0, %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14177
nop
ba %icc, .L14182
nop
.L14177:
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14287
nop
.L14182:
mov %i0, %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14190
nop
ba %icc, .L14195
nop
.L14190:
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14284
nop
.L14195:
mov %i0, %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14203
nop
ba %icc, .L14208
nop
.L14203:
sethi %hi(100), %l0
or %l0, %lo(100), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14281
nop
.L14208:
mov %i0, %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14216
nop
ba %icc, .L14221
nop
.L14216:
sethi %hi(101), %l0
or %l0, %lo(101), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14278
nop
.L14221:
mov %i0, %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14229
nop
ba %icc, .L14234
nop
.L14229:
sethi %hi(110), %l0
or %l0, %lo(110), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14275
nop
.L14234:
mov %i0, %l1
sethi %hi(7), %l0
or %l0, %lo(7), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14242
nop
ba %icc, .L14247
nop
.L14242:
sethi %hi(111), %l0
or %l0, %lo(111), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14272
nop
.L14247:
mov %i0, %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L14255
nop
ba %icc, .L14260
nop
.L14255:
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14269
nop
.L14260:
sethi %hi(1001), %l0
or %l0, %lo(1001), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14269
nop
.L14269:
ba %icc, .L14272
nop
.L14272:
ba %icc, .L14275
nop
.L14275:
ba %icc, .L14278
nop
.L14278:
ba %icc, .L14281
nop
.L14281:
ba %icc, .L14284
nop
.L14284:
ba %icc, .L14287
nop
.L14287:
ba %icc, .L14290
nop
.L14290:
ba %icc, .L14292
nop
.L14292:
	.size    convertBinary, .-convertBinary
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
or %g0, 1, %o0
or %g0, 36, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 0]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 4]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 8]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 12]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 16]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 20]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 24]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 28]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 32]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
.L14353:
or %l0, 0, %l3
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
movne %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14359
nop
ba %icc, .L14565
nop
.L14359:
or %l0, 0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14367
nop
ba %icc, .L14379
nop
.L14367:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 0], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 0]
ba %icc, .L14555
nop
.L14379:
or %l0, 0, %l3
sethi %hi(2), %l2
or %l2, %lo(2), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14387
nop
ba %icc, .L14399
nop
.L14387:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 4], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 4]
ba %icc, .L14553
nop
.L14399:
or %l0, 0, %l3
sethi %hi(3), %l2
or %l2, %lo(3), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14407
nop
ba %icc, .L14419
nop
.L14407:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 8], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 8]
ba %icc, .L14550
nop
.L14419:
or %l0, 0, %l3
sethi %hi(4), %l2
or %l2, %lo(4), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14427
nop
ba %icc, .L14439
nop
.L14427:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 12], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 12]
ba %icc, .L14547
nop
.L14439:
or %l0, 0, %l3
sethi %hi(5), %l2
or %l2, %lo(5), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14447
nop
ba %icc, .L14459
nop
.L14447:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 16], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 16]
ba %icc, .L14544
nop
.L14459:
or %l0, 0, %l3
sethi %hi(6), %l2
or %l2, %lo(6), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14467
nop
ba %icc, .L14479
nop
.L14467:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 20], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 20]
ba %icc, .L14541
nop
.L14479:
or %l0, 0, %l3
sethi %hi(7), %l2
or %l2, %lo(7), %l2
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l3, %l2
move %icc, 1, %l4
sethi %hi(1), %l2
or %l2, %lo(1), %l2
cmp %l4, %l2
be %icc, .L14487
nop
ba %icc, .L14499
nop
.L14487:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 24], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 24]
ba %icc, .L14538
nop
.L14499:
or %l0, 0, %l2
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l3
or %l3, %lo(0), %l3
cmp %l2, %l0
move %icc, 1, %l3
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l3, %l0
be %icc, .L14507
nop
ba %icc, .L14519
nop
.L14507:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 28], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 28]
ba %icc, .L14535
nop
.L14519:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 32], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 32]
ba %icc, .L14535
nop
.L14535:
ba %icc, .L14538
nop
.L14538:
ba %icc, .L14541
nop
.L14541:
ba %icc, .L14544
nop
.L14544:
ba %icc, .L14547
nop
.L14547:
ba %icc, .L14550
nop
.L14550:
ba %icc, .L14553
nop
.L14553:
ba %icc, .L14555
nop
.L14555:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
ba %icc, .L14353
nop
.L14565:
or %l1, 0, %l0
mov %l0, %o0
call countTotal
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 0], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 4], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 8], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 12], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(5), %l0
or %l0, %lo(5), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 16], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(6), %l0
or %l0, %lo(6), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 20], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(7), %l0
or %l0, %lo(7), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 24], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(8), %l0
or %l0, %lo(8), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 28], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l2
or %l1, 0, %l0
ldsw [%l0 + 32], %l0
mov %l2, %o0
mov %l0, %o1
call printRecursive
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

