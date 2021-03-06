using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A006329
{
public static readonly BigInteger[] Value={ 1L,10L,79L,602L,4682L,38072L,326570L,2964992L,28506383L,289973248L,3116028865L,35308153600L,421048783264L,5273818620928L,69250997724484L,951571372015616L,13658940616055885L,204474999700324352L,3187421031909630947L,BigInteger.Parse("51663403849575956480") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006329Inst Instance=new A006329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006330
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,21L,38L,63L,106L,170L,272L,422L,653L,986L,1482L,2191L,3218L,4666L,6726L,9592L,13602L,19122L,26733L,37102L,51232L,70292L,95989L,130356L,176246L,237120L,317724L,423840L,563266L,745562L,983384L,1292333L,1692790L,2209886L,2876132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006330Inst : IEnumerable<long>
{
public static readonly long[] Value=A006330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006330.Bytes);
public long this[int i]=>Value[i];

public static A006330Inst Instance=new A006330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006331
{
public static readonly long[] Value={ 0L,2L,10L,28L,60L,110L,182L,280L,408L,570L,770L,1012L,1300L,1638L,2030L,2480L,2992L,3570L,4218L,4940L,5740L,6622L,7590L,8648L,9800L,11050L,12402L,13860L,15428L,17110L,18910L,20832L,22880L,25058L,27370L,29820L,32412L,35150L,38038L,41080L,44280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006331Inst : IEnumerable<long>
{
public static readonly long[] Value=A006331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006331.Bytes);
public long this[int i]=>Value[i];

public static A006331Inst Instance=new A006331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006332
{
public static readonly long[] Value={ 0L,2L,28L,168L,660L,2002L,5096L,11424L,23256L,43890L,77924L,131560L,212940L,332514L,503440L,742016L,1068144L,1505826L,2083692L,2835560L,3801028L,5026098L,6563832L,8475040L,10829000L,13704210L,17189172L,21383208L,26397308L,32355010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006332Inst : IEnumerable<long>
{
public static readonly long[] Value=A006332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006332.Bytes);
public long this[int i]=>Value[i];

public static A006332Inst Instance=new A006332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006333
{
public static readonly long[] Value={ 0L,2L,60L,660L,4290L,20020L,74256L,232560L,639540L,1586310L,3617900L,7696260L,15438150L,29451240L,53796160L,94607040L,160908264L,265670730L,427156860L,670609940L,1030350090L,1552346268L,2297341200L,3344614000L,4796473500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006333Inst : IEnumerable<long>
{
public static readonly long[] Value=A006333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006333.Bytes);
public long this[int i]=>Value[i];

public static A006333Inst Instance=new A006333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006366
{
public static readonly BigInteger[] Value={ 1L,2L,5L,20L,132L,1452L,26741L,826540L,42939620L,3752922788L,552176360205L,136830327773400L,57125602787130000L,BigInteger.Parse("40191587143536420000"),BigInteger.Parse("47663133295107416936400"),BigInteger.Parse("95288872904963020131203520"),BigInteger.Parse("321195665986577042490185260608") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006366Inst Instance=new A006366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006367
{
public static readonly long[] Value={ 1L,0L,2L,2L,5L,8L,15L,26L,46L,80L,139L,240L,413L,708L,1210L,2062L,3505L,5944L,10059L,16990L,28646L,48220L,81047L,136032L,228025L,381768L,638450L,1066586L,1780061L,2968040L,4944519L,8230370L,13689118L,22751528L,37786915L,62716752L,104028245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006367Inst : IEnumerable<long>
{
public static readonly long[] Value=A006367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006367.Bytes);
public long this[int i]=>Value[i];

public static A006367Inst Instance=new A006367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006368
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,9L,5L,12L,7L,15L,8L,18L,10L,21L,11L,24L,13L,27L,14L,30L,16L,33L,17L,36L,19L,39L,20L,42L,22L,45L,23L,48L,25L,51L,26L,54L,28L,57L,29L,60L,31L,63L,32L,66L,34L,69L,35L,72L,37L,75L,38L,78L,40L,81L,41L,84L,43L,87L,44L,90L,46L,93L,47L,96L,49L,99L,50L,102L,52L,105L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006368Inst : IEnumerable<long>
{
public static readonly long[] Value=A006368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006368.Bytes);
public long this[int i]=>Value[i];

public static A006368Inst Instance=new A006368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006369
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,7L,4L,9L,11L,6L,13L,15L,8L,17L,19L,10L,21L,23L,12L,25L,27L,14L,29L,31L,16L,33L,35L,18L,37L,39L,20L,41L,43L,22L,45L,47L,24L,49L,51L,26L,53L,55L,28L,57L,59L,30L,61L,63L,32L,65L,67L,34L,69L,71L,36L,73L,75L,38L,77L,79L,40L,81L,83L,42L,85L,87L,44L,89L,91L,46L,93L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006369Inst : IEnumerable<long>
{
public static readonly long[] Value=A006369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006369.Bytes);
public long this[int i]=>Value[i];

public static A006369Inst Instance=new A006369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006370
{
public static readonly long[] Value={ 4L,1L,10L,2L,16L,3L,22L,4L,28L,5L,34L,6L,40L,7L,46L,8L,52L,9L,58L,10L,64L,11L,70L,12L,76L,13L,82L,14L,88L,15L,94L,16L,100L,17L,106L,18L,112L,19L,118L,20L,124L,21L,130L,22L,136L,23L,142L,24L,148L,25L,154L,26L,160L,27L,166L,28L,172L,29L,178L,30L,184L,31L,190L,32L,196L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006370Inst : IEnumerable<long>
{
public static readonly long[] Value=A006370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006370.Bytes);
public long this[int i]=>Value[i];

public static A006370Inst Instance=new A006370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006371
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,3L,2L,2L,2L,3L,3L,2L,3L,4L,2L,1L,4L,5L,4L,2L,2L,4L,4L,3L,4L,5L,4L,1L,4L,7L,3L,3L,4L,5L,6L,3L,4L,6L,2L,2L,6L,8L,6L,3L,3L,5L,6L,3L,6L,8L,4L,2L,6L,10L,4L,2L,6L,5L,7L,5L,4L,8L,4L,3L,8L,10L,8L,3L,2L,7L,6L,4L,8L,10L,6L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006371Inst : IEnumerable<long>
{
public static readonly long[] Value=A006371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006371.Bytes);
public long this[int i]=>Value[i];

public static A006371Inst Instance=new A006371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006372
{
public static readonly long[] Value={ 1L,1L,3L,8L,25L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006372Inst : IEnumerable<long>
{
public static readonly long[] Value=A006372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006372.Bytes);
public long this[int i]=>Value[i];

public static A006372Inst Instance=new A006372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006373
{
public static readonly long[] Value={ 1L,2L,7L,26L,115L,596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006373Inst : IEnumerable<long>
{
public static readonly long[] Value=A006373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006373.Bytes);
public long this[int i]=>Value[i];

public static A006373Inst Instance=new A006373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006374
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,3L,3L,2L,4L,4L,2L,4L,4L,4L,4L,3L,4L,6L,4L,2L,6L,6L,3L,6L,6L,4L,6L,4L,6L,7L,4L,4L,8L,8L,2L,6L,8L,6L,8L,4L,4L,10L,6L,4L,10L,8L,5L,7L,8L,6L,6L,8L,8L,12L,4L,2L,12L,8L,6L,8L,10L,8L,8L,8L,4L,12L,8L,4L,14L,9L,4L,10L,10L,10L,8L,4L,10L,14L,9L,4L,12L,12L,4L,10L,12L,6L,12L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006374Inst : IEnumerable<long>
{
public static readonly long[] Value=A006374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006374.Bytes);
public long this[int i]=>Value[i];

public static A006374Inst Instance=new A006374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006375
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,1L,1L,2L,4L,2L,1L,2L,2L,1L,2L,5L,2L,2L,1L,3L,2L,1L,1L,3L,6L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,7L,3L,1L,2L,4L,2L,2L,1L,2L,4L,1L,1L,4L,6L,3L,2L,3L,2L,2L,2L,3L,2L,2L,1L,4L,2L,1L,3L,8L,2L,2L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006375Inst : IEnumerable<long>
{
public static readonly long[] Value=A006375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006375.Bytes);
public long this[int i]=>Value[i];

public static A006375Inst Instance=new A006375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006376
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,2L,3L,1L,2L,1L,3L,2L,1L,2L,5L,1L,1L,3L,5L,2L,3L,1L,5L,5L,2L,2L,6L,2L,2L,5L,6L,3L,3L,3L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006376Inst : IEnumerable<long>
{
public static readonly long[] Value=A006376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006376.Bytes);
public long this[int i]=>Value[i];

public static A006376Inst Instance=new A006376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006377
{
public static readonly long[] Value={ 8L,28L,32L,56L,64L,68L,72L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006377Inst : IEnumerable<long>
{
public static readonly long[] Value=A006377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006377.Bytes);
public long this[int i]=>Value[i];

public static A006377Inst Instance=new A006377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006378
{
public static readonly long[] Value={ 3L,5L,7L,31L,53L,97L,211L,233L,277L,367L,389L,457L,479L,547L,569L,613L,659L,727L,839L,883L,929L,1021L,1087L,1109L,1223L,1289L,1447L,1559L,1627L,1693L,1783L,1873L,2099L,2213L,2347L,2437L,2459L,2503L,2549L,2593L,2617L,2683L,2729L,2819L,2953L,3023L,3067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006378Inst : IEnumerable<long>
{
public static readonly long[] Value=A006378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006378.Bytes);
public long this[int i]=>Value[i];

public static A006378Inst Instance=new A006378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006379
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,3L,2L,2L,3L,0L,4L,3L,1L,2L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006379Inst : IEnumerable<long>
{
public static readonly long[] Value=A006379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006379.Bytes);
public long this[int i]=>Value[i];

public static A006379Inst Instance=new A006379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006380
{
public static readonly long[] Value={ 1L,3L,8L,19L,41L,81L,153L,273L,468L,774L,1240L,1930L,2933L,4356L,6341L,9064L,12743L,17643L,24093L,32479L,43270L,57019L,74377L,96103L,123089L,156354L,197081L,246622L,306519L,378520L,464614L,567028L,688276L,831169L,998845L,1194793L,1422899L,1687447L,1993182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006380Inst : IEnumerable<long>
{
public static readonly long[] Value=A006380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006380.Bytes);
public long this[int i]=>Value[i];

public static A006380Inst Instance=new A006380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006381
{
public static readonly long[] Value={ 1L,1L,4L,7L,19L,32L,68L,114L,210L,336L,562L,862L,1349L,1987L,2950L,4201L,5991L,8278L,11422L,15386L,20660L,27218L,35718L,46158L,59401L,75475L,95494L,119545L,149035L,184118L,226562L,276620L,336470L,406490L,489344L,585572L,698397L,828549L,979896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006381Inst : IEnumerable<long>
{
public static readonly long[] Value=A006381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006381.Bytes);
public long this[int i]=>Value[i];

public static A006381Inst Instance=new A006381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006398
{
public static readonly long[] Value={ 1L,2L,4L,8L,29L,92L,403L,1846L,9239L,48028L,259567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006398Inst : IEnumerable<long>
{
public static readonly long[] Value=A006398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006398.Bytes);
public long this[int i]=>Value[i];

public static A006398Inst Instance=new A006398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006399
{
public static readonly long[] Value={ 1L,2L,4L,8L,27L,76L,295L,1188L,5462L,26580L,138110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006399Inst : IEnumerable<long>
{
public static readonly long[] Value=A006399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006399.Bytes);
public long this[int i]=>Value[i];

public static A006399Inst Instance=new A006399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006400
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,33L,117L,431L,1755L,7485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006400Inst : IEnumerable<long>
{
public static readonly long[] Value=A006400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006400.Bytes);
public long this[int i]=>Value[i];

public static A006400Inst Instance=new A006400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006401
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,28L,86L,285L,1055L,4211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006401Inst : IEnumerable<long>
{
public static readonly long[] Value=A006401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006401.Bytes);
public long this[int i]=>Value[i];

public static A006401Inst Instance=new A006401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006402
{
public static readonly long[] Value={ 1L,2L,3L,6L,16L,42L,151L,596L,2605L,12098L,59166L,297684L,1538590L,8109078L,43476751L,236474942L,1302680941L,7256842362L,40832979283L,231838418310L,1327095781740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006402Inst : IEnumerable<long>
{
public static readonly long[] Value=A006402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006402.Bytes);
public long this[int i]=>Value[i];

public static A006402Inst Instance=new A006402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006403
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,15L,36L,114L,396L,1565L,6756L,31563L,154370L,785113L,4099948L,21870704L,118624544L,652485364L,3631820462L,20426666644L,115949791342L,663640383400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006403Inst : IEnumerable<long>
{
public static readonly long[] Value=A006403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006403.Bytes);
public long this[int i]=>Value[i];

public static A006403Inst Instance=new A006403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006404
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,29L,96L,339L,1320L,5473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006404Inst : IEnumerable<long>
{
public static readonly long[] Value=A006404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006404.Bytes);
public long this[int i]=>Value[i];

public static A006404Inst Instance=new A006404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006405
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,24L,70L,222L,785L,3055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006405Inst : IEnumerable<long>
{
public static readonly long[] Value=A006405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006405.Bytes);
public long this[int i]=>Value[i];

public static A006405Inst Instance=new A006405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006406
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,81L,274L,1071L,4357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006406Inst : IEnumerable<long>
{
public static readonly long[] Value=A006406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006406.Bytes);
public long this[int i]=>Value[i];

public static A006406Inst Instance=new A006406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006407
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,20L,58L,177L,630L,2410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006407Inst : IEnumerable<long>
{
public static readonly long[] Value=A006407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006407.Bytes);
public long this[int i]=>Value[i];

public static A006407Inst Instance=new A006407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006408
{
public static readonly long[] Value={ 4L,39L,190L,651L,1792L,4242L,8988L,17490L,31812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006408Inst : IEnumerable<long>
{
public static readonly long[] Value=A006408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006408.Bytes);
public long this[int i]=>Value[i];

public static A006408Inst Instance=new A006408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006409
{
public static readonly long[] Value={ 10L,190L,1568L,8344L,33580L,111100L,317680L,811096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006409Inst : IEnumerable<long>
{
public static readonly long[] Value=A006409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006409.Bytes);
public long this[int i]=>Value[i];

public static A006409Inst Instance=new A006409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006410
{
public static readonly long[] Value={ 20L,651L,8344L,64667L,361884L,1607125L,5997992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006410Inst : IEnumerable<long>
{
public static readonly long[] Value=A006410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006410.Bytes);
public long this[int i]=>Value[i];

public static A006410Inst Instance=new A006410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006411
{
public static readonly long[] Value={ 3L,20L,75L,210L,490L,1008L,1890L,3300L,5445L,8580L,13013L,19110L,27300L,38080L,52020L,69768L,92055L,119700L,153615L,194810L,244398L,303600L,373750L,456300L,552825L,665028L,794745L,943950L,1114760L,1309440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006411Inst : IEnumerable<long>
{
public static readonly long[] Value=A006411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006411.Bytes);
public long this[int i]=>Value[i];

public static A006411Inst Instance=new A006411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006412
{
public static readonly long[] Value={ 4L,75L,604L,3150L,12480L,40788L,115500L,292578L,677820L,1459315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006412Inst : IEnumerable<long>
{
public static readonly long[] Value=A006412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006412.Bytes);
public long this[int i]=>Value[i];

public static A006412Inst Instance=new A006412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006413
{
public static readonly long[] Value={ 5L,210L,3150L,27556L,170793L,829920L,3359356L,11786190L,36845718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006413Inst : IEnumerable<long>
{
public static readonly long[] Value=A006413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006413.Bytes);
public long this[int i]=>Value[i];

public static A006413Inst Instance=new A006413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006430
{
public static readonly long[] Value={ 0L,5L,360L,7350L,73700L,474588L,2292790L,9046807L,30676440L,92393015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006430Inst : IEnumerable<long>
{
public static readonly long[] Value=A006430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006430.Bytes);
public long this[int i]=>Value[i];

public static A006430Inst Instance=new A006430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006431
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,11L,14L,15L,23L,24L,32L,56L,96L,128L,224L,384L,512L,896L,1536L,2048L,3584L,6144L,8192L,14336L,24576L,32768L,57344L,98304L,131072L,229376L,393216L,524288L,917504L,1572864L,2097152L,3670016L,6291456L,8388608L,14680064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006431Inst : IEnumerable<long>
{
public static readonly long[] Value=A006431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006431.Bytes);
public long this[int i]=>Value[i];

public static A006431Inst Instance=new A006431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006432
{
public static readonly long[] Value={ 0L,3L,60L,650L,5352L,37681L,239752L,1421226L,7996160L,43219990L,226309800L,1154900708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006432Inst : IEnumerable<long>
{
public static readonly long[] Value=A006432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006432.Bytes);
public long this[int i]=>Value[i];

public static A006432Inst Instance=new A006432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006433
{
public static readonly long[] Value={ 0L,4L,175L,3324L,42469L,429120L,3711027L,28723640L,204598130L,1366223880L,8664086470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006433Inst : IEnumerable<long>
{
public static readonly long[] Value=A006433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006433.Bytes);
public long this[int i]=>Value[i];

public static A006433Inst Instance=new A006433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006434
{
public static readonly long[] Value={ 4L,120L,1230L,7424L,32424L,113584L,338742L,893220L,2136618L,4721728L,9770904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006434Inst : IEnumerable<long>
{
public static readonly long[] Value=A006434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006434.Bytes);
public long this[int i]=>Value[i];

public static A006434Inst Instance=new A006434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006435
{
public static readonly long[] Value={ 10L,705L,14478L,154420L,1092640L,5826492L,25240410L,93203561L,303143970L,889015725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006435Inst : IEnumerable<long>
{
public static readonly long[] Value=A006435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006435.Bytes);
public long this[int i]=>Value[i];

public static A006435Inst Instance=new A006435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006436
{
public static readonly long[] Value={ 10L,192L,1630L,8924L,36834L,124560L,362934L,941820L,2227368L,4881448L,889015725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006436Inst : IEnumerable<long>
{
public static readonly long[] Value=A006436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006436.Bytes);
public long this[int i]=>Value[i];

public static A006436Inst Instance=new A006436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006437
{
public static readonly long[] Value={ 70L,2330L,32130L,271285L,1655800L,7997850L,32332170L,113568455L,355905030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006437Inst : IEnumerable<long>
{
public static readonly long[] Value=A006437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006437.Bytes);
public long this[int i]=>Value[i];

public static A006437Inst Instance=new A006437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006438
{
public static readonly BigInteger[] Value={ 1L,4L,47L,924L,25449L,901380L,39024495L,1996824060L,117897243345L,7889215807620L,590030724668175L,48773659291364700L,4415782937120703225L,BigInteger.Parse("434554886774113805700"),BigInteger.Parse("46185660455230892170575"),BigInteger.Parse("5272363854999057185869500"),BigInteger.Parse("643381344417456140309438625") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006438Inst Instance=new A006438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006439
{
public static readonly long[] Value={ 4L,152L,2630L,31500L,303534L,2530976L,19030428L,132386340L,866782510L,5405853200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006439Inst : IEnumerable<long>
{
public static readonly long[] Value=A006439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006439.Bytes);
public long this[int i]=>Value[i];

public static A006439Inst Instance=new A006439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006440
{
public static readonly long[] Value={ 10L,805L,23730L,431319L,5862920L,65548890L,636520890L,5555779185L,44603489700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006440Inst : IEnumerable<long>
{
public static readonly long[] Value=A006440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006440.Bytes);
public long this[int i]=>Value[i];

public static A006440Inst Instance=new A006440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006441
{
public static readonly long[] Value={ 10L,595L,11010L,111650L,773640L,4104225L,17838730L,66390610L,218140650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006441Inst : IEnumerable<long>
{
public static readonly long[] Value=A006441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006441.Bytes);
public long this[int i]=>Value[i];

public static A006441Inst Instance=new A006441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006442
{
public static readonly long[] Value={ 1L,5L,37L,305L,2641L,23525L,213445L,1961825L,18205345L,170195525L,1600472677L,15122515985L,143457011569L,1365435096485L,13033485491077L,124715953657025L,1195966908404545L,11490534389896325L,110584004488276645L,1065853221648055025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006442Inst : IEnumerable<long>
{
public static readonly long[] Value=A006442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006442.Bytes);
public long this[int i]=>Value[i];

public static A006442Inst Instance=new A006442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006443
{
public static readonly long[] Value={ 2L,4L,14L,47L,184L,761L,3314L,14997L,69886L,333884L,1626998L,8067786L,40580084L,206734083L,1064666724L,5536480877L,29036188788L,153450351924L,816503772830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006443Inst : IEnumerable<long>
{
public static readonly long[] Value=A006443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006443.Bytes);
public long this[int i]=>Value[i];

public static A006443Inst Instance=new A006443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006444
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,14L,30L,77L,196L,525L,1414L,3960L,11056L,31636L,90818L,264657L,774146L,2289787L,6798562L,20354005L,61164374L,184985060L,561433922L,1712696708L,5241637812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006444Inst : IEnumerable<long>
{
public static readonly long[] Value=A006444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006444.Bytes);
public long this[int i]=>Value[i];

public static A006444Inst Instance=new A006444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006445
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,2L,1L,4L,9L,12L,27L,50L,99L,188L,386L,740L,1528L,3012L,6192L,12376L,25594L,51628L,107135L,218100L,453895L,930812L,1943281L,4009512L,8394915L,17414512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006445Inst : IEnumerable<long>
{
public static readonly long[] Value=A006445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006445.Bytes);
public long this[int i]=>Value[i];

public static A006445Inst Instance=new A006445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006462
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,-2L,0L,2L,4L,3L,0L,-1L,6L,28L,72L,139L,242L,407L,722L,1215L,2348L,3753L,7186L,9558L,21800L,16576L,61234L,-7978L,226136L,-446034L,1118180L,-3180033L,6428640L,-24607343L,56904504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006462Inst : IEnumerable<long>
{
public static readonly long[] Value=A006462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006462.Bytes);
public long this[int i]=>Value[i];

public static A006462Inst Instance=new A006462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006463
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,8L,11L,14L,17L,20L,24L,28L,32L,36L,40L,45L,50L,55L,60L,65L,70L,76L,82L,88L,94L,100L,106L,112L,119L,126L,133L,140L,147L,154L,161L,168L,176L,184L,192L,200L,208L,216L,224L,232L,240L,249L,258L,267L,276L,285L,294L,303L,312L,321L,330L,340L,350L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006463Inst : IEnumerable<long>
{
public static readonly long[] Value=A006463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006463.Bytes);
public long this[int i]=>Value[i];

public static A006463Inst Instance=new A006463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006464
{
public static readonly long[] Value={ 0L,3L,6L,4L,4L,2L,4L,6L,4L,2L,6L,4L,2L,4L,4L,6L,4L,2L,6L,4L,4L,2L,4L,6L,2L,4L,6L,4L,2L,4L,4L,6L,4L,2L,6L,4L,4L,2L,4L,6L,4L,2L,6L,4L,2L,4L,4L,6L,2L,4L,6L,4L,4L,2L,4L,6L,2L,4L,6L,4L,2L,4L,4L,6L,4L,2L,6L,4L,4L,2L,4L,6L,4L,2L,6L,4L,2L,4L,4L,6L,4L,2L,6L,4L,4L,2L,4L,6L,2L,4L,6L,4L,2L,4L,4L,6L,2L,4L,6L,4L,4L,2L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006464Inst : IEnumerable<long>
{
public static readonly long[] Value=A006464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006464.Bytes);
public long this[int i]=>Value[i];

public static A006464Inst Instance=new A006464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006465
{
public static readonly long[] Value={ 324L,63L,1L,1023L,64L,1023L,1L,63L,1023L,1L,63L,1023L,1L,62L,1L,1023L,63L,1L,1023L,64L,1023L,1L,63L,1023L,1L,62L,1L,1023L,64L,1023L,1L,63L,1023L,1L,62L,1L,1023L,63L,1L,1023L,63L,1L,1023L,64L,1023L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006465Inst : IEnumerable<long>
{
public static readonly long[] Value=A006465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006465.Bytes);
public long this[int i]=>Value[i];

public static A006465Inst Instance=new A006465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006466
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006466Inst : IEnumerable<long>
{
public static readonly long[] Value=A006466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006466.Bytes);
public long this[int i]=>Value[i];

public static A006466Inst Instance=new A006466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006467
{
public static readonly long[] Value={ 0L,4L,3L,1L,3L,5L,1L,3L,5L,3L,3L,1L,5L,3L,1L,3L,3L,5L,3L,1L,3L,5L,1L,3L,3L,5L,3L,1L,5L,3L,1L,3L,5L,3L,3L,1L,3L,5L,1L,3L,5L,3L,3L,1L,5L,3L,1L,3L,5L,3L,3L,1L,3L,5L,1L,3L,3L,5L,3L,1L,5L,3L,1L,3L,3L,5L,3L,1L,3L,5L,1L,3L,5L,3L,3L,1L,5L,3L,1L,3L,3L,5L,3L,1L,3L,5L,1L,3L,3L,5L,3L,1L,5L,3L,1L,3L,3L,5L,3L,1L,3L,5L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006467Inst : IEnumerable<long>
{
public static readonly long[] Value=A006467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006467.Bytes);
public long this[int i]=>Value[i];

public static A006467Inst Instance=new A006467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006468
{
public static readonly long[] Value={ 5L,37L,150L,449L,1113L,2422L,4788L,8790L,15213L,25091L,39754L,60879L,90545L,131292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006468Inst : IEnumerable<long>
{
public static readonly long[] Value=A006468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006468.Bytes);
public long this[int i]=>Value[i];

public static A006468Inst Instance=new A006468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006469
{
public static readonly long[] Value={ 10L,79L,340L,1071L,2772L,6258L,12768L,24090L,42702L,71929L,116116L,180817L,273000L,401268L,576096L,810084L,1118226L,1518195L,2030644L,2679523L,3492412L,4500870L,5740800L,7252830L,9082710L,11281725L,13907124L,17022565L,20698576L,25013032L,30051648L,35908488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006469Inst : IEnumerable<long>
{
public static readonly long[] Value=A006469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006469.Bytes);
public long this[int i]=>Value[i];

public static A006469Inst Instance=new A006469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006470
{
public static readonly long[] Value={ 2L,15L,60L,175L,420L,882L,1680L,2970L,4950L,7865L,12012L,17745L,25480L,35700L,48960L,65892L,87210L,113715L,146300L,185955L,233772L,290950L,358800L,438750L,532350L,641277L,767340L,912485L,1078800L,1268520L,1484032L,1727880L,2002770L,2311575L,2657340L,3043287L,3472820L,3949530L,4477200L,5059810L,5701542L,6406785L,7180140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006470Inst : IEnumerable<long>
{
public static readonly long[] Value=A006470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006470.Bytes);
public long this[int i]=>Value[i];

public static A006470Inst Instance=new A006470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006471
{
public static readonly long[] Value={ 5L,84L,650L,3324L,13020L,42240L,118998L,300300L,693693L,1490060L,3011580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006471Inst : IEnumerable<long>
{
public static readonly long[] Value=A006471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006471.Bytes);
public long this[int i]=>Value[i];

public static A006471Inst Instance=new A006471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006472
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,180L,2700L,56700L,1587600L,57153600L,2571912000L,141455160000L,9336040560000L,728211163680000L,66267215894880000L,6958057668962400000L,BigInteger.Parse("834966920275488000000"),BigInteger.Parse("113555501157466368000000"),BigInteger.Parse("17373991677092354304000000"),BigInteger.Parse("2970952576782792585984000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006472Inst Instance=new A006472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006473
{
public static readonly BigInteger[] Value={ 1L,30L,30240L,1816214400L,10137091700736000L,BigInteger.Parse("7561714896123855667200000"),BigInteger.Parse("1025113885554181044609786839040000000"),BigInteger.Parse("32964677266721834921175915315161407370035200000000"),BigInteger.Parse("318071672921132854486459356650996997744817246158245068800000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006473Inst Instance=new A006473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006474
{
public static readonly long[] Value={ 1L,2L,4L,9L,16L,20L,30L,42L,49L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006474Inst : IEnumerable<long>
{
public static readonly long[] Value=A006474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006474.Bytes);
public long this[int i]=>Value[i];

public static A006474Inst Instance=new A006474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006475
{
public static readonly long[] Value={ 2L,324L,48869983488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006475Inst : IEnumerable<long>
{
public static readonly long[] Value=A006475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006475.Bytes);
public long this[int i]=>Value[i];

public static A006475Inst Instance=new A006475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006476
{
public static readonly long[] Value={ 389L,433L,563L,571L,643L,709L,997L,1061L,1171L,1483L,1531L,1567L,1613L,1621L,1627L,1693L,1873L,1907L,1913L,1933L,2027L,2029L,2081L,2089L,2251L,2293L,2333L,2381L,2593L,2609L,2617L,2677L,2797L,2837L,2843L,2861L,2953L,2963L,3019L,3089L,3271L,3463L,3583L,3701L,3779L,3911L,3943L,3967L,4027L,4093L,4139L,4217L,4253L,4357L,4481L,4547L,4787L,4799L,4951L,5003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006476Inst : IEnumerable<long>
{
public static readonly long[] Value=A006476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006476.Bytes);
public long this[int i]=>Value[i];

public static A006476Inst Instance=new A006476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006477
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,4L,4L,10L,11L,22L,25L,44L,51L,83L,98L,149L,177L,259L,309L,436L,521L,716L,857L,1151L,1376L,1816L,2170L,2818L,3361L,4309L,5132L,6502L,7728L,9695L,11501L,14298L,16924L,20877L,24661L,30203L,35598L,43323L,50956L,61651L,72357L,87086L,101999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006477Inst : IEnumerable<long>
{
public static readonly long[] Value=A006477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006477.Bytes);
public long this[int i]=>Value[i];

public static A006477Inst Instance=new A006477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006494
{
public static readonly long[] Value={ 1L,20L,400L,8902L,197281L,4865617L,119060679L,3195913043L,84999425906L,2439540533153L,69353270203366L,2097660204806910L,62855340727822758L,1981075507583376209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006494Inst : IEnumerable<long>
{
public static readonly long[] Value=A006494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006494.Bytes);
public long this[int i]=>Value[i];

public static A006494Inst Instance=new A006494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006495
{
public static readonly long[] Value={ 1L,1L,-3L,-11L,-7L,41L,117L,29L,-527L,-1199L,237L,6469L,11753L,-8839L,-76443L,-108691L,164833L,873121L,922077L,-2521451L,-9653287L,-6699319L,34867797L,103232189L,32125393L,-451910159L,-1064447283L,130656229L,5583548873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006495Inst : IEnumerable<long>
{
public static readonly long[] Value=A006495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006495.Bytes);
public long this[int i]=>Value[i];

public static A006495Inst Instance=new A006495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006496
{
public static readonly long[] Value={ 0L,2L,4L,-2L,-24L,-38L,44L,278L,336L,-718L,-3116L,-2642L,10296L,33802L,16124L,-136762L,-354144L,-24478L,1721764L,3565918L,-1476984L,-20783558L,-34182196L,35553398L,242017776L,306268562L,-597551756L,-2726446322L,-2465133864L,8701963882L,29729597084L,15949374758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006496Inst : IEnumerable<long>
{
public static readonly long[] Value=A006496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006496.Bytes);
public long this[int i]=>Value[i];

public static A006496Inst Instance=new A006496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006497
{
public static readonly long[] Value={ 2L,3L,11L,36L,119L,393L,1298L,4287L,14159L,46764L,154451L,510117L,1684802L,5564523L,18378371L,60699636L,200477279L,662131473L,2186871698L,7222746567L,23855111399L,78788080764L,260219353691L,859446141837L,2838557779202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006497Inst : IEnumerable<long>
{
public static readonly long[] Value=A006497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006497.Bytes);
public long this[int i]=>Value[i];

public static A006497Inst Instance=new A006497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006498
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,6L,9L,15L,25L,40L,64L,104L,169L,273L,441L,714L,1156L,1870L,3025L,4895L,7921L,12816L,20736L,33552L,54289L,87841L,142129L,229970L,372100L,602070L,974169L,1576239L,2550409L,4126648L,6677056L,10803704L,17480761L,28284465L,45765225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006498Inst : IEnumerable<long>
{
public static readonly long[] Value=A006498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006498.Bytes);
public long this[int i]=>Value[i];

public static A006498Inst Instance=new A006498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006499
{
public static readonly long[] Value={ 1L,3L,9L,12L,16L,28L,49L,77L,121L,198L,324L,522L,841L,1363L,2209L,3572L,5776L,9348L,15129L,24477L,39601L,64078L,103684L,167762L,271441L,439203L,710649L,1149852L,1860496L,3010348L,4870849L,7881197L,12752041L,20633238L,33385284L,54018522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006499Inst : IEnumerable<long>
{
public static readonly long[] Value=A006499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006499.Bytes);
public long this[int i]=>Value[i];

public static A006499Inst Instance=new A006499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006500
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,18L,27L,45L,75L,125L,200L,320L,512L,832L,1352L,2197L,3549L,5733L,9261L,14994L,24276L,39304L,63580L,102850L,166375L,269225L,435655L,704969L,1140624L,1845504L,2985984L,4831488L,7817616L,12649337L,20466953L,33116057L,53582633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006500Inst : IEnumerable<long>
{
public static readonly long[] Value=A006500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006500.Bytes);
public long this[int i]=>Value[i];

public static A006500Inst Instance=new A006500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006501
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,18L,27L,36L,48L,64L,80L,100L,125L,150L,180L,216L,252L,294L,343L,392L,448L,512L,576L,648L,729L,810L,900L,1000L,1100L,1210L,1331L,1452L,1584L,1728L,1872L,2028L,2197L,2366L,2548L,2744L,2940L,3150L,3375L,3600L,3840L,4096L,4352L,4624L,4913L,5202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006501Inst : IEnumerable<long>
{
public static readonly long[] Value=A006501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006501.Bytes);
public long this[int i]=>Value[i];

public static A006501Inst Instance=new A006501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006502
{
public static readonly long[] Value={ 1L,3L,14L,60L,279L,1251L,5329L,21532L,83225L,310464L,1126502L,4000602L,13973725L,48187521L,164535708L,557528652L,1878067349L,6297614277L,21043287325L,70125062642L,233198372319L,774246922848L,2567419361916L,8505547438596L,28157369861593L,93162331494255L,308108749498202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006502Inst : IEnumerable<long>
{
public static readonly long[] Value=A006502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006502.Bytes);
public long this[int i]=>Value[i];

public static A006502Inst Instance=new A006502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006503
{
public static readonly long[] Value={ 0L,3L,10L,22L,40L,65L,98L,140L,192L,255L,330L,418L,520L,637L,770L,920L,1088L,1275L,1482L,1710L,1960L,2233L,2530L,2852L,3200L,3575L,3978L,4410L,4872L,5365L,5890L,6448L,7040L,7667L,8330L,9030L,9768L,10545L,11362L,12220L,13120L,14063L,15050L,16082L,17160L,18285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006503Inst : IEnumerable<long>
{
public static readonly long[] Value=A006503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006503.Bytes);
public long this[int i]=>Value[i];

public static A006503Inst Instance=new A006503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006504
{
public static readonly long[] Value={ 5L,20L,51L,105L,190L,315L,490L,726L,1035L,1430L,1925L,2535L,3276L,4165L,5220L,6460L,7905L,9576L,11495L,13685L,16170L,18975L,22126L,25650L,29575L,33930L,38745L,44051L,49880L,56265L,63240L,70840L,79101L,88060L,97755L,108225L,119510L,131651L,144690L,158670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006504Inst : IEnumerable<long>
{
public static readonly long[] Value=A006504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006504.Bytes);
public long this[int i]=>Value[i];

public static A006504Inst Instance=new A006504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006505
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,11L,36L,92L,491L,2557L,11353L,60105L,362506L,2169246L,13580815L,91927435L,650078097L,4762023647L,36508923530L,292117087090L,2424048335917L,20847410586719L,185754044235873L,1711253808769653L,16272637428430152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006505Inst : IEnumerable<long>
{
public static readonly long[] Value=A006505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006505.Bytes);
public long this[int i]=>Value[i];

public static A006505Inst Instance=new A006505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006506
{
public static readonly BigInteger[] Value={ 2L,7L,63L,1234L,55447L,5598861L,1280128950L,660647962955L,770548397261707L,2030049051145980050L,BigInteger.Parse("12083401651433651945979"),BigInteger.Parse("162481813349792588536582997"),BigInteger.Parse("4935961285224791538367780371090"),BigInteger.Parse("338752110195939290445247645371206783"),BigInteger.Parse("52521741712869136440040654451875316861275") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006506Inst Instance=new A006506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006507
{
public static readonly long[] Value={ 7L,14L,19L,29L,40L,44L,52L,59L,73L,83L,94L,107L,115L,122L,127L,137L,148L,161L,169L,185L,199L,218L,229L,242L,250L,257L,271L,281L,292L,305L,313L,320L,325L,335L,346L,359L,376L,392L,406L,416L,427L,440L,448L,464L,478L,497L,517L,530L,538L,554L,568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006507Inst : IEnumerable<long>
{
public static readonly long[] Value=A006507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006507.Bytes);
public long this[int i]=>Value[i];

public static A006507Inst Instance=new A006507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006508
{
public static readonly long[] Value={ 1L,4L,9L,16L,26L,39L,56L,78L,106L,141L,184L,236L,299L,374L,465L,570L,696L,843L,1014L,1212L,1441L,1708L,2014L,2365L,2769L,3226L,3749L,4343L,5016L,5774L,6630L,7596L,8676L,9897L,11259L,12784L,14482L,16383L,18502L,20847L,23458L,26354L,29562L,33112L,37041L,41370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006508Inst : IEnumerable<long>
{
public static readonly long[] Value=A006508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006508.Bytes);
public long this[int i]=>Value[i];

public static A006508Inst Instance=new A006508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006509
{
public static readonly long[] Value={ 1L,3L,6L,11L,4L,15L,2L,19L,38L,61L,32L,63L,26L,67L,24L,71L,18L,77L,16L,83L,12L,85L,164L,81L,170L,73L,174L,277L,384L,275L,162L,35L,166L,29L,168L,317L,468L,311L,148L,315L,142L,321L,140L,331L,138L,335L,136L,347L,124L,351L,122L,355L,116L,357L,106L,363L,100L,369L,98L,375L,94L,377L,84L,391L,80L,393L,76L,407L,70L,417L,68L,421L,62L,429L,56L,435L,52L,441L,44L,445L,36L,455L,34L,465L,898L,459L,902L,453L,910L,449L,912L,1379L,900L,413L,904L,405L,908L,399L,920L,397L,938L,1485L,928L,365L,934L,1505L,2082L,1495L,2088L,1489L,888L,281L,894L,1511L,892L,261L,0L,643L,1290L,637L,1296L,635L,1308L,631L,1314L,623L,1324L,615L,1334L,607L,1340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006509Inst : IEnumerable<long>
{
public static readonly long[] Value=A006509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006509.Bytes);
public long this[int i]=>Value[i];

public static A006509Inst Instance=new A006509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006526
{
public static readonly BigInteger[] Value={ 3L,29L,15786L,513429610L,339840390654894740L,BigInteger.Parse("383515880462620946584018566350380249"),BigInteger.Parse("226890280396768133952782550246970728734549546771915172071782710229538300") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006526Inst Instance=new A006526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006527
{
public static readonly long[] Value={ 0L,1L,4L,11L,24L,45L,76L,119L,176L,249L,340L,451L,584L,741L,924L,1135L,1376L,1649L,1956L,2299L,2680L,3101L,3564L,4071L,4624L,5225L,5876L,6579L,7336L,8149L,9020L,9951L,10944L,12001L,13124L,14315L,15576L,16909L,18316L,19799L,21360L,23001L,24724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006527Inst : IEnumerable<long>
{
public static readonly long[] Value=A006527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006527.Bytes);
public long this[int i]=>Value[i];

public static A006527Inst Instance=new A006527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006528
{
public static readonly long[] Value={ 0L,1L,6L,24L,70L,165L,336L,616L,1044L,1665L,2530L,3696L,5226L,7189L,9660L,12720L,16456L,20961L,26334L,32680L,40110L,48741L,58696L,70104L,83100L,97825L,114426L,133056L,153874L,177045L,202740L,231136L,262416L,296769L,334390L,375480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006528Inst : IEnumerable<long>
{
public static readonly long[] Value=A006528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006528.Bytes);
public long this[int i]=>Value[i];

public static A006528Inst Instance=new A006528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006529
{
public static readonly long[] Value={ 0L,1L,10L,57L,272L,885L,2226L,4725L,8912L,15417L,24970L,38401L,56640L,80717L,111762L,151005L,199776L,259505L,331722L,418057L,520240L,640101L,779570L,940677L,1125552L,1336425L,1575626L,1845585L,2148832L,2487997L,2865810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006529Inst : IEnumerable<long>
{
public static readonly long[] Value=A006529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006529.Bytes);
public long this[int i]=>Value[i];

public static A006529Inst Instance=new A006529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006530
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,3L,13L,7L,5L,2L,17L,3L,19L,5L,7L,11L,23L,3L,5L,13L,3L,7L,29L,5L,31L,2L,11L,17L,7L,3L,37L,19L,13L,5L,41L,7L,43L,11L,5L,23L,47L,3L,7L,5L,17L,13L,53L,3L,11L,7L,19L,29L,59L,5L,61L,31L,7L,2L,13L,11L,67L,17L,23L,7L,71L,3L,73L,37L,5L,19L,11L,13L,79L,5L,3L,41L,83L,7L,17L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006530Inst : IEnumerable<long>
{
public static readonly long[] Value=A006530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006530.Bytes);
public long this[int i]=>Value[i];

public static A006530Inst Instance=new A006530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006531
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,183L,2371L,38703L,763099L,17648823L,468603091L,14050842303L,469643495179L,17315795469063L,698171064855811L,30561156525545103L,1443380517590979259L,BigInteger.Parse("73161586346500098903"),BigInteger.Parse("3961555049961803092531"),BigInteger.Parse("228225249142441259147103"),BigInteger.Parse("13938493569348563803135339") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006531Inst Instance=new A006531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006532
{
public static readonly long[] Value={ 1L,3L,22L,66L,70L,81L,94L,115L,119L,170L,210L,214L,217L,265L,282L,310L,322L,343L,345L,357L,364L,382L,385L,400L,472L,497L,510L,517L,527L,642L,651L,679L,710L,742L,745L,782L,795L,820L,862L,884L,889L,930L,935L,966L,970L,1004L,1029L,1066L,1080L,1092L,1146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006532Inst : IEnumerable<long>
{
public static readonly long[] Value=A006532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006532.Bytes);
public long this[int i]=>Value[i];

public static A006532Inst Instance=new A006532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006533
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,30L,57L,88L,163L,230L,386L,456L,794L,966L,1471L,1712L,2517L,2484L,4048L,4520L,6196L,6842L,9109L,9048L,12951L,14014L,17902L,19208L,24158L,21510L,31931L,33888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006533Inst : IEnumerable<long>
{
public static readonly long[] Value=A006533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006533.Bytes);
public long this[int i]=>Value[i];

public static A006533Inst Instance=new A006533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006534
{
public static readonly long[] Value={ 1L,1L,1L,4L,6L,19L,43L,120L,307L,866L,2336L,6588L,18373L,52119L,147700L,422016L,1207477L,3471067L,9999135L,28893560L,83665729L,242826187L,706074369L,2056870697L,6001555275L,17538335077L,51323792789L,150390053432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006534Inst : IEnumerable<long>
{
public static readonly long[] Value=A006534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006534.Bytes);
public long this[int i]=>Value[i];

public static A006534Inst Instance=new A006534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006535
{
public static readonly long[] Value={ 1L,1L,3L,10L,33L,147L,620L,2821L,12942L,60639L,286190L,1364621L,6545430L,31586358L,153143956L,745700845L,3644379397L,17869651166L,87877879487L,433301253231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006535Inst : IEnumerable<long>
{
public static readonly long[] Value=A006535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006535.Bytes);
public long this[int i]=>Value[i];

public static A006535Inst Instance=new A006535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006536
{
public static readonly BigInteger[] Value={ 2L,6L,38L,684L,50224L,13946352L,14061131152L,50947324188128L,666754350781269760L,BigInteger.Parse("31763991166456912086656"),BigInteger.Parse("5550343429517595744902558208"),BigInteger.Parse("3581353054755185129132443153728000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A006536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A006536Inst Instance=new A006536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006537
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,12L,22L,30L,32L,61L,65L,115L,161L,189L,296L,470L,598L,841L,904L,1856L,2158L,2416L,1925L,3462L,2130L,3749L,6546L,11201L,2159L,2360L,5186L,6071L,8664L,14735L,59745L,68482L,117997L,175672L,268618L,135585L,178909L,314752L,490652L,76800L,116789L,125493L,290641L,540539L,831180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006537Inst : IEnumerable<long>
{
public static readonly long[] Value=A006537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006537.Bytes);
public long this[int i]=>Value[i];

public static A006537Inst Instance=new A006537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006538
{
public static readonly long[] Value={ 1L,3L,5L,11L,11L,19L,35L,47L,53L,95L,103L,179L,251L,299L,503L,743L,1019L,1319L,1439L,2939L,3359L,3959L,5387L,5387L,5879L,5879L,17747L,17747L,23399L,23399L,23399L,23399L,23399L,23399L,93596L,186479L,186479L,278387L,442679L,493919L,493919L,493919L,830939L,1371719L,1371719L,1371719L,1371719L,1371719L,1371719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006538Inst : IEnumerable<long>
{
public static readonly long[] Value=A006538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006538.Bytes);
public long this[int i]=>Value[i];

public static A006538Inst Instance=new A006538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006539
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,12L,18L,20L,30L,46L,60L,62L,72L,89L,105L,113L,117L,119L,120L,241L,483L,633L,647L,654L,1074L,1752L,1806L,3050L,3609L,3611L,3612L,5459L,5460L,7976L,7999L,8005L,8008L,10076L,16379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006539Inst : IEnumerable<long>
{
public static readonly long[] Value=A006539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006539.Bytes);
public long this[int i]=>Value[i];

public static A006539Inst Instance=new A006539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A006540
{
public static readonly long[] Value={ 1L,3L,5L,7L,7L,13L,19L,23L,31L,47L,61L,71L,73L,121L,121L,121L,121L,121L,121L,242L,484L,661L,661L,661L,1093L,1753L,1807L,3053L,3613L,3613L,3613L,5461L,5461L,8011L,8011L,8011L,8011L,10081L,16381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A006540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A006540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A006540Inst : IEnumerable<long>
{
public static readonly long[] Value=A006540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A006540.Bytes);
public long this[int i]=>Value[i];

public static A006540Inst Instance=new A006540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}