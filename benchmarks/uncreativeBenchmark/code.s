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
save %sp, -96, %sp
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
be %icc, .L14208
nop
ba %icc, .L14214
nop
.L14208:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14240
nop
.L14214:
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
ba %icc, .L14240
nop
.L14240:
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
be %icc, .L14253
nop
ba %icc, .L14258
nop
.L14253:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14394
nop
.L14258:
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
be %icc, .L14266
nop
ba %icc, .L14271
nop
.L14266:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14392
nop
.L14271:
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
be %icc, .L14279
nop
ba %icc, .L14284
nop
.L14279:
sethi %hi(10), %l0
or %l0, %lo(10), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14389
nop
.L14284:
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
be %icc, .L14292
nop
ba %icc, .L14297
nop
.L14292:
sethi %hi(11), %l0
or %l0, %lo(11), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14386
nop
.L14297:
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
be %icc, .L14305
nop
ba %icc, .L14310
nop
.L14305:
sethi %hi(100), %l0
or %l0, %lo(100), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14383
nop
.L14310:
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
be %icc, .L14318
nop
ba %icc, .L14323
nop
.L14318:
sethi %hi(101), %l0
or %l0, %lo(101), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14380
nop
.L14323:
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
be %icc, .L14331
nop
ba %icc, .L14336
nop
.L14331:
sethi %hi(110), %l0
or %l0, %lo(110), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14377
nop
.L14336:
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
be %icc, .L14344
nop
ba %icc, .L14349
nop
.L14344:
sethi %hi(111), %l0
or %l0, %lo(111), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14374
nop
.L14349:
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
be %icc, .L14357
nop
ba %icc, .L14362
nop
.L14357:
sethi %hi(1000), %l0
or %l0, %lo(1000), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14371
nop
.L14362:
sethi %hi(1001), %l0
or %l0, %lo(1001), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L14371
nop
.L14371:
ba %icc, .L14374
nop
.L14374:
ba %icc, .L14377
nop
.L14377:
ba %icc, .L14380
nop
.L14380:
ba %icc, .L14383
nop
.L14383:
ba %icc, .L14386
nop
.L14386:
ba %icc, .L14389
nop
.L14389:
ba %icc, .L14392
nop
.L14392:
ba %icc, .L14394
nop
.L14394:
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
.L14455:
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
be %icc, .L14461
nop
ba %icc, .L14667
nop
.L14461:
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
be %icc, .L14469
nop
ba %icc, .L14481
nop
.L14469:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 0], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 0]
ba %icc, .L14657
nop
.L14481:
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
be %icc, .L14489
nop
ba %icc, .L14501
nop
.L14489:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 4], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 4]
ba %icc, .L14655
nop
.L14501:
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
be %icc, .L14509
nop
ba %icc, .L14521
nop
.L14509:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 8], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 8]
ba %icc, .L14652
nop
.L14521:
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
be %icc, .L14529
nop
ba %icc, .L14541
nop
.L14529:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 12], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 12]
ba %icc, .L14649
nop
.L14541:
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
be %icc, .L14549
nop
ba %icc, .L14561
nop
.L14549:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 16], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 16]
ba %icc, .L14646
nop
.L14561:
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
be %icc, .L14569
nop
ba %icc, .L14581
nop
.L14569:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 20], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 20]
ba %icc, .L14643
nop
.L14581:
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
be %icc, .L14589
nop
ba %icc, .L14601
nop
.L14589:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 24], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 24]
ba %icc, .L14640
nop
.L14601:
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
be %icc, .L14609
nop
ba %icc, .L14621
nop
.L14609:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 28], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 28]
ba %icc, .L14637
nop
.L14621:
or %l1, 0, %l3
or %l1, 0, %l0
ldsw [%l0 + 32], %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
stw %l0, [%l3 + 32]
ba %icc, .L14637
nop
.L14637:
ba %icc, .L14640
nop
.L14640:
ba %icc, .L14643
nop
.L14643:
ba %icc, .L14646
nop
.L14646:
ba %icc, .L14649
nop
.L14649:
ba %icc, .L14652
nop
.L14652:
ba %icc, .L14655
nop
.L14655:
ba %icc, .L14657
nop
.L14657:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
ba %icc, .L14455
nop
.L14667:
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

