using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A253082
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,9L,13L,22L,23L,24L,25L,29L,33L,37L,46L,62L,63L,64L,65L,69L,70L,71L,75L,84L,88L,92L,96L,112L,121L,130L,146L,171L,172L,173L,174L,178L,179L,180L,184L,193L,194L,195L,196L,200L,204L,208L,217L,233L,237L,241L,245L,261L,265L,269L,285L,321L,330L,339L,348L,384L,400L,416L,441L,477L,478L,479L,480L,484L,485L,486L,490L,499L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253082Inst : IEnumerable<long>
{
public static readonly long[] Value=A253082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253082.Bytes);
public long this[int i]=>Value[i];

public static A253082Inst Instance=new A253082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253083
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,12L,13L,14L,15L,17L,19L,21L,24L,28L,29L,30L,31L,33L,34L,35L,37L,40L,42L,44L,46L,50L,53L,56L,60L,65L,66L,67L,68L,70L,71L,72L,74L,77L,78L,79L,80L,82L,84L,86L,89L,93L,95L,97L,99L,103L,105L,107L,111L,117L,120L,123L,126L,132L,136L,140L,145L,151L,152L,153L,154L,156L,157L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253083Inst : IEnumerable<long>
{
public static readonly long[] Value=A253083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253083.Bytes);
public long this[int i]=>Value[i];

public static A253083Inst Instance=new A253083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253084
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253084Inst : IEnumerable<long>
{
public static readonly long[] Value=A253084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253084.Bytes);
public long this[int i]=>Value[i];

public static A253084Inst Instance=new A253084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253085
{
public static readonly long[] Value={ 5L,7L,17L,19L,19L,31L,25L,61L,71L,41L,71L,77L,71L,91L,77L,107L,121L,85L,113L,103L,217L,251L,125L,251L,281L,121L,185L,151L,251L,289L,151L,281L,307L,251L,335L,281L,311L,349L,289L,373L,307L,383L,445L,247L,445L,487L,289L,397L,331L,389L,439L,331L,463L,409L,773L,895L,457L,895L,997L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253085Inst : IEnumerable<long>
{
public static readonly long[] Value=A253085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253085.Bytes);
public long this[int i]=>Value[i];

public static A253085Inst Instance=new A253085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253086
{
public static readonly long[] Value={ 1L,4L,5L,12L,4L,16L,20L,48L,17L,24L,36L,80L,12L,48L,60L,144L,40L,56L,108L,200L,56L,72L,140L,200L,156L,176L,232L,368L,140L,232L,336L,440L,316L,304L,388L,544L,316L,344L,364L,464L,460L,424L,508L,584L,448L,488L,780L,808L,688L,624L,792L,1120L,736L,784L,860L,1240L,876L,1088L,1100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253086Inst : IEnumerable<long>
{
public static readonly long[] Value=A253086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253086.Bytes);
public long this[int i]=>Value[i];

public static A253086Inst Instance=new A253086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253087
{
public static readonly long[] Value={ 1L,4L,12L,48L,144L,440L,1816L,6816L,25816L,101856L,397944L,1573464L,6274560L,25071152L,100180872L,400625360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253087Inst : IEnumerable<long>
{
public static readonly long[] Value=A253087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253087.Bytes);
public long this[int i]=>Value[i];

public static A253087Inst Instance=new A253087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253088
{
public static readonly long[] Value={ 1L,9L,12L,40L,24L,88L,48L,148L,80L,164L,172L,296L,236L,380L,324L,500L,436L,552L,552L,644L,688L,936L,788L,1168L,928L,1296L,1044L,1444L,1352L,1768L,1576L,2136L,1728L,2116L,1992L,2264L,2288L,2604L,2536L,3056L,2812L,3380L,3112L,3864L,3484L,4204L,3836L,4764L,4120L,4748L,4456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253088Inst : IEnumerable<long>
{
public static readonly long[] Value=A253088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253088.Bytes);
public long this[int i]=>Value[i];

public static A253088Inst Instance=new A253088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253089
{
public static readonly long[] Value={ 1L,9L,20L,29L,69L,44L,112L,84L,228L,81L,253L,240L,361L,329L,408L,436L,552L,544L,656L,852L,748L,752L,1040L,1173L,1097L,928L,1389L,1857L,1208L,1244L,1664L,2457L,1448L,1636L,2028L,2732L,2164L,1957L,2841L,3204L,2849L,2301L,3504L,3869L,3548L,2756L,4140L,4509L,4060L,3388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253089Inst : IEnumerable<long>
{
public static readonly long[] Value=A253089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253089.Bytes);
public long this[int i]=>Value[i];

public static A253089Inst Instance=new A253089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253090
{
public static readonly long[] Value={ 1L,9L,8L,32L,16L,88L,16L,104L,16L,136L,72L,312L,56L,360L,76L,468L,76L,444L,156L,708L,152L,928L,164L,996L,156L,924L,292L,1316L,256L,1520L,348L,1676L,304L,1768L,400L,1928L,408L,2040L,524L,2628L,516L,2684L,688L,3272L,744L,3872L,684L,3692L,756L,3724L,840L,4080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253090Inst : IEnumerable<long>
{
public static readonly long[] Value=A253090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253090.Bytes);
public long this[int i]=>Value[i];

public static A253090Inst Instance=new A253090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253091
{
public static readonly BigInteger[] Value={ 1L,12L,111L,1002L,12021L,111222L,1001001L,12012012L,111111111L,1000000002L,12000000021L,111000000222L,1002000002001L,12021000021012L,111222000222111L,1001001002002002L,12012012021021021L,111111111222222222L,1000000001000000001L,12000000012000000012UL,BigInteger.Parse("111000000111000000111") };
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
public class A253091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253091.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253091Inst Instance=new A253091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253092
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,1L,2L,3L,1L,2L,3L,2L,3L,4L,3L,4L,5L,3L,4L,5L,4L,5L,6L,5L,6L,7L,4L,5L,6L,5L,6L,7L,6L,7L,8L,6L,7L,8L,7L,8L,9L,8L,9L,10L,8L,9L,10L,9L,10L,11L,10L,11L,12L,9L,10L,11L,10L,11L,12L,11L,12L,13L,11L,12L,13L,12L,13L,14L,13L,14L,15L,13L,14L,15L,14L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253092Inst : IEnumerable<long>
{
public static readonly long[] Value=A253092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253092.Bytes);
public long this[int i]=>Value[i];

public static A253092Inst Instance=new A253092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253093
{
public static readonly long[] Value={ 1L,-2L,-2L,-6L,-24L,-114L,-606L,-3486L,-21258L,-135582L,-896046L,-6095490L,-42470280L,-301938390L,-2183873490L,-16032229362L,-119232361656L,-896918310126L,-6815685210078L,-52262898201642L,-404022890110872L,-3146342571901278L,-24666061437979938L,-194550540203413314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253093Inst : IEnumerable<long>
{
public static readonly long[] Value=A253093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253093.Bytes);
public long this[int i]=>Value[i];

public static A253093Inst Instance=new A253093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253094
{
public static readonly long[] Value={ 1L,-5L,6L,2L,6L,18L,66L,278L,1296L,6528L,34950L,196578L,1151610L,6981102L,43570170L,278841438L,1823991630L,12162884778L,82498605594L,568140045918L,3966323992074L,28032955095198L,200355706872054L,1446628270673682L,10542888272710224L,77496225169484448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253094Inst : IEnumerable<long>
{
public static readonly long[] Value=A253094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253094.Bytes);
public long this[int i]=>Value[i];

public static A253094Inst Instance=new A253094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253095
{
public static readonly BigInteger[] Value={ 1L,4L,22L,148L,1144L,9784L,90346L,885868L,9115276L,97578688L,1079676448L,12285725632L,143204046496L,1704422018992L,20660609113186L,254522834851516L,3180935346538684L,40269426101933392L,515743456513546072L,6675036087017279056L,BigInteger.Parse("87221496402779437696"),BigInteger.Parse("1149701868292524559744") };
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
public class A253095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253095Inst Instance=new A253095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253096
{
public static readonly BigInteger[] Value={ 1L,5L,35L,305L,3105L,35505L,444225L,5970725L,85068365L,1272022745L,19810304695L,319422093325L,5307057746125L,90508769121165L,1579462112057595L,28130401719357645L,510199561574590125L,9405815167297415025UL,BigInteger.Parse("175977472926360962295"),BigInteger.Parse("3336795660732459377085"),BigInteger.Parse("6404722290128845788628") };
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
public class A253096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253096Inst Instance=new A253096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253097
{
public static readonly long[] Value={ 1L,6L,51L,546L,6906L,99156L,1573011L,27045906L,496875786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253097Inst : IEnumerable<long>
{
public static readonly long[] Value=A253097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253097.Bytes);
public long this[int i]=>Value[i];

public static A253097Inst Instance=new A253097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253098
{
public static readonly long[] Value={ 1L,6L,15L,36L,61L,98L,155L,240L,329L,430L,551L,700L,869L,1082L,1363L,1704L,2049L,2406L,2783L,3188L,3613L,4082L,4619L,5216L,5833L,6494L,7223L,8028L,8917L,9962L,11203L,12568L,13937L,15318L,16719L,18148L,19597L,21090L,22651L,24272L,25913L,27598L,29351L,31180L,33093L,35162L,37427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253098Inst : IEnumerable<long>
{
public static readonly long[] Value=A253098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253098.Bytes);
public long this[int i]=>Value[i];

public static A253098Inst Instance=new A253098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253099
{
public static readonly long[] Value={ 4L,126L,813L,966L,1166L,1177L,1666L,1897L,1974L,2030L,2041L,2190L,2349L,2702L,3299L,3453L,3695L,4016L,4140L,4238L,4278L,4409L,4784L,4969L,5102L,5262L,5274L,5421L,5536L,5574L,5587L,5636L,5650L,5688L,5790L,5814L,6269L,6592L,7015L,7403L,8137L,8334L,8536L,8784L,9443L,9597L,9839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253099Inst : IEnumerable<long>
{
public static readonly long[] Value=A253099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253099.Bytes);
public long this[int i]=>Value[i];

public static A253099Inst Instance=new A253099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253100
{
public static readonly long[] Value={ 1L,6L,6L,24L,6L,36L,24L,96L,6L,36L,36L,144L,24L,144L,96L,372L,6L,36L,36L,144L,36L,216L,144L,576L,24L,144L,144L,576L,96L,576L,372L,1416L,6L,36L,36L,144L,36L,216L,144L,576L,36L,216L,216L,864L,144L,864L,576L,2232L,24L,144L,144L,576L,144L,864L,576L,2304L,96L,576L,576L,2304L,372L,2232L,1416L,5340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253100Inst : IEnumerable<long>
{
public static readonly long[] Value=A253100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253100.Bytes);
public long this[int i]=>Value[i];

public static A253100Inst Instance=new A253100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253101
{
public static readonly long[] Value={ 1L,6L,24L,96L,372L,1416L,5340L,20040L,75012L,280392L,1047324L,3910440L,14597508L,54485736L,203357724L,758969736L,2832570372L,10571410056L,39453266460L,147242049000L,549515715972L,2050822387752L,7653776980764L,28564291826760L,106603402909188L,397849344975816L,1484794027325724L,5541326864990376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253101Inst : IEnumerable<long>
{
public static readonly long[] Value=A253101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253101.Bytes);
public long this[int i]=>Value[i];

public static A253101Inst Instance=new A253101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253102
{
public static readonly long[] Value={ 1L,27L,27L,125L,27L,729L,125L,1331L,27L,729L,729L,3375L,125L,3375L,1331L,9261L,27L,729L,729L,3375L,729L,19683L,3375L,35937L,125L,3375L,3375L,15625L,1331L,35937L,9261L,79507L,27L,729L,729L,3375L,729L,19683L,3375L,35937L,729L,19683L,19683L,91125L,3375L,91125L,35937L,250047L,125L,3375L,3375L,15625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253102Inst : IEnumerable<long>
{
public static readonly long[] Value=A253102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253102.Bytes);
public long this[int i]=>Value[i];

public static A253102Inst Instance=new A253102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253103
{
public static readonly BigInteger[] Value={ 1L,27L,125L,1331L,9261L,79507L,614125L,5000211L,39651821L,318611987L,2543302125L,20368783891L,162860787181L,1303244200467L,10424521926125L,83401901988371L,667192309327341L,5337630100412947L,42700674299078125L,341606860407429651L,2732849019196024301L,BigInteger.Parse("21862815609813457427") };
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
public class A253103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253103Inst Instance=new A253103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253104
{
public static readonly long[] Value={ 1L,8L,8L,32L,8L,64L,32L,140L,8L,64L,64L,256L,32L,256L,140L,580L,8L,64L,64L,256L,64L,512L,256L,1120L,32L,256L,256L,1024L,140L,1120L,580L,2300L,8L,64L,64L,256L,64L,512L,256L,1120L,64L,512L,512L,2048L,256L,2048L,1120L,4640L,32L,256L,256L,1024L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253104Inst : IEnumerable<long>
{
public static readonly long[] Value=A253104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253104.Bytes);
public long this[int i]=>Value[i];

public static A253104Inst Instance=new A253104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253105
{
public static readonly long[] Value={ 1L,8L,32L,140L,580L,2300L,9212L,36708L,145684L,579132L,2300748L,9136868L,36293220L,144150716L,572523772L,2273961796L,9031663444L,35871633244L,142474173772L,565874928900L,2247525801188L,8926662348828L,35454669141436L,140817868278436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253105Inst : IEnumerable<long>
{
public static readonly long[] Value=A253105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253105.Bytes);
public long this[int i]=>Value[i];

public static A253105Inst Instance=new A253105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253106
{
public static readonly long[] Value={ 4L,6L,9L,10L,14L,15L,21L,22L,26L,33L,34L,38L,39L,46L,51L,57L,58L,62L,69L,74L,82L,86L,87L,93L,94L,106L,111L,118L,122L,123L,129L,134L,141L,142L,146L,158L,159L,166L,177L,178L,183L,194L,201L,202L,206L,213L,214L,218L,219L,226L,237L,249L,254L,262L,267L,274L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253106Inst : IEnumerable<long>
{
public static readonly long[] Value=A253106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253106.Bytes);
public long this[int i]=>Value[i];

public static A253106Inst Instance=new A253106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253107
{
public static readonly BigInteger[] Value={ 1L,40L,132160L,33565612800L,641149227424067584L,BigInteger.Parse("911979417737022109612195840"),BigInteger.Parse("96089134887576552087085389330051891200"),BigInteger.Parse("747578503218020593242369202628724536730457230016512") };
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
public class A253107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253107Inst Instance=new A253107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253108
{
public static readonly long[] Value={ 2L,4L,6L,9L,14L,17L,20L,21L,25L,32L,34L,35L,40L,45L,49L,51L,52L,56L,60L,62L,65L,76L,80L,82L,86L,87L,89L,94L,95L,96L,100L,104L,105L,107L,112L,114L,115L,116L,117L,124L,126L,135L,137L,140L,145L,147L,151L,164L,167L,172L,174L,179L,180L,181L,182L,199L,200L,202L,205L,206L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253108Inst : IEnumerable<long>
{
public static readonly long[] Value=A253108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253108.Bytes);
public long this[int i]=>Value[i];

public static A253108Inst Instance=new A253108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253109
{
public static readonly BigInteger[] Value={ 1L,2L,9L,64L,1L,36L,117649L,32768L,4782969L,100000L,11L,1L,23298085122481L,793714773254144L,576650390625L,17592186044416L,BigInteger.Parse("48661191875666868481"),3570467226624L,19L,3200000L,4084101L,22L,BigInteger.Parse("907846434775996175406740561329"),1L,1L,BigInteger.Parse("236773830007967588876795164938469376") };
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
public class A253109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253109Inst Instance=new A253109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253110
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,23L,31L,41L,61L,83L,137L,167L,211L,233L,277L,337L,373L,383L,433L,461L,619L,631L,659L,683L,719L,733L,811L,823L,877L,919L,971L,977L,1181L,1291L,1367L,1373L,1637L,1663L,1777L,1831L,2381L,2437L,2677L,2683L,2767L,3413L,3461L,3463L,3527L,3539L,3541L,3583L,3623L,4159L,4261L,4289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253110Inst : IEnumerable<long>
{
public static readonly long[] Value=A253110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253110.Bytes);
public long this[int i]=>Value[i];

public static A253110Inst Instance=new A253110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253111
{
public static readonly BigInteger[] Value={ 53L,920L,64228L,3950239L,343085240L,40022802662L,13003501426084L,2924899495974755L,1116335029837922477L,BigInteger.Parse("284500068986134613257"),BigInteger.Parse("261185251605484202491966") };
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
public class A253111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253111Inst Instance=new A253111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253112
{
public static readonly long[] Value={ 53L,272L,1342L,4619L,14541L,34786L,113891L,233392L,525617L,853971L,2327441L,3609337L,6243433L,8189113L,18881723L,25291483L,37714007L,44777219L,90840301L,112309445L,153843349L,173399285L,320621751L,377531207L,490093227L,535756183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253112Inst : IEnumerable<long>
{
public static readonly long[] Value=A253112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253112.Bytes);
public long this[int i]=>Value[i];

public static A253112Inst Instance=new A253112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253113
{
public static readonly long[] Value={ 272L,920L,6334L,28600L,139760L,502272L,2259097L,5670421L,21399557L,39120366L,120865988L,183106294L,479657064L,649963111L,1500762543L,1895383751L,3973980189L,4787211558L,9308563998L,10844855216L,19852566186L,22566185885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253113Inst : IEnumerable<long>
{
public static readonly long[] Value=A253113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253113.Bytes);
public long this[int i]=>Value[i];

public static A253113Inst Instance=new A253113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253114
{
public static readonly long[] Value={ 1342L,6334L,64228L,426571L,2801464L,11529235L,79249122L,269081698L,1126140254L,2033916546L,10398959008L,19253327106L,49068963720L,62663185107L,216434297394L,306964534797L,600045409295L,683103473164L,1832436683833L,2296747272574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253114Inst : IEnumerable<long>
{
public static readonly long[] Value=A253114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253114.Bytes);
public long this[int i]=>Value[i];

public static A253114Inst Instance=new A253114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253115
{
public static readonly long[] Value={ 4619L,28600L,426571L,3950239L,28256241L,201911670L,1873418602L,7421334529L,54446797689L,133685068828L,745867325532L,1354111174816L,5818864244979L,8824640573225L,30688212938784L,41602065842866L,122867434214623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253115Inst : IEnumerable<long>
{
public static readonly long[] Value=A253115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253115.Bytes);
public long this[int i]=>Value[i];

public static A253115Inst Instance=new A253115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253116
{
public static readonly long[] Value={ 14541L,139760L,2801464L,28256241L,343085240L,3518586637L,32095583880L,235545304374L,2365327348752L,6157835478824L,61076262847690L,134095009274344L,607685624163428L,879408920721914L,4881736615145034L,7415366603022735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253116Inst : IEnumerable<long>
{
public static readonly long[] Value=A253116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253116.Bytes);
public long this[int i]=>Value[i];

public static A253116Inst Instance=new A253116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253117
{
public static readonly long[] Value={ 34786L,502272L,11529235L,201911670L,3518586637L,40022802662L,638441329329L,7166392767013L,68323597331510L,307062940433405L,4214839734514057L,9577612840865990L,77191247728672767L,130867110971414685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253117Inst : IEnumerable<long>
{
public static readonly long[] Value=A253117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253117.Bytes);
public long this[int i]=>Value[i];

public static A253117Inst Instance=new A253117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253118
{
public static readonly long[] Value={ 113891L,2259097L,79249122L,1873418602L,32095583880L,638441329329L,13003501426084L,147806633033577L,2230834419429696L,14396665989796585L,192005351314663070L,697433605478869427L,7950834540377070980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253118Inst : IEnumerable<long>
{
public static readonly long[] Value=A253118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253118.Bytes);
public long this[int i]=>Value[i];

public static A253118Inst Instance=new A253118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253119
{
public static readonly long[] Value={ 53L,272L,272L,1342L,920L,1342L,4619L,6334L,6334L,4619L,14541L,28600L,64228L,28600L,14541L,34786L,139760L,426571L,426571L,139760L,34786L,113891L,502272L,2801464L,3950239L,2801464L,502272L,113891L,233392L,2259097L,11529235L,28256241L,28256241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253119Inst : IEnumerable<long>
{
public static readonly long[] Value=A253119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253119.Bytes);
public long this[int i]=>Value[i];

public static A253119Inst Instance=new A253119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253120
{
public static readonly BigInteger[] Value={ 6L,705L,69196L,6780615L,664431186L,65107475725L,6379868189976L,625161975142035L,61259493695729566L,6002805220206355545L,BigInteger.Parse("588213652086527113956"),BigInteger.Parse("57638935099259450812255"),BigInteger.Parse("5648027426075339652487146"),BigInteger.Parse("553449048820284026492928165"),BigInteger.Parse("54232358756961759256654473136") };
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
public class A253120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253120Inst Instance=new A253120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253121
{
public static readonly BigInteger[] Value={ 18L,1730L,169498L,16609050L,1627517378L,159480093970L,15627421691658L,1531327845688490L,150054501455780338L,14703809814820784610UL,BigInteger.Parse("1440823307350981111418"),BigInteger.Parse("141185980310581328134330"),BigInteger.Parse("13834785247129619176052898"),BigInteger.Parse("1355667768238392097925049650") };
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
public class A253121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253121Inst Instance=new A253121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253122
{
public static readonly long[] Value={ 4L,12L,16L,40L,64L,144L,256L,544L,1024L,2112L,4096L,8320L,16384L,33024L,65536L,131584L,262144L,525312L,1048576L,2099200L,4194304L,8392704L,16777216L,33562624L,67108864L,134234112L,268435456L,536903680L,1073741824L,2147549184L,4294967296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253122Inst : IEnumerable<long>
{
public static readonly long[] Value=A253122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253122.Bytes);
public long this[int i]=>Value[i];

public static A253122Inst Instance=new A253122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253123
{
public static readonly long[] Value={ 7L,53L,90L,393L,952L,3323L,9205L,29445L,85717L,264455L,784350L,2382673L,7116997L,21472661L,64312410L,193442021L,579975177L,1742036675L,5224994385L,15683870729L,47048349217L,141182669949L,423540081615L,1270780266933L,3812331343012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253123Inst : IEnumerable<long>
{
public static readonly long[] Value=A253123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253123.Bytes);
public long this[int i]=>Value[i];

public static A253123Inst Instance=new A253123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253124
{
public static readonly long[] Value={ 10L,152L,281L,2058L,6515L,32166L,119317L,517390L,2015982L,8326770L,32994052L,133707596L,532970510L,2143392252L,8562485503L,34327247500L,137243453902L,549498735586L,2197615094086L,8794063054122L,35174129326437L,140721492893118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253124Inst : IEnumerable<long>
{
public static readonly long[] Value=A253124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253124.Bytes);
public long this[int i]=>Value[i];

public static A253124Inst Instance=new A253124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253125
{
public static readonly long[] Value={ 13L,345L,673L,7257L,28428L,184145L,866944L,4737473L,23297196L,120376601L,598856998L,3032621917L,15138719850L,76078222215L,380193902100L,1904900579053L,9522965707286L,47655682592913L,238267659404765L,1191769118082757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253125Inst : IEnumerable<long>
{
public static readonly long[] Value=A253125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253125.Bytes);
public long this[int i]=>Value[i];

public static A253125Inst Instance=new A253125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253126
{
public static readonly long[] Value={ 16L,676L,1356L,19990L,92041L,764836L,4373134L,29088446L,172527610L,1072084446L,6410227358L,38947762444L,233409450993L,1407074717250L,8438849710124L,50726297744076L,304311761563422L,1827223612898464L,10962789965155112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253126Inst : IEnumerable<long>
{
public static readonly long[] Value=A253126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253126.Bytes);
public long this[int i]=>Value[i];

public static A253126Inst Instance=new A253126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253127
{
public static readonly long[] Value={ 19L,1197L,2452L,46945L,246003L,2521335L,16987236L,134079743L,932611547L,6789960255L,47460044577L,336719190243L,2355817261111L,16570926140871L,115971713357683L,813294142451421L,5692584117442169L,39876957472466661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253127Inst : IEnumerable<long>
{
public static readonly long[] Value=A253127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253127.Bytes);
public long this[int i]=>Value[i];

public static A253127Inst Instance=new A253127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253128
{
public static readonly long[] Value={ 22L,1968L,4083L,98124L,570578L,7036012L,54817908L,503679532L,4023378619L,33615995160L,268926369666L,2182138427066L,17455223471532L,140332925179614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253128Inst : IEnumerable<long>
{
public static readonly long[] Value=A253128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253128.Bytes);
public long this[int i]=>Value[i];

public static A253128Inst Instance=new A253128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253129
{
public static readonly long[] Value={ 4L,7L,12L,10L,53L,16L,13L,152L,90L,40L,16L,345L,281L,393L,64L,19L,676L,673L,2058L,952L,144L,22L,1197L,1356L,7257L,6515L,3323L,256L,25L,1968L,2452L,19990L,28428L,32166L,9205L,544L,28L,3057L,4083L,46945L,92041L,184145L,119317L,29445L,1024L,31L,4540L,6409L,98124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253129Inst : IEnumerable<long>
{
public static readonly long[] Value=A253129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253129.Bytes);
public long this[int i]=>Value[i];

public static A253129Inst Instance=new A253129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253130
{
public static readonly long[] Value={ 12L,53L,152L,345L,676L,1197L,1968L,3057L,4540L,6501L,9032L,12233L,16212L,21085L,26976L,34017L,42348L,52117L,63480L,76601L,91652L,108813L,128272L,150225L,174876L,202437L,233128L,267177L,304820L,346301L,391872L,441793L,496332L,555765L,620376L,690457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253130Inst : IEnumerable<long>
{
public static readonly long[] Value=A253130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253130.Bytes);
public long this[int i]=>Value[i];

public static A253130Inst Instance=new A253130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253131
{
public static readonly long[] Value={ 16L,90L,281L,673L,1356L,2452L,4083L,6409L,9584L,13806L,19261L,26185L,34796L,45368L,58151L,73457L,91568L,112834L,137569L,166161L,198956L,236380L,278811L,326713L,380496L,440662L,507653L,582009L,664204L,754816L,854351L,963425L,1082576L,1212458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253131Inst : IEnumerable<long>
{
public static readonly long[] Value=A253131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253131.Bytes);
public long this[int i]=>Value[i];

public static A253131Inst Instance=new A253131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253132
{
public static readonly long[] Value={ 40L,393L,2058L,7257L,19990L,46945L,98124L,187593L,335106L,566597L,915078L,1423385L,2144128L,3140689L,4491642L,6289609L,8642310L,11679353L,15549300L,20420721L,26492194L,33986741L,43152838L,54278609L,67682648L,83714937L,102776362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253132Inst : IEnumerable<long>
{
public static readonly long[] Value=A253132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253132.Bytes);
public long this[int i]=>Value[i];

public static A253132Inst Instance=new A253132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253133
{
public static readonly long[] Value={ 64L,952L,6515L,28428L,92041L,246003L,570578L,1191085L,2291766L,4133344L,7059815L,11542364L,18172847L,27698453L,41058154L,59405687L,84086912L,116790762L,159453863L,214336718L,284126387L,371920965L,481131250L,615892739L,780722246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253133Inst : IEnumerable<long>
{
public static readonly long[] Value=A253133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253133.Bytes);
public long this[int i]=>Value[i];

public static A253133Inst Instance=new A253133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253134
{
public static readonly long[] Value={ 144L,3323L,32166L,184145L,764836L,2521335L,7036012L,17264207L,38381418L,78763123L,151375270L,275557605L,479126062L,800684721L,1293413658L,2028024289L,3097019402L,4620705367L,6751984484L,9681773551L,13650121504L,18950897209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253134Inst : IEnumerable<long>
{
public static readonly long[] Value=A253134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253134.Bytes);
public long this[int i]=>Value[i];

public static A253134Inst Instance=new A253134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253135
{
public static readonly long[] Value={ 256L,9205L,119317L,866944L,4373134L,16987236L,54817908L,153203700L,382427902L,870816931L,1838833115L,3646368028L,6856114327L,12312181791L,21251285131L,35433012016L,57295925135L,90169126459L,138505569304L,208154690963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253135Inst : IEnumerable<long>
{
public static readonly long[] Value=A253135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253135.Bytes);
public long this[int i]=>Value[i];

public static A253135Inst Instance=new A253135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253136
{
public static readonly long[] Value={ 1L,0L,2L,0L,4L,2L,6L,4L,10L,8L,18L,14L,28L,24L,44L,42L,68L,66L,102L,104L,154L,160L,226L,238L,330L,354L,476L,516L,676L,742L,958L,1056L,1342L,1486L,1862L,2076L,2568L,2872L,3516L,3940L,4782L,5370L,6464L,7268L,8686L,9774L,11606L,13070L,15428L,17380L,20408L,22986L,26868L,30258L,35214L,39648L,45952L,51716L,59726L,67182L,77330L,86924L,99740L,112040L,128196L,143900L,164206L,184172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253136Inst : IEnumerable<long>
{
public static readonly long[] Value=A253136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253136.Bytes);
public long this[int i]=>Value[i];

public static A253136Inst Instance=new A253136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253137
{
public static readonly long[] Value={ 1L,4L,12L,12L,10L,36L,14L,8L,9L,60L,22L,12L,26L,112L,15L,32L,17L,36L,38L,40L,21L,44L,23L,216L,50L,26L,216L,56L,58L,90L,62L,64L,33L,68L,35L,72L,74L,38L,312L,40L,82L,504L,86L,132L,45L,46L,94L,96L,49L,100L,612L,104L,159L,108L,55L,112L,570L,58L,118L,720L,61L,124L,63L,512L,390L,66L,134L,68L,138L,70L,852L,144L,219L,74L,150L,608L,77L,156L,948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253137Inst : IEnumerable<long>
{
public static readonly long[] Value=A253137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253137.Bytes);
public long this[int i]=>Value[i];

public static A253137Inst Instance=new A253137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253138
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,4L,3L,4L,3L,3L,5L,7L,6L,5L,5L,8L,8L,7L,9L,7L,10L,10L,12L,11L,15L,12L,14L,14L,13L,11L,13L,15L,15L,14L,15L,20L,14L,15L,19L,20L,16L,17L,17L,17L,21L,24L,23L,24L,28L,23L,25L,24L,27L,25L,32L,29L,25L,21L,26L,31L,31L,29L,36L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253138Inst : IEnumerable<long>
{
public static readonly long[] Value=A253138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253138.Bytes);
public long this[int i]=>Value[i];

public static A253138Inst Instance=new A253138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253139
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,4L,2L,12L,6L,4L,2L,12L,2L,4L,4L,60L,2L,12L,2L,12L,4L,4L,2L,24L,6L,4L,12L,12L,2L,8L,2L,60L,4L,4L,4L,36L,2L,4L,4L,24L,2L,8L,2L,12L,12L,4L,2L,120L,6L,12L,4L,12L,2L,24L,4L,24L,4L,4L,2L,24L,2L,4L,12L,420L,4L,8L,2L,12L,4L,8L,2L,72L,2L,4L,12L,12L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253139Inst : IEnumerable<long>
{
public static readonly long[] Value=A253139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253139.Bytes);
public long this[int i]=>Value[i];

public static A253139Inst Instance=new A253139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253140
{
public static readonly long[] Value={ 89L,373L,773L,863L,1279L,2063L,2089L,2399L,2663L,2753L,3299L,4153L,4373L,5879L,6173L,6263L,6779L,7079L,7499L,7853L,9473L,10453L,11399L,12253L,12479L,14699L,16763L,19379L,21163L,21563L,25073L,29363L,32189L,33599L,40063L,41879L,42773L,50053L,50363L,52673L,56453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253140Inst : IEnumerable<long>
{
public static readonly long[] Value=A253140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253140.Bytes);
public long this[int i]=>Value[i];

public static A253140Inst Instance=new A253140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253141
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,1L,2L,2L,3L,1L,2L,1L,2L,1L,1L,5L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,7L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,5L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253141Inst : IEnumerable<long>
{
public static readonly long[] Value=A253141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253141.Bytes);
public long this[int i]=>Value[i];

public static A253141Inst Instance=new A253141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253142
{
public static readonly long[] Value={ 2L,4L,8L,14L,16L,22L,26L,32L,38L,44L,46L,52L,64L,68L,86L,88L,98L,124L,134L,158L,178L,184L,196L,212L,236L,242L,248L,256L,262L,296L,298L,316L,322L,338L,364L,374L,386L,394L,452L,472L,484L,488L,548L,578L,586L,598L,602L,626L,632L,638L,646L,658L,662L,676L,694L,718L,728L,736L,794L,806L,842L,848L,862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253142Inst : IEnumerable<long>
{
public static readonly long[] Value=A253142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253142.Bytes);
public long this[int i]=>Value[i];

public static A253142Inst Instance=new A253142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253143
{
public static readonly long[] Value={ 2L,4L,16L,22L,32L,44L,86L,88L,98L,298L,316L,452L,602L,638L,658L,736L,862L,868L,896L,1276L,1358L,1586L,1768L,1996L,2342L,2366L,2444L,2452L,2542L,2788L,2902L,3242L,3448L,3704L,3718L,3998L,4376L,4552L,4928L,5422L,5504L,5566L,5608L,5644L,5728L,5768L,5776L,6664L,6934L,6946L,7708L,7858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253143Inst : IEnumerable<long>
{
public static readonly long[] Value=A253143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253143.Bytes);
public long this[int i]=>Value[i];

public static A253143Inst Instance=new A253143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253144
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,5L,5L,5L,6L,6L,7L,9L,10L,11L,12L,13L,14L,16L,18L,19L,21L,23L,25L,28L,31L,34L,37L,40L,43L,47L,52L,56L,61L,66L,71L,78L,85L,92L,99L,107L,115L,124L,135L,145L,156L,168L,180L,194L,210L,226L,242L,260L,278L,297L,320L,343L,367L,393L,420L,449L,481L,516L,550L,587L,626L,666L,712L,760L,810L,863L,919L,978L,1041L,1110L,1180L,1254L,1333L,1414L,1503L,1598L,1697L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253144Inst : IEnumerable<long>
{
public static readonly long[] Value=A253144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253144.Bytes);
public long this[int i]=>Value[i];

public static A253144Inst Instance=new A253144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253145
{
public static readonly long[] Value={ 0L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,253L,276L,300L,325L,351L,378L,406L,435L,465L,496L,528L,561L,595L,630L,666L,703L,741L,780L,820L,861L,903L,946L,990L,1035L,1081L,1128L,1176L,1225L,1275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253145Inst : IEnumerable<long>
{
public static readonly long[] Value=A253145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253145.Bytes);
public long this[int i]=>Value[i];

public static A253145Inst Instance=new A253145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253146
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,5L,6L,2L,3L,7L,8L,4L,1L,5L,9L,10L,6L,2L,3L,7L,11L,12L,8L,4L,1L,5L,9L,13L,14L,10L,6L,2L,3L,7L,11L,15L,16L,12L,8L,4L,1L,5L,9L,13L,17L,18L,14L,10L,6L,2L,3L,7L,11L,15L,19L,20L,16L,12L,8L,4L,1L,5L,9L,13L,17L,21L,22L,18L,14L,10L,6L,2L,3L,7L,11L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253146Inst : IEnumerable<long>
{
public static readonly long[] Value=A253146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253146.Bytes);
public long this[int i]=>Value[i];

public static A253146Inst Instance=new A253146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253147
{
public static readonly long[] Value={ 8448L,31613L,32123L,55255L,63736L,92929L,96769L,108801L,450054L,516615L,995599L,1413141L,1432341L,1539351L,1558551L,2019102L,2491942L,2513152L,2712172L,2731372L,2750572L,2807082L,2838382L,2857582L,2876782L,3097903L,3740473L,3866683L,3885883L,4201024L,4220224L,4327234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253147Inst : IEnumerable<long>
{
public static readonly long[] Value=A253147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253147.Bytes);
public long this[int i]=>Value[i];

public static A253147Inst Instance=new A253147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253148
{
public static readonly long[] Value={ 55255L,63736L,92929L,96769L,108801L,450054L,516615L,995599L,1413141L,1432341L,1539351L,1558551L,2019102L,2491942L,2807082L,3097903L,3740473L,3866683L,3885883L,4201024L,4220224L,4327234L,4346434L,4365634L,4384834L,5614165L,5633365L,5759575L,6692966L,7153517L,7172717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253148Inst : IEnumerable<long>
{
public static readonly long[] Value=A253148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253148.Bytes);
public long this[int i]=>Value[i];

public static A253148Inst Instance=new A253148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253149
{
public static readonly long[] Value={ 257L,269L,293L,311L,313L,347L,379L,397L,419L,449L,479L,491L,773L,809L,823L,827L,829L,857L,883L,887L,947L,953L,971L,977L,1013L,1283L,1289L,1297L,1301L,1307L,1321L,1327L,1367L,1373L,1399L,1409L,1429L,1439L,1451L,1453L,1481L,1483L,1511L,1523L,1801L,1811L,1847L,1867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253149Inst : IEnumerable<long>
{
public static readonly long[] Value=A253149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253149.Bytes);
public long this[int i]=>Value[i];

public static A253149Inst Instance=new A253149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253150
{
public static readonly BigInteger[] Value={ 450L,4480L,51842L,631750L,7840800L,97964230L,1227006722L,15382568320L,192913661250L,2419663276870L,30350713098272L,380707349218630L,4775477743210050L,59902315898992000L,751399441414986242L,9425367683335685830UL,BigInteger.Parse("118229486214797575200"),BigInteger.Parse("1483041587095202467270"),BigInteger.Parse("18602909221707721745282"),BigInteger.Parse("233350323785397856885120") };
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
public class A253150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253150Inst Instance=new A253150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253151
{
public static readonly long[] Value={ 16L,72L,94L,164L,308L,596L,1172L,2324L,4628L,9236L,18452L,36884L,73748L,147476L,294932L,589844L,1179668L,2359316L,4718612L,9437204L,18874388L,37748756L,75497492L,150994964L,301989908L,603979796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253151Inst : IEnumerable<long>
{
public static readonly long[] Value=A253151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253151.Bytes);
public long this[int i]=>Value[i];

public static A253151Inst Instance=new A253151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253152
{
public static readonly long[] Value={ 16L,39L,69L,109L,181L,325L,613L,1189L,2341L,4645L,9253L,18469L,36901L,73765L,147493L,294949L,589861L,1179685L,2359333L,4718629L,9437221L,18874405L,37748773L,75497509L,150994981L,301989925L,603979813L,1207959589L,2415919141L,4831838245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253152Inst : IEnumerable<long>
{
public static readonly long[] Value=A253152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253152.Bytes);
public long this[int i]=>Value[i];

public static A253152Inst Instance=new A253152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253153
{
public static readonly long[] Value={ 39L,72L,88L,120L,192L,336L,624L,1200L,2352L,4656L,9264L,18480L,36912L,73776L,147504L,294960L,589872L,1179696L,2359344L,4718640L,9437232L,18874416L,37748784L,75497520L,150994992L,301989936L,603979824L,1207959600L,2415919152L,4831838256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253153Inst : IEnumerable<long>
{
public static readonly long[] Value=A253153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253153.Bytes);
public long this[int i]=>Value[i];

public static A253153Inst Instance=new A253153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253154
{
public static readonly long[] Value={ 69L,88L,94L,129L,201L,345L,633L,1209L,2361L,4665L,9273L,18489L,36921L,73785L,147513L,294969L,589881L,1179705L,2359353L,4718649L,9437241L,18874425L,37748793L,75497529L,150995001L,301989945L,603979833L,1207959609L,2415919161L,4831838265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253154Inst : IEnumerable<long>
{
public static readonly long[] Value=A253154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253154.Bytes);
public long this[int i]=>Value[i];

public static A253154Inst Instance=new A253154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253155
{
public static readonly long[] Value={ 109L,120L,129L,164L,236L,380L,668L,1244L,2396L,4700L,9308L,18524L,36956L,73820L,147548L,295004L,589916L,1179740L,2359388L,4718684L,9437276L,18874460L,37748828L,75497564L,150995036L,301989980L,603979868L,1207959644L,2415919196L,4831838300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253155Inst : IEnumerable<long>
{
public static readonly long[] Value=A253155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253155.Bytes);
public long this[int i]=>Value[i];

public static A253155Inst Instance=new A253155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253156
{
public static readonly long[] Value={ 181L,192L,201L,236L,308L,452L,740L,1316L,2468L,4772L,9380L,18596L,37028L,73892L,147620L,295076L,589988L,1179812L,2359460L,4718756L,9437348L,18874532L,37748900L,75497636L,150995108L,301990052L,603979940L,1207959716L,2415919268L,4831838372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253156Inst : IEnumerable<long>
{
public static readonly long[] Value=A253156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253156.Bytes);
public long this[int i]=>Value[i];

public static A253156Inst Instance=new A253156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253157
{
public static readonly long[] Value={ 325L,336L,345L,380L,452L,596L,884L,1460L,2612L,4916L,9524L,18740L,37172L,74036L,147764L,295220L,590132L,1179956L,2359604L,4718900L,9437492L,18874676L,37749044L,75497780L,150995252L,301990196L,603980084L,1207959860L,2415919412L,4831838516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253157Inst : IEnumerable<long>
{
public static readonly long[] Value=A253157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253157.Bytes);
public long this[int i]=>Value[i];

public static A253157Inst Instance=new A253157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253158
{
public static readonly long[] Value={ 613L,624L,633L,668L,740L,884L,1172L,1748L,2900L,5204L,9812L,19028L,37460L,74324L,148052L,295508L,590420L,1180244L,2359892L,4719188L,9437780L,18874964L,37749332L,75498068L,150995540L,301990484L,603980372L,1207960148L,2415919700L,4831838804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253158Inst : IEnumerable<long>
{
public static readonly long[] Value=A253158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253158.Bytes);
public long this[int i]=>Value[i];

public static A253158Inst Instance=new A253158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253159
{
public static readonly long[] Value={ 16L,39L,39L,69L,72L,69L,109L,88L,88L,109L,181L,120L,94L,120L,181L,325L,192L,129L,129L,192L,325L,613L,336L,201L,164L,201L,336L,613L,1189L,624L,345L,236L,236L,345L,624L,1189L,2341L,1200L,633L,380L,308L,380L,633L,1200L,2341L,4645L,2352L,1209L,668L,452L,452L,668L,1209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253159Inst : IEnumerable<long>
{
public static readonly long[] Value=A253159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253159.Bytes);
public long this[int i]=>Value[i];

public static A253159Inst Instance=new A253159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253160
{
public static readonly long[] Value={ 558L,5136L,46752L,443362L,4189216L,39478862L,371551030L,3500351616L,32968666098L,310607972526L,2925948121986L,27562007609152L,259623715582126L,2445694348190100L,23038546105524370L,217021887885861286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253160Inst : IEnumerable<long>
{
public static readonly long[] Value=A253160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253160.Bytes);
public long this[int i]=>Value[i];

public static A253160Inst Instance=new A253160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253161
{
public static readonly ulong[] Value={ 3844L,46752L,555842L,7252320L,92998506L,1190692584L,15179218714L,194198939906L,2482220834294L,31740256495626L,405683545431502L,5186473593590730L,66301707444606534L,847604837440730462L,10835407210226372002UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253161Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A253161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253161.Bytes);
public ulong this[int i]=>Value[i];

public static A253161Inst Instance=new A253161Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253162
{
public static readonly BigInteger[] Value={ 26784L,443362L,7252320L,135741428L,2461955138L,44789509812L,808045500430L,14674315377606L,265844130932752L,4822273171428216L,87389675007459160L,1584487801002237370L,BigInteger.Parse("28722425603939593796"),BigInteger.Parse("520728445103764345118") };
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
public class A253162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253162Inst Instance=new A253162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253163
{
public static readonly BigInteger[] Value={ 186624L,4189216L,92998506L,2461955138L,62954425188L,1612778665632L,40892835737758L,1045243631714532L,26655995880836874L,680590803725411114L,17356137926136738110UL,BigInteger.Parse("442903594404834251862"),BigInteger.Parse("11300064205772118129666") };
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
public class A253163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253163Inst Instance=new A253163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253164
{
public static readonly long[] Value={ 81L,558L,558L,3844L,5136L,3844L,26784L,46752L,46752L,26784L,186624L,443362L,555842L,443362L,186624L,1296000L,4189216L,7252320L,7252320L,4189216L,1296000L,9000000L,39478862L,92998506L,135741428L,92998506L,39478862L,9000000L,62568000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253164Inst : IEnumerable<long>
{
public static readonly long[] Value=A253164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253164.Bytes);
public long this[int i]=>Value[i];

public static A253164Inst Instance=new A253164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253165
{
public static readonly BigInteger[] Value={ 1L,8L,256L,17408L,2031616L,362283008L,91620376576L,31191159799808L,13753735117275136L,7625476699018231808L,BigInteger.Parse("5192022022552652087296"),BigInteger.Parse("4258996468871236847403008"),BigInteger.Parse("4142655008190840426050093056"),BigInteger.Parse("4714505177821257067736657297408"),BigInteger.Parse("6206008749802659037752564348092416") };
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
public class A253165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253165Inst Instance=new A253165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253166
{
public static readonly long[] Value={ 599921326L,1107778868L,2011251698L,3589612642L,4811175086L,6153188512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253166Inst : IEnumerable<long>
{
public static readonly long[] Value=A253166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253166.Bytes);
public long this[int i]=>Value[i];

public static A253166Inst Instance=new A253166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253167
{
public static readonly BigInteger[] Value={ 1L,871L,2841L,1006671L,3280049L,1161698999L,3785175241L,1340599639711L,4368088949601L,1547050822529031L,5040770862665849L,1785295308598863599L,5817045207427441681L,BigInteger.Parse("2060229239072266065751"),BigInteger.Parse("6712865128600405035561"),BigInteger.Parse("2377502756594086441014591") };
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
public class A253167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253167Inst Instance=new A253167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253168
{
public static readonly BigInteger[] Value={ 4L,1234L,4020L,1423650L,4638692L,1642890482L,5353046164L,1895894192194L,6177410634180L,2187860254901010L,7128726518797172L,2524788838261572962L,8226544225281301924L,BigInteger.Parse("2913604131493600296754"),BigInteger.Parse("9493424907248103622740"),BigInteger.Parse("3362296642954776480880770") };
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
public class A253168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253168Inst Instance=new A253168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253169
{
public static readonly long[] Value={ 1L,2L,9L,5L,6L,36L,10L,11L,12L,100L,17L,18L,19L,20L,225L,26L,27L,28L,29L,30L,441L,37L,38L,39L,40L,41L,42L,784L,50L,51L,52L,53L,54L,55L,56L,1296L,65L,66L,67L,68L,69L,70L,71L,72L,2025L,82L,83L,84L,85L,86L,87L,88L,89L,90L,3025L,101L,102L,103L,104L,105L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253169Inst : IEnumerable<long>
{
public static readonly long[] Value=A253169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253169.Bytes);
public long this[int i]=>Value[i];

public static A253169Inst Instance=new A253169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253170
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,13L,17L,22L,28L,35L,42L,50L,60L,72L,85L,101L,119L,139L,162L,187L,215L,246L,279L,315L,353L,394L,437L,482L,529L,579L,632L,688L,748L,810L,875L,944L,1016L,1094L,1177L,1263L,1351L,1443L,1538L,1637L,1742L,1852L,1966L,2083L,2205L,2330L,2460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253170Inst : IEnumerable<long>
{
public static readonly long[] Value=A253170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253170.Bytes);
public long this[int i]=>Value[i];

public static A253170Inst Instance=new A253170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253171
{
public static readonly long[] Value={ 3L,12L,60L,240L,756L,1988L,4572L,9495L,18205L,32736L,55848L,91182L,143430L,218520L,323816L,468333L,662967L,920740L,1257060L,1689996L,2240568L,2933052L,3795300L,4859075L,6160401L,7739928L,9643312L,11921610L,14631690L,17836656L,21606288L,26017497L,31154795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253171Inst : IEnumerable<long>
{
public static readonly long[] Value=A253171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253171.Bytes);
public long this[int i]=>Value[i];

public static A253171Inst Instance=new A253171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253172
{
public static readonly long[] Value={ 15628L,15678L,16038L,17082L,17820L,19084L,20457L,20748L,20754L,21658L,24507L,24587L,25704L,26910L,26970L,27096L,27504L,27690L,28156L,28651L,29076L,29370L,29670L,29706L,29730L,30956L,30972L,30976L,32890L,32970L,34056L,34902L,34986L,35046L,35074L,35096L,35496L,35690L,36092L,36490L,36508L,36950L,36970L,36972L,37092L,37096L,37290L,37590L,37690L,37908L,38870L,39026L,39720L,39760L,40587L,40596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253172Inst : IEnumerable<long>
{
public static readonly long[] Value=A253172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253172.Bytes);
public long this[int i]=>Value[i];

public static A253172Inst Instance=new A253172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253173
{
public static readonly long[] Value={ 15628L,15678L,16038L,17082L,17820L,19084L,20457L,20754L,21658L,24507L,26910L,27504L,28156L,28651L,30976L,32890L,34902L,35046L,35496L,36508L,36970L,37096L,37690L,38870L,40596L,40898L,43076L,43670L,45068L,46740L,46970L,47690L,48504L,48592L,50076L,50346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253173Inst : IEnumerable<long>
{
public static readonly long[] Value=A253173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253173.Bytes);
public long this[int i]=>Value[i];

public static A253173Inst Instance=new A253173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253174
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,3L,4L,5L,4L,3L,4L,5L,4L,3L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,7L,8L,9L,8L,7L,6L,7L,6L,7L,8L,9L,8L,7L,6L,7L,6L,5L,6L,7L,8L,9L,10L,9L,8L,9L,10L,11L,10L,9L,10L,11L,12L,13L,14L,13L,14L,13L,12L,13L,12L,11L,10L,11L,10L,9L,8L,9L,10L,9L,8L,9L,10L,11L,12L,11L,10L,9L,10L,11L,12L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253174Inst : IEnumerable<long>
{
public static readonly long[] Value=A253174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253174.Bytes);
public long this[int i]=>Value[i];

public static A253174Inst Instance=new A253174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253175
{
public static readonly BigInteger[] Value={ 1L,7L,67L,661L,6541L,64747L,640927L,6344521L,62804281L,621698287L,6154178587L,60920087581L,603046697221L,5969546884627L,59092422149047L,584954674605841L,5790454323909361L,57319588564487767L,567405431320968307L,5616734724645195301L,BigInteger.Parse("55599941815130984701") };
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
public class A253175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A253175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253175Inst Instance=new A253175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253176
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,3L,2L,0L,6L,1L,3L,0L,2L,2L,1L,1L,2L,0L,14L,5L,1L,0L,1L,2L,5L,5L,2L,1L,4L,1L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253176Inst : IEnumerable<long>
{
public static readonly long[] Value=A253176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253176.Bytes);
public long this[int i]=>Value[i];

public static A253176Inst Instance=new A253176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253177
{
public static readonly long[] Value={ 23L,47L,53L,59L,69L,71L,89L,94L,106L,107L,134L,141L,142L,143L,159L,161L,167L,177L,178L,179L,188L,191L,207L,212L,213L,214L,215L,227L,233L,239L,242L,251L,263L,265L,267L,268L,269L,282L,283L,284L,286L,287L,299L,311L,317L,318L,319L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253177Inst : IEnumerable<long>
{
public static readonly long[] Value=A253177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253177.Bytes);
public long this[int i]=>Value[i];

public static A253177Inst Instance=new A253177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253178
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,47L,1L,1L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,1L,2729L,1L,1L,2L,1L,2L,175L,1L,1L,1L,1L,1L,1L,3L,3L,3L,43L,1L,1L,2L,1L,1L,3L,2L,1L,1L,3L,1L,11L,1L,1L,4L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,192275L,2L,1233L,1L,3L,5L,51L,1L,1L,1L,1L,286L,1L,1L,755L,2L,1L,4L,1L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253178Inst : IEnumerable<long>
{
public static readonly long[] Value=A253178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253178.Bytes);
public long this[int i]=>Value[i];

public static A253178Inst Instance=new A253178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253179
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,2L,-4L,0L,0L,2L,-2L,0L,0L,4L,6L,0L,0L,0L,-2L,0L,0L,2L,-6L,0L,0L,6L,0L,0L,0L,-4L,-12L,0L,0L,4L,4L,0L,0L,6L,12L,0L,0L,-4L,0L,0L,0L,4L,-10L,0L,0L,0L,4L,0L,0L,0L,18L,0L,0L,2L,-6L,0L,0L,8L,0L,0L,0L,-8L,2L,0L,0L,-4L,-14L,0L,0L,10L,0L,0L,0L,-4L,-22L,0L,0L,4L,-4L,0L,0L,10L,14L,0L,0L,0L,2L,0L,0L,8L,14L,0L,0L,0L,0L,0L,0L,-4L,-22L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253179Inst : IEnumerable<long>
{
public static readonly long[] Value=A253179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253179.Bytes);
public long this[int i]=>Value[i];

public static A253179Inst Instance=new A253179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253180
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,2L,0L,5L,15L,5L,0L,14L,98L,84L,14L,0L,42L,630L,1050L,420L,42L,0L,132L,4092L,11880L,8580L,1980L,132L,0L,429L,27027L,129129L,150150L,60060L,9009L,429L,0L,1430L,181610L,1381380L,2432430L,1501500L,380380L,40040L,1430L,0L,4862L,1239810L,14707550L,37777740L,33795762L,12864852L,2246244L,175032L,4862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253180Inst : IEnumerable<long>
{
public static readonly long[] Value=A253180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253180.Bytes);
public long this[int i]=>Value[i];

public static A253180Inst Instance=new A253180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253181
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,13L,15L,16L,17L,25L,32L,35L,36L,37L,40L,43L,46L,49L,52L,56L,63L,64L,65L,81L,99L,100L,101L,109L,121L,136L,143L,144L,145L,152L,158L,169L,175L,190L,195L,196L,197L,225L,243L,255L,256L,257L,289L,312L,317L,323L,324L,325L,331L,336L,351L,356L,361L,366L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253181Inst : IEnumerable<long>
{
public static readonly long[] Value=A253181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253181.Bytes);
public long this[int i]=>Value[i];

public static A253181Inst Instance=new A253181Inst();

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