using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A188613
{
public static readonly BigInteger[] Value={ 88L,7744L,165506L,2925040L,52884231L,919272280L,15651179908L,260970703443L,4300360372354L,70130618145688L,1136591420736796L,18325387673235042L,294484831915118120L,4719745235890254821L,BigInteger.Parse("75508745229294132673") };
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
public class A188613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188613Inst Instance=new A188613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188614
{
public static readonly long[] Value={ 3L,2L,6L,1L,9L,7L,2L,6L,2L,7L,3L,9L,5L,6L,6L,8L,5L,6L,1L,0L,5L,8L,0L,5L,5L,1L,0L,3L,0L,0L,3L,2L,7L,4L,6L,5L,2L,2L,1L,4L,5L,0L,5L,1L,2L,7L,1L,0L,4L,2L,3L,3L,0L,4L,5L,4L,0L,6L,8L,7L,5L,2L,0L,0L,5L,5L,1L,8L,0L,2L,4L,9L,3L,4L,6L,4L,3L,1L,1L,7L,5L,6L,2L,8L,0L,0L,6L,7L,4L,0L,4L,0L,2L,8L,3L,3L,0L,7L,6L,4L,9L,3L,0L,9L,3L,9L,8L,9L,7L,7L,9L,5L,4L,0L,8L,0L,6L,3L,0L,8L,6L,6L,6L,3L,1L,9L,1L,2L,1L,5L };
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
public class A188614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188614Inst : IEnumerable<long>
{
public static readonly long[] Value=A188614.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188614.Bytes);
public long this[int i]=>Value[i];

public static A188614Inst Instance=new A188614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188615
{
public static readonly long[] Value={ 3L,3L,9L,8L,3L,6L,9L,0L,9L,4L,5L,4L,1L,2L,1L,9L,3L,7L,0L,9L,6L,3L,9L,2L,5L,1L,3L,3L,9L,1L,7L,6L,4L,0L,6L,6L,3L,8L,8L,2L,4L,4L,6L,9L,0L,3L,3L,2L,4L,5L,8L,0L,7L,1L,4L,3L,1L,9L,2L,3L,9L,6L,2L,4L,8L,9L,9L,1L,5L,8L,8L,8L,6L,6L,4L,8L,4L,8L,4L,1L,1L,4L,6L,0L,7L,6L,5L,7L,9L,2L,5L,0L,0L,1L,9L,7L,6L,1L,2L,8L,5L,2L,1L,2L,9L,7L,6L,3L,8L,0L,7L,4L,0L,2L,2L,9L,4L,4L,7L,4L,1L,5L,2L,3L,9L,3L,5L,7L,5L,7L };
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
public class A188615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188615Inst : IEnumerable<long>
{
public static readonly long[] Value=A188615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188615.Bytes);
public long this[int i]=>Value[i];

public static A188615Inst Instance=new A188615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188616
{
public static readonly long[] Value={ 5L,9L,1L,0L,6L,7L,7L,9L,9L,7L,0L,5L,1L,6L,4L,8L,7L,9L,7L,6L,3L,2L,3L,2L,3L,7L,4L,1L,9L,6L,6L,2L,1L,7L,2L,3L,6L,0L,5L,4L,9L,7L,8L,5L,3L,1L,4L,6L,5L,8L,3L,4L,0L,5L,9L,0L,5L,0L,3L,1L,3L,2L,9L,0L,3L,6L,5L,9L,4L,6L,1L,4L,7L,0L,8L,5L,5L,8L,0L,0L,1L,2L,5L,4L,3L,4L,3L,8L,2L,2L,5L,8L,1L,9L,1L,6L,4L,3L,1L,2L,6L,6L,0L,3L,6L,8L,6L,5L,6L,4L,1L,3L,8L,1L,5L,7L,7L,8L,3L,7L };
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
public class A188616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188616Inst : IEnumerable<long>
{
public static readonly long[] Value=A188616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188616.Bytes);
public long this[int i]=>Value[i];

public static A188616Inst Instance=new A188616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188617
{
public static readonly long[] Value={ 2L,8L,5L,0L,8L,8L,7L,3L,0L,0L,4L,8L,6L,1L,0L,5L,5L,3L,7L,1L,4L,5L,6L,0L,9L,1L,3L,7L,8L,0L,2L,1L,6L,3L,3L,7L,0L,2L,4L,0L,0L,1L,0L,2L,5L,6L,9L,7L,6L,7L,5L,9L,1L,4L,1L,8L,1L,0L,0L,4L,0L,5L,1L,3L,3L,9L,0L,9L,0L,3L,9L,6L,5L,6L,7L,1L,4L,0L,1L,1L,5L,5L,4L,0L,7L,0L,3L,8L,4L,5L,0L,1L,3L,8L,3L,1L,0L,8L,0L,1L,6L,1L,4L,0L,7L,1L,6L,0L,9L,8L,8L,9L,3L,6L,8L,9L,1L,7L,6L,9L };
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
public class A188617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188617Inst : IEnumerable<long>
{
public static readonly long[] Value=A188617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188617.Bytes);
public long this[int i]=>Value[i];

public static A188617Inst Instance=new A188617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188618
{
public static readonly long[] Value={ 1L,6L,9L,2L,9L,3L,3L,9L,6L,3L,2L,0L,8L,3L,8L,1L,8L,0L,7L,3L,0L,6L,2L,9L,6L,0L,3L,2L,1L,5L,5L,5L,9L,6L,2L,2L,3L,0L,5L,9L,1L,0L,3L,1L,2L,5L,6L,1L,4L,3L,7L,6L,4L,6L,7L,0L,6L,9L,4L,2L,7L,3L,9L,1L,6L,6L,2L,0L,3L,9L,5L,7L,7L,3L,0L,2L,1L,5L,6L,7L,4L,5L,5L,9L,2L,7L,8L,3L,1L,5L,3L,7L,9L,6L,5L,8L,6L,5L,7L,4L,1L,2L,0L,0L,2L,0L,0L,2L,8L,4L,4L,6L,4L,5L,9L,5L,8L,7L,0L,2L,9L,6L,6L,9L,5L,0L,3L,4L,7L,1L };
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
public class A188618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188618Inst : IEnumerable<long>
{
public static readonly long[] Value=A188618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188618.Bytes);
public long this[int i]=>Value[i];

public static A188618Inst Instance=new A188618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188619
{
public static readonly long[] Value={ 2L,9L,0L,9L,3L,1L,2L,9L,1L,1L,1L,7L,6L,4L,0L,9L,4L,6L,4L,6L,0L,9L,7L,9L,9L,1L,3L,2L,0L,2L,0L,5L,2L,7L,5L,7L,1L,4L,7L,6L,9L,8L,6L,1L,8L,8L,3L,7L,9L,9L,3L,0L,3L,0L,1L,3L,3L,6L,8L,2L,8L,4L,6L,7L,5L,3L,4L,4L,4L,4L,3L,3L,8L,4L,4L,6L,6L,4L,0L,3L,8L,7L,6L,8L,7L,8L,1L,1L,3L,8L,7L,2L,2L,3L,7L,1L,0L,3L,2L,7L,1L,2L,0L,3L,0L,2L,5L,4L,2L,8L,1L,3L,0L,3L,1L,9L,9L,1L,8L,6L,0L,7L,8L,0L,5L,6L,3L,5L,0L,4L };
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
public class A188619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188619Inst : IEnumerable<long>
{
public static readonly long[] Value=A188619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188619.Bytes);
public long this[int i]=>Value[i];

public static A188619Inst Instance=new A188619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188652
{
public static readonly long[] Value={ 0L,1L,2L,-1L,6L,-5L,12L,-11L,20L,-19L,30L,-29L,42L,-41L,56L,-55L,72L,-71L,90L,-89L,110L,-109L,132L,-131L,156L,-155L,182L,-181L,210L,-209L,240L,-239L,272L,-271L,306L,-305L,342L,-341L,380L,-379L,420L,-419L,462L,-461L,506L,-505L,552L,-551L,600L,-599L,650L,-649L,702L,-701L,756L,-755L,812L,-811L,870L,-869L,930L,-929L,992L,-991L,1056L,-1055L,1122L,-1121L,1190L,-1189L,1260L,-1259L,1332L,-1331L,1406L };
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
public class A188652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188652Inst : IEnumerable<long>
{
public static readonly long[] Value=A188652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188652.Bytes);
public long this[int i]=>Value[i];

public static A188652Inst Instance=new A188652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188653
{
public static readonly long[] Value={ 1L,1L,-3L,7L,-11L,17L,-23L,31L,-39L,49L,-59L,71L,-83L,97L,-111L,127L,-143L,161L,-179L,199L,-219L,241L,-263L,287L,-311L,337L,-363L,391L,-419L,449L,-479L,511L,-543L,577L,-611L,647L,-683L,721L,-759L,799L,-839L,881L,-923L,967L,-1011L,1057L,-1103L,1151L,-1199L,1249L,-1299L,1351L,-1403L,1457L,-1511L,1567L,-1623L,1681L,-1739L,1799L,-1859L,1921L,-1983L,2047L,-2111L,2177L,-2243L,2311L,-2379L,2449L,-2519L,2591L,-2663L,2737L,-2811L };
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
public class A188653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188653Inst : IEnumerable<long>
{
public static readonly long[] Value=A188653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188653.Bytes);
public long this[int i]=>Value[i];

public static A188653Inst Instance=new A188653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188654
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,14L,15L,16L,21L,22L,24L,25L,26L,27L,30L,32L,33L,34L,35L,38L,39L,40L,42L,46L,48L,49L,51L,54L,55L,56L,57L,58L,60L,62L,64L,65L,66L,69L,70L,72L,74L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,93L,94L,95L,96L,102L,104L,105L,106L,108L,110L,111L };
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
public class A188654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188654Inst : IEnumerable<long>
{
public static readonly long[] Value=A188654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188654.Bytes);
public long this[int i]=>Value[i];

public static A188654Inst Instance=new A188654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188655
{
public static readonly long[] Value={ 1L,8L,6L,8L,5L,1L,7L,0L,9L,1L,8L,2L,1L,3L,2L,9L,7L,6L,4L,3L,7L,3L,0L,7L,3L,7L,5L,5L,8L,2L,3L,4L,9L,8L,6L,4L,8L,7L,5L,0L,4L,3L,2L,1L,9L,1L,2L,8L,1L,7L,4L,8L,7L,3L,7L,5L,7L,0L,1L,5L,1L,0L,1L,8L,7L,4L,2L,3L,8L,8L,9L,8L,2L,7L,6L,4L,3L,3L,6L,8L,1L,5L,0L,6L,8L,2L,0L,6L,3L,6L,0L,6L,7L,2L,8L,3L,0L,2L,3L,9L,2L,2L,4L,5L,0L,4L,7L,2L,7L,3L,4L,1L,3L,5L,4L,5L,1L,3L,4L,5L,8L,6L,7L,6L,8L,9L,2L,7L,5L,5L };
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
public class A188655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188655Inst : IEnumerable<long>
{
public static readonly long[] Value=A188655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188655.Bytes);
public long this[int i]=>Value[i];

public static A188655Inst Instance=new A188655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188656
{
public static readonly long[] Value={ 1L,1L,3L,2L,7L,8L,2L,2L,1L,8L,5L,3L,7L,3L,1L,8L,7L,0L,6L,5L,4L,5L,8L,2L,6L,6L,5L,3L,7L,8L,7L,9L,7L,1L,3L,9L,1L,3L,9L,1L,7L,9L,9L,5L,3L,8L,2L,0L,1L,0L,7L,1L,6L,7L,3L,4L,9L,2L,0L,7L,4L,0L,4L,8L,6L,5L,7L,9L,8L,4L,3L,6L,8L,8L,7L,8L,2L,1L,1L,0L,2L,5L,3L,7L,0L,0L,1L,9L,2L,8L,3L,3L,3L,9L,6L,5L,3L,8L,3L,0L,4L,5L,4L,6L,8L,0L,3L,0L,8L,2L,6L,7L,4L,9L,3L,2L,3L,9L,0L,2L,6L,7L,1L,8L,5L,8L,1L,5L,1L,5L };
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
public class A188656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188656Inst : IEnumerable<long>
{
public static readonly long[] Value=A188656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188656.Bytes);
public long this[int i]=>Value[i];

public static A188656Inst Instance=new A188656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188657
{
public static readonly long[] Value={ 1L,4L,4L,3L,0L,0L,0L,4L,6L,8L,1L,6L,4L,6L,9L,1L,3L,9L,5L,9L,8L,3L,9L,5L,6L,0L,4L,0L,7L,7L,9L,9L,6L,3L,3L,0L,4L,3L,2L,4L,3L,0L,6L,9L,1L,6L,1L,9L,1L,6L,6L,0L,2L,8L,0L,2L,3L,8L,5L,8L,1L,4L,0L,6L,7L,2L,1L,4L,5L,6L,1L,0L,2L,4L,1L,5L,9L,1L,2L,2L,9L,7L,6L,3L,5L,1L,2L,1L,5L,0L,3L,7L,6L,3L,3L,7L,6L,1L,7L,8L,7L,0L,0L,0L,7L,9L,0L,8L,1L,5L,8L };
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
public class A188657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188657Inst : IEnumerable<long>
{
public static readonly long[] Value=A188657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188657.Bytes);
public long this[int i]=>Value[i];

public static A188657Inst Instance=new A188657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188658
{
public static readonly long[] Value={ 1L,1L,0L,4L,9L,8L,7L,5L,6L,2L,1L,1L,2L,0L,8L,9L,0L,2L,7L,0L,2L,1L,9L,2L,6L,4L,9L,1L,2L,7L,5L,9L,5L,7L,6L,1L,8L,6L,9L,4L,5L,0L,2L,3L,4L,7L,0L,0L,2L,6L,3L,7L,7L,2L,9L,0L,5L,7L,2L,8L,2L,8L,2L,9L,7L,3L,2L,8L,4L,9L,1L,2L,3L,1L,5L,5L,1L,9L,7L,0L,3L,8L,1L,2L,3L,6L,1L,7L,7L,6L,9L,2L,4L,5L,3L,9L,5L,2L,3L,5L,2L,3L,6L,6L,2L,9L,9L,5L,0L,3L,2L,6L,5L,2L,6L,1L,3L,2L,3L,1L,8L,8L,1L,5L,9L,3L,5L,8L,5L,8L };
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
public class A188658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188658Inst : IEnumerable<long>
{
public static readonly long[] Value=A188658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188658.Bytes);
public long this[int i]=>Value[i];

public static A188658Inst Instance=new A188658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188659
{
public static readonly long[] Value={ 1L,2L,1L,9L,8L,0L,3L,9L,0L,2L,7L,1L,8L,5L,5L,6L,9L,6L,6L,0L,0L,5L,6L,4L,4L,8L,2L,1L,8L,0L,4L,5L,5L,6L,3L,9L,7L,9L,1L,2L,7L,5L,4L,1L,8L,9L,2L,1L,9L,9L,1L,9L,2L,8L,1L,5L,1L,6L,9L,9L,4L,1L,6L,0L,8L,8L,5L,1L,8L,6L,7L,2L,6L,4L,1L,2L,4L,4L,4L,8L,3L,9L,1L,1L,7L,6L,6L,9L,7L,7L,0L,2L,1L,8L,7L,8L,6L,4L,0L,1L,6L,7L,2L,2L,3L,8L,0L,5L,1L,6L,4L,8L,2L,0L,7L,9L,8L,2L,1L,3L,2L,2L,8L,6L,3L,5L,5L,8L,6L,8L };
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
public class A188659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188659Inst : IEnumerable<long>
{
public static readonly long[] Value=A188659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188659.Bytes);
public long this[int i]=>Value[i];

public static A188659Inst Instance=new A188659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188660
{
public static readonly long[] Value={ 12L,72L,240L,420L,600L,1260L,2352L,4032L,6480L,7140L,9900L,14280L,14520L,20592L,28392L,38220L,46872L,50400L,65280L,78120L,83232L,104652L,123552L,129960L,159600L,194040L,233772L,279312L,291060L,331200L,390000L,456300L,485112L,530712L,609180L,613872L,699732L,706440L,809100L,852852L,922560L };
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
public class A188660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188660Inst : IEnumerable<long>
{
public static readonly long[] Value=A188660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188660.Bytes);
public long this[int i]=>Value[i];

public static A188660Inst Instance=new A188660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188661
{
public static readonly BigInteger[] Value={ 17L,41L,113L,353L,1217L,4481L,67073L,1054721L,4206593L,16801793L,274881052673L,18014399314788353L,72057595648540673L,BigInteger.Parse("18446744099479355393"),BigInteger.Parse("4722366483281962074113"),BigInteger.Parse("79228162514266026443404214273") };
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
public class A188661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188661Inst Instance=new A188661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188662
{
public static readonly BigInteger[] Value={ 1L,9L,225L,7056L,245025L,9018009L,344622096L,13521038400L,540917591841L,21966328580625L,902702926350225L,37456461988358400L,1566697064677290000L,BigInteger.Parse("65973795093338597136"),BigInteger.Parse("2794203818390077646400"),BigInteger.Parse("118933541228935777741056"),BigInteger.Parse("5084343623375056062840609") };
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
public class A188662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188662Inst Instance=new A188662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188663
{
public static readonly long[] Value={ 10045L,11310L,52360L,230300L,341055L,4048352L,6192520L,16008300L,18573282L,21430710L,44175780L,49452975L,75377337L,89579112L,174695500L,201243042L,212087876L,616116800L,755319180L,1369585525L,1557466482L,1586309340L,1625178126L,1674425676L,1744607172L,1857169860L,1868270250L,1985347551L };
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
public class A188663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188663Inst : IEnumerable<long>
{
public static readonly long[] Value=A188663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188663.Bytes);
public long this[int i]=>Value[i];

public static A188663Inst Instance=new A188663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188664
{
public static readonly BigInteger[] Value={ 2L,1L,2L,8L,52L,495L,6470L,111034L,2419928L,65269092L,2133844440L,83133090480L,3805035352536L,202147745618247L,12336516593999598L,857054350280418290L,BigInteger.Parse("67247553674224203280"),BigInteger.Parse("5917723267088513913032"),BigInteger.Parse("580407202154922558537264"),BigInteger.Parse("63093021853191022229671056"),BigInteger.Parse("7563270705677373923076693840") };
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
public class A188664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188664Inst Instance=new A188664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188665
{
public static readonly long[] Value={ 2L,7L,71L,109L,1321L,1453L,1621L,1951L,2719L,3373L,3853L,4639L,5791L,6427L,6733L,9619L,10837L,11699L,13933L,15391L,16927L,18517L,20173L,23743L,25633L,28927L,29599L,33151L,40813L,43291L,44959L,47533L,55711L,56671L,58579L,70783L,80671L,84127L,88813L };
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
public class A188665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188665Inst : IEnumerable<long>
{
public static readonly long[] Value=A188665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188665.Bytes);
public long this[int i]=>Value[i];

public static A188665Inst Instance=new A188665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188666
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,5L,5L,7L,7L,7L,7L,8L,8L,9L,9L,11L,11L,11L,11L,13L,13L,13L,13L,16L,16L,16L,16L,16L,16L,17L,17L,19L,19L,19L,19L,23L,23L,23L,23L,23L,23L,23L,23L,25L,25L,25L,25L,27L,27L,27L,27L,29L,29L,29L,29L,31L,31L,31L,31L,32L,32L,37L,37L,37L,37L,37L,37L };
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
public class A188666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188666Inst : IEnumerable<long>
{
public static readonly long[] Value=A188666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188666.Bytes);
public long this[int i]=>Value[i];

public static A188666Inst Instance=new A188666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188667
{
public static readonly long[] Value={ 0L,0L,3L,21L,72L,180L,375L,693L,1176L,1872L,2835L,4125L,5808L,7956L,10647L,13965L,18000L,22848L,28611L,35397L,43320L,52500L,63063L,75141L,88872L,104400L,121875L,141453L,163296L,187572L,214455L,244125L,276768L,312576L,351747L,394485L,441000L };
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
public class A188667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188667Inst : IEnumerable<long>
{
public static readonly long[] Value=A188667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188667.Bytes);
public long this[int i]=>Value[i];

public static A188667Inst Instance=new A188667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188700
{
public static readonly long[] Value={ 8L,21L,90L,304L,1141L,4084L,14925L,54049L,196508L,713225L,2590574L,9406448L,34159833L,124045128L,450458681L,1635781681L,5940155616L,21570956189L,78332387394L,284454730240L,1032963629229L,3751084683708L,13621618755397L };
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
public class A188700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188700Inst : IEnumerable<long>
{
public static readonly long[] Value=A188700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188700.Bytes);
public long this[int i]=>Value[i];

public static A188700Inst Instance=new A188700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188701
{
public static readonly long[] Value={ 16L,55L,387L,1876L,10857L,57665L,318732L,1729531L,9464035L,51591068L,281717653L,1537169293L,8390298820L,45789639603L,249911548135L,1363931051824L,7443964229917L,40626890315469L,221729775973184L,1210135365944631L };
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
public class A188701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188701Inst : IEnumerable<long>
{
public static readonly long[] Value=A188701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188701.Bytes);
public long this[int i]=>Value[i];

public static A188701Inst Instance=new A188701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188702
{
public static readonly long[] Value={ 32L,144L,1665L,11556L,103484L,813309L,6814290L,55337580L,456131965L,3733374889L,30657827284L,251373054600L,2062533960693L,16917792861256L,138787419681888L,1138485405941113L,9339379255511170L,76613020663877804L,628477682370006669L };
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
public class A188702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188702Inst : IEnumerable<long>
{
public static readonly long[] Value=A188702.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188702.Bytes);
public long this[int i]=>Value[i];

public static A188702Inst Instance=new A188702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188703
{
public static readonly long[] Value={ 64L,377L,7164L,71152L,986929L,11462588L,145764780L,1769780565L,21988745988L,270110390804L,3336423566677L,41102425332512L,506994024857925L,6249982640820369L,77068431918058476L,950205205067610609L };
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
public class A188703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188703Inst : IEnumerable<long>
{
public static readonly long[] Value=A188703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188703.Bytes);
public long this[int i]=>Value[i];

public static A188703Inst Instance=new A188703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188704
{
public static readonly BigInteger[] Value={ 128L,987L,30825L,438048L,9413801L,161506225L,3118943536L,56585607231L,1060220669261L,19540000913840L,363127600370277L,6720433284624777L,124629114169963492L,2308929622288774467L,BigInteger.Parse("42796685753793213877") };
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
public class A188704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188704Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188704.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188704Inst Instance=new A188704Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188705
{
public static readonly BigInteger[] Value={ 256L,2584L,132633L,2696784L,89796720L,2275402541L,66743533552L,1808994829500L,51125945437653L,1413407939489088L,39524443386479892L,1098772573002280493L,BigInteger.Parse("30637099060362271520"),BigInteger.Parse("852972971744061721372"),BigInteger.Parse("23765518994514834443569") };
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
public class A188705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188705Inst Instance=new A188705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188706
{
public static readonly long[] Value={ 2L,4L,3L,8L,8L,5L,16L,21L,21L,8L,32L,55L,90L,49L,13L,64L,144L,387L,304L,120L,21L,128L,377L,1665L,1876L,1141L,288L,34L,256L,987L,7164L,11556L,10857L,4084L,697L,55L,512L,2584L,30825L,71152L,103484L,57665L,14925L,1681L,89L,1024L,6765L,132633L,438048L,986929L };
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
public class A188706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188706Inst : IEnumerable<long>
{
public static readonly long[] Value=A188706.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188706.Bytes);
public long this[int i]=>Value[i];

public static A188706Inst Instance=new A188706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188707
{
public static readonly long[] Value={ 5L,21L,90L,387L,1665L,7164L,30825L,132633L,570690L,2455551L,10565685L,45461772L,195611805L,841673709L,3621533130L,15582644523L,67048623225L,288495182556L,1241330043105L,5341164667857L,22981833209970L,98885672046279L };
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
public class A188707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188707Inst : IEnumerable<long>
{
public static readonly long[] Value=A188707.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188707.Bytes);
public long this[int i]=>Value[i];

public static A188707Inst Instance=new A188707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188708
{
public static readonly long[] Value={ 8L,49L,304L,1876L,11556L,71152L,438048L,2696784L,16602304L,102209216L,629233216L,3873764352L,23848153088L,146816985344L,903853103104L,5564413613056L,34256339608576L,210893165924352L,1298326906544128L,7992922619695104L };
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
public class A188708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188708Inst : IEnumerable<long>
{
public static readonly long[] Value=A188708.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188708.Bytes);
public long this[int i]=>Value[i];

public static A188708Inst Instance=new A188708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188709
{
public static readonly long[] Value={ 13L,120L,1141L,10857L,103484L,986929L,9413801L,89796720L,856564045L,8170716249L,77940041492L,743466128137L,7091886123065L,67649146608936L,645301822994341L,6155501787932937L,58717023436375724L,560098747441089889L };
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
public class A188709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188709Inst : IEnumerable<long>
{
public static readonly long[] Value=A188709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188709.Bytes);
public long this[int i]=>Value[i];

public static A188709Inst Instance=new A188709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188710
{
public static readonly long[] Value={ 21L,288L,4084L,57665L,813309L,11462588L,161506225L,2275402541L,32056524184L,451618426905L,6362474783637L,89635548416108L,1262799579803897L,17790516723173509L,250635561977240232L,3530992705334939489L };
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
public class A188710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188710Inst : IEnumerable<long>
{
public static readonly long[] Value=A188710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188710.Bytes);
public long this[int i]=>Value[i];

public static A188710Inst Instance=new A188710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188711
{
public static readonly BigInteger[] Value={ 34L,697L,14925L,318732L,6814290L,145764780L,3118943536L,66743533552L,1428321913952L,30566631602016L,654139520133696L,13998888884058752L,299582781445141504L,6411212320129846144L,BigInteger.Parse("137202959280321342208") };
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
public class A188711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188711Inst Instance=new A188711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188712
{
public static readonly BigInteger[] Value={ 55L,1681L,54049L,1729531L,55337580L,1769780565L,56585607231L,1808994829500L,57829148027161L,1848624216954643L,59094629276262316L,1889063777872100973L,BigInteger.Parse("60387214464117233335"),BigInteger.Parse("1930382199629976832828"),BigInteger.Parse("61708017083116822627729") };
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
public class A188712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188712Inst Instance=new A188712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188713
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,23L,31L,47L,67L,71L,79L,127L,131L,191L,257L,263L,271L,383L,1031L,1039L,1087L,1151L,1279L,2063L,2111L,4099L,4111L,4127L,4159L,5119L,6143L,8191L,8447L,16447L,20479L,32771L,32783L,32831L,33023L,33791L,65537L };
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
public class A188713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188713Inst : IEnumerable<long>
{
public static readonly long[] Value=A188713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188713.Bytes);
public long this[int i]=>Value[i];

public static A188713Inst Instance=new A188713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188714
{
public static readonly long[] Value={ 1L,4L,16L,64L,252L,996L,3936L,15552L,61452L,242820L,959472L,3791232L,14980572L,59193828L,233896896L,924213888L,3651913836L,14430073860L,57018604752L,225301777344L,890251367868L,3517715249892L,13899805185312L,54923315409216L,217022507533260L,857536884383364L,3388448121977520L,13389022541682432L,52905022644129948L,209047479923369700L };
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
public class A188714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188714Inst : IEnumerable<long>
{
public static readonly long[] Value=A188714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188714.Bytes);
public long this[int i]=>Value[i];

public static A188714Inst Instance=new A188714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188715
{
public static readonly long[] Value={ 2L,3L,4L,6L,13L,28L,64L,756L,126225L,157366665L };
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
public class A188715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188715Inst : IEnumerable<long>
{
public static readonly long[] Value=A188715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188715.Bytes);
public long this[int i]=>Value[i];

public static A188715Inst Instance=new A188715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188716
{
public static readonly long[] Value={ 1L,1L,4L,15L,46L,125L,316L,763L,1786L,4089L,9208L,20471L,45046L,98293L,212980L,458739L,983026L,2097137L,4456432L,9437167L,19922926L,41943021L,88080364L,184549355L,385875946L,805306345L,1677721576L,3489660903L,7247757286L,15032385509L,31138512868L,64424509411L,133143986146L,274877906913L,566935683040L,1168231104479L };
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
public class A188716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188716Inst : IEnumerable<long>
{
public static readonly long[] Value=A188716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188716.Bytes);
public long this[int i]=>Value[i];

public static A188716Inst Instance=new A188716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188717
{
public static readonly long[] Value={ 17L,1297L,1336337L,4477457L,29986577L,45212177L,126247697L,193877777L,406586897L,562448657L,916636177L,1416468497L,1944810001L,3208542737L,4162314257L,5006411537L,5972816657L,12444741137L,19565295377L,34188010001L,38167092497L };
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
public class A188717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188717Inst : IEnumerable<long>
{
public static readonly long[] Value=A188717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188717.Bytes);
public long this[int i]=>Value[i];

public static A188717Inst Instance=new A188717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188718
{
public static readonly BigInteger[] Value={ 1L,6L,130L,3772L,125378L,4512788L,171163380L,6737259192L,272624233922L,11270562833828L,473960605546620L,20211120713747144L,871908517791261620L,BigInteger.Parse("37984137010354633288"),BigInteger.Parse("1668675534695695271592"),BigInteger.Parse("73839856328273510564464"),BigInteger.Parse("3288232505457053332149954"),BigInteger.Parse("147251876924939254405677892"),BigInteger.Parse("6626961347483273293096934060") };
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
public class A188718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188718Inst Instance=new A188718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188719
{
public static readonly long[] Value={ 2L,7L,25L,115L,670L,4324L,30657L,229568L,1775675L,14156112L,115500275L,960392564L };
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
public class A188719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188719Inst : IEnumerable<long>
{
public static readonly long[] Value=A188719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188719.Bytes);
public long this[int i]=>Value[i];

public static A188719Inst Instance=new A188719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188720
{
public static readonly long[] Value={ 3L,0L,4L,6L,5L,2L,4L,6L,9L,5L,3L,3L,3L,4L,7L,2L,4L,7L,1L,8L,1L,1L,4L,0L,1L,7L,6L,6L,5L,8L,7L,1L,5L,5L,2L,4L,3L,2L,7L,4L,6L,0L,7L,0L,5L,8L,8L,7L,9L,7L,9L,4L,7L,7L,4L,5L,7L,7L,4L,2L,2L,4L,9L,6L,3L,1L,2L,0L,4L,6L,2L,8L,7L,4L,0L,0L,0L,6L,5L,6L,0L,6L,0L,1L,8L,9L,8L,5L,5L,3L,5L,0L,7L,3L,6L,5L,9L,4L,2L,6L,8L,0L,6L,1L,2L,7L,1L,1L,0L,2L,5L,2L,3L,4L,2L,9L,9L,9L,8L,0L,8L,1L,3L,2L,0L,9L,6L,8L,1L,5L };
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
public class A188720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188720Inst : IEnumerable<long>
{
public static readonly long[] Value=A188720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188720.Bytes);
public long this[int i]=>Value[i];

public static A188720Inst Instance=new A188720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188721
{
public static readonly long[] Value={ 3L,21L,2L,40L,1L,8L,1L,18L,1L,4L,2L,7L,14L,25L,1L,2L,1L,4L,1L,1L,1L,1L,2L,8L,50L,4L,1L,1L,3L,1L,11L,1L,1L,2L,3L,1L,1L,3L,1L,2L,22L,1L,1L,4L,1L,4L,1L,1L,4L,4L,2L,2L,2L,57L,1L,1L,34L,5L,1L,2L,2L,1L,1L,8L,13L,2L,3L,3L,17L,1L,1L,49L,1L,2L,1L,5L,1L,7L,1L,9L,1L,11L,1L,1L,7L,13L,1L,1L,59L,4L,8L,1L,3L,1L,4L,6L,1L,9L,11L,1L,1L,4L,456L,2L,8L,23L,2L,4L,2L,2L,1066L,1L,2L,2L,1L,11L,1L,3L,2L,26L };
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
public class A188721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188721Inst : IEnumerable<long>
{
public static readonly long[] Value=A188721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188721.Bytes);
public long this[int i]=>Value[i];

public static A188721Inst Instance=new A188721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188722
{
public static readonly long[] Value={ 3L,4L,3L,2L,8L,9L,2L,2L,1L,5L,9L,1L,3L,4L,8L,3L,2L,4L,4L,2L,0L,1L,4L,6L,0L,3L,7L,0L,2L,3L,5L,8L,1L,0L,9L,6L,6L,9L,0L,2L,7L,3L,4L,1L,0L,5L,8L,2L,0L,2L,4L,4L,4L,1L,9L,5L,1L,0L,1L,5L,2L,2L,2L,1L,9L,5L,8L,7L,9L,8L,8L,1L,1L,1L,4L,5L,4L,4L,9L,7L,0L,2L,3L,0L,4L,1L,2L,0L,2L,4L,6L,9L,6L,5L,7L,3L,3L,7L,8L,4L,4L,6L,2L,1L,6L,9L,9L,3L,2L,3L,2L,9L,8L,3L,6L,4L,2L,4L,4L,3L,3L,3L,0L,0L,7L,2L,7L,6L,8L,8L };
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
public class A188722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188722Inst : IEnumerable<long>
{
public static readonly long[] Value=A188722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188722.Bytes);
public long this[int i]=>Value[i];

public static A188722Inst Instance=new A188722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188723
{
public static readonly long[] Value={ 3L,2L,3L,4L,2L,3L,1L,1L,105L,1L,2L,1L,13L,5L,16L,1L,44L,1L,1L,4L,2L,1L,2L,3L,100L,4L,1L,1L,18L,4L,2L,2L,2L,8L,2L,5L,2L,2L,3L,7L,184L,1L,8L,6L,2L,6L,2L,1L,5L,1L,38L,1L,2L,1L,1L,1L,4L,2L,6L,2L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,2L,1L,2L,3L,8L,1L,1L,2L,1L,3L,1L,2L,1L,10L,1L,6L,1L,3L,1L,1L,1L,1L,2L,2L,1L,7L,1L,11L,1L,6L,1L,2L,13L,35L,1L,5L,2L,2L,1L,1L,2L,8L,2L,6L,2L,3L,1L,1L,2L,5L };
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
public class A188723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188723Inst : IEnumerable<long>
{
public static readonly long[] Value=A188723.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188723.Bytes);
public long this[int i]=>Value[i];

public static A188723Inst Instance=new A188723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188724
{
public static readonly long[] Value={ 2L,0L,5L,6L,9L,5L,2L,4L,3L,8L,7L,1L,0L,9L,6L,5L,9L,0L,9L,3L,9L,6L,7L,8L,7L,9L,2L,4L,3L,7L,8L,8L,0L,7L,2L,5L,8L,5L,8L,8L,0L,9L,9L,1L,4L,1L,5L,4L,9L,7L,1L,7L,6L,2L,0L,4L,6L,7L,6L,4L,2L,6L,8L,3L,4L,1L,6L,1L,9L,5L,6L,5L,7L,6L,0L,3L,4L,1L,7L,4L,6L,1L,3L,2L,2L,1L,8L,2L,6L,6L,1L,4L,5L,7L,6L,5L,0L,2L,1L,5L,1L,8L,9L,6L,9L,9L,2L,5L,3L,9L,6L,2L,4L,2L,1L,0L,6L,6L,2L,4L,8L,0L,9L,8L,2L,4L,8L,8L,4L,2L };
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
public class A188724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188724Inst : IEnumerable<long>
{
public static readonly long[] Value=A188724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188724.Bytes);
public long this[int i]=>Value[i];

public static A188724Inst Instance=new A188724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188725
{
public static readonly long[] Value={ 6L,4L,3L,8L,5L,0L,0L,9L,6L,3L,0L,6L,5L,4L,0L,8L,3L,9L,7L,2L,2L,3L,2L,3L,2L,5L,6L,3L,5L,9L,4L,6L,9L,1L,7L,2L,9L,2L,6L,2L,1L,6L,6L,5L,4L,0L,8L,1L,3L,2L,6L,1L,5L,2L,5L,6L,1L,0L,6L,5L,1L,7L,3L,2L,5L,8L,9L,5L,9L,2L,1L,2L,6L,3L,3L,4L,3L,7L,5L,1L,1L,6L,9L,3L,8L,6L,9L,6L,6L,9L,2L,7L,7L,2L,1L,5L,3L,0L,9L,8L,5L,0L,0L,3L,9L,3L,0L,2L,8L,1L,2L,1L,5L,8L,5L,8L,7L,0L,2L,3L,1L,6L,7L,6L,5L,3L,0L,9L,1L,5L };
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
public class A188725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188725Inst : IEnumerable<long>
{
public static readonly long[] Value=A188725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188725.Bytes);
public long this[int i]=>Value[i];

public static A188725Inst Instance=new A188725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188726
{
public static readonly long[] Value={ 6L,2L,3L,1L,1L,3L,2L,1L,16L,47L,1L,4L,2L,7L,1L,5L,317L,4L,1L,1L,1L,2L,13L,1L,38L,37L,1L,4L,1L,13L,1L,59L,3L,17L,1L,2L,2L,2L,5L,1L,3L,1L,3L,9L,1L,3L,4L,1L,2L,2L,1L,1L,2L,1L,23L,8L,9L,84L,1L,3L,1L,2L,1L,1L,3L,5L,5L,1L,1L,16L,1L,8L,4L,11L,1L,3L,1L,16L,4L,1L,1L,1L,1L,18L,1L,12L,1L,21L,3L,3L,1L,2L,4L,2L,10L,3L,5L,6L,1L,1L,25L,4L,10L,1L,5L,2L,1L,4L,16L,2L,5L,4L,2L,1L,4L,1L,1L,2L,1L,1L };
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
public class A188726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188726Inst : IEnumerable<long>
{
public static readonly long[] Value=A188726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188726.Bytes);
public long this[int i]=>Value[i];

public static A188726Inst Instance=new A188726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188727
{
public static readonly long[] Value={ 1L,8L,8L,8L,6L,2L,6L,2L,8L,9L,6L,4L,8L,2L,1L,6L,1L,6L,7L,0L,7L,5L,8L,1L,9L,4L,2L,5L,3L,2L,1L,7L,7L,0L,9L,2L,4L,4L,2L,4L,1L,9L,5L,2L,7L,0L,1L,1L,9L,0L,6L,0L,6L,0L,0L,9L,4L,2L,6L,4L,6L,6L,8L,8L,2L,5L,7L,9L,6L,8L,5L,5L,6L,1L,0L,1L,6L,9L,4L,5L,7L,4L,2L,8L,7L,0L,6L,2L,9L,9L,5L,7L,1L,6L,9L,2L,4L,5L,4L,1L,7L,5L,9L,0L,1L,3L,4L,9L,3L,3L,5L,7L,9L,1L,6L,1L,2L,2L,4L,6L,4L,3L,8L,9L,5L,4L,5L,0L,1L,8L };
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
public class A188727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188727Inst : IEnumerable<long>
{
public static readonly long[] Value=A188727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188727.Bytes);
public long this[int i]=>Value[i];

public static A188727Inst Instance=new A188727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188728
{
public static readonly long[] Value={ 1L,1L,7L,1L,46L,8L,30L,1L,5L,4L,2L,6L,3L,2L,5L,1L,1L,1L,3L,50L,1L,3L,1L,1L,3L,1L,45L,1L,1L,1L,4L,1L,1L,2L,8L,2L,35L,2L,1L,27L,6L,112L,1L,113L,16L,1L,11L,1L,1L,6L,1L,12L,1L,3L,2L,15L,1L,2L,1L,1L,5L,1L,16L,2L,2L,2L,1L,10L,1L,43L,1L,13L,1L,6L,1L,4L,1L,2L,1L,1L,1L,6L,1L,8L,8L,1L,6L,3L,3L,17L,3L,1L,27L,1L,11L,1L,1L,1L,1L,1L,1L,9L,7L,2L,1L,5L,5L,7L,6L,2L,1L,5L,1L,2L,1L,5L,57L,8L,2L,1L };
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
public class A188728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188728Inst : IEnumerable<long>
{
public static readonly long[] Value=A188728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188728.Bytes);
public long this[int i]=>Value[i];

public static A188728Inst Instance=new A188728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188729
{
public static readonly long[] Value={ 1L,3L,4L,4L,0L,3L,0L,6L,5L,0L,8L,9L,1L,0L,5L,5L,0L,1L,7L,9L,7L,5L,7L,7L,5L,4L,0L,2L,2L,5L,4L,8L,0L,4L,7L,6L,7L,8L,2L,8L,9L,8L,4L,9L,8L,3L,7L,7L,1L,9L,7L,9L,9L,7L,5L,3L,0L,0L,5L,3L,9L,7L,2L,4L,9L,0L,0L,4L,7L,0L,3L,9L,1L,4L,6L,2L,8L,1L,3L,4L,9L,1L,8L,7L,4L,5L,3L,9L,7L,2L,9L,1L,1L,1L,2L,4L,3L,1L,3L,7L,8L,9L,7L,9L,8L,2L,2L,5L,3L,8L,2L,5L,5L,9L,3L,4L,8L,5L,1L,4L,9L,1L,6L,1L,9L,0L,3L,2L,6L,8L };
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
public class A188729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188729Inst : IEnumerable<long>
{
public static readonly long[] Value=A188729.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188729.Bytes);
public long this[int i]=>Value[i];

public static A188729Inst Instance=new A188729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188730
{
public static readonly long[] Value={ 1L,4L,7L,7L,0L,3L,2L,9L,6L,1L,4L,2L,6L,9L,0L,0L,8L,0L,6L,2L,5L,0L,1L,4L,2L,0L,9L,8L,3L,0L,8L,0L,6L,5L,9L,1L,1L,2L,5L,9L,0L,2L,4L,0L,3L,2L,3L,2L,8L,9L,5L,7L,7L,6L,7L,5L,3L,6L,0L,7L,7L,7L,3L,4L,0L,0L,3L,3L,2L,9L,1L,9L,2L,5L,6L,5L,5L,3L,1L,7L,3L,8L,5L,7L,5L,3L,2L,6L,7L,5L,6L,3L,3L,5L,9L,6L,7L,0L,9L,6L,8L,8L,3L,7L,4L,0L,9L,6L,4L,3L,5L,8L,7L,8L,9L,1L,5L,2L,1L,2L,1L,5L,3L,7L,7L,2L,4L,2L,8L,0L };
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
public class A188730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188730Inst : IEnumerable<long>
{
public static readonly long[] Value=A188730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188730.Bytes);
public long this[int i]=>Value[i];

public static A188730Inst Instance=new A188730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188731
{
public static readonly long[] Value={ 2L,8L,5L,0L,7L,8L,1L,0L,5L,9L,3L,5L,8L,2L,1L,2L,1L,7L,1L,6L,2L,2L,0L,5L,4L,4L,1L,8L,6L,5L,5L,4L,5L,3L,3L,1L,6L,1L,3L,0L,1L,0L,5L,0L,3L,3L,1L,5L,5L,2L,5L,4L,7L,2L,1L,3L,8L,2L,3L,1L,8L,1L,5L,6L,6L,6L,7L,0L,4L,5L,6L,8L,9L,5L,4L,9L,2L,1L,9L,0L,1L,8L,5L,7L,2L,3L,3L,8L,5L,7L,5L,5L,6L,2L,4L,6L,7L,4L,9L,0L,7L,9L,2L,7L,0L,2L,9L,5L,8L,1L,2L,5L,9L,4L,9L,2L,9L,5L,8L,1L,5L,6L,1L,7L,4L,3L,6L,0L,9L,3L };
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
public class A188731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188731Inst : IEnumerable<long>
{
public static readonly long[] Value=A188731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188731.Bytes);
public long this[int i]=>Value[i];

public static A188731Inst Instance=new A188731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188748
{
public static readonly long[] Value={ 7L,49L,292L,1723L,10327L,61996L,371641L,2227333L,13350748L,80027347L,479695855L,2875358812L,17235289777L,103310698477L,619258487404L,3711920099323L,22249757087527L,133368089673676L,799426585401961L,4791872379016597L };
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
public class A188748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188748Inst : IEnumerable<long>
{
public static readonly long[] Value=A188748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188748.Bytes);
public long this[int i]=>Value[i];

public static A188748Inst Instance=new A188748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188749
{
public static readonly long[] Value={ 13L,169L,1651L,17286L,184411L,1944586L,20544154L,217243096L,2296414963L,24275369558L,256625412014L,2712870938389L,28678635692942L,303171638077403L,3204930092906176L,33880400190604953L,358161194075528039L };
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
public class A188749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188749Inst : IEnumerable<long>
{
public static readonly long[] Value=A188749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188749.Bytes);
public long this[int i]=>Value[i];

public static A188749Inst Instance=new A188749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188750
{
public static readonly BigInteger[] Value={ 24L,576L,9504L,176002L,3283906L,60714322L,1127318294L,20939826298L,388867222760L,7222456829200L,134147557893368L,2491616383146400L,46278849344155436L,859576817744096818L,15965664732975667282UL,BigInteger.Parse("296544220226026744002") };
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
public class A188750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188750Inst Instance=new A188750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188751
{
public static readonly BigInteger[] Value={ 44L,1936L,52072L,1605680L,50067824L,1536573216L,47325959200L,1458401558672L,44920478350336L,1383729806664224L,42625318691202112L,1313038765458668928L,BigInteger.Parse("40447195582501099328"),BigInteger.Parse("1245947218943096747520"),BigInteger.Parse("38380504925120799720192") };
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
public class A188751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188751Inst Instance=new A188751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188752
{
public static readonly BigInteger[] Value={ 81L,6561L,289776L,15398676L,828466161L,43558358008L,2307086087740L,122293738629021L,6476421031528420L,343061756270359870L,18173221774555803823UL,BigInteger.Parse("962672885162309091074"),BigInteger.Parse("50995334218704721900811") };
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
public class A188752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188752Inst Instance=new A188752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188753
{
public static readonly BigInteger[] Value={ 149L,22201L,1617326L,148041805L,13666030547L,1229158478968L,111642244016936L,10143499802360135L,920790924506170069L,BigInteger.Parse("83620597537361329902"),BigInteger.Parse("7594234703661480583759"),BigInteger.Parse("689675447630925638390079") };
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
public class A188753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188753Inst Instance=new A188753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188754
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,37L,43L,73L,79L,151L,181L,211L,223L,241L,337L,349L,373L,379L,439L,487L,547L,577L,601L,613L,643L,769L,787L,811L,823L,883L,919L,937L,1009L,1039L,1069L,1123L,1249L,1303L,1381L,1753L,1789L,1801L,1831L,1933L,2017L,2053L,2131L,2161L,2239L,2389L,2593L,2617L,2659L,2671L,2707L,2791L,2917L,2953L };
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
public class A188754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188754Inst : IEnumerable<long>
{
public static readonly long[] Value=A188754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188754.Bytes);
public long this[int i]=>Value[i];

public static A188754Inst Instance=new A188754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188755
{
public static readonly long[] Value={ 10267951L,38248981L,39547171L,54637831L,123771511L,264350521L,284166877L,317712877L,585281791L,842220289L,1480849831L,2144961253L,2385076987L,3256366051L,3363763231L,3383477191L,3637831753L,4042578403L,5541525331L };
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
public class A188755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188755Inst : IEnumerable<long>
{
public static readonly long[] Value=A188755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188755.Bytes);
public long this[int i]=>Value[i];

public static A188755Inst Instance=new A188755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188756
{
public static readonly BigInteger[] Value={ 2L,16L,240L,8024L,532168L,75643222L,23051042448L,15452387615952L,22950235913333896L,BigInteger.Parse("76154002726353974190"),BigInteger.Parse("566628641478740667189960"),BigInteger.Parse("9481314346965748016023712242"),BigInteger.Parse("357341446119863197891865122035480") };
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
public class A188756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188756Inst Instance=new A188756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188757
{
public static readonly long[] Value={ 7L,49L,240L,1112L,4792L,20129L,82807L,337209L,1363568L,5492088L,22063552L,88498657L,354619079L,1420087393L,5684504432L,22748788280L,91023096360L,364165082465L,1456849628855L,5827892187561L,23312857086192L,93254793361944L };
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
public class A188757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188757Inst : IEnumerable<long>
{
public static readonly long[] Value=A188757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188757.Bytes);
public long this[int i]=>Value[i];

public static A188757Inst Instance=new A188757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188758
{
public static readonly long[] Value={ 12L,144L,1112L,8024L,53024L,339927L,2125134L,13128024L,80418708L,490332106L,2980442190L,18082824827L,109579150934L,663532220578L,4015904399274L,24297890544570L,146982319288138L,889004822816985L,5376572830392848L };
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
public class A188758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188758Inst : IEnumerable<long>
{
public static readonly long[] Value=A188758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188758.Bytes);
public long this[int i]=>Value[i];

public static A188758Inst Instance=new A188758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188759
{
public static readonly long[] Value={ 20L,400L,4792L,53024L,532168L,5163989L,48759352L,454436200L,4196906454L,38563523452L,353149127960L,3227401734383L,29455645703492L,268607915360488L,2448108525665546L,22304314950595356L,203163892637966720L };
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
public class A188759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188759Inst : IEnumerable<long>
{
public static readonly long[] Value=A188759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188759.Bytes);
public long this[int i]=>Value[i];

public static A188759Inst Instance=new A188759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188760
{
public static readonly long[] Value={ 33L,1089L,20129L,339927L,5163989L,75643222L,1076278662L,15104206828L,209938880964L,2902462402332L,39984970277418L,549661931523107L,7545440863028881L,103487881710317937L,1418545619416264861L };
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
public class A188760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188760Inst : IEnumerable<long>
{
public static readonly long[] Value=A188760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188760.Bytes);
public long this[int i]=>Value[i];

public static A188760Inst Instance=new A188760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188761
{
public static readonly BigInteger[] Value={ 54L,2916L,82807L,2125134L,48759352L,1076278662L,23051042448L,486675087796L,10173867472000L,211512633571598L,4381259021867922L,90552637913884195L,1868853564303970702L,BigInteger.Parse("38534809875015493620"),BigInteger.Parse("794094746915798233015") };
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
public class A188761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188761Inst Instance=new A188761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188762
{
public static readonly BigInteger[] Value={ 88L,7744L,337209L,13128024L,454436200L,15104206828L,486675087796L,15452387615952L,485691897312770L,15180400491179444L,472703941058052104L,14686500873806680089UL,BigInteger.Parse("455626112297181852684"),BigInteger.Parse("14121996559127763001844") };
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
public class A188762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188762Inst Instance=new A188762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188763
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,20L,144L,240L,144L,20L,33L,400L,1112L,1112L,400L,33L,54L,1089L,4792L,8024L,4792L,1089L,54L,88L,2916L,20129L,53024L,53024L,20129L,2916L,88L,143L,7744L,82807L,339927L,532168L,339927L,82807L,7744L,143L,232L,20449L,337209L,2125134L };
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
public class A188763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188763Inst : IEnumerable<long>
{
public static readonly long[] Value=A188763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188763.Bytes);
public long this[int i]=>Value[i];

public static A188763Inst Instance=new A188763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188780
{
public static readonly long[] Value={ 0L,0L,8L,584L,5464L,26360L,91120L,252720L,603696L,1288592L,2525400L,4620728L,7998984L,13219528L,21014336L,32306400L,48256608L,70282656L,100115880L,139819944L,191858360L,259112216L,344959120L,453289232L,588596368L,755991600L };
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
public class A188780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188780Inst : IEnumerable<long>
{
public static readonly long[] Value=A188780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188780.Bytes);
public long this[int i]=>Value[i];

public static A188780Inst Instance=new A188780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188781
{
public static readonly long[] Value={ 0L,0L,0L,840L,15824L,112680L,516160L,1778608L,5082912L,12622640L,28225472L,58013112L,111476080L,202472856L,350897664L,584067552L,939135552L,1464903648L,2225144448L,3300867240L,4794722064L,6833735304L,9574980800L,13208790672L };
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
public class A188781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188781Inst : IEnumerable<long>
{
public static readonly long[] Value=A188781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188781.Bytes);
public long this[int i]=>Value[i];

public static A188781Inst Instance=new A188781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188782
{
public static readonly long[] Value={ 0L,0L,0L,784L,40496L,451104L,2803552L,12139552L,41792672L,121269248L,310362944L,718151344L,1534460624L,3067048224L,5801302304L,10464095808L,18125622336L,30299632896L,49104515712L,77410664016L,119081302128L,179178580768L };
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
public class A188782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188782Inst : IEnumerable<long>
{
public static readonly long[] Value=A188782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188782.Bytes);
public long this[int i]=>Value[i];

public static A188782Inst Instance=new A188782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188783
{
public static readonly long[] Value={ 0L,0L,0L,384L,88264L,1665344L,14497784L,80088992L,335122320L,1142391712L,3358831216L,8772323808L,20882774744L,46000760736L,95075730152L,186010966464L,347367851808L,622687135680L,1077266143968L,1805545001664L,2942598571752L };
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
public class A188783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188783Inst : IEnumerable<long>
{
public static readonly long[] Value=A188783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188783.Bytes);
public long this[int i]=>Value[i];

public static A188783Inst Instance=new A188783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188784
{
public static readonly long[] Value={ 1L,16L,0L,81L,64L,0L,256L,432L,192L,0L,625L,1536L,1944L,576L,0L,1296L,4000L,7936L,8928L,1536L,0L,2401L,8640L,22200L,41984L,39408L,4224L,0L,4096L,16464L,50112L,125840L,217728L,174720L,9984L,0L,6561L,28672L,98392L,296064L,702904L,1141248L,748128L };
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
public class A188784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188784Inst : IEnumerable<long>
{
public static readonly long[] Value=A188784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188784.Bytes);
public long this[int i]=>Value[i];

public static A188784Inst Instance=new A188784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188785
{
public static readonly long[] Value={ 0L,64L,432L,1536L,4000L,8640L,16464L,28672L,46656L,72000L,106480L,152064L,210912L,285376L,378000L,491520L,628864L,793152L,987696L,1216000L,1481760L,1788864L,2141392L,2543616L,3000000L,3515200L,4094064L,4741632L,5463136L,6264000L,7149840L };
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
public class A188785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188785Inst : IEnumerable<long>
{
public static readonly long[] Value=A188785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188785.Bytes);
public long this[int i]=>Value[i];

public static A188785Inst Instance=new A188785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188786
{
public static readonly long[] Value={ 0L,192L,1944L,7936L,22200L,50112L,98392L,175104L,289656L,452800L,676632L,974592L,1361464L,1853376L,2467800L,3223552L,4140792L,5241024L,6547096L,8083200L,9874872L,11948992L,14333784L,17058816L,20155000L,23654592L,27591192L,31999744L,36916536L };
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
public class A188786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188786Inst : IEnumerable<long>
{
public static readonly long[] Value=A188786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188786.Bytes);
public long this[int i]=>Value[i];

public static A188786Inst Instance=new A188786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188787
{
public static readonly long[] Value={ 0L,576L,8928L,41984L,125840L,296064L,597632L,1084928L,1821744L,2881280L,4346144L,6308352L,8869328L,12139904L,16240320L,21300224L,27458672L,34864128L,43674464L,54056960L,66188304L,80254592L,96451328L,114983424L,136065200L,159920384L };
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
public class A188787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188787Inst : IEnumerable<long>
{
public static readonly long[] Value=A188787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188787.Bytes);
public long this[int i]=>Value[i];

public static A188787Inst Instance=new A188787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188788
{
public static readonly long[] Value={ 0L,1536L,39408L,217728L,702904L,1726080L,3583320L,6635392L,11307768L,18090624L,27538840L,40272000L,56974392L,78395008L,105347544L,138710400L,179426680L,228504192L,287015448L,356097664L,436952760L,530847360L,639112792L,763145088L };
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
public class A188788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188788Inst : IEnumerable<long>
{
public static readonly long[] Value=A188788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188788.Bytes);
public long this[int i]=>Value[i];

public static A188788Inst Instance=new A188788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188789
{
public static readonly long[] Value={ 0L,4224L,174720L,1141248L,3974784L,10183872L,21725776L,41004288L,70869216L,114616384L,175987632L,259170816L,368799808L,509954496L,688160784L,909390592L,1180061856L,1507038528L,1897630576L,2359593984L,2901130752L,3530888896L };
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
public class A188789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188789Inst : IEnumerable<long>
{
public static readonly long[] Value=A188789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188789.Bytes);
public long this[int i]=>Value[i];

public static A188789Inst Instance=new A188789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188790
{
public static readonly long[] Value={ 0L,9984L,748128L,5886720L,22274448L,59693952L,130988744L,252065024L,441881832L,722450048L,1118832392L,1659143424L,2374549544L,3299268992L,4470571848L,5928780032L,7717267304L,9882459264L,12473833352L,15543918848L,19148296872L };
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
public class A188790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188790Inst : IEnumerable<long>
{
public static readonly long[] Value=A188790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188790.Bytes);
public long this[int i]=>Value[i];

public static A188790Inst Instance=new A188790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188791
{
public static readonly long[] Value={ 0L,24576L,3203232L,30437760L,125478336L,352052352L,794632800L,1558721152L,2770757712L,4578094656L,7148994304L,10672629120L,15359081712L,21439344832L,29165321376L,38809824384L,50666577040L,65050212672L,82296274752L };
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
public class A188791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188791Inst : IEnumerable<long>
{
public static readonly long[] Value=A188791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188791.Bytes);
public long this[int i]=>Value[i];

public static A188791Inst Instance=new A188791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188792
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,8L,3L,2L,5L,16L,18L,8L,5L,5L,45L,57L,56L,25L,15L,15L,84L,220L,213L,203L,90L,52L,15L,235L,583L,1005L,909L,826L,364L,203L,52L,402L,1965L,3358L,4914L,4247L,3708L,1624L,877L,52L,1190L,4737L,13250L,19340L,25735L,21511L,18127L,7893L,4140L,203L,2020L };
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
public class A188792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188792Inst : IEnumerable<long>
{
public static readonly long[] Value=A188792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188792.Bytes);
public long this[int i]=>Value[i];

public static A188792Inst Instance=new A188792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188793
{
public static readonly long[] Value={ 1L,5L,7L,9L,11L,29L,31L,89L,91L,269L,271L,809L,811L,2429L,2431L,7289L,7291L,21869L,21871L,65609L,65611L,196829L,196831L,590489L,590491L,1771469L,1771471L,5314409L,5314411L,15943229L,15943231L,47829689L,47829691L,143489069L,143489071L,430467209L,430467211L };
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
public class A188793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188793Inst : IEnumerable<long>
{
public static readonly long[] Value=A188793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188793.Bytes);
public long this[int i]=>Value[i];

public static A188793Inst Instance=new A188793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188794
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,2L,5L,2L,3L,4L,2L,2L,3L,2L,3L,2L,5L,4L,2L,2L,3L,4L,2L,2L,3L,2L,3L,2L,2L,3L,7L,2L,3L,4L,2L,2L,5L,2L,3L,2L,3L,4L,2L,2L,3L,4L,5L,2L,2L,4L,3L,2L,2L,2L,3L,2L,3L,4L,2L,6L,2L,2L,3L,2L,3L,4L,5L,2L,3L,4L,2L,2L,7L,2L,3L,4L,5L,6L,2L,2L,3L,4L,2L,2L,3L,8L,5L,2L,2L,3L,4L,2L,3L,2L,3L,2L };
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
public class A188794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188794Inst : IEnumerable<long>
{
public static readonly long[] Value=A188794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188794.Bytes);
public long this[int i]=>Value[i];

public static A188794Inst Instance=new A188794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188795
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,3L,1L,2L,2L,3L,2L,1L,1L,1L,1L,1L,1L,4L,2L,2L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L };
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
public class A188795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188795Inst : IEnumerable<long>
{
public static readonly long[] Value=A188795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188795.Bytes);
public long this[int i]=>Value[i];

public static A188795Inst Instance=new A188795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188812
{
public static readonly long[] Value={ 9L,272L,25904L,7114752L,4566151168L };
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
public class A188812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188812Inst : IEnumerable<long>
{
public static readonly long[] Value=A188812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188812.Bytes);
public long this[int i]=>Value[i];

public static A188812Inst Instance=new A188812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188813
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,2L,9L,20L,20L,9L,44L,272L,448L,272L,44L,265L,6032L,25904L,25904L,6032L,265L,1854L,205312L,2952608L,7114752L,2952608L,205312L,1854L,14833L,9672448L,596917696L,4566151168L,4566151168L,596917696L,9672448L,14833L,133496L,601903360L };
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
public class A188813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188813Inst : IEnumerable<long>
{
public static readonly long[] Value=A188813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188813.Bytes);
public long this[int i]=>Value[i];

public static A188813Inst Instance=new A188813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188814
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,12L,27L,57L,107L,192L,327L,538L,855L,1329L,2018L,3003L,4402L,6349L,9045L,12720L,17713L,24395L,33335L,45118L,60655L,80888L,107242L,141177L,184905L,240679L,311850L,401860L,515725L,658630L,838006L,1061561L,1340193L,1685271L,2112576L,2638727L };
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
public class A188814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188814Inst : IEnumerable<long>
{
public static readonly long[] Value=A188814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188814.Bytes);
public long this[int i]=>Value[i];

public static A188814Inst Instance=new A188814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188815
{
public static readonly long[] Value={ 3L,5L,2L,19L,97L,23L,31L,73L,67L,347L,89L,109L,199L,83L,281L,631L,233L,607L,131L,421L,727L,1103L,743L,353L,577L,907L,307L,641L,433L,1237L,251L,389L,271L,829L,593L,449L,1879L,487L,331L,3109L,1609L,3257L,1907L,383L,2357L,1987L,3163L,443L,2719L,683L,1861L,6211L,719L,2251L,769L,3943L,5647L,2437L,4153L,3371L,563L,877L,3677L,929L,937L };
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
public class A188815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188815Inst : IEnumerable<long>
{
public static readonly long[] Value=A188815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188815.Bytes);
public long this[int i]=>Value[i];

public static A188815Inst Instance=new A188815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188816
{
public static readonly long[] Value={ 1L,0L,1L,2L,-1L,0L,0L,1L,-3L,6L,-2L,9L,-6L,1L,0L,0L,0L,1L,4L,-12L,12L,-3L,-44L,60L,-24L,3L,64L,-48L,12L,-1L,0L,0L,0L,0L,1L,-5L,20L,-30L,20L,-4L,155L,-300L,210L,-60L,6L,-655L,780L,-330L,60L,-4L,625L };
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
public class A188816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188816Inst : IEnumerable<long>
{
public static readonly long[] Value=A188816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188816.Bytes);
public long this[int i]=>Value[i];

public static A188816Inst Instance=new A188816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188817
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,2L,2L,1L,2L,3L,2L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,2L,2L,1L,2L,3L,3L,3L,2L,2L,2L,3L,3L,3L,2L,3L,4L,3L,3L,3L,4L,4L,4L,3L,3L,3L,4L,3L,3L,3L,2L,3L,3L,4L,3L,3L,3L,3L,3L,4L,3L,3L,3L,4L,5L,5L,5L,4L,4L,3L,4L,4L,4L,4L,5L,4L,4L,4L,4L,3L,4L,4L,3L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,6L,6L,6L,6L,6L,5L,5L,5L,5L,4L,4L,3L,3L,3L,4L,3L,3L,2L };
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
public class A188817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188817Inst : IEnumerable<long>
{
public static readonly long[] Value=A188817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188817.Bytes);
public long this[int i]=>Value[i];

public static A188817Inst Instance=new A188817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188818
{
public static readonly long[] Value={ 2L,9L,48L,256L,1360L,7056L,36000L,179776L,884256L,4276624L,20432608L,96353856L,449990080L,2080089664L,9540782208L,43403888896L,196212020800L,881112632976L,3936117388896L,17487049789504L,77350773736512L,340574032803904L };
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
public class A188818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188818Inst : IEnumerable<long>
{
public static readonly long[] Value=A188818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188818.Bytes);
public long this[int i]=>Value[i];

public static A188818Inst Instance=new A188818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188819
{
public static readonly long[] Value={ 8L,25L,48L,81L,120L,169L,224L,289L,360L,441L,528L,625L,728L,841L,960L,1089L,1224L,1369L,1520L,1681L,1848L,2025L,2208L,2401L,2600L,2809L,3024L,3249L,3480L,3721L,3968L,4225L,4488L,4761L,5040L,5329L,5624L,5929L,6240L,6561L,6888L,7225L,7568L,7921L,8280L,8649L };
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
public class A188819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188819Inst : IEnumerable<long>
{
public static readonly long[] Value=A188819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188819.Bytes);
public long this[int i]=>Value[i];

public static A188819Inst Instance=new A188819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188820
{
public static readonly long[] Value={ 32L,169L,432L,841L,1360L,2025L,2800L,3721L,4752L,5929L,7216L,8649L,10192L,11881L,13680L,15625L,17680L,19881L,22192L,24649L,27216L,29929L,32752L,35721L,38800L,42025L,45360L,48841L,52432L,56169L,60016L,64009L,68112L,72361L,76720L,81225L,85840L,90601L };
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
public class A188820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188820Inst : IEnumerable<long>
{
public static readonly long[] Value=A188820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188820.Bytes);
public long this[int i]=>Value[i];

public static A188820Inst Instance=new A188820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188821
{
public static readonly long[] Value={ 64L,441L,1296L,2704L,4624L,7056L,10000L,13456L,17424L,21904L,26896L,32400L,38416L,44944L,51984L,59536L,67600L,76176L,85264L,94864L,104976L,115600L,126736L,138384L,150544L,163216L,176400L,190096L,204304L,219024L,234256L,250000L,266256L,283024L };
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
public class A188821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188821Inst : IEnumerable<long>
{
public static readonly long[] Value=A188821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188821.Bytes);
public long this[int i]=>Value[i];

public static A188821Inst Instance=new A188821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188822
{
public static readonly long[] Value={ 128L,1156L,3888L,8836L,15776L,24964L,36000L,49284L,64416L,81796L,101024L,122500L,145824L,171396L,198816L,228484L,260000L,293764L,329376L,367236L,406944L,448900L,492704L,538756L,586656L,636804L,688800L,743044L,799136L,857476L,917664L,980100L };
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
public class A188822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188822Inst : IEnumerable<long>
{
public static readonly long[] Value=A188822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188822.Bytes);
public long this[int i]=>Value[i];

public static A188822Inst Instance=new A188822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188823
{
public static readonly long[] Value={ 256L,3025L,11664L,28561L,53824L,87616L,129600L,179776L,238144L,304704L,379456L,462400L,553536L,652864L,760384L,876096L,1000000L,1132096L,1272384L,1420864L,1577536L,1742400L,1915456L,2096704L,2286144L,2483776L,2689600L,2903616L,3125824L };
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
public class A188823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188823Inst : IEnumerable<long>
{
public static readonly long[] Value=A188823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188823.Bytes);
public long this[int i]=>Value[i];

public static A188823Inst Instance=new A188823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188824
{
public static readonly long[] Value={ 2L,4L,4L,8L,9L,8L,16L,25L,16L,16L,32L,64L,48L,25L,32L,64L,169L,144L,81L,36L,64L,128L,441L,432L,256L,120L,49L,128L,256L,1156L,1296L,841L,400L,169L,64L,256L,512L,3025L,3888L,2704L,1360L,576L,224L,81L,512L,1024L,7921L,11664L,8836L,4624L,2025L,784L,289L,100L,1024L,2048L };
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
public class A188824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188824Inst : IEnumerable<long>
{
public static readonly long[] Value=A188824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188824.Bytes);
public long this[int i]=>Value[i];

public static A188824Inst Instance=new A188824Inst();

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