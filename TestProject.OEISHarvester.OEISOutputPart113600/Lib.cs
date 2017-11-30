using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A268544
{
public static readonly long[] Value={ 17L,73L,77L,103L,107L,112L,113L,114L,115L,116L,121L,125L,128L,129L,133L,137L,143L,147L,153L,157L,163L,167L,170L,172L,174L,176L,181L,185L,188L,189L,191L,195L,198L,199L };
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
public class A268544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268544Inst : IEnumerable<long>
{
public static readonly long[] Value=A268544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268544.Bytes);
public long this[int i]=>Value[i];

public static A268544Inst Instance=new A268544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268545
{
public static readonly BigInteger[] Value={ 1L,10L,246L,7540L,255430L,9163980L,341237820L,13042646760L,508236930630L,20101587623260L,804500381097556L,32508382071448920L,1324112273705453596L,BigInteger.Parse("54296281503438398200"),BigInteger.Parse("2239266766596344681400"),BigInteger.Parse("92809720054802928741840"),BigInteger.Parse("3863305447624183692730950"),BigInteger.Parse("161427619265399264526790140") };
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
public class A268545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268545Inst Instance=new A268545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268546
{
public static readonly BigInteger[] Value={ 1L,42L,4878L,748020L,130916310L,24762428460L,4929691760532L,1017691904736936L,215868481746244470L,BigInteger.Parse("46762158493003813860"),BigInteger.Parse("10301263206399347906724"),BigInteger.Parse("2300606339065015587232536"),BigInteger.Parse("519698719167846252879954564"),BigInteger.Parse("118536490001488475468485495800") };
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
public class A268546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268546Inst Instance=new A268546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268547
{
public static readonly long[] Value={ 1L,214L,97278L,53983020L,32898451110L,21172639875156L,14121624413802444L };
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
public class A268547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268547Inst : IEnumerable<long>
{
public static readonly long[] Value=A268547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268547.Bytes);
public long this[int i]=>Value[i];

public static A268547Inst Instance=new A268547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268660
{
public static readonly long[] Value={ 2L,5L,8L,41L,209L,353L,2816L,20909L,42665L,157169L,213321L,303093L,362765L,382449L,2145353L,2478785L };
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
public class A268660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268660Inst : IEnumerable<long>
{
public static readonly long[] Value=A268660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268660.Bytes);
public long this[int i]=>Value[i];

public static A268660Inst Instance=new A268660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268661
{
public static readonly long[] Value={ 3L,55L,127L,13165L,240937L,819739L,1282755L };
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
public class A268661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268661Inst : IEnumerable<long>
{
public static readonly long[] Value=A268661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268661.Bytes);
public long this[int i]=>Value[i];

public static A268661Inst Instance=new A268661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268662
{
public static readonly long[] Value={ 7L,15L,25L,39L,55L,75L,85L,127L,1947L,3313L,13165L,23473L,125413L,1282755L,1777515L };
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
public class A268662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268662Inst : IEnumerable<long>
{
public static readonly long[] Value=A268662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268662.Bytes);
public long this[int i]=>Value[i];

public static A268662Inst Instance=new A268662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268663
{
public static readonly long[] Value={ 127L,4687L,1777515L };
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
public class A268663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268663Inst : IEnumerable<long>
{
public static readonly long[] Value=A268663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268663.Bytes);
public long this[int i]=>Value[i];

public static A268663Inst Instance=new A268663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268664
{
public static readonly long[] Value={ 13L,15L,127L,5947L,26607L,1320487L };
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
public class A268664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268664Inst : IEnumerable<long>
{
public static readonly long[] Value=A268664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268664.Bytes);
public long this[int i]=>Value[i];

public static A268664Inst Instance=new A268664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268665
{
public static readonly long[] Value={ 6L,9L,22L,26L,44L,52L,73L,111L,122L,164L,201L,214L,254L,311L,374L,398L,465L,521L,542L,617L,684L,774L,899L,969L,1005L,1064L,1100L,1181L,1441L,1548L,1658L,1694L,1918L,1977L,2114L,2255L,2376L,2537L,2684L,2727L,3019L,3068L,3181L,3238L,3611L,3985L,4114L,4182L,4313L };
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
public class A268665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268665Inst : IEnumerable<long>
{
public static readonly long[] Value=A268665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268665.Bytes);
public long this[int i]=>Value[i];

public static A268665Inst Instance=new A268665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268666
{
public static readonly long[] Value={ 1L,2L,8L,64L,646L,9364L,151028L };
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
public class A268666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268666Inst : IEnumerable<long>
{
public static readonly long[] Value=A268666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268666.Bytes);
public long this[int i]=>Value[i];

public static A268666Inst Instance=new A268666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268667
{
public static readonly BigInteger[] Value={ 1L,1L,2L,26L,3511L,6742796L,233249911607L,175703195017370516L,BigInteger.Parse("3377940832101159287907151"),BigInteger.Parse("1899957346851645870857879683505890"),BigInteger.Parse("35246706696124014829643459097288501560957174"),BigInteger.Parse("23998872279553738609365779286317516184675391844037227392") };
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
public class A268667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268667Inst Instance=new A268667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268668
{
public static readonly long[] Value={ 1L,1L,3L,23L,465L,19834L,1532489L,193746632L,37368959742L,10437763731100L };
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
public class A268668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268668Inst : IEnumerable<long>
{
public static readonly long[] Value=A268668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268668.Bytes);
public long this[int i]=>Value[i];

public static A268668Inst Instance=new A268668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268669
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,7L,8L,7L,2L,11L,4L,13L,14L,1L,16L,1L,14L,19L,4L,21L,22L,13L,8L,25L,26L,7L,28L,11L,2L,31L,32L,31L,2L,35L,28L,37L,38L,11L,8L,41L,42L,25L,44L,7L,26L,47L,16L,49L,50L,1L,52L,19L,14L,55L,56L,13L,22L,59L,4L,61L,62L,21L,64L,21L,62L,67L,4L,69L,70L,61L,56L,73L,74L,13L,76L,59L,22L,79L,16L,81L,82L,49L,84L,1L };
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
public class A268669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268669Inst : IEnumerable<long>
{
public static readonly long[] Value=A268669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268669.Bytes);
public long this[int i]=>Value[i];

public static A268669Inst Instance=new A268669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268670
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,3L,5L,15L,5L,3L,13L,7L,9L,11L,1L,31L,1L,11L,29L,7L,25L,27L,9L,15L,17L,19L,5L,23L,13L,3L,21L,63L,21L,3L,61L,23L,57L,59L,13L,15L,49L,51L,17L,55L,5L,19L,53L,31L,33L,35L,1L,39L,29L,11L,37L,47L,9L,27L,45L,7L,41L,43L,25L,127L,25L,43L,125L,7L,121L,123L,41L,47L,113L,115L,9L,119L,45L,27L,117L,31L,97L,99L,33L,103L,1L };
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
public class A268670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268670Inst : IEnumerable<long>
{
public static readonly long[] Value=A268670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268670.Bytes);
public long this[int i]=>Value[i];

public static A268670Inst Instance=new A268670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268671
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,3L,8L,3L,2L,7L,4L,5L,6L,1L,16L,1L,6L,15L,4L,13L,14L,5L,8L,9L,10L,3L,12L,7L,2L,11L,32L,11L,2L,31L,12L,29L,30L,7L,8L,25L,26L,9L,28L,3L,10L,27L,16L,17L,18L,1L,20L,15L,6L,19L,24L,5L,14L,23L,4L,21L,22L,13L,64L,13L,22L,63L,4L,61L,62L,21L,24L,57L,58L,5L,60L,23L,14L,59L,16L,49L,50L,17L,52L,1L };
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
public class A268671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268671Inst : IEnumerable<long>
{
public static readonly long[] Value=A268671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268671.Bytes);
public long this[int i]=>Value[i];

public static A268671Inst Instance=new A268671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268672
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,2L,3L,4L,4L,3L,4L,4L,5L,6L,4L,5L,2L,2L,3L,2L,3L,4L,4L,4L,5L,6L,5L,6L,6L,4L,5L,6L,6L,3L,4L,4L,5L,6L,5L,4L,5L,6L,6L,7L,5L,5L,6L,6L,7L,8L,4L,5L,5L,4L,5L,6L,5L,5L,6L,4L,5L,6L,6L,7L,6L,6L,7L,4L,5L,6L,6L,6L,7L,8L,6L,7L,7L,6L,7L,6L,7L,8L,8L,9L,4L,4L,5L,6L,6L,4L,5L,5L,6L,7L,6L,6L,7L,8L,7L,8L,8L,4L,5L,6L,4L,4L,5L,4L,5L,6L,6L,7L,7L,6L,7L,7L,8L,9L,6L,4L };
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
public class A268672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268672Inst : IEnumerable<long>
{
public static readonly long[] Value=A268672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268672.Bytes);
public long this[int i]=>Value[i];

public static A268672Inst Instance=new A268672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268673
{
public static readonly long[] Value={ 0L,1L,5L,29L,45L,53L,77L,85L,101L,125L,141L,149L,165L,189L,197L,221L,237L,245L,269L,277L,293L,317L,325L,349L,365L,373L,389L,413L,429L,437L,461L,469L,485L,509L,525L,533L,549L,573L,581L,605L,621L,629L,645L,669L,685L,693L,717L,725L,741L,765L,773L,797L,813L,821L,845L,853L,869L,893L,909L,917L,933L,957L,965L,989L,1005L };
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
public class A268673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268673Inst : IEnumerable<long>
{
public static readonly long[] Value=A268673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268673.Bytes);
public long this[int i]=>Value[i];

public static A268673Inst Instance=new A268673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268674
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,5L,1L,4L,3L,7L,2L,11L,5L,6L,1L,13L,4L,17L,3L,8L,7L,19L,2L,9L,11L,10L,5L,23L,6L,29L,1L,12L,13L,15L,4L,31L,17L,14L,3L,37L,8L,41L,7L,16L,19L,43L,2L,25L,9L,18L,11L,47L,10L,21L,5L,20L,23L,53L,6L,59L,29L,22L,1L,27L,12L,61L,13L,24L,15L,67L,4L,71L,31L,26L,17L,35L,14L,73L,3L,28L,37L,79L,8L,33L,41L,30L,7L };
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
public class A268674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268674Inst : IEnumerable<long>
{
public static readonly long[] Value=A268674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268674.Bytes);
public long this[int i]=>Value[i];

public static A268674Inst Instance=new A268674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268675
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,6L,7L,4L,21L,10L,11L,24L,13L,14L,15L,32L,17L,42L,19L,40L,9L,22L,23L,12L,55L,26L,27L,56L,29L,30L,31L,16L,69L,34L,35L,168L,37L,38L,39L,20L,41L,18L,43L,88L,93L,46L,47L,96L,91L,110L,123L,104L,53L,54L,25L,28L,117L,58L,59L,120L,61L,62L,63L,64L,65L,138L,67L,136L,33L,70L,71L,84L,73L,74L,75L,152L,77L,78L,79L,160L };
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
public class A268675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268675Inst : IEnumerable<long>
{
public static readonly long[] Value=A268675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268675.Bytes);
public long this[int i]=>Value[i];

public static A268675Inst Instance=new A268675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268724
{
public static readonly long[] Value={ 1L,3L,3L,2L,9L,2L,7L,6L,6L,7L,6L,21L,4L,21L,6L,4L,18L,14L,14L,18L,4L,5L,12L,12L,49L,12L,12L,5L,15L,15L,8L,42L,42L,8L,15L,15L,14L,45L,10L,28L,36L,28L,10L,45L,14L,12L,42L,30L,35L,24L,24L,35L,30L,42L,12L,13L,36L,28L,105L,30L,16L,30L,105L,28L,36L,13L,8L,39L,24L,98L,90L,20L,20L,90L,98L,24L,39L,8L,9L,24L,26L,84L,84L,60L,25L,60L,84L,84L,26L,24L,9L };
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
public class A268724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268724Inst : IEnumerable<long>
{
public static readonly long[] Value=A268724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268724.Bytes);
public long this[int i]=>Value[i];

public static A268724Inst Instance=new A268724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268725
{
public static readonly long[] Value={ 1L,2L,2L,3L,13L,3L,4L,5L,5L,4L,5L,31L,6L,31L,5L,6L,27L,9L,9L,27L,6L,7L,10L,10L,41L,10L,10L,7L,8L,8L,12L,63L,63L,12L,8L,8L,9L,59L,15L,18L,54L,18L,15L,59L,9L,10L,63L,17L,50L,20L,20L,50L,17L,63L,10L,11L,54L,18L,93L,17L,24L,17L,93L,18L,54L,11L,12L,52L,20L,83L,119L,30L,30L,119L,83L,20L,52L,12L,13L,20L,23L,126L,126L,34L,21L,34L,126L,126L,23L,20L,13L };
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
public class A268725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268725Inst : IEnumerable<long>
{
public static readonly long[] Value=A268725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268725.Bytes);
public long this[int i]=>Value[i];

public static A268725Inst Instance=new A268725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268726
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,6L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,7L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L };
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
public class A268726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268726Inst : IEnumerable<long>
{
public static readonly long[] Value=A268726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268726.Bytes);
public long this[int i]=>Value[i];

public static A268726Inst Instance=new A268726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268727
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,7L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,8L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L };
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
public class A268727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268727Inst : IEnumerable<long>
{
public static readonly long[] Value=A268727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268727.Bytes);
public long this[int i]=>Value[i];

public static A268727Inst Instance=new A268727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268728
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,7L,0L,0L,0L,4L,3L,0L,1L,0L,13L,3L,0L,2L,0L,0L,14L,0L,0L,0L,0L,1L,0L,11L,1L,0L,2L,4L,0L,1L,0L,8L,1L,0L,1L,7L,7L,2L,1L,0L,25L,0L,0L,1L,0L,0L,7L,0L,0L,0L,26L,3L,0L,6L,15L,5L,4L,0L,0L,1L,0L,31L,3L,0L,0L,10L,3L,13L,4L,0L,2L,1L,0L,28L,0L,0L,6L,0L,2L,14L,0L,6L,0L,0L,1L,0L,21L,1L,0L,1L,26L,7L,11L,4L,12L,0L,3L,0L,0L };
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
public class A268728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268728Inst : IEnumerable<long>
{
public static readonly long[] Value=A268728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268728.Bytes);
public long this[int i]=>Value[i];

public static A268728Inst Instance=new A268728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268729
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,0L,0L,7L,0L,1L,0L,3L,4L,0L,0L,2L,0L,3L,13L,0L,1L,0L,0L,0L,0L,14L,0L,1L,0L,4L,2L,0L,1L,11L,0L,1L,2L,7L,7L,1L,0L,1L,8L,0L,0L,0L,7L,0L,0L,1L,0L,0L,25L,0L,1L,0L,0L,4L,5L,15L,6L,0L,3L,26L,0L,1L,2L,0L,4L,13L,3L,10L,0L,0L,3L,31L,0L,1L,0L,0L,6L,0L,14L,2L,0L,6L,0L,0L,28L,0L,0L,0L,3L,0L,12L,4L,11L,7L,26L,1L,0L,1L,21L,0L };
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
public class A268729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268729Inst : IEnumerable<long>
{
public static readonly long[] Value=A268729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268729.Bytes);
public long this[int i]=>Value[i];

public static A268729Inst Instance=new A268729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268730
{
public static readonly BigInteger[] Value={ 10L,260L,10920L,633360L,46868640L,4218177600L,447126825600L,54549472723200L,7527827235801600L,1159285394313446400L,BigInteger.Parse("197078517033285888000"),BigInteger.Parse("36656604168191175168000"),BigInteger.Parse("7404634041974617383936000"),BigInteger.Parse("1614210221150466589698048000"),BigInteger.Parse("377725191749209181989343232000") };
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
public class A268730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268730Inst Instance=new A268730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268731
{
public static readonly long[] Value={ 1L,6L,1L,1L,1L,1L,1L,18L,1L,6L,1L,1L,16L,16L,1L,1L,1L,1L,6L,6L,1L,1L,1L,22L,1L,3L,1L,1L,1L,13L,1L,6L,6L,6L,6L,6L,6L,16L,1L,108L,1L,28L,1L,1L,1L,6L,2L,1L,1L,1L,2L,2L,6L,6L,18L,1L,18L,1L,18L,18L,53L,53L,1L,3L,3L,3L,6L,6L,6L,16L,2L,22L,2L,6L,2L,2L,6L,6L,1L,2L,2L,2L };
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
public class A268731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268731Inst : IEnumerable<long>
{
public static readonly long[] Value=A268731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268731.Bytes);
public long this[int i]=>Value[i];

public static A268731Inst Instance=new A268731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268732
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,23L,27L,31L,33L,41L,43L,47L,51L,60L,62L,70L,72L,80L,84L,88L,90L,102L,106L,110L,116L,124L,126L,134L,136L,148L,152L,156L,160L,176L,178L,182L,186L,198L,200L,208L,210L,218L,226L,230L,232L,250L,254L,262L,266L,274L,276L,288L,292L,304L,308L,312L,314L,330L };
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
public class A268732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268732Inst : IEnumerable<long>
{
public static readonly long[] Value=A268732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268732.Bytes);
public long this[int i]=>Value[i];

public static A268732Inst Instance=new A268732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268733
{
public static readonly long[] Value={ 28L,78L,248L,684L,1862L,3294L,6140L,9144L,16590L,27872L,37734L,59094L,75812L,90864L,121878L,171780L,219542L,257244L,328104L,378362L,432240L,530964L,627570L,785078L,969714L,1071512L,1157004L,1271270L,1366974L,1649024L,2145924L };
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
public class A268733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268733Inst : IEnumerable<long>
{
public static readonly long[] Value=A268733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268733.Bytes);
public long this[int i]=>Value[i];

public static A268733Inst Instance=new A268733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268734
{
public static readonly BigInteger[] Value={ 0L,4L,80L,2876L,200204L,29134076L,9039552112L,6084192150856L,8965720251221240L,BigInteger.Parse("29122359898196696856"),BigInteger.Parse("209490003763160695865576"),BigInteger.Parse("3348908247850171650090422060"),BigInteger.Parse("119286836904111393911302107179212") };
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
public class A268734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268734Inst Instance=new A268734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268735
{
public static readonly long[] Value={ 2L,15L,80L,396L,1788L,7831L,33170L,137868L,563486L,2275119L,9091772L,36031648L,141793168L,554669335L,2158604934L,8363066408L,32273565050L,124112115647L,475807505288L,1819019281732L,6936664653476L,26392068734023L,100206016839642L };
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
public class A268735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268735Inst : IEnumerable<long>
{
public static readonly long[] Value=A268735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268735.Bytes);
public long this[int i]=>Value[i];

public static A268735Inst Instance=new A268735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268736
{
public static readonly long[] Value={ 5L,48L,396L,2876L,19591L,128232L,816009L,5087814L,31228804L,189328186L,1136393919L,6764778660L,39991075367L,235019630164L,1374139675314L,7998875575940L,46380134987289L,267999333435856L,1543818690094499L,8868640131544198L };
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
public class A268736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268736Inst : IEnumerable<long>
{
public static readonly long[] Value=A268736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268736.Bytes);
public long this[int i]=>Value[i];

public static A268736Inst Instance=new A268736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268737
{
public static readonly long[] Value={ 10L,145L,1788L,19591L,200204L,1971414L,18847982L,176668038L,1629738420L,14851460143L,133983018272L,1198816726867L,10652116047394L,94092052069550L,826903484125628L,7234834159717064L,63053215344757166L,547626807437714177L };
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
public class A268737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268737Inst : IEnumerable<long>
{
public static readonly long[] Value=A268737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268737.Bytes);
public long this[int i]=>Value[i];

public static A268737Inst Instance=new A268737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268738
{
public static readonly long[] Value={ 20L,420L,7831L,128232L,1971414L,29134076L,418632185L,5894815754L,81718671716L,1119014223138L,15171181272721L,203998929406004L,2724149465085496L,36163754541884778L,477648079847735215L,6280858615510607492L };
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
public class A268738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268738Inst : IEnumerable<long>
{
public static readonly long[] Value=A268738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268738.Bytes);
public long this[int i]=>Value[i];

public static A268738Inst Instance=new A268738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268739
{
public static readonly BigInteger[] Value={ 38L,1183L,33170L,816009L,18847982L,418632185L,9039552112L,191307160577L,3985770068310L,82030747371058L,1671509767296774L,33781019022038039L,678004335124666334L,13528033902348727292UL,BigInteger.Parse("268553181861956273470") };
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
public class A268739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268739Inst Instance=new A268739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268788
{
public static readonly long[] Value={ 38L,850L,14984L,228384L,3295246L,45515227L,611932378L,8057509992L,104456486696L,1337467436839L,16954554895936L,213155407369839L,2661273257222436L,33030289066656341L,407868045265169610L,5014148928763408926L };
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
public class A268788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268788Inst : IEnumerable<long>
{
public static readonly long[] Value=A268788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268788.Bytes);
public long this[int i]=>Value[i];

public static A268788Inst Instance=new A268788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268789
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,2L,5L,17L,17L,5L,10L,48L,72L,48L,10L,20L,131L,302L,302L,131L,20L,38L,338L,1144L,1714L,1144L,338L,38L,71L,850L,4207L,9085L,9085L,4207L,850L,71L,130L,2091L,14984L,46195L,67100L,46195L,14984L,2091L,130L,235L,5061L,52335L,228384L,477128L,477128L,228384L };
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
public class A268789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268789Inst : IEnumerable<long>
{
public static readonly long[] Value=A268789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268789.Bytes);
public long this[int i]=>Value[i];

public static A268789Inst Instance=new A268789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268790
{
public static readonly long[] Value={ 177L,213L,219L,267L,309L,327L,381L,393L,411L,417L,447L,453L,471L,501L,519L,537L,573L,579L,633L,681L,717L,723L,753L,771L,789L,807L,813L,843L,849L,879L,921L,933L,1011L,1041L,1047L,1059L,1077L,1101L,1119L,1137L,1149L,1167L,1191L,1203L,1227L,1257L,1263L,1293L };
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
public class A268790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268790Inst : IEnumerable<long>
{
public static readonly long[] Value=A268790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268790.Bytes);
public long this[int i]=>Value[i];

public static A268790Inst Instance=new A268790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268791
{
public static readonly BigInteger[] Value={ 0L,22L,248L,4800L,168740L,11138352L,1384570516L,325815151556L,145913571668076L,124768928833331732L,BigInteger.Parse("204377241703937153076"),BigInteger.Parse("642788798787566885184552"),BigInteger.Parse("3889478620658657294120765368"),BigInteger.Parse("45350632160719542617837369658508") };
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
public class A268791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268791Inst Instance=new A268791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268792
{
public static readonly long[] Value={ 3L,22L,78L,234L,652L,1714L,4360L,10820L,26366L,63346L,150482L,354196L,827310L,1919884L,4430664L,10175910L,23272918L,53029498L,120435100L,272714858L,615904208L,1387638220L,3119557838L,6999162874L,15675003042L,35046218020L };
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
public class A268792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268792Inst : IEnumerable<long>
{
public static readonly long[] Value=A268792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268792.Bytes);
public long this[int i]=>Value[i];

public static A268792Inst Instance=new A268792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268793
{
public static readonly long[] Value={ 12L,78L,248L,950L,3384L,11948L,41248L,140698L,474472L,1586038L,5262024L,17348096L,56884272L,185647624L,603388088L,1953997896L,6307338900L,20300666174L,65169102416L,208712267048L,666993883320L,2127375490930L,6773070493400L };
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
public class A268793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268793Inst : IEnumerable<long>
{
public static readonly long[] Value=A268793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268793.Bytes);
public long this[int i]=>Value[i];

public static A268793Inst Instance=new A268793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268794
{
public static readonly long[] Value={ 36L,234L,950L,4800L,23994L,117062L,561116L,2652936L,12405748L,57490444L,264428454L,1208522850L,5493284922L,24851601802L,111963916212L,502590509990L,2248738675490L,10032298715910L,44640056867750L,198161794087570L };
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
public class A268794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268794Inst : IEnumerable<long>
{
public static readonly long[] Value=A268794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268794.Bytes);
public long this[int i]=>Value[i];

public static A268794Inst Instance=new A268794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268795
{
public static readonly long[] Value={ 96L,652L,3384L,23994L,168740L,1158904L,7801688L,51781418L,339641264L,2206871084L,14226779556L,91107781858L,580148670100L,3676143046622L,23194484120032L,145793482383084L,913349363853072L,5704743147188222L,35535874740219072L };
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
public class A268795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268795Inst : IEnumerable<long>
{
public static readonly long[] Value=A268795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268795.Bytes);
public long this[int i]=>Value[i];

public static A268795Inst Instance=new A268795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268796
{
public static readonly long[] Value={ 240L,1714L,11948L,117062L,1158904L,11138352L,104971262L,974000420L,8927994302L,81031120788L,729449219322L,6521558348746L,57964319359808L,512593621373638L,4513059897036336L,39580897460175788L,345946165584055346L };
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
public class A268796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268796Inst : IEnumerable<long>
{
public static readonly long[] Value=A268796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268796.Bytes);
public long this[int i]=>Value[i];

public static A268796Inst Instance=new A268796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268797
{
public static readonly long[] Value={ 576L,4360L,41248L,561116L,7801688L,104971262L,1384570516L,17967375416L,230262982692L,2921020155826L,36745483472428L,459003330021886L,5699362152372404L,70403795917829390L,865796392149477244L };
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
public class A268797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268797Inst : IEnumerable<long>
{
public static readonly long[] Value=A268797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268797.Bytes);
public long this[int i]=>Value[i];

public static A268797Inst Instance=new A268797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268798
{
public static readonly long[] Value={ 0L,3L,3L,12L,22L,12L,36L,78L,78L,36L,96L,234L,248L,234L,96L,240L,652L,950L,950L,652L,240L,576L,1714L,3384L,4800L,3384L,1714L,576L,1344L,4360L,11948L,23994L,23994L,11948L,4360L,1344L,3072L,10820L,41248L,117062L,168740L,117062L,41248L,10820L,3072L,6912L,26366L };
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
public class A268798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268798Inst : IEnumerable<long>
{
public static readonly long[] Value=A268798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268798.Bytes);
public long this[int i]=>Value[i];

public static A268798Inst Instance=new A268798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268799
{
public static readonly long[] Value={ 4L,8L,12L,20L,24L,36L,40L,56L,60L,64L,68L,112L,120L,132L,144L,156L,168L,176L,184L,200L,240L,256L,272L,280L,296L,356L,396L,444L,452L,480L,532L,616L,620L,672L,692L,708L,840L,864L,896L,916L,1004L };
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
public class A268799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268799Inst : IEnumerable<long>
{
public static readonly long[] Value=A268799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268799.Bytes);
public long this[int i]=>Value[i];

public static A268799Inst Instance=new A268799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268800
{
public static readonly long[] Value={ 3L,11L,31L,83L,283L,383L,1327L,2591L,7351L,7759L,11171L,11587L,31391L,46919L,147919L,288023L,360611L,425603L,507163L,666203L,1414703L,2198887L,3358151L,9287659L,11512547L,11648531L,24315047L,42453823L,145554779L,161720147L,184007671L,766668811L };
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
public class A268800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268800Inst : IEnumerable<long>
{
public static readonly long[] Value=A268800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268800.Bytes);
public long this[int i]=>Value[i];

public static A268800Inst Instance=new A268800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268801
{
public static readonly long[] Value={ 7L,19L,43L,103L,307L,419L,1367L,2647L,7411L,7823L,11239L,11699L,31511L,47051L,148063L,288179L,360779L,425779L,507347L,666403L,1414943L,2199143L,3358423L,9287939L,11512843L,11648887L,24315443L,42454267L,145555231L,161720627L,184008203L,766669427L };
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
public class A268801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268801Inst : IEnumerable<long>
{
public static readonly long[] Value=A268801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268801.Bytes);
public long this[int i]=>Value[i];

public static A268801Inst Instance=new A268801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268802
{
public static readonly BigInteger[] Value={ 3L,34L,332L,5848L,195384L,12432856L,1508087180L,348686105792L,154172619407288L,130573457756588328L,BigInteger.Parse("212323461305457440492"),BigInteger.Parse("663970589813116610557692"),BigInteger.Parse("3999438097971983178736358520"),BigInteger.Parse("46462227980008803491191644654968") };
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
public class A268802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268802Inst Instance=new A268802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268803
{
public static readonly long[] Value={ 9L,34L,104L,290L,772L,1972L,4914L,12010L,28922L,68836L,162274L,379524L,881712L,2036734L,4681646L,10714994L,24430816L,55516546L,125777028L,284188780L,640549034L,1440572818L,3233256010L,7243375068L,16199546178L,36172883716L };
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
public class A268803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268803Inst : IEnumerable<long>
{
public static readonly long[] Value=A268803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268803.Bytes);
public long this[int i]=>Value[i];

public static A268803Inst Instance=new A268803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269076
{
public static readonly long[] Value={ 4L,11L,27L,76L,185L,489L,1204L,3059L,7539L,18748L,46001L,112977L,275620L,671387L,1629003L,3944428L,9524969L,22955577L,55208404L,132545027L,317673891L,760222300L,1816668257L,4335499425L,10333941316L,24603369515L,58513434747L,139020574348L };
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
public class A269076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269076Inst : IEnumerable<long>
{
public static readonly long[] Value=A269076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269076.Bytes);
public long this[int i]=>Value[i];

public static A269076Inst Instance=new A269076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269077
{
public static readonly long[] Value={ 8L,32L,123L,521L,1887L,7477L,27042L,102070L,368391L,1351259L,4850557L,17489481L,62373468L,222422348L,788291635L,2789267661L,9831173339L,34583332541L,121320954422L,424799241314L,1484281289599L,5177412026719L,18028809567225L };
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
public class A269077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269077Inst : IEnumerable<long>
{
public static readonly long[] Value=A269077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269077.Bytes);
public long this[int i]=>Value[i];

public static A269077Inst Instance=new A269077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269078
{
public static readonly long[] Value={ 16L,89L,537L,3288L,17713L,102545L,542112L,2991561L,15699273L,84015848L,437869217L,2298582593L,11896438960L,61665786297L,317089210745L,1629210973432L,8329629544721L,42518834195697L,216316340106688L,1098583548812969L };
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
public class A269078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269078Inst : IEnumerable<long>
{
public static readonly long[] Value=A269078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269078.Bytes);
public long this[int i]=>Value[i];

public static A269078Inst Instance=new A269078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269079
{
public static readonly long[] Value={ 32L,244L,2343L,20400L,165607L,1383105L,10778640L,86308622L,661641931L,5146079168L,39031235709L,297777942033L,2239241624640L,16861326990168L,125878250277823L,939067269600080L,6967653661432115L,51619835791134129L,381021973991495280L };
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
public class A269079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269079Inst : IEnumerable<long>
{
public static readonly long[] Value=A269079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269079.Bytes);
public long this[int i]=>Value[i];

public static A269079Inst Instance=new A269079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269080
{
public static readonly long[] Value={ 64L,659L,10167L,123976L,1529241L,18220241L,210476400L,2427784475L,27272243911L,306906072088L,3392662878321L,37516091561153L,410121025237344L,4478699111368451L,48545701054002647L,525277883650197736L };
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
public class A269080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269080Inst : IEnumerable<long>
{
public static readonly long[] Value=A269080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269080.Bytes);
public long this[int i]=>Value[i];

public static A269080Inst Instance=new A269080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269081
{
public static readonly ulong[] Value={ 128L,1760L,43959L,742688L,14011359L,236272677L,4064720816L,67174864630L,1109043586715L,17995383255288L,290431722641261L,4645047826683577L,73887191299532384L,1168678595574438796L,18400291710723401503UL };
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
public class A269081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269081Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A269081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269081.Bytes);
public ulong this[int i]=>Value[i];

public static A269081Inst Instance=new A269081Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269082
{
public static readonly BigInteger[] Value={ 2L,11L,114L,2238L,80422L,5372270L,673690710L,159449028034L,71709929917104L,61507638902069052L,BigInteger.Parse("100988524469068110876"),BigInteger.Parse("318195132133780181426070"),BigInteger.Parse("1928131640777904103958251102"),BigInteger.Parse("22507425106868892327680953474828") };
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
public class A269082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269082Inst Instance=new A269082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269083
{
public static readonly long[] Value={ 4L,11L,30L,76L,191L,467L,1127L,2686L,6339L,14840L,34504L,79759L,183445L,420077L,958248L,2178427L,4937234L,11159252L,25160111L,56599879L,127066227L,284728994L,636922003L,1422499564L,3172350160L,7065116255L,15714769641L,34912773337L };
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
public class A269083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269083Inst : IEnumerable<long>
{
public static readonly long[] Value=A269083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269083.Bytes);
public long this[int i]=>Value[i];

public static A269083Inst Instance=new A269083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269084
{
public static readonly long[] Value={ 7L,30L,114L,428L,1531L,5387L,18590L,63347L,213490L,713237L,2365217L,7794642L,25549763L,83359179L,270860625L,876943006L,2830104798L,9107202178L,29230933367L,93601324315L,299085155918L,953808773503L,3036347307176L,9649992762591L };
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
public class A269084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269084Inst : IEnumerable<long>
{
public static readonly long[] Value=A269084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269084.Bytes);
public long this[int i]=>Value[i];

public static A269084Inst Instance=new A269084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269085
{
public static readonly long[] Value={ 13L,76L,428L,2238L,11314L,55620L,268289L,1274435L,5982734L,27813229L,128268964L,587560638L,2675945006L,12126527636L,54715085702L,245932380152L,1101667424213L,4920048498594L,21913218006880L,97358802936939L,431593734805059L };
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
public class A269085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269085Inst : IEnumerable<long>
{
public static readonly long[] Value=A269085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269085.Bytes);
public long this[int i]=>Value[i];

public static A269085Inst Instance=new A269085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269086
{
public static readonly long[] Value={ 23L,191L,1531L,11314L,80422L,555789L,3761534L,25063389L,164926651L,1074440360L,6941695514L,44537043804L,284052377508L,1802408061740L,11386034886784L,71645923776799L,449267054051740L,2808501899850347L,17508131088788801L };
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
public class A269086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269086Inst : IEnumerable<long>
{
public static readonly long[] Value=A269086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269086.Bytes);
public long this[int i]=>Value[i];

public static A269086Inst Instance=new A269086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269087
{
public static readonly long[] Value={ 41L,467L,5387L,55620L,555789L,5372270L,50865307L,473602013L,4353444165L,39602482120L,357186481377L,3198535920085L,28468239800885L,252053488597419L,2221493915335639L,19501164969933904L,170584538930223039L };
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
public class A269087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269087Inst : IEnumerable<long>
{
public static readonly long[] Value=A269087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269087.Bytes);
public long this[int i]=>Value[i];

public static A269087Inst Instance=new A269087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269088
{
public static readonly long[] Value={ 72L,1127L,18590L,268289L,3761534L,50865307L,673690710L,8768989835L,112658396453L,1431998499913L,18044145807959L,225714076389625L,2806025783464923L,34698719581599414L,427098528675334433L,5235801241750340793L };
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
public class A269088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269088Inst : IEnumerable<long>
{
public static readonly long[] Value=A269088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269088.Bytes);
public long this[int i]=>Value[i];

public static A269088Inst Instance=new A269088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269089
{
public static readonly long[] Value={ 2L,4L,4L,7L,11L,7L,13L,30L,30L,13L,23L,76L,114L,76L,23L,41L,191L,428L,428L,191L,41L,72L,467L,1531L,2238L,1531L,467L,72L,126L,1127L,5387L,11314L,11314L,5387L,1127L,126L,219L,2686L,18590L,55620L,80422L,55620L,18590L,2686L,219L,379L,6339L,63347L,268289L,555789L };
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
public class A269089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269089Inst : IEnumerable<long>
{
public static readonly long[] Value=A269089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269089.Bytes);
public long this[int i]=>Value[i];

public static A269089Inst Instance=new A269089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269090
{
public static readonly BigInteger[] Value={ 0L,96L,31296L,37963968L,211625837280L,5826856525990272L,BigInteger.Parse("819944297332124826720"),BigInteger.Parse("600994567853371717147309536"),BigInteger.Parse("2321584677123190401202986846749664"),BigInteger.Parse("47631920426007575412576023256743509016160") };
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
public class A269090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269090Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269090.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269090.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269090Inst Instance=new A269090Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269091
{
public static readonly long[] Value={ 4L,96L,1152L,11424L,103488L,889056L,7375872L,59698464L,474360768L,3715826016L,28777886592L,220814937504L,1681292682048L,12718165610976L,95670977133312L,716203564928544L,5338972029467328L,39651633731043936L,293513242790716032L };
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
public class A269091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269091Inst : IEnumerable<long>
{
public static readonly long[] Value=A269091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269091.Bytes);
public long this[int i]=>Value[i];

public static A269091Inst Instance=new A269091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269156
{
public static readonly long[] Value={ 3L,19L,60L,90L };
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
public class A269156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269156Inst : IEnumerable<long>
{
public static readonly long[] Value=A269156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269156.Bytes);
public long this[int i]=>Value[i];

public static A269156Inst Instance=new A269156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269157
{
public static readonly long[] Value={ 1L,4L,16L,25L,35L,64L,100L,129L,140L,217L,256L,400L,516L,560L,868L,1024L,1057L,1169L,1413L,1523L,1600L,2064L,2240L,2245L,2315L,3435L,3472L,3781L,3841L,4096L,4228L,4287L,4451L,4671L,4676L,4677L,4681L,4869L,5652L,6092L,6400L,6553L,6921L,8047L,8256L,8960L,8967L,8980L,9260L,9335L,11745L,12493L,12749L,13057L,13069L,13073L,13085L,13105L,13740L,13888L,15124L,15364L,16384L };
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
public class A269157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269157Inst : IEnumerable<long>
{
public static readonly long[] Value=A269157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269157.Bytes);
public long this[int i]=>Value[i];

public static A269157Inst Instance=new A269157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269158
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,7L,3L,0L,0L,4L,3L,0L,1L,0L,13L,3L,0L,2L,0L,0L,14L,1L,0L,5L,1L,1L,0L,11L,1L,0L,2L,4L,0L,1L,0L,8L,1L,0L,1L,7L,7L,2L,1L,0L,25L,3L,0L,1L,12L,7L,7L,0L,0L,0L,26L,3L,0L,6L,15L,5L,4L,0L,0L,1L,0L,31L,3L,0L,5L,10L,3L,13L,4L,2L,2L,1L,0L,28L,1L,0L,6L,11L,2L,14L,9L,6L,0L,3L,1L,0L,21L,1L,0L,1L,26L,7L,11L,4L,12L,0L,3L,0L,0L };
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
public class A269158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269158Inst : IEnumerable<long>
{
public static readonly long[] Value=A269158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269158.Bytes);
public long this[int i]=>Value[i];

public static A269158Inst Instance=new A269158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269159
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,0L,3L,7L,0L,1L,0L,3L,4L,0L,0L,2L,0L,3L,13L,0L,1L,1L,5L,0L,1L,14L,0L,1L,0L,4L,2L,0L,1L,11L,0L,1L,2L,7L,7L,1L,0L,1L,8L,0L,0L,0L,7L,7L,12L,1L,0L,3L,25L,0L,1L,0L,0L,4L,5L,15L,6L,0L,3L,26L,0L,1L,2L,2L,4L,13L,3L,10L,5L,0L,3L,31L,0L,1L,3L,0L,6L,9L,14L,2L,11L,6L,0L,1L,28L,0L,0L,0L,3L,0L,12L,4L,11L,7L,26L,1L,0L,1L,21L,0L };
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
public class A269159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269159Inst : IEnumerable<long>
{
public static readonly long[] Value=A269159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269159.Bytes);
public long this[int i]=>Value[i];

public static A269159Inst Instance=new A269159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269160
{
public static readonly long[] Value={ 0L,7L,14L,13L,28L,27L,26L,25L,56L,63L,54L,53L,52L,51L,50L,49L,112L,119L,126L,125L,108L,107L,106L,105L,104L,111L,102L,101L,100L,99L,98L,97L,224L,231L,238L,237L,252L,251L,250L,249L,216L,223L,214L,213L,212L,211L,210L,209L,208L,215L,222L,221L,204L,203L,202L,201L,200L,207L,198L,197L,196L,195L,194L,193L,448L,455L,462L };
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
public class A269160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269160Inst : IEnumerable<long>
{
public static readonly long[] Value=A269160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269160.Bytes);
public long this[int i]=>Value[i];

public static A269160Inst Instance=new A269160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269161
{
public static readonly long[] Value={ 0L,7L,14L,11L,28L,27L,22L,19L,56L,63L,54L,51L,44L,43L,38L,35L,112L,119L,126L,123L,108L,107L,102L,99L,88L,95L,86L,83L,76L,75L,70L,67L,224L,231L,238L,235L,252L,251L,246L,243L,216L,223L,214L,211L,204L,203L,198L,195L,176L,183L,190L,187L,172L,171L,166L,163L,152L,159L,150L,147L,140L,139L,134L,131L,448L,455L,462L,459L };
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
public class A269161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269161Inst : IEnumerable<long>
{
public static readonly long[] Value=A269161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269161.Bytes);
public long this[int i]=>Value[i];

public static A269161Inst Instance=new A269161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269162
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,3L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,6L,5L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,15L,14L,13L,12L,11L,10L,0L,8L,0L,0L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,31L,30L,29L,28L,27L,26L,0L,24L,23L,22L,21L,20L,0L,0L,25L };
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
public class A269162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269162Inst : IEnumerable<long>
{
public static readonly long[] Value=A269162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269162.Bytes);
public long this[int i]=>Value[i];

public static A269162Inst Instance=new A269162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269163
{
public static readonly long[] Value={ 0L,7L,13L,14L,25L,26L,27L,28L,49L,50L,51L,52L,53L,54L,56L,63L,97L,98L,99L,100L,101L,102L,104L,105L,106L,107L,108L,111L,112L,119L,125L,126L,193L,194L,195L,196L,197L,198L,200L,201L,202L,203L,204L,207L,208L,209L,210L,211L,212L,213L,214L,215L,216L,221L,222L,223L,224L,231L,237L,238L,249L,250L,251L,252L,385L,386L,387L,388L };
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
public class A269163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269163Inst : IEnumerable<long>
{
public static readonly long[] Value=A269163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269163.Bytes);
public long this[int i]=>Value[i];

public static A269163Inst Instance=new A269163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269164
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,55L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L };
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
public class A269164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269164Inst : IEnumerable<long>
{
public static readonly long[] Value=A269164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269164.Bytes);
public long this[int i]=>Value[i];

public static A269164Inst Instance=new A269164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269165
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,1L,8L,9L,10L,11L,12L,3L,2L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,1L,6L,5L,4L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,15L,2L,3L,12L,11L,10L,55L,8L,57L,58L,59L,60L,61L,62L,9L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L };
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
public class A269165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269165Inst : IEnumerable<long>
{
public static readonly long[] Value=A269165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269165.Bytes);
public long this[int i]=>Value[i];

public static A269165Inst Instance=new A269165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269166
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,0L,1L,1L,1L,1L,1L,0L,0L,3L,1L,0L,0L,0L,0L,0L,0L,1L,0L };
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
public class A269166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269166Inst : IEnumerable<long>
{
public static readonly long[] Value=A269166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269166.Bytes);
public long this[int i]=>Value[i];

public static A269166Inst Instance=new A269166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269167
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,2L,127L,5L,255L,11L,511L,14L,6L,23L,1023L,29L,13L,47L,2047L,59L,27L,95L,4095L,4L,126L,62L,30L,119L,55L,191L,8191L,9L,253L,125L,61L,239L,111L,383L,16383L,19L,507L,251L,123L,479L,223L,767L,32767L,46L,12L,28L,1022L,22L,510L,39L,254L,1015L,503L,247L,959L,447L,1535L,10L,65535L,93L,25L,57L,2045L,45L };
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
public class A269167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269167Inst : IEnumerable<long>
{
public static readonly long[] Value=A269167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269167.Bytes);
public long this[int i]=>Value[i];

public static A269167Inst Instance=new A269167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269168
{
public static readonly long[] Value={ 1L,7L,2L,25L,9L,14L,3L,111L,33L,63L,11L,50L,18L,13L,4L,401L,143L,231L,41L,193L,79L,53L,15L,222L,66L,126L,22L,51L,17L,28L,5L,1783L,529L,945L,175L,825L,295L,223L,55L,839L,257L,497L,95L,203L,69L,49L,19L,802L,286L,462L,82L,386L,158L,106L,30L,221L,67L,119L,21L,100L,36L,27L,6L,6409L,2295L,3703L,657L,3159L,1201L,849L,233L };
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
public class A269168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269168Inst : IEnumerable<long>
{
public static readonly long[] Value=A269168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269168.Bytes);
public long this[int i]=>Value[i];

public static A269168Inst Instance=new A269168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269169
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,10L,11L,11L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,21L,21L,21L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,41L,41L,41L,41L,41L,41L,42L,42L,43L,44L,45L,46L,47L,48L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L };
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
public class A269169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269169Inst : IEnumerable<long>
{
public static readonly long[] Value=A269169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269169.Bytes);
public long this[int i]=>Value[i];

public static A269169Inst Instance=new A269169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269170
{
public static readonly long[] Value={ 0L,1L,3L,3L,6L,7L,7L,7L,12L,13L,15L,15L,14L,15L,15L,15L,24L,25L,27L,27L,30L,31L,31L,31L,28L,29L,31L,31L,30L,31L,31L,31L,48L,49L,51L,51L,54L,55L,55L,55L,60L,61L,63L,63L,62L,63L,63L,63L,56L,57L,59L,59L,62L,63L,63L,63L,60L,61L,63L,63L,62L,63L,63L,63L,96L,97L,99L,99L,102L,103L,103L,103L,108L,109L,111L,111L,110L,111L };
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
public class A269170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269170Inst : IEnumerable<long>
{
public static readonly long[] Value=A269170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269170.Bytes);
public long this[int i]=>Value[i];

public static A269170Inst Instance=new A269170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269171
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,23L,20L,21L,22L,25L,24L,19L,26L,27L,28L,29L,30L,37L,32L,33L,34L,35L,36L,41L,46L,39L,40L,43L,42L,47L,44L,45L,50L,53L,48L,31L,38L,51L,52L,61L,54L,49L,56L,57L,58L,67L,60L,71L,74L,63L,64L,65L,66L,77L,68L,69L,70L,83L,72L,89L,82L,75L,92L,59L,78L,91L,80L,81L,86L,97L,84L,79L,94L,87L,88L,107L,90L,85L,100L };
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
public class A269171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269171Inst : IEnumerable<long>
{
public static readonly long[] Value=A269171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269171.Bytes);
public long this[int i]=>Value[i];

public static A269171Inst Instance=new A269171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269236
{
public static readonly long[] Value={ 13L,43L,163L,953L,3163L,4243L,6473L,8233L,10093L,13313L,13463L,27583L,156253L,1046833L,1087423L,4343873L,5649433L,9292193L,18819653L,32015773L,38024653L,53664593L,90421003L,133126013L,169727903L,228590863L,284826133L,318828313L,431959873L,949478653L,1054257163L,2343370033L,7392449633L,15207880463L,28072102973L };
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
public class A269236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269236Inst : IEnumerable<long>
{
public static readonly long[] Value=A269236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269236.Bytes);
public long this[int i]=>Value[i];

public static A269236Inst Instance=new A269236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269237
{
public static readonly long[] Value={ 1L,34L,189L,616L,1525L,3186L,5929L,10144L,16281L,24850L,36421L,51624L,71149L,95746L,126225L,163456L,208369L,261954L,325261L,399400L,485541L,584914L,698809L,828576L,975625L,1141426L,1327509L,1535464L,1766941L,2023650L,2307361L,2619904L,2963169L,3339106L,3749725L,4197096L };
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
public class A269237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269237Inst : IEnumerable<long>
{
public static readonly long[] Value=A269237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269237.Bytes);
public long this[int i]=>Value[i];

public static A269237Inst Instance=new A269237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269238
{
public static readonly long[] Value={ 10L,20L,30L,60L,90L,130L,150L,180L,210L,240L,280L,380L,420L,430L,450L,470L,500L,530L,630L,640L,660L,780L,840L,920L,960L,970L,990L,1030L,1070L,1130L,1170L,1190L,1230L,1330L,1610L,1680L,2030L };
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
public class A269238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269238Inst : IEnumerable<long>
{
public static readonly long[] Value=A269238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269238.Bytes);
public long this[int i]=>Value[i];

public static A269238Inst Instance=new A269238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269239
{
public static readonly long[] Value={ 7L,17L,67L,397L,997L,4657L,10687L,28097L,39397L,61057L,130987L,250307L,425417L,2385157L,2717567L,3207857L,5247257L,6996377L,7402237L,23363167L,27614507L,46359967L,103494037L,118884947L,499144627L,544698487L,705338497L,760949557L,1625986457L };
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
public class A269239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269239Inst : IEnumerable<long>
{
public static readonly long[] Value=A269239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269239.Bytes);
public long this[int i]=>Value[i];

public static A269239Inst Instance=new A269239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269240
{
public static readonly long[] Value={ 17L,37L,97L,457L,1087L,4787L,10837L,28277L,39607L,61297L,131267L,250687L,425837L,2385587L,2718017L,3208327L,5247757L,6996907L,7402867L,23363807L,27615167L,46360747L,103494877L,118885867L,499145587L,544699457L,705339487L,760950587L,1625987527L };
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
public class A269240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269240Inst : IEnumerable<long>
{
public static readonly long[] Value=A269240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269240.Bytes);
public long this[int i]=>Value[i];

public static A269240Inst Instance=new A269240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269241
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,2L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,2L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,2L,1L,1L,1L,1L,2L,2L,3L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L };
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
public class A269241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269241Inst : IEnumerable<long>
{
public static readonly long[] Value=A269241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269241.Bytes);
public long this[int i]=>Value[i];

public static A269241Inst Instance=new A269241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269242
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,2L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,1L,2L,2L,1L,0L,1L,1L,0L,0L,1L,0L,2L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
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
public class A269242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269242Inst : IEnumerable<long>
{
public static readonly long[] Value=A269242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269242.Bytes);
public long this[int i]=>Value[i];

public static A269242Inst Instance=new A269242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269243
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,2L,2L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,0L,0L,0L,2L,2L,1L,2L,1L,2L,1L,0L,0L,1L,2L,0L,2L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L };
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
public class A269243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269243Inst : IEnumerable<long>
{
public static readonly long[] Value=A269243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269243.Bytes);
public long this[int i]=>Value[i];

public static A269243Inst Instance=new A269243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269244
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,1L,0L,2L,0L,1L,0L,1L,0L,2L,1L,1L,1L,2L,1L,0L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L };
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
public class A269244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269244Inst : IEnumerable<long>
{
public static readonly long[] Value=A269244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269244.Bytes);
public long this[int i]=>Value[i];

public static A269244Inst Instance=new A269244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269245
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,2L,2L,0L,1L,1L,2L,1L,1L,1L,1L,2L,0L,0L,0L,2L,0L,1L,1L,2L };
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
public class A269245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269245Inst : IEnumerable<long>
{
public static readonly long[] Value=A269245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269245.Bytes);
public long this[int i]=>Value[i];

public static A269245Inst Instance=new A269245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269246
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,3L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,2L,2L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,3L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L };
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
public class A269246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269246Inst : IEnumerable<long>
{
public static readonly long[] Value=A269246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269246.Bytes);
public long this[int i]=>Value[i];

public static A269246Inst Instance=new A269246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269247
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,1L,0L,0L,0L,2L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,3L,1L,0L,0L,0L,1L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,1L,0L };
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
public class A269247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269247Inst : IEnumerable<long>
{
public static readonly long[] Value=A269247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269247.Bytes);
public long this[int i]=>Value[i];

public static A269247Inst Instance=new A269247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269248
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,2L,0L,2L,0L,0L,1L,0L,0L,0L,0L,1L,2L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,3L,1L,2L,1L,2L,0L,0L,0L,0L };
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
public class A269248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269248Inst : IEnumerable<long>
{
public static readonly long[] Value=A269248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269248.Bytes);
public long this[int i]=>Value[i];

public static A269248Inst Instance=new A269248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269249
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,2L,0L,1L,1L,0L,0L,0L,0L,2L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,1L,2L,3L,0L };
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
public class A269249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269249Inst : IEnumerable<long>
{
public static readonly long[] Value=A269249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269249.Bytes);
public long this[int i]=>Value[i];

public static A269249Inst Instance=new A269249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269250
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,1L,0L,0L,3L,0L,1L,1L,0L,0L,0L,1L,1L,0L,3L,0L,2L,0L,0L,0L,0L,0L,0L,1L,3L,0L,0L,2L,0L,0L,0L,2L,0L,1L,3L,0L,0L,1L,1L,0L,0L,0L,0L,1L,3L,0L,0L,0L,1L,0L,1L,1L,0L,1L,3L,0L,0L,1L,1L,0L,0L,0L,0L,1L,6L };
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
public class A269250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269250Inst : IEnumerable<long>
{
public static readonly long[] Value=A269250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A269250.Bytes);
public long this[int i]=>Value[i];

public static A269250Inst Instance=new A269250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A269251
{
public static readonly BigInteger[] Value={ 0L,0L,2L,3L,19L,5L,41L,7L,71L,89L,109L,11L,2003L,13L,3121L,239L,271L,17L,729962708557509701L,19L,419L,461L,11593L,23L,599L,11356201L,701L,BigInteger.Parse("11546481261621528160662473705515857458665002781273993"),811L,29L,929L };
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
public class A269251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A269251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A269251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A269251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A269251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A269251Inst Instance=new A269251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}