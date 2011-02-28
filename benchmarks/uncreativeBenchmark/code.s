	.section        ".text"
	.align 4
	.global countTotal
.type    countTotal, #function
countTotal:
save %sp, -104, %sp
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
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
stw %l0, [%sp + 96]
ldsw [%sp + 96], %l0
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
be %icc, .L8238
nop
ba %icc, .L8244
nop
.L8238:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8270
nop
.L8244:
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
ba %icc, .L8270
nop
.L8270:
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
be %icc, .L8282
nop
ba %icc, .L8287
nop
.L8282:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8423
nop
.L8287:
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
be %icc, .L8295
nop
ba %icc, .L8300
nop
.L8295:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8421
nop
.L8300:
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
be %icc, .L8308
nop
ba %icc, .L8313
nop
.L8308:
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8418
nop
.L8313:
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
be %icc, .L8321
nop
ba %icc, .L8326
nop
.L8321:
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8415
nop
.L8326:
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
be %icc, .L8334
nop
ba %icc, .L8339
nop
.L8334:
sethi %hi(100), %l0
or %l0, %lo(100), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8412
nop
.L8339:
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
be %icc, .L8347
nop
ba %icc, .L8352
nop
.L8347:
sethi %hi(101), %l0
or %l0, %lo(101), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8409
nop
.L8352:
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
be %icc, .L8360
nop
ba %icc, .L8365
nop
.L8360:
sethi %hi(110), %l0
or %l0, %lo(110), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8406
nop
.L8365:
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
be %icc, .L8373
nop
ba %icc, .L8378
nop
.L8373:
sethi %hi(111), %l0
or %l0, %lo(111), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8403
nop
.L8378:
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
be %icc, .L8386
nop
ba %icc, .L8391
nop
.L8386:
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8400
nop
.L8391:
sethi %hi(1001), %l0
or %l0, %lo(1001), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L8400
nop
.L8400:
ba %icc, .L8403
nop
.L8403:
ba %icc, .L8406
nop
.L8406:
ba %icc, .L8409
nop
.L8409:
ba %icc, .L8412
nop
.L8412:
ba %icc, .L8415
nop
.L8415:
ba %icc, .L8418
nop
.L8418:
ba %icc, .L8421
nop
.L8421:
ba %icc, .L8423
nop
.L8423:
	.size    convertBinary, .-convertBinary
	.align 4
	.global main
.type    main, #function
main:
save %sp, -112, %sp
or %g0, 1, %o0
or %g0, 36, %o1
call calloc
nop
mov %o0, %l0
stw %l0, [%sp + 104]
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%sp + 96]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 0]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 8]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 12]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 16]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 20]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 24]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 28]
ldsw [%sp + 104], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 32]
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 108, %o1
call scanf
nop
ldsw [%sp + 108], %l0
stw %l0, [%sp + 92]
.L8484:
ldsw [%sp + 92], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8490
nop
ba %icc, .L8696
nop
.L8490:
ldsw [%sp + 92], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8498
nop
ba %icc, .L8510
nop
.L8498:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 0], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 0]
ba %icc, .L8686
nop
.L8510:
ldsw [%sp + 92], %l1
sethi %hi(2), %l0
or %l0, %lo(2), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8518
nop
ba %icc, .L8530
nop
.L8518:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 4], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 4]
ba %icc, .L8684
nop
.L8530:
ldsw [%sp + 92], %l1
sethi %hi(3), %l0
or %l0, %lo(3), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8538
nop
ba %icc, .L8550
nop
.L8538:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 8], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 8]
ba %icc, .L8681
nop
.L8550:
ldsw [%sp + 92], %l1
sethi %hi(4), %l0
or %l0, %lo(4), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8558
nop
ba %icc, .L8570
nop
.L8558:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 12], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 12]
ba %icc, .L8678
nop
.L8570:
ldsw [%sp + 92], %l1
sethi %hi(5), %l0
or %l0, %lo(5), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8578
nop
ba %icc, .L8590
nop
.L8578:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 16], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 16]
ba %icc, .L8675
nop
.L8590:
ldsw [%sp + 92], %l1
sethi %hi(6), %l0
or %l0, %lo(6), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8598
nop
ba %icc, .L8610
nop
.L8598:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 20], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 20]
ba %icc, .L8672
nop
.L8610:
ldsw [%sp + 92], %l1
sethi %hi(7), %l0
or %l0, %lo(7), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8618
nop
ba %icc, .L8630
nop
.L8618:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 24], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 24]
ba %icc, .L8669
nop
.L8630:
ldsw [%sp + 92], %l1
sethi %hi(8), %l0
or %l0, %lo(8), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L8638
nop
ba %icc, .L8650
nop
.L8638:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 28], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 28]
ba %icc, .L8666
nop
.L8650:
ldsw [%sp + 104], %l2
ldsw [%sp + 104], %l0
ldsw [%l0 + 32], %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l1, %l0, %l0
stw %l0, [%l2 + 32]
ba %icc, .L8666
nop
.L8666:
ba %icc, .L8669
nop
.L8669:
ba %icc, .L8672
nop
.L8672:
ba %icc, .L8675
nop
.L8675:
ba %icc, .L8678
nop
.L8678:
ba %icc, .L8681
nop
.L8681:
ba %icc, .L8684
nop
.L8684:
ba %icc, .L8686
nop
.L8686:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 108, %o1
call scanf
nop
ldsw [%sp + 108], %l0
stw %l0, [%sp + 92]
ba %icc, .L8484
nop
.L8696:
ldsw [%sp + 104], %l0
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
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 4], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 8], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(4), %l0
or %l0, %lo(4), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 12], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(5), %l0
or %l0, %lo(5), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 16], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(6), %l0
or %l0, %lo(6), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 20], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(7), %l0
or %l0, %lo(7), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 24], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(8), %l0
or %l0, %lo(8), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 28], %l0
mov %l1, %o0
mov %l0, %o1
call printRecursive
nop
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l0, %o0
call convertBinary
nop
mov %o0, %l1
ldsw [%sp + 104], %l0
ldsw [%l0 + 32], %l0
mov %l1, %o0
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

