	.section        ".text"
	.align 4
	.global concatLists
.type    concatLists, #function
concatLists:
save %sp, -104, %sp
mov %i0, %l0
or %l0, 0, %l3
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
be %icc, .L26
nop
ba %icc, .L37
nop
.L26:
mov %i1, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L51
nop
.L37:
ba %icc, .L51
nop
.L51:
or %l3, 0, %l0
ldsw [%l0 + 4], %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L62
nop
ba %icc, .L79
nop
.L62:
or %l3, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l3
ba %icc, .L51
nop
.L79:
or %l3, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 4]
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    concatLists, .-concatLists
	.align 4
	.global add
.type    add, #function
add:
save %sp, -104, %sp
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l1
mov %i0, %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    add, .-add
	.align 4
	.global size
.type    size, #function
size:
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
be %icc, .L144
nop
ba %icc, .L149
nop
.L144:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L154
nop
.L149:
ba %icc, .L154
nop
.L154:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call size
nop
mov %o0, %l1
add %l0, %l1, %l0
or %l0, 0, %i0
ret
restore
	.size    size, .-size
	.align 4
	.global get
.type    get, #function
get:
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
be %icc, .L176
nop
ba %icc, .L183
nop
.L176:
mov %i0, %l0
ldsw [%l0 + 0], %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L188
nop
.L183:
ba %icc, .L188
nop
.L188:
mov %i0, %l0
ldsw [%l0 + 4], %l2
mov %i1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sub %l1, %l0, %l0
mov %l2, %o0
mov %l0, %o1
call get
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    get, .-get
	.align 4
	.global pop
.type    pop, #function
pop:
save %sp, -96, %sp
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %i0
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    pop, .-pop
	.align 4
	.global printList
.type    printList, #function
printList:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L298
nop
ba %icc, .L325
nop
.L298:
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call printList
nop
ba %icc, .L330
nop
.L325:
ba %icc, .L330
nop
.L330:
ret
restore
	.size    printList, .-printList
	.align 4
	.global treeprint
.type    treeprint, #function
treeprint:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L342
nop
ba %icc, .L359
nop
.L342:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call treeprint
nop
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
mov %l0, %o0
call treeprint
nop
ba %icc, .L364
nop
.L359:
ba %icc, .L364
nop
.L364:
ret
restore
	.size    treeprint, .-treeprint
	.align 4
	.global freeList
.type    freeList, #function
freeList:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L376
nop
ba %icc, .L387
nop
.L376:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeList
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L392
nop
.L387:
ba %icc, .L392
nop
.L392:
ret
restore
	.size    freeList, .-freeList
	.align 4
	.global freeTree
.type    freeTree, #function
freeTree:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
xor %l2, 1, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l1, %l0
be %icc, .L405
nop
ba %icc, .L421
nop
.L405:
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call freeTree
nop
mov %i0, %l0
ldsw [%l0 + 8], %l0
mov %l0, %o0
call freeTree
nop
mov %i0, %l0
mov %l0, %o0
call free
nop
ba %icc, .L426
nop
.L421:
ba %icc, .L426
nop
.L426:
ret
restore
	.size    freeTree, .-freeTree
	.align 4
	.global postOrder
.type    postOrder, #function
postOrder:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L438
nop
ba %icc, .L476
nop
.L438:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l2
mov %i0, %l0
ldsw [%l0 + 0], %l0
stw %l0, [%l2 + 0]
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l2 + 4]
mov %i0, %l0
ldsw [%l0 + 4], %l0
mov %l0, %o0
call postOrder
nop
mov %o0, %l0
mov %i0, %l2
ldsw [%l2 + 8], %l2
mov %l2, %o0
call postOrder
nop
mov %o0, %l2
mov %l0, %o0
mov %l2, %o1
call concatLists
nop
mov %o0, %l2
or %l1, 0, %l0
mov %l2, %o0
mov %l0, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L481
nop
.L476:
ba %icc, .L481
nop
.L481:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    postOrder, .-postOrder
	.align 4
	.global treeadd
.type    treeadd, #function
treeadd:
save %sp, -104, %sp
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
be %icc, .L496
nop
ba %icc, .L522
nop
.L496:
or %g0, 1, %o0
or %g0, 12, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l1
mov %i1, %l0
stw %l0, [%l1 + 0]
or %l2, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 4]
or %l2, 0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
stw %l0, [%l1 + 8]
or %l2, 0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L527
nop
.L522:
ba %icc, .L527
nop
.L527:
mov %i1, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L536
nop
ba %icc, .L550
nop
.L536:
mov %i0, %l0
mov %i0, %l1
ldsw [%l1 + 4], %l2
mov %i1, %l1
mov %l2, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l1
stw %l1, [%l0 + 4]
ba %icc, .L567
nop
.L550:
mov %i0, %l0
mov %i0, %l1
ldsw [%l1 + 8], %l2
mov %i1, %l1
mov %l2, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l1
stw %l1, [%l0 + 8]
ba %icc, .L567
nop
.L567:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    treeadd, .-treeadd
	.align 4
	.global quickSort
.type    quickSort, #function
quickSort:
save %sp, -96, %sp
sethi %hi(0), %l4
or %l4, %lo(0), %l4
sethi %hi(0), %l5
or %l5, %lo(0), %l5
mov %i0, %l0
mov %l0, %o0
call size
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movle %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L607
nop
ba %icc, .L613
nop
.L607:
mov %i0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L618
nop
.L613:
ba %icc, .L618
nop
.L618:
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l1, %o0
mov %l0, %o1
call get
nop
mov %o0, %l1
mov %i0, %l0
mov %i0, %l2
mov %l2, %o0
call size
nop
mov %o0, %l3
sethi %hi(1), %l2
or %l2, %lo(1), %l2
sub %l3, %l2, %l2
mov %l0, %o0
mov %l2, %o1
call get
nop
mov %o0, %l0
add %l1, %l0, %l0
sra %l0, 1, %l0
or %l0, 0, %l3
mov %i0, %l0
or %l0, 0, %l1
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L692:
or %l1, 0, %l6
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l0
movne %icc, 1, %l7
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l7, %l0
be %icc, .L701
nop
ba %icc, .L824
nop
.L701:
mov %i0, %l6
or %l2, 0, %l0
mov %l6, %o0
mov %l0, %o1
call get
nop
mov %o0, %l6
or %l3, 0, %l0
sethi %hi(0), %l7
or %l7, %lo(0), %l7
cmp %l6, %l0
movg %icc, 1, %l7
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l7, %l0
be %icc, .L728
nop
ba %icc, .L761
nop
.L728:
or %l5, 0, %l0
mov %i0, %l6
or %l2, 0, %l5
mov %l6, %o0
mov %l5, %o1
call get
nop
mov %o0, %l5
mov %l0, %o0
mov %l5, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l5
ba %icc, .L799
nop
.L761:
or %l4, 0, %l0
mov %i0, %l6
or %l2, 0, %l4
mov %l6, %o0
mov %l4, %o1
call get
nop
mov %o0, %l4
mov %l0, %o0
mov %l4, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l4
ba %icc, .L799
nop
.L799:
or %l1, 0, %l0
ldsw [%l0 + 4], %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L692
nop
.L824:
mov %i0, %l0
mov %l0, %o0
call freeList
nop
or %l4, 0, %l0
mov %l0, %o0
call quickSort
nop
mov %o0, %l0
or %l5, 0, %l1
mov %l1, %o0
call quickSort
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    quickSort, .-quickSort
	.align 4
	.global quickSortMain
.type    quickSortMain, #function
quickSortMain:
save %sp, -96, %sp
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
mov %l0, %o0
call printList
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l0
or %l0, 0, %i0
ret
restore
	.size    quickSortMain, .-quickSortMain
	.align 4
	.global treesearch
.type    treesearch, #function
treesearch:
save %sp, -104, %sp
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L891
nop
ba %icc, .L958
nop
.L891:
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L901
nop
ba %icc, .L906
nop
.L901:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L911
nop
.L906:
ba %icc, .L911
nop
.L911:
mov %i0, %l0
ldsw [%l0 + 4], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L923
nop
ba %icc, .L928
nop
.L923:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L933
nop
.L928:
ba %icc, .L933
nop
.L933:
mov %i0, %l0
ldsw [%l0 + 8], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l1
sethi %hi(1), %l0
or %l0, %lo(1), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L945
nop
ba %icc, .L950
nop
.L945:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L960
nop
.L950:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L960
nop
.L960:
ba %icc, .L963
nop
.L958:
ba %icc, .L963
nop
.L963:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    treesearch, .-treesearch
	.align 4
	.global inOrder
.type    inOrder, #function
inOrder:
save %sp, -96, %sp
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L978
nop
ba %icc, .L1017
nop
.L978:
or %g0, 1, %o0
or %g0, 8, %o1
call calloc
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %i0, %l1
ldsw [%l1 + 0], %l1
stw %l1, [%l2 + 0]
or %l0, 0, %l2
sethi %hi(0), %l1
or %l1, %lo(0), %l1
stw %l1, [%l2 + 4]
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call inOrder
nop
mov %o0, %l1
or %l0, 0, %l0
mov %i0, %l2
ldsw [%l2 + 8], %l2
mov %l2, %o0
call inOrder
nop
mov %o0, %l2
mov %l0, %o0
mov %l2, %o1
call concatLists
nop
mov %o0, %l0
mov %l1, %o0
mov %l0, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1025
nop
.L1017:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1025
nop
.L1025:
	.size    inOrder, .-inOrder
	.align 4
	.global bintreesearch
.type    bintreesearch, #function
bintreesearch:
save %sp, -104, %sp
sethi %hi(-1), %l0
or %l0, %lo(-1), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
mov %i0, %l1
sethi %hi(0), %l0
or %l0, %lo(0), %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movne %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L1041
nop
ba %icc, .L1096
nop
.L1041:
mov %i0, %l0
ldsw [%l0 + 0], %l1
mov %i1, %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
move %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L1051
nop
ba %icc, .L1056
nop
.L1051:
sethi %hi(1), %l0
or %l0, %lo(1), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1061
nop
.L1056:
ba %icc, .L1061
nop
.L1061:
mov %i1, %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
sethi %hi(0), %l2
or %l2, %lo(0), %l2
cmp %l1, %l0
movl %icc, 1, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l2, %l0
be %icc, .L1069
nop
ba %icc, .L1081
nop
.L1069:
mov %i0, %l0
ldsw [%l0 + 4], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1098
nop
.L1081:
mov %i0, %l0
ldsw [%l0 + 8], %l1
mov %i1, %l0
mov %l1, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1098
nop
.L1098:
ba %icc, .L1101
nop
.L1096:
ba %icc, .L1101
nop
.L1101:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    bintreesearch, .-bintreesearch
	.align 4
	.global buildTree
.type    buildTree, #function
buildTree:
save %sp, -96, %sp
sethi %hi(0), %l1
or %l1, %lo(0), %l1
sethi %hi(0), %l2
or %l2, %lo(0), %l2
.L1118:
or %l2, 0, %l0
mov %i0, %l3
mov %l3, %o0
call size
nop
mov %o0, %l3
sethi %hi(0), %l4
or %l4, %lo(0), %l4
cmp %l0, %l3
movl %icc, 1, %l4
sethi %hi(1), %l0
or %l0, %lo(1), %l0
cmp %l4, %l0
be %icc, .L1127
nop
ba %icc, .L1163
nop
.L1127:
or %l1, 0, %l0
mov %i0, %l3
or %l2, 0, %l1
mov %l3, %o0
mov %l1, %o1
call get
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call treeadd
nop
mov %o0, %l0
or %l0, 0, %l1
or %l2, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
add %l2, %l0, %l0
or %l0, 0, %l2
ba %icc, .L1118
nop
.L1163:
or %l1, 0, %l0
or %l0, 0, %i0
ret
restore
	.size    buildTree, .-buildTree
	.align 4
	.global treeMain
.type    treeMain, #function
treeMain:
save %sp, -96, %sp
mov %i0, %l0
mov %l0, %o0
call buildTree
nop
mov %o0, %l0
or %l0, 0, %l1
or %l1, 0, %l0
mov %l0, %o0
call treeprint
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
mov %l0, %o0
call inOrder
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %l2, %o0
call printList
nop
sethi %hi(-999), %l2
or %l2, %lo(-999), %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
or %l1, 0, %l0
mov %l0, %o0
call postOrder
nop
mov %o0, %l0
or %l0, 0, %l0
or %l0, 0, %l2
mov %l2, %o0
call printList
nop
sethi %hi(-999), %l2
or %l2, %lo(-999), %l2
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l2, %o1
call printf
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(-2), %l0
or %l0, %lo(-2), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l2, %o0
mov %l0, %o1
call treesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(0), %l0
or %l0, %lo(0), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(10), %l0
or %l0, %lo(10), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(-2), %l0
or %l0, %lo(-2), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(2), %l0
or %l0, %lo(2), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(3), %l0
or %l0, %lo(3), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(9), %l0
or %l0, %lo(9), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l2
sethi %hi(1), %l0
or %l0, %lo(1), %l0
mov %l2, %o0
mov %l0, %o1
call bintreesearch
nop
mov %o0, %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
sethi %hi(-999), %l0
or %l0, %lo(-999), %l0
sethi %hi(.ConstantString1), %o0
or %o0, %lo(.ConstantString1), %o0
mov %l0, %o1
call printf
nop
or %l1, 0, %l0
mov %l0, %o0
call freeTree
nop
ret
restore
	.size    treeMain, .-treeMain
	.align 4
	.global myCopy
.type    myCopy, #function
myCopy:
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
be %icc, .L1412
nop
ba %icc, .L1417
nop
.L1412:
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
ba %icc, .L1422
nop
.L1417:
ba %icc, .L1422
nop
.L1422:
sethi %hi(0), %l1
or %l1, %lo(0), %l1
mov %i0, %l0
ldsw [%l0 + 0], %l0
mov %l1, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
mov %i0, %l1
ldsw [%l1 + 4], %l1
mov %l1, %o0
call myCopy
nop
mov %o0, %l1
mov %l0, %o0
mov %l1, %o1
call concatLists
nop
mov %o0, %l0
or %l0, 0, %i0
ret
restore
	.size    myCopy, .-myCopy
	.align 4
	.global main
.type    main, #function
main:
save %sp, -96, %sp
sethi %hi(0), %l2
or %l2, %lo(0), %l2
sethi %hi(0), %l3
or %l3, %lo(0), %l3
.L1453:
or %l3, 0, %l5
sethi %hi(10), %l4
or %l4, %lo(10), %l4
sethi %hi(0), %l6
or %l6, %lo(0), %l6
cmp %l5, %l4
movl %icc, 1, %l6
sethi %hi(1), %l4
or %l4, %lo(1), %l4
cmp %l6, %l4
be %icc, .L1459
nop
ba %icc, .L1518
nop
.L1459:
sethi %hi(.ConstantString2), %o0
or %o0, %lo(.ConstantString2), %o0
add %sp, 92, %o1
call scanf
nop
ldsw [%sp + 92], %l0
or %l0, 0, %l0
or %l2, 0, %l1
or %l0, 0, %l0
mov %l1, %o0
mov %l0, %o1
call add
nop
mov %o0, %l0
or %l0, 0, %l2
or %l2, 0, %l0
mov %l0, %o0
call myCopy
nop
mov %o0, %l0
or %l0, 0, %l1
or %l2, 0, %l0
mov %l0, %o0
call myCopy
nop
mov %o0, %l0
or %l0, 0, %l0
or %l1, 0, %l4
mov %l4, %o0
call quickSortMain
nop
mov %o0, %l4
or %l4, 0, %l4
or %l4, 0, %l4
mov %l4, %o0
call freeList
nop
or %l0, 0, %l4
mov %l4, %o0
call treeMain
nop
or %l3, 0, %l4
sethi %hi(1), %l3
or %l3, %lo(1), %l3
add %l4, %l3, %l3
or %l3, 0, %l3
ba %icc, .L1453
nop
.L1518:
or %l2, 0, %l2
mov %l2, %o0
call freeList
nop
or %l1, 0, %l1
mov %l1, %o0
call freeList
nop
or %l0, 0, %l0
mov %l0, %o0
call freeList
nop
sethi %hi(0), %l0
or %l0, %lo(0), %l0
or %l0, 0, %i0
ret
restore
	.size    main, .-main
	.common a,4,4
	.common b,4,4
	.common i,4,4
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

