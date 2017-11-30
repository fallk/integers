using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238389
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,7L,16L,19L,37L,67L,94L,178L,295L,460L,829L,1345L,2209L,3832L,6244L,10459L,17740L,29191L,49117L,82411L,136690L,229762L,383923L,639832L,1073209L,1791601L,2992705L,5011228L,8367508L,13989343L,23401192L,39091867L,65369221L,109295443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238389Inst : IEnumerable<long>
{
public static readonly long[] Value=A238389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238389.Bytes);
public long this[int i]=>Value[i];

public static A238389Inst Instance=new A238389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238390
{
public static readonly BigInteger[] Value={ 1L,1L,4L,35L,546L,13482L,485892L,24108513L,1576676530L,131451399794L,13609184032808L,1712978776719938L,257612765775847132L,BigInteger.Parse("45620136452519144700"),BigInteger.Parse("9396239458048330569840"),BigInteger.Parse("2227147531572856811691105"),BigInteger.Parse("601916577165056911293330930"),BigInteger.Parse("183994483721828524163677628370") };
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
public class A238390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238390Inst Instance=new A238390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238391
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,4L,7L,7L,10L,19L,22L,40L,43L,70L,100L,136L,220L,265L,430L,565L,838L,1225L,1633L,2515L,3328L,5029L,7003L,9928L,14548L,19912L,29635L,40921L,59419L,84565L,119155L,173470L,241918L,351727L,495613L,709192L,1016023L,1434946L,2071204L,2921785L,4198780L,5969854L,8503618L,12183466L,17268973L,24779806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238391Inst : IEnumerable<long>
{
public static readonly long[] Value=A238391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238391.Bytes);
public long this[int i]=>Value[i];

public static A238391Inst Instance=new A238391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238392
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,4L,2L,1L,1L,2L,4L,4L,2L,1L,1L,2L,4L,6L,4L,2L,1L,1L,2L,4L,6L,6L,4L,2L,1L,1L,2L,4L,6L,10L,6L,4L,2L,1L,1L,2L,4L,6L,10L,10L,6L,4L,2L,1L,1L,2L,4L,6L,10L,14L,10L,6L,4L,2L,1L,1L,2L,4L,6L,10L,14L,14L,10L,6L,4L,2L,1L,1L,2L,4L,6L,10L,14L,20L,14L,10L,6L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238392Inst : IEnumerable<long>
{
public static readonly long[] Value=A238392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238392.Bytes);
public long this[int i]=>Value[i];

public static A238392Inst Instance=new A238392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238393
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,2L,5L,2L,6L,3L,3L,5L,1L,9L,3L,4L,5L,5L,6L,2L,7L,3L,5L,8L,3L,4L,8L,10L,7L,10L,6L,7L,9L,8L,8L,6L,6L,4L,12L,10L,10L,8L,6L,6L,5L,7L,8L,6L,10L,5L,9L,9L,11L,7L,7L,6L,9L,11L,8L,7L,11L,6L,9L,8L,4L,8L,5L,18L,14L,10L,9L,7L,8L,6L,13L,9L,4L,7L,7L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238393Inst : IEnumerable<long>
{
public static readonly long[] Value=A238393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238393.Bytes);
public long this[int i]=>Value[i];

public static A238393Inst Instance=new A238393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238394
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,3L,3L,4L,5L,8L,9L,12L,13L,17L,22L,28L,34L,42L,48L,59L,71L,88L,106L,130L,151L,181L,210L,250L,295L,354L,417L,494L,577L,675L,780L,909L,1053L,1231L,1431L,1668L,1930L,2240L,2573L,2963L,3392L,3896L,4461L,5129L,5873L,6742L,7710L,8816L,10043L,11439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238394Inst : IEnumerable<long>
{
public static readonly long[] Value=A238394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238394.Bytes);
public long this[int i]=>Value[i];

public static A238394Inst Instance=new A238394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238395
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,5L,8L,12L,18L,25L,34L,47L,65L,88L,118L,154L,203L,263L,343L,442L,568L,721L,914L,1149L,1445L,1807L,2255L,2800L,3468L,4270L,5250L,6425L,7855L,9566L,11635L,14103L,17068L,20584L,24784L,29754L,35670L,42653L,50934L,60688L,72212L,85742L,101662L,120293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238395Inst : IEnumerable<long>
{
public static readonly long[] Value=A238395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238395.Bytes);
public long this[int i]=>Value[i];

public static A238395Inst Instance=new A238395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238396
{
public static readonly long[] Value={ 1L,2L,0L,9L,1L,0L,54L,20L,0L,0L,378L,307L,21L,0L,0L,2916L,4280L,966L,0L,0L,0L,24057L,56914L,27954L,1485L,0L,0L,0L,208494L,736568L,650076L,113256L,0L,0L,0L,0L,1876446L,9370183L,13271982L,5008230L,225225L,0L,0L,0L,0L,17399772L,117822512L,248371380L,167808024L,24635754L,0L,0L,0L,0L,0L,165297834L,1469283166L,4366441128L,4721384790L,1495900107L,59520825L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238396Inst : IEnumerable<long>
{
public static readonly long[] Value=A238396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238396.Bytes);
public long this[int i]=>Value[i];

public static A238396Inst Instance=new A238396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238397
{
public static readonly long[] Value={ 31L,41L,59L,61L,71L,87L,91L,101L,103L,113L,119L,121L,129L,131L,143L,151L,161L,167L,171L,185L,191L,199L,211L,213L,215L,221L,227L,239L,241L,243L,247L,251L,263L,269L,271L,275L,281L,293L,297L,299L,301L,311L,321L,327L,331L,339L,341L,343L,347L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238397Inst : IEnumerable<long>
{
public static readonly long[] Value=A238397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238397.Bytes);
public long this[int i]=>Value[i];

public static A238397Inst Instance=new A238397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238398
{
public static readonly BigInteger[] Value={ 1L,-3L,2L,-11L,4L,-11L,6L,-39L,8L,-49L,10L,647L,12L,-5487L,14L,929329L,16L,-3202325L,18L,221930505L,20L,-4722116563L,22L,968383680643L,24L,-14717667114201L,26L,2093660879252563L,28L,-86125672563201239L,30L,BigInteger.Parse("129848163681107300961"),32L };
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
public class A238398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238398Inst Instance=new A238398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238399
{
public static readonly long[] Value={ 2L,3L,7L,55L,255L,478L,663L,984L,1237L,1955L,3021L,3214L,8312L,13519L,38267L,40805L,45400L,47444L,48835L,55269L,56758L,59032L,66067L,92141L,93063L,103620L,106611L,108602L,112713L,140874L,151335L,163314L,178215L,183330L,211350L,235410L,244165L,265160L,275971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238399Inst : IEnumerable<long>
{
public static readonly long[] Value=A238399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238399.Bytes);
public long this[int i]=>Value[i];

public static A238399Inst Instance=new A238399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238528
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,29L,41L,59L,71L,101L,107L,137L,149L,179L,191L,197L,227L,239L,269L,281L,311L,347L,419L,431L,461L,521L,569L,599L,617L,641L,659L,809L,821L,827L,857L,881L,1019L,1031L,1049L,1061L,1091L,1151L,1229L,1277L,1289L,1301L,1319L,1427L,1451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238528Inst : IEnumerable<long>
{
public static readonly long[] Value=A238528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238528.Bytes);
public long this[int i]=>Value[i];

public static A238528Inst Instance=new A238528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238529
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,1L,3L,1L,2L,1L,2L,2L,2L,2L,1L,1L,3L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,2L,1L,2L,2L,1L,1L,1L,1L,3L,3L,2L,2L,2L,1L,2L,3L,3L,1L,1L,2L,2L,2L,2L,1L,3L,2L,2L,3L,2L,2L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238529Inst : IEnumerable<long>
{
public static readonly long[] Value=A238529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238529.Bytes);
public long this[int i]=>Value[i];

public static A238529Inst Instance=new A238529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238530
{
public static readonly long[] Value={ 2L,8L,22L,166L,778L,4962L,29922L,179682L,688078L,7060198L,42361338L,674524645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238530Inst : IEnumerable<long>
{
public static readonly long[] Value=A238530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238530.Bytes);
public long this[int i]=>Value[i];

public static A238530Inst Instance=new A238530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238531
{
public static readonly long[] Value={ 1L,1L,3L,5L,8L,12L,17L,23L,30L,38L,47L,57L,68L,80L,93L,107L,122L,138L,155L,173L,192L,212L,233L,255L,278L,302L,327L,353L,380L,408L,437L,467L,498L,530L,563L,597L,632L,668L,705L,743L,782L,822L,863L,905L,948L,992L,1037L,1083L,1130L,1178L,1227L,1277L,1328L,1380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238531Inst : IEnumerable<long>
{
public static readonly long[] Value=A238531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238531.Bytes);
public long this[int i]=>Value[i];

public static A238531Inst Instance=new A238531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238532
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,2L,0L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,3L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,4L,0L,4L,0L,0L,0L,0L,0L,3L,0L,0L,0L,7L,0L,1L,0L,0L,0L,0L,0L,4L,0L,0L,0L,4L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,3L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238532Inst : IEnumerable<long>
{
public static readonly long[] Value=A238532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238532.Bytes);
public long this[int i]=>Value[i];

public static A238532Inst Instance=new A238532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238533
{
public static readonly long[] Value={ 1L,16L,162L,512L,2500L,2592L,14406L,16384L,39366L,40000L,146410L,82944L,342732L,230496L,405000L,524288L,1336336L,629856L,2345778L,1280000L,2333772L,2342560L,6156502L,2654208L,7812500L,5483712L,9565938L,7375872L,19803868L,6480000L,27705630L,16777216L,23718420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238533Inst : IEnumerable<long>
{
public static readonly long[] Value=A238533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238533.Bytes);
public long this[int i]=>Value[i];

public static A238533Inst Instance=new A238533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238534
{
public static readonly long[] Value={ 1L,32L,504L,2048L,12400L,16128L,101136L,131072L,367416L,396800L,1611720L,1032192L,4453488L,3236352L,6249600L,8388608L,22713088L,11757312L,44576280L,25395200L,50972544L,51575040L,141611184L,66060288L,193750000L,142511616L,267846264L,207126528L,574288624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238534Inst : IEnumerable<long>
{
public static readonly long[] Value=A238534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238534.Bytes);
public long this[int i]=>Value[i];

public static A238534Inst Instance=new A238534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238535
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,9L,7L,12L,9L,15L,11L,22L,13L,21L,20L,24L,17L,33L,19L,35L,28L,33L,23L,50L,25L,39L,36L,49L,29L,61L,31L,56L,44L,51L,42L,75L,37L,57L,52L,78L,41L,84L,43L,77L,69L,69L,47L,108L,49L,85L,68L,91L,53L,108L,66L,106L,76L,87L,59L,147L,61L,93L,93L,112L,78L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238535Inst : IEnumerable<long>
{
public static readonly long[] Value=A238535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238535.Bytes);
public long this[int i]=>Value[i];

public static A238535Inst Instance=new A238535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238536
{
public static readonly long[] Value={ 1L,12L,68L,504L,3355L,23256L,158717L,1089648L,7463884L,51170460L,350695511L,2403786672L,16475579353L,112925875764L,774003961940L,5305106018016L,36361727272627L,249227013404808L,1708227291909269L,11708364225400920L,80250321774226396L,550043889533755332L,3770056901455017263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238536Inst : IEnumerable<long>
{
public static readonly long[] Value=A238536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238536.Bytes);
public long this[int i]=>Value[i];

public static A238536Inst Instance=new A238536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238537
{
public static readonly BigInteger[] Value={ 1L,42L,1379L,47124L,1599205L,54335358L,1845747527L,62701403688L,2130000094537L,72357312787410L,2458018570699691L,83500274463891516L,2836551311028252973L,BigInteger.Parse("96359244313163973414"),BigInteger.Parse("3273377755262716618895"),BigInteger.Parse("111198484435049515150416"),BigInteger.Parse("3777475093033912744231057") };
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
public class A238537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238537Inst Instance=new A238537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238538
{
public static readonly BigInteger[] Value={ 1L,15L,219L,3315L,51491L,811395L,12882499L,205321155L,3278747331L,52408827075L,838132189379L,13406842675395L,214483303960771L,3431523432591555L,54902699475185859L,878429788032676035L,14054769379960303811UL,BigInteger.Parse("224875452250864496835"),BigInteger.Parse("3598000373385828511939") };
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
public class A238538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238538Inst Instance=new A238538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238539
{
public static readonly BigInteger[] Value={ 1L,35L,399L,7735L,112871L,1893255L,29593159L,479082695L,7620584391L,122287263175L,1953732901319L,31282632909255L,500338874618311L,8006888009380295L,128098480026087879L,2049669505409577415L,BigInteger.Parse("32793961486615474631"),BigInteger.Parse("524709388585350492615"),BigInteger.Parse("8395302178969583120839") };
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
public class A238539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238539Inst Instance=new A238539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238540
{
public static readonly BigInteger[] Value={ 1L,70L,5299L,419020L,33664741L,2719393810L,220069738519L,17820217484440L,1443290970139081L,116902609136432350L,9469004435040169339UL,BigInteger.Parse("766986472802959676260"),BigInteger.Parse("62125826363286791503021"),BigInteger.Parse("5032189831214900660779690"),BigInteger.Parse("407607319514701058318401759"),BigInteger.Parse("33016191346720726553176114480") };
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
public class A238540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238540Inst Instance=new A238540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238541
{
public static readonly BigInteger[] Value={ 1L,91L,7063L,538447L,41441455L,3231753343L,254851186927L,20265345051679L,1621012954550479L,130194036583465855L,10485834936321976111UL,BigInteger.Parse("846117830539227426271"),BigInteger.Parse("68360837263665964839823"),BigInteger.Parse("5527792975131721247371327"),BigInteger.Parse("447241733557623755497669615") };
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
public class A238541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238541Inst Instance=new A238541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238542
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,14L,20L,28L,40L,50L,72L,93L,124L,161L,213L,270L,355L,447L,573L,723L,919L,1142L,1441L,1786L,2225L,2745L,3398L,4160L,5121L,6240L,7623L,9255L,11246L,13577L,16423L,19753L,23767L,28478L,34125L,40723L,48614L,57815L,68740L,81496L,96568L,114103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238542Inst : IEnumerable<long>
{
public static readonly long[] Value=A238542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238542.Bytes);
public long this[int i]=>Value[i];

public static A238542Inst Instance=new A238542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238543
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,15L,21L,29L,39L,54L,73L,96L,126L,167L,217L,281L,359L,461L,587L,744L,935L,1176L,1470L,1832L,2271L,2814L,3465L,4262L,5219L,6383L,7777L,9456L,11458L,13869L,16733L,20155L,24208L,29040L,34743L,41508L,49473L,58886L,69944L,82964L,98208L,116113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238543Inst : IEnumerable<long>
{
public static readonly long[] Value=A238543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238543.Bytes);
public long this[int i]=>Value[i];

public static A238543Inst Instance=new A238543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238576
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,1L,4L,3L,2L,2L,4L,2L,2L,2L,3L,2L,2L,4L,5L,2L,2L,1L,8L,2L,2L,3L,3L,2L,2L,4L,4L,5L,6L,2L,5L,4L,3L,3L,7L,2L,2L,8L,8L,5L,4L,6L,3L,3L,7L,6L,5L,3L,3L,9L,4L,8L,3L,5L,3L,1L,5L,6L,4L,6L,7L,7L,8L,6L,6L,2L,7L,1L,5L,9L,7L,5L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238576Inst : IEnumerable<long>
{
public static readonly long[] Value=A238576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238576.Bytes);
public long this[int i]=>Value[i];

public static A238576Inst Instance=new A238576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238577
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,4L,3L,4L,3L,7L,4L,5L,6L,4L,4L,6L,4L,7L,1L,4L,6L,2L,8L,6L,6L,5L,4L,5L,4L,8L,5L,9L,3L,4L,2L,3L,10L,5L,11L,5L,10L,5L,6L,3L,6L,8L,7L,9L,6L,6L,3L,10L,3L,9L,9L,6L,10L,8L,8L,7L,4L,6L,6L,6L,5L,3L,9L,4L,8L,12L,5L,2L,8L,8L,3L,6L,10L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238577Inst : IEnumerable<long>
{
public static readonly long[] Value=A238577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238577.Bytes);
public long this[int i]=>Value[i];

public static A238577Inst Instance=new A238577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238578
{
public static readonly long[] Value={ 0L,1L,3L,11L,45L,191L,833L,3695L,16593L,75199L,343233L,1575551L,7265921L,33637631L,156234497L,727681791L,3397475585L,15896054783L,74512968705L,349859309567L,1645121398785L,7746058698751L,36516283891713L,172332643868671L,814108326764545L,3849410342715391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238578Inst : IEnumerable<long>
{
public static readonly long[] Value=A238578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238578.Bytes);
public long this[int i]=>Value[i];

public static A238578Inst Instance=new A238578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238579
{
public static readonly BigInteger[] Value={ 146L,273L,3713L,4779L,333359L,1325643L,3111717139L,29177760383L,69142225413L,3471134339561L,7980350584141L,1324115101168677L,33147123900129853L,1941131324815763997L,BigInteger.Parse("37816317113233982621"),BigInteger.Parse("291304010934939102849"),BigInteger.Parse("333777134924210136703397"),BigInteger.Parse("7409854792211363875345439") };
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
public class A238579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238579Inst Instance=new A238579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238580
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,1L,3L,1L,2L,3L,2L,3L,3L,3L,2L,4L,2L,3L,3L,3L,2L,3L,2L,2L,3L,1L,1L,5L,3L,4L,3L,1L,4L,3L,1L,5L,4L,4L,2L,4L,5L,4L,5L,2L,5L,5L,3L,2L,4L,2L,4L,5L,3L,5L,2L,7L,4L,5L,2L,5L,4L,8L,4L,6L,5L,6L,5L,2L,5L,4L,3L,6L,2L,5L,1L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238580Inst : IEnumerable<long>
{
public static readonly long[] Value=A238580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238580.Bytes);
public long this[int i]=>Value[i];

public static A238580Inst Instance=new A238580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238581
{
public static readonly long[] Value={ 1L,4L,12L,10L,3L,1L,4L,24L,40L,22L,1L,8L,65L,230L,467L,476L,269L,70L,9L,1L,8L,109L,641L,2281L,4424L,4718L,2409L,473L,1L,12L,182L,1479L,7644L,24024L,47022L,56226L,41000L,17834L,4545L,625L,39L,1L,12L,258L,2762L,19347L,86536L,255552L,495547L,625705L,499314L,239254L,61732L,6533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238581Inst : IEnumerable<long>
{
public static readonly long[] Value=A238581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238581.Bytes);
public long this[int i]=>Value[i];

public static A238581Inst Instance=new A238581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238582
{
public static readonly long[] Value={ 1L,4L,6L,1L,1L,4L,12L,3L,1L,8L,28L,10L,1L,8L,54L,82L,49L,8L,1L,1L,12L,95L,283L,311L,91L,10L,1L,12L,146L,647L,1118L,451L,68L,1L,16L,212L,1300L,3380L,3076L,1200L,209L,20L,1L,1L,16L,288L,2260L,8443L,13336L,9364L,2819L,387L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238582Inst : IEnumerable<long>
{
public static readonly long[] Value=A238582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238582.Bytes);
public long this[int i]=>Value[i];

public static A238582Inst Instance=new A238582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238583
{
public static readonly long[] Value={ 1L,3L,2L,1L,3L,4L,1L,6L,9L,1L,6L,14L,1L,9L,32L,18L,4L,1L,9L,55L,65L,23L,1L,12L,91L,164L,87L,1L,12L,132L,320L,229L,1L,15L,186L,608L,648L,134L,10L,1L,15L,245L,1043L,1633L,770L,106L,1L,18L,317L,1736L,3659L,2800L,646L,1L,18L,394L,2666L,7247L,7572L,2510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238583Inst : IEnumerable<long>
{
public static readonly long[] Value=A238583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238583.Bytes);
public long this[int i]=>Value[i];

public static A238583Inst Instance=new A238583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238584
{
public static readonly BigInteger[] Value={ 11L,47L,5L,337L,1171L,17L,67L,37649L,1222373689L,379L,257247841L,31L,13L,6354384973L,37L,7457L,103L,23L,19L,85447L,57301L,285287L,BigInteger.Parse("135510460324096326439969913816044529"),131L,11453399471L,14810217908652678241UL,701L,43L,3889L };
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
public class A238584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238584Inst Instance=new A238584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238585
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,1L,2L,2L,1L,1L,1L,3L,2L,3L,2L,2L,3L,1L,5L,1L,1L,3L,2L,4L,5L,2L,4L,3L,4L,1L,4L,5L,3L,4L,6L,3L,2L,2L,2L,2L,1L,8L,1L,3L,4L,7L,2L,5L,3L,2L,2L,4L,7L,4L,3L,2L,3L,5L,7L,5L,3L,6L,6L,5L,3L,4L,5L,2L,2L,2L,3L,7L,2L,3L,7L,3L,4L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238585Inst : IEnumerable<long>
{
public static readonly long[] Value=A238585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238585.Bytes);
public long this[int i]=>Value[i];

public static A238585Inst Instance=new A238585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238586
{
public static readonly long[] Value={ 1L,5L,16L,19L,9L,1L,1L,5L,32L,73L,66L,10L,1L,10L,85L,377L,961L,1348L,1080L,472L,111L,12L,1L,1L,10L,142L,1011L,4429L,11370L,17252L,14478L,6094L,1020L,70L,1L,15L,236L,2280L,14203L,56571L,146212L,244063L,261847L,179063L,77974L,21422L,3637L,368L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238586Inst : IEnumerable<long>
{
public static readonly long[] Value=A238586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238586.Bytes);
public long this[int i]=>Value[i];

public static A238586Inst Instance=new A238586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238587
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,1L,2L,3L,4L,5L,6L,8L,10L,13L,15L,22L,24L,31L,39L,48L,56L,73L,84L,106L,127L,153L,181L,226L,263L,317L,377L,453L,530L,640L,745L,890L,1043L,1233L,1441L,1708L,1982L,2331L,2715L,3183L,3687L,4316L,4989L,5814L,6725L,7802L,8998L,10437L,12004L,13871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238587Inst : IEnumerable<long>
{
public static readonly long[] Value=A238587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238587.Bytes);
public long this[int i]=>Value[i];

public static A238587Inst Instance=new A238587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238588
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,2L,3L,4L,6L,7L,10L,11L,15L,18L,23L,27L,36L,42L,52L,64L,79L,94L,117L,139L,171L,206L,248L,296L,361L,429L,514L,613L,732L,866L,1034L,1218L,1443L,1700L,2001L,2348L,2764L,3227L,3775L,4404L,5137L,5969L,6947L,8048L,9333L,10798L,12481L,14396L,16618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238588Inst : IEnumerable<long>
{
public static readonly long[] Value=A238588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238588.Bytes);
public long this[int i]=>Value[i];

public static A238588Inst Instance=new A238588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238589
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,5L,8L,13L,17L,24L,36L,47L,64L,88L,116L,153L,203L,261L,340L,439L,559L,710L,905L,1136L,1427L,1786L,2223L,2756L,3415L,4201L,5167L,6330L,7730L,9413L,11449L,13864L,16767L,20225L,24344L,29228L,35045L,41898L,50029L,59609L,70899L,84165L,99785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238589Inst : IEnumerable<long>
{
public static readonly long[] Value=A238589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238589.Bytes);
public long this[int i]=>Value[i];

public static A238589Inst Instance=new A238589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238590
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,6L,7L,12L,16L,25L,32L,46L,61L,86L,110L,149L,192L,257L,326L,425L,538L,694L,871L,1107L,1381L,1740L,2154L,2689L,3313L,4103L,5024L,6176L,7529L,9201L,11157L,13554L,16365L,19784L,23782L,28610L,34260L,41039L,48958L,58405L,69431L,82525L,97775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238590Inst : IEnumerable<long>
{
public static readonly long[] Value=A238590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238590.Bytes);
public long this[int i]=>Value[i];

public static A238590Inst Instance=new A238590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238591
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,5L,8L,11L,16L,23L,32L,45L,60L,81L,109L,144L,190L,247L,320L,412L,529L,675L,854L,1078L,1355L,1695L,2117L,2626L,3251L,4010L,4932L,6047L,7394L,9012L,10959L,13290L,16083L,19407L,23379L,28090L,33689L,40317L,48158L,57406L,68324L,81155L,96248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238591Inst : IEnumerable<long>
{
public static readonly long[] Value=A238591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238591.Bytes);
public long this[int i]=>Value[i];

public static A238591Inst Instance=new A238591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238656
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,4L,5L,9L,14L,19L,28L,41L,57L,80L,109L,149L,199L,265L,351L,457L,599L,780L,1011L,1299L,1664L,2121L,2682L,3377L,4252L,5345L,6660L,8279L,10277L,12733L,15596L,19245L,23556L,28761L,35066L,42723L,51615L,62657L,75494L,90978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238656Inst : IEnumerable<long>
{
public static readonly long[] Value=A238656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238656.Bytes);
public long this[int i]=>Value[i];

public static A238656Inst Instance=new A238656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238657
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,5L,9L,11L,16L,25L,34L,45L,64L,87L,121L,160L,212L,279L,369L,481L,614L,797L,1027L,1308L,1670L,2102L,2661L,3345L,4189L,5224L,6494L,8069L,9982L,12281L,15093L,18508L,22731L,27564L,33639L,40757L,49496L,59838L,72228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238657Inst : IEnumerable<long>
{
public static readonly long[] Value=A238657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238657.Bytes);
public long this[int i]=>Value[i];

public static A238657Inst Instance=new A238657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238658
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,14L,19L,25L,33L,44L,57L,72L,92L,114L,143L,179L,216L,267L,321L,389L,470L,562L,668L,798L,946L,1100L,1295L,1521L,1759L,2059L,2392L,2742L,3206L,3674L,4172L,4831L,5566L,6265L,7115L,8089L,9152L,10381L,11664L,13131L,14927L,16666L,18565L,20977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238658Inst : IEnumerable<long>
{
public static readonly long[] Value=A238658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238658.Bytes);
public long this[int i]=>Value[i];

public static A238658Inst Instance=new A238658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238659
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,14L,20L,25L,35L,44L,59L,72L,93L,115L,146L,179L,221L,267L,328L,393L,472L,562L,687L,801L,948L,1109L,1315L,1521L,1797L,2059L,2414L,2775L,3213L,3686L,4256L,4831L,5574L,6317L,7205L,8089L,9279L,10381L,11751L,13234L,14949L,16666L,18869L,20986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238659Inst : IEnumerable<long>
{
public static readonly long[] Value=A238659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238659.Bytes);
public long this[int i]=>Value[i];

public static A238659Inst Instance=new A238659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238660
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,2L,0L,1L,1L,3L,0L,5L,0L,7L,4L,2L,0L,19L,3L,2L,9L,20L,0L,38L,0L,22L,33L,7L,12L,84L,0L,8L,52L,90L,0L,127L,0L,87L,103L,22L,0L,304L,9L,74L,131L,153L,0L,214L,139L,390L,192L,59L,0L,1219L,0L,73L,460L,372L,383L,908L,0L,501L,439L,832L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238660Inst : IEnumerable<long>
{
public static readonly long[] Value=A238660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238660.Bytes);
public long this[int i]=>Value[i];

public static A238660Inst Instance=new A238660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238661
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,5L,7L,12L,18L,29L,42L,61L,85L,118L,164L,223L,299L,399L,530L,693L,888L,1157L,1488L,1901L,2403L,3044L,3807L,4783L,5935L,7368L,9097L,11197L,13721L,16806L,20441L,24868L,30133L,36494L,43895L,52880L,63424L,75900L,90609L,108088L,128404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238661Inst : IEnumerable<long>
{
public static readonly long[] Value=A238661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238661.Bytes);
public long this[int i]=>Value[i];

public static A238661Inst Instance=new A238661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238662
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,3L,5L,9L,12L,20L,29L,43L,62L,88L,118L,169L,223L,306L,403L,532L,693L,907L,1160L,1490L,1910L,2423L,3044L,3845L,4783L,5957L,7401L,9104L,11209L,13805L,16806L,20449L,24920L,30223L,36494L,44022L,52880L,63511L,76003L,90631L,108088L,128708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238662Inst : IEnumerable<long>
{
public static readonly long[] Value=A238662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238662.Bytes);
public long this[int i]=>Value[i];

public static A238662Inst Instance=new A238662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238663
{
public static readonly long[] Value={ 3L,31L,59L,163L,487L,1019L,433L,2617L,1831L,2383L,16189L,2711L,3407L,18541L,2693L,21613L,51517L,6323L,37313L,32401L,65543L,13337L,72661L,95603L,19571L,484369L,28463L,31817L,598891L,59627L,405599L,217117L,93257L,191021L,497257L,381569L,74567L,1120087L,263621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238663Inst : IEnumerable<long>
{
public static readonly long[] Value=A238663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238663.Bytes);
public long this[int i]=>Value[i];

public static A238663Inst Instance=new A238663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238664
{
public static readonly long[] Value={ 7L,31L,37L,43L,79L,97L,103L,241L,271L,307L,367L,373L,421L,499L,547L,571L,601L,607L,709L,751L,883L,907L,967L,1033L,1129L,1213L,1231L,1237L,1327L,1423L,1597L,1609L,1621L,1747L,1801L,1867L,1933L,1951L,1993L,2017L,2131L,2137L,2203L,2221L,2281L,2287L,2647L,2659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238664Inst : IEnumerable<long>
{
public static readonly long[] Value=A238664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238664.Bytes);
public long this[int i]=>Value[i];

public static A238664Inst Instance=new A238664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238665
{
public static readonly long[] Value={ 11L,47L,59L,61L,67L,71L,127L,131L,137L,151L,157L,227L,337L,347L,353L,431L,467L,509L,521L,557L,577L,599L,613L,617L,619L,631L,683L,691L,701L,733L,743L,773L,857L,911L,983L,997L,1013L,1039L,1051L,1097L,1151L,1153L,1193L,1201L,1307L,1321L,1453L,1471L,1531L,1607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238665Inst : IEnumerable<long>
{
public static readonly long[] Value=A238665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238665.Bytes);
public long this[int i]=>Value[i];

public static A238665Inst Instance=new A238665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238666
{
public static readonly long[] Value={ 29L,41L,113L,163L,173L,199L,211L,251L,449L,479L,491L,503L,659L,661L,809L,823L,941L,1031L,1171L,1181L,1259L,1361L,1669L,1753L,1759L,1861L,1879L,1901L,1999L,2039L,2081L,2141L,2161L,2213L,2273L,2371L,2473L,2539L,2579L,2591L,2633L,2819L,2903L,2939L,2969L,3011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238666Inst : IEnumerable<long>
{
public static readonly long[] Value=A238666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238666.Bytes);
public long this[int i]=>Value[i];

public static A238666Inst Instance=new A238666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238667
{
public static readonly long[] Value={ 193L,331L,409L,457L,487L,787L,829L,991L,1087L,1117L,1249L,1297L,1303L,1543L,1627L,2251L,2311L,2377L,2521L,2767L,2857L,3061L,3067L,3739L,3769L,3907L,3931L,4027L,4057L,4099L,4159L,4567L,5023L,5281L,5407L,5581L,5749L,5827L,5839L,6073L,6379L,7039L,7879L,7963L,8017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238667Inst : IEnumerable<long>
{
public static readonly long[] Value=A238667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238667.Bytes);
public long this[int i]=>Value[i];

public static A238667Inst Instance=new A238667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238668
{
public static readonly long[] Value={ 139L,523L,563L,769L,853L,1019L,1489L,1553L,1559L,1583L,1693L,1723L,1949L,2239L,2339L,2393L,2423L,3469L,3779L,3863L,4073L,4133L,4273L,4283L,4483L,4663L,4969L,5233L,5503L,5683L,5869L,5953L,6269L,6299L,6473L,6569L,6959L,7229L,7309L,8233L,8513L,8573L,8839L,9749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238668Inst : IEnumerable<long>
{
public static readonly long[] Value=A238668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238668.Bytes);
public long this[int i]=>Value[i];

public static A238668Inst Instance=new A238668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238669
{
public static readonly long[] Value={ 107L,293L,359L,389L,397L,401L,433L,461L,647L,727L,797L,821L,977L,1063L,1163L,1229L,1301L,1367L,1427L,1451L,1499L,1571L,1657L,1721L,1987L,2099L,2111L,2179L,2207L,2351L,2447L,2707L,2797L,2801L,2861L,2957L,3037L,3187L,3221L,3457L,3463L,3527L,3541L,3557L,3607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238669Inst : IEnumerable<long>
{
public static readonly long[] Value=A238669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238669.Bytes);
public long this[int i]=>Value[i];

public static A238669Inst Instance=new A238669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238670
{
public static readonly long[] Value={ 181L,277L,541L,937L,1381L,1741L,2551L,2617L,2677L,3433L,3919L,4231L,4657L,4933L,5923L,6337L,6481L,6781L,7669L,7717L,7867L,8161L,8167L,8287L,8329L,8389L,8647L,8707L,9013L,9151L,9397L,9661L,9739L,9967L,10651L,11059L,11287L,11743L,11887L,12421L,12457L,12697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238670Inst : IEnumerable<long>
{
public static readonly long[] Value=A238670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238670.Bytes);
public long this[int i]=>Value[i];

public static A238670Inst Instance=new A238670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238671
{
public static readonly long[] Value={ 101L,191L,233L,311L,881L,1103L,1291L,1733L,1831L,1931L,2011L,2029L,2113L,2129L,2269L,2543L,2843L,3023L,3089L,3163L,3299L,3491L,3701L,3761L,3943L,4051L,4391L,4583L,4951L,5333L,5441L,5743L,5801L,6211L,6421L,6491L,7019L,7069L,7121L,7253L,7331L,8081L,8171L,8293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238671Inst : IEnumerable<long>
{
public static readonly long[] Value=A238671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238671.Bytes);
public long this[int i]=>Value[i];

public static A238671Inst Instance=new A238671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238720
{
public static readonly long[] Value={ 2L,4L,10L,16L,42L,64L,170L,256L,682L,1024L,2730L,4096L,10922L,16384L,43690L,65536L,174762L,262144L,699050L,1048576L,2796202L,4194304L,11184810L,16777216L,44739242L,67108864L,178956970L,268435456L,715827882L,1073741824L,2863311530L,4294967296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238720Inst : IEnumerable<long>
{
public static readonly long[] Value=A238720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238720.Bytes);
public long this[int i]=>Value[i];

public static A238720Inst Instance=new A238720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238721
{
public static readonly long[] Value={ 4L,10L,40L,86L,336L,704L,2704L,5660L,21504L,45176L,170464L,359400L,1350272L,2854496L,10694912L,22650672L,84716224L,179637056L,671110848L,1424180800L,5316817088L,11288673952L,42124029504L,89466980000L,333750473152L,708999096096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238721Inst : IEnumerable<long>
{
public static readonly long[] Value=A238721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238721.Bytes);
public long this[int i]=>Value[i];

public static A238721Inst Instance=new A238721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238722
{
public static readonly long[] Value={ 4L,16L,86L,284L,1506L,4636L,24298L,73300L,381280L,1144292L,5923512L,17767180L,91688754L,275195668L,1417323260L,4257556764L,21898760846L,65830136636L,338306366754L,1017543445164L,5226264297018L,15725498143268L,80738182410936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238722Inst : IEnumerable<long>
{
public static readonly long[] Value=A238722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238722.Bytes);
public long this[int i]=>Value[i];

public static A238722Inst Instance=new A238722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238723
{
public static readonly long[] Value={ 8L,42L,336L,1506L,11440L,48538L,359456L,1502622L,10971288L,45750856L,331213056L,1382740252L,9956765976L,41644596642L,298827741680L,1252006016638L,8963172170592L,37604588665246L,268792589572384L,1128862873230946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238723Inst : IEnumerable<long>
{
public static readonly long[] Value=A238723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238723.Bytes);
public long this[int i]=>Value[i];

public static A238723Inst Instance=new A238723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238724
{
public static readonly long[] Value={ 8L,64L,704L,4636L,48538L,296384L,3022230L,17949864L,180550234L,1061806368L,10600024286L,62140749704L,617608768008L,3618173053808L,35862152511062L,210135126555696L,2079126382654402L,12188142518006216L,120451983593221798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238724Inst : IEnumerable<long>
{
public static readonly long[] Value=A238724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238724.Bytes);
public long this[int i]=>Value[i];

public static A238724Inst Instance=new A238724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238725
{
public static readonly long[] Value={ 16L,170L,2704L,24298L,359456L,3022230L,43248968L,354823094L,4990305568L,40601871406L,565368140984L,4590068472250L,63524027304400L,515796560253008L,7110064227756832L,57780149815277172L,794366012177843040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238725Inst : IEnumerable<long>
{
public static readonly long[] Value=A238725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238725.Bytes);
public long this[int i]=>Value[i];

public static A238725Inst Instance=new A238725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238726
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,4L,4L,10L,10L,4L,8L,16L,40L,16L,8L,8L,42L,86L,86L,42L,8L,16L,64L,336L,284L,336L,64L,16L,16L,170L,704L,1506L,1506L,704L,170L,16L,32L,256L,2704L,4636L,11440L,4636L,2704L,256L,32L,32L,682L,5660L,24298L,48538L,48538L,24298L,5660L,682L,32L,64L,1024L,21504L,73300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238726Inst : IEnumerable<long>
{
public static readonly long[] Value=A238726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238726.Bytes);
public long this[int i]=>Value[i];

public static A238726Inst Instance=new A238726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238727
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,1L,3L,0L,0L,1L,2L,7L,0L,0L,1L,3L,8L,14L,0L,0L,1L,4L,11L,19L,41L,0L,0L,1L,7L,19L,34L,64L,107L,0L,0L,1L,11L,32L,62L,119L,202L,337L,0L,0L,1L,21L,64L,131L,248L,418L,671L,1066L,0L,0L,1L,36L,124L,277L,545L,943L,1518L,2361L,3691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238727Inst : IEnumerable<long>
{
public static readonly long[] Value=A238727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238727.Bytes);
public long this[int i]=>Value[i];

public static A238727Inst Instance=new A238727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238728
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,14L,41L,107L,337L,1066L,3691L,12962L,49061L,188894L,766845L,3182844L,13758383L,60858842L,278312475L,1301323108L,6258671365L,30742575588L,154785692507L,794888735945L,4173162573277L,22318859784416L,121767607626621L,676010926754742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238728Inst : IEnumerable<long>
{
public static readonly long[] Value=A238728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238728.Bytes);
public long this[int i]=>Value[i];

public static A238728Inst Instance=new A238728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238729
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,7L,2L,3L,4L,11L,4L,13L,4L,6L,2L,17L,5L,19L,4L,6L,4L,23L,4L,5L,4L,3L,4L,29L,8L,31L,2L,6L,4L,10L,5L,37L,4L,6L,4L,41L,8L,43L,4L,6L,4L,47L,4L,7L,6L,6L,4L,53L,5L,10L,4L,6L,4L,59L,8L,61L,4L,6L,2L,10L,8L,67L,4L,6L,8L,71L,5L,73L,4L,8L,4L,14L,8L,79L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238729Inst : IEnumerable<long>
{
public static readonly long[] Value=A238729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238729.Bytes);
public long this[int i]=>Value[i];

public static A238729Inst Instance=new A238729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238730
{
public static readonly long[] Value={ 7L,19L,47L,79L,109L,139L,199L,229L,317L,439L,467L,619L,647L,829L,859L,887L,1039L,1069L,1097L,1307L,1429L,1459L,1489L,1609L,1669L,1699L,1789L,1879L,1999L,2089L,2389L,2689L,2719L,3169L,3259L,3469L,3677L,3769L,3919L,4007L,4099L,4159L,4219L,4519L,4729L,4789L,4937L,5237L,5419L,5449L,5479L,5507L,5659L,5749L,5869L,6709L,6829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238730Inst : IEnumerable<long>
{
public static readonly long[] Value=A238730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238730.Bytes);
public long this[int i]=>Value[i];

public static A238730Inst Instance=new A238730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238731
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,5L,13L,7L,1L,13L,40L,33L,10L,1L,34L,120L,132L,62L,13L,1L,89L,354L,483L,308L,100L,16L,1L,233L,1031L,1671L,1345L,595L,147L,19L,1L,610L,2972L,5561L,5398L,3030L,1020L,203L,22L,1L,1597L,8495L,17984L,20410L,13893L,5943L,1610L,268L,25L,1L,4181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238731Inst : IEnumerable<long>
{
public static readonly long[] Value=A238731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238731.Bytes);
public long this[int i]=>Value[i];

public static A238731Inst Instance=new A238731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238732
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,3L,3L,2L,2L,1L,2L,1L,3L,4L,4L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,2L,1L,2L,4L,5L,5L,4L,4L,3L,3L,1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,2L,3L,2L,4L,5L,4L,3L,3L,5L,4L,4L,3L,3L,4L,4L,3L,3L,3L,4L,4L,3L,3L,3L,3L,4L,5L,4L,4L,4L,3L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238732Inst : IEnumerable<long>
{
public static readonly long[] Value=A238732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238732.Bytes);
public long this[int i]=>Value[i];

public static A238732Inst Instance=new A238732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238733
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,3L,3L,2L,2L,2L,4L,3L,4L,3L,4L,2L,3L,1L,3L,3L,4L,2L,3L,1L,2L,2L,3L,1L,2L,1L,4L,5L,5L,3L,2L,2L,3L,3L,3L,3L,4L,3L,3L,3L,3L,4L,6L,5L,5L,4L,5L,3L,4L,2L,3L,3L,4L,2L,3L,3L,5L,5L,5L,2L,2L,1L,4L,4L,4L,3L,4L,3L,4L,4L,5L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238733Inst : IEnumerable<long>
{
public static readonly long[] Value=A238733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238733.Bytes);
public long this[int i]=>Value[i];

public static A238733Inst Instance=new A238733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238734
{
public static readonly long[] Value={ 2L,7L,7L,8L,7L,6L,8L,8L,2L,0L,7L,3L,2L,3L,1L,9L,6L,1L,9L,3L,2L,3L,1L,0L,8L,6L,6L,7L,0L,3L,2L,5L,3L,4L,2L,0L,3L,6L,0L,2L,0L,6L,2L,9L,4L,1L,4L,7L,3L,6L,8L,2L,9L,8L,8L,2L,4L,5L,2L,7L,0L,5L,3L,3L,6L,7L,7L,1L,6L,4L,9L,8L,0L,0L,8L,2L,8L,3L,5L,0L,7L,5L,9L,9L,6L,6L,3L,7L,4L,8L,8L,4L,6L,9L,1L,0L,3L,9L,4L,1L,6L,6L,9L,8L,0L,9L,2L,9L,5L,8L,6L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238734Inst : IEnumerable<long>
{
public static readonly long[] Value=A238734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238734.Bytes);
public long this[int i]=>Value[i];

public static A238734Inst Instance=new A238734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238735
{
public static readonly long[] Value={ 1L,2L,1L,2L,0L,3L,2L,2L,0L,1L,0L,2L,0L,0L,0L,3L,0L,1L,0L,3L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238735Inst : IEnumerable<long>
{
public static readonly long[] Value=A238735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238735.Bytes);
public long this[int i]=>Value[i];

public static A238735Inst Instance=new A238735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238768
{
public static readonly long[] Value={ 3L,6L,14L,32L,72L,164L,372L,844L,1916L,4348L,9868L,22396L,50828L,115356L,261804L,594172L,1348492L,3060444L,6945772L,15763644L,35776076L,81194908L,184274348L,418216316L,949154828L,2154136156L,4888878444L,11095460412L,25181489612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238768Inst : IEnumerable<long>
{
public static readonly long[] Value=A238768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238768.Bytes);
public long this[int i]=>Value[i];

public static A238768Inst Instance=new A238768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238769
{
public static readonly long[] Value={ 6L,30L,156L,810L,4106L,21132L,108124L,553828L,2837376L,14532678L,74442728L,381318484L,1953232394L,10005076766L,51249191766L,262514541710L,1344682852464L,6887891796282L,35281965360630L,180725414294348L,925732869184032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238769Inst : IEnumerable<long>
{
public static readonly long[] Value=A238769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238769.Bytes);
public long this[int i]=>Value[i];

public static A238769Inst Instance=new A238769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238770
{
public static readonly long[] Value={ 14L,156L,1888L,22242L,258720L,3044922L,35640158L,417759376L,4896355616L,57381427884L,672498981628L,7881524612006L,92368952604638L,1082538628472286L,12687046377009060L,148688524405160494L,1742587393576465646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238770Inst : IEnumerable<long>
{
public static readonly long[] Value=A238770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238770.Bytes);
public long this[int i]=>Value[i];

public static A238770Inst Instance=new A238770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238771
{
public static readonly BigInteger[] Value={ 32L,810L,22242L,604412L,16041854L,432845880L,11591229010L,311132395064L,8346793174230L,223952032043062L,6008329642035378L,161205690589879938L,4325039168486267828L,BigInteger.Parse("116040031314154634676"),BigInteger.Parse("3113310166409157643842") };
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
public class A238771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238771Inst Instance=new A238771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238772
{
public static readonly BigInteger[] Value={ 72L,4106L,258720L,16041854L,976810146L,60277582112L,3697656930974L,227187542722224L,13955749970865816L,857261491476892738L,BigInteger.Parse("52658393610889121840"),BigInteger.Parse("3234721167229892503186"),BigInteger.Parse("198698256597994229328826") };
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
public class A238772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238772Inst Instance=new A238772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238773
{
public static readonly BigInteger[] Value={ 164L,21132L,3044922L,432845880L,60277582112L,8524103612876L,1196624830872094L,168396084501288492L,BigInteger.Parse("23680768603975178514"),BigInteger.Parse("3331020788759644930084"),BigInteger.Parse("468469415929532646412296"),BigInteger.Parse("65893254772438271888320118") };
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
public class A238773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238773Inst Instance=new A238773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238774
{
public static readonly BigInteger[] Value={ 372L,108124L,35640158L,11591229010L,3697656930974L,1196624830872094L,384784855475971422L,BigInteger.Parse("123956747366595875798"),BigInteger.Parse("39919552979103628547138"),BigInteger.Parse("12856324240299526142031482"),BigInteger.Parse("4140275724296969459612393060") };
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
public class A238774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238774Inst Instance=new A238774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238775
{
public static readonly long[] Value={ 3L,6L,6L,14L,30L,14L,32L,156L,156L,32L,72L,810L,1888L,810L,72L,164L,4106L,22242L,22242L,4106L,164L,372L,21132L,258720L,604412L,258720L,21132L,372L,844L,108124L,3044922L,16041854L,16041854L,3044922L,108124L,844L,1916L,553828L,35640158L,432845880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238775Inst : IEnumerable<long>
{
public static readonly long[] Value=A238775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238775.Bytes);
public long this[int i]=>Value[i];

public static A238775Inst Instance=new A238775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238776
{
public static readonly long[] Value={ 2L,5L,7L,13L,31L,41L,43L,83L,109L,151L,211L,281L,307L,317L,349L,353L,499L,601L,709L,757L,883L,911L,971L,1447L,1453L,1483L,1531L,1801L,2053L,2281L,2819L,2833L,3163L,3329L,3331L,3881L,3907L,4051L,4243L,4447L,4451L,4703L,4751L,5483L,5659L,5701L,5737L,6011L,6271L,6311L,6361L,6379L,6427L,6571L,6827L,6841L,6983L,7159L,7879L,8209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238776Inst : IEnumerable<long>
{
public static readonly long[] Value=A238776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238776.Bytes);
public long this[int i]=>Value[i];

public static A238776Inst Instance=new A238776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238777
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,17L,29L,49L,82L,137L,229L,382L,638L,1063L,1772L,2953L,4923L,8205L,13675L,22792L,37987L,63312L,105521L,175868L,293114L,488524L,814207L,1357012L,2261686L,3769478L,6282463L,10470772L,17451288L,29085480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238777Inst : IEnumerable<long>
{
public static readonly long[] Value=A238777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238777.Bytes);
public long this[int i]=>Value[i];

public static A238777Inst Instance=new A238777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238778
{
public static readonly long[] Value={ 2L,3L,8L,15L,12L,21L,32L,36L,40L,55L,72L,65L,56L,90L,64L,119L,144L,57L,120L,168L,132L,161L,240L,200L,156L,270L,168L,203L,360L,155L,320L,396L,136L,350L,432L,333L,380L,546L,320L,369L,672L,387L,352L,810L,368L,423L,672L,294L,600L,816L,520L,583L,864L,660L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238778Inst : IEnumerable<long>
{
public static readonly long[] Value=A238778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238778.Bytes);
public long this[int i]=>Value[i];

public static A238778Inst Instance=new A238778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238779
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,2L,4L,3L,7L,6L,11L,9L,18L,15L,27L,23L,40L,35L,59L,51L,85L,75L,119L,106L,168L,150L,231L,208L,316L,286L,428L,388L,575L,525L,764L,700L,1012L,929L,1327L,1223L,1732L,1601L,2246L,2080L,2898L,2692L,3715L,3459L,4748L,4428L,6032L,5638L,7635L,7150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238779Inst : IEnumerable<long>
{
public static readonly long[] Value=A238779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238779.Bytes);
public long this[int i]=>Value[i];

public static A238779Inst Instance=new A238779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238780
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,2L,5L,4L,7L,5L,10L,8L,14L,11L,20L,16L,26L,21L,37L,31L,48L,40L,65L,55L,85L,72L,113L,97L,145L,125L,190L,165L,242L,211L,313L,274L,396L,348L,505L,446L,633L,561L,801L,713L,998L,890L,1249L,1118L,1548L,1389L,1922L,1730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238780Inst : IEnumerable<long>
{
public static readonly long[] Value=A238780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238780.Bytes);
public long this[int i]=>Value[i];

public static A238780Inst Instance=new A238780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238781
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,3L,2L,4L,2L,6L,4L,6L,4L,10L,5L,12L,7L,16L,8L,20L,10L,27L,14L,32L,16L,44L,19L,53L,25L,69L,31L,84L,36L,108L,47L,130L,55L,167L,67L,202L,83L,252L,99L,305L,119L,380L,146L,456L,173L,564L,208L,676L,250L,826L,298L,991L,352L,1205L,424L,1435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238781Inst : IEnumerable<long>
{
public static readonly long[] Value=A238781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238781.Bytes);
public long this[int i]=>Value[i];

public static A238781Inst Instance=new A238781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238782
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,2L,5L,3L,9L,5L,11L,9L,18L,12L,25L,18L,35L,26L,48L,36L,67L,50L,87L,69L,119L,91L,157L,123L,206L,162L,266L,213L,349L,277L,443L,360L,572L,460L,725L,590L,919L,750L,1156L,950L,1456L,1195L,1812L,1502L,2263L,1872L,2802L,2334L,3468L,2892L,4267L,3574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238782Inst : IEnumerable<long>
{
public static readonly long[] Value=A238782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238782.Bytes);
public long this[int i]=>Value[i];

public static A238782Inst Instance=new A238782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238783
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,2L,0L,2L,2L,2L,1L,5L,1L,5L,3L,8L,2L,10L,4L,13L,6L,16L,6L,25L,7L,28L,11L,38L,13L,48L,16L,61L,22L,75L,25L,100L,30L,119L,41L,153L,47L,186L,59L,234L,73L,283L,87L,356L,106L,426L,132L,528L,154L,639L,186L,781L,227L,935L,271L,1143L,322L,1362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238783Inst : IEnumerable<long>
{
public static readonly long[] Value=A238783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238783.Bytes);
public long this[int i]=>Value[i];

public static A238783Inst Instance=new A238783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238864
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,14L,20L,26L,36L,46L,63L,79L,104L,131L,169L,210L,269L,332L,418L,515L,640L,782L,967L,1173L,1435L,1736L,2108L,2534L,3062L,3663L,4398L,5243L,6259L,7429L,8834L,10441L,12356L,14559L,17159L,20144L,23661L,27686L,32403L,37807L,44102L,51306L,59680L,69235L,80297L,92924L,107482L,124070L,143157L,164862L,189763L,218057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238864Inst : IEnumerable<long>
{
public static readonly long[] Value=A238864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238864.Bytes);
public long this[int i]=>Value[i];

public static A238864Inst Instance=new A238864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238865
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,21L,28L,38L,50L,67L,87L,114L,146L,188L,238L,302L,379L,476L,593L,737L,911L,1124L,1379L,1688L,2058L,2504L,3034L,3669L,4422L,5319L,6378L,7634L,9114L,10859L,12908L,15316L,18134L,21434L,25283L,29775L,35001L,41080L,48133L,56312L,65778L,76727L,89366L,103947L,120739L,140065L,162271L,187769L,217006L,250504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238865Inst : IEnumerable<long>
{
public static readonly long[] Value=A238865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238865.Bytes);
public long this[int i]=>Value[i];

public static A238865Inst Instance=new A238865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238866
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,29L,40L,52L,71L,91L,121L,155L,202L,255L,328L,410L,520L,647L,810L,1000L,1244L,1525L,1879L,2293L,2804L,3401L,4135L,4988L,6028L,7241L,8701L,10404L,12447L,14818L,17645L,20931L,24822L,29334L,34658L,40817L,48052L,56416L,66190L,77471L,90621L,105756L,123338L,143555L,166956L,193815L,224828L,260352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238866Inst : IEnumerable<long>
{
public static readonly long[] Value=A238866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238866.Bytes);
public long this[int i]=>Value[i];

public static A238866Inst Instance=new A238866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238867
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,41L,54L,73L,95L,125L,162L,210L,268L,344L,434L,549L,688L,861L,1069L,1328L,1637L,2016L,2472L,3023L,3682L,4479L,5424L,6558L,7905L,9508L,11404L,13657L,16307L,19440L,23123L,27454L,32526L,38479L,45424L,53545L,63006L,74024L,86824L,101701L,118931L,138899L,161983L,188656L,219419L,254895L,295709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238867Inst : IEnumerable<long>
{
public static readonly long[] Value=A238867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238867.Bytes);
public long this[int i]=>Value[i];

public static A238867Inst Instance=new A238867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238868
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,55L,75L,97L,129L,166L,217L,276L,356L,449L,572L,715L,900L,1117L,1393L,1717L,2123L,2601L,3193L,3889L,4744L,5748L,6970L,8404L,10135L,12165L,14600L,17448L,20845L,24813L,29522L,35009L,41491L,49031L,57900L,68195L,80258L,94234L,110553L,129421L,151382L,176724L,206132L,240002L,279195L,324255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238868Inst : IEnumerable<long>
{
public static readonly long[] Value=A238868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238868.Bytes);
public long this[int i]=>Value[i];

public static A238868Inst Instance=new A238868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238869
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,56L,76L,99L,131L,170L,221L,283L,364L,461L,586L,737L,926L,1154L,1439L,1779L,2199L,2703L,3317L,4051L,4942L,6001L,7278L,8796L,10610L,12760L,15323L,18344L,21928L,26148L,31127L,36971L,43848L,51890L,61321L,72327L,85183L,100149L,117588L,137827L,161343L,188583L,220139L,256607L,298761L,347360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238869Inst : IEnumerable<long>
{
public static readonly long[] Value=A238869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238869.Bytes);
public long this[int i]=>Value[i];

public static A238869Inst Instance=new A238869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238870
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,2L,2L,1L,4L,4L,4L,9L,10L,11L,21L,25L,30L,51L,62L,80L,125L,157L,208L,309L,399L,536L,772L,1013L,1373L,1938L,2574L,3503L,4882L,6540L,8918L,12329L,16611L,22672L,31183L,42182L,57588L,78952L,107092L,146202L,200037L,271831L,371057L,507053L,689885L,941558L,1285655L,1750672L,2388951L,3260459L,4442179L,6060948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238870Inst : IEnumerable<long>
{
public static readonly long[] Value=A238870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238870.Bytes);
public long this[int i]=>Value[i];

public static A238870Inst Instance=new A238870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238871
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,10L,14L,21L,27L,40L,52L,70L,92L,124L,156L,206L,264L,335L,425L,539L,673L,847L,1052L,1300L,1611L,1990L,2433L,2977L,3638L,4420L,5367L,6496L,7829L,9439L,11341L,13590L,16270L,19425L,23135L,27525L,32697L,38745L,45844L,54168L,63875L,75247L,88493L,103892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238871Inst : IEnumerable<long>
{
public static readonly long[] Value=A238871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238871.Bytes);
public long this[int i]=>Value[i];

public static A238871Inst Instance=new A238871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238872
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,3L,3L,4L,3L,6L,4L,3L,5L,6L,4L,9L,5L,3L,7L,7L,5L,9L,6L,6L,8L,9L,5L,9L,8L,6L,10L,6L,5L,15L,8L,9L,10L,7L,7L,12L,10L,3L,11L,15L,7L,15L,8L,6L,13L,12L,9L,12L,9L,9L,14L,12L,7L,15L,12L,6L,15L,13L,6L,21L,12L,12L,13L,6L,11L,15L,15L,9L,14L,12L,8L,24L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238872Inst : IEnumerable<long>
{
public static readonly long[] Value=A238872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238872.Bytes);
public long this[int i]=>Value[i];

public static A238872Inst Instance=new A238872Inst();

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