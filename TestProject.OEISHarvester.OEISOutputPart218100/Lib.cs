using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256482
{
public static readonly long[] Value={ 2L,6L,14L,24L,44L,60L,84L,122L,142L,176L,216L,252L,274L,308L,360L,412L,454L,498L,546L,594L,648L,672L,736L,810L,868L,908L,930L,994L,1040L,1130L,1188L,1254L,1310L,1398L,1444L,1484L,1500L,1614L,1748L,1780L,1866L,1890L,1944L,2012L,2040L,2096L,2154L,2240L,2328L,2436L,2488L,2544L,2676L,2740L,2800L,2948L,2976L,3034L,3090L,3210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256482Inst : IEnumerable<long>
{
public static readonly long[] Value=A256482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256482.Bytes);
public long this[int i]=>Value[i];

public static A256482Inst Instance=new A256482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256483
{
public static readonly long[] Value={ 1L,3L,7L,12L,22L,30L,42L,61L,71L,88L,108L,126L,137L,154L,180L,206L,227L,249L,273L,297L,324L,336L,368L,405L,434L,454L,465L,497L,520L,565L,594L,627L,655L,699L,722L,742L,750L,807L,874L,890L,933L,945L,972L,1006L,1020L,1048L,1077L,1120L,1164L,1218L,1244L,1272L,1338L,1370L,1400L,1474L,1488L,1517L,1545L,1605L,1627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256483Inst : IEnumerable<long>
{
public static readonly long[] Value=A256483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256483.Bytes);
public long this[int i]=>Value[i];

public static A256483Inst Instance=new A256483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256484
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,173L,199L,211L,233L,239L,241L,251L,263L,269L,281L,293L,311L,317L,331L,337L,349L,353L,359L,379L,383L,397L,401L,409L,421L,431L,433L,439L,449L,461L,463L,467L,487L,491L,499L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256484Inst : IEnumerable<long>
{
public static readonly long[] Value=A256484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256484.Bytes);
public long this[int i]=>Value[i];

public static A256484Inst Instance=new A256484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256485
{
public static readonly long[] Value={ 41L,97L,101L,163L,167L,179L,181L,191L,193L,197L,223L,227L,229L,257L,271L,277L,283L,307L,313L,347L,367L,373L,389L,419L,443L,457L,479L,503L,521L,547L,563L,577L,587L,593L,599L,641L,643L,659L,661L,673L,683L,691L,719L,811L,821L,823L,829L,839L,857L,859L,877L,907L,929L,937L,983L,1009L,1021L,1031L,1051L,1063L,1087L,1091L,1093L,1151L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256485Inst : IEnumerable<long>
{
public static readonly long[] Value=A256485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256485.Bytes);
public long this[int i]=>Value[i];

public static A256485Inst Instance=new A256485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256486
{
public static readonly long[] Value={ 0L,-1L,-4L,-4L,-6L,-4L,-8L,-8L,-8L,-8L,-8L,-6L,-8L,-8L,-16L,-14L,-8L,-6L,-4L,-2L,-4L,-4L,-8L,-8L,-4L,0L,-8L,-8L,-6L,-4L,2L,-2L,-2L,-2L,4L,4L,-10L,-12L,-2L,8L,6L,10L,4L,4L,2L,0L,2L,6L,-2L,4L,10L,10L,4L,16L,18L,16L,26L,24L,18L,20L,26L,28L,22L,28L,26L,28L,30L,22L,24L,26L,22L,22L,18L,16L,18L,34L,34L,24L,18L,18L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256486Inst : IEnumerable<long>
{
public static readonly long[] Value=A256486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256486.Bytes);
public long this[int i]=>Value[i];

public static A256486Inst Instance=new A256486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256487
{
public static readonly long[] Value={ 2L,4L,0L,4L,10L,18L,16L,36L,28L,48L,78L,80L,62L,90L,76L,110L,134L,158L,200L,220L,224L,216L,236L,280L,308L,312L,262L,314L,328L,402L,430L,424L,438L,488L,506L,538L,414L,510L,642L,620L,680L,648L,656L,690L,666L,684L,730L,790L,742L,840L,844L,862L,916L,976L,1004L,1092L,1072L,1112L,1054L,1166L,1176L,1184L,1292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256487Inst : IEnumerable<long>
{
public static readonly long[] Value=A256487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256487.Bytes);
public long this[int i]=>Value[i];

public static A256487Inst Instance=new A256487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256488
{
public static readonly long[] Value={ 1L,2L,0L,2L,5L,9L,8L,18L,14L,24L,39L,40L,31L,45L,38L,55L,67L,79L,100L,110L,112L,108L,118L,140L,154L,156L,131L,157L,164L,201L,215L,212L,219L,244L,253L,269L,207L,255L,321L,310L,340L,324L,328L,345L,333L,342L,365L,395L,371L,420L,422L,431L,458L,488L,502L,546L,536L,556L,527L,583L,588L,592L,646L,643L,639L,665L,688L,662L,662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256488Inst : IEnumerable<long>
{
public static readonly long[] Value=A256488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256488.Bytes);
public long this[int i]=>Value[i];

public static A256488Inst Instance=new A256488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256489
{
public static readonly long[] Value={ 8L,8L,3L,13L,3L,7L,11L,11L,3L,7L,11L,4L,12L,8L,3L,16L,3L,7L,11L,4L,12L,8L,3L,8L,13L,8L,3L,13L,3L,7L,9L,16L,3L,7L,11L,4L,12L,8L,3L,8L,13L,8L,3L,13L,3L,7L,9L,7L,14L,8L,3L,13L,3L,7L,9L,13L,3L,7L,9L,6L,10L,7L,5L,20L,3L,7L,11L,4L,12L,8L,3L,8L,13L,8L,3L,13L,3L,7L,9L,7L,14L,8L,3L,13L,3L,7L,9L,13L,3L,7L,9L,6L,10L,7L,5L,10L,15L,8L,3L,13L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256489Inst : IEnumerable<long>
{
public static readonly long[] Value=A256489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256489.Bytes);
public long this[int i]=>Value[i];

public static A256489Inst Instance=new A256489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256490
{
public static readonly long[] Value={ 8L,7L,9L,7L,13L,2L,10L,7L,13L,2L,14L,8L,7L,2L,11L,7L,13L,2L,14L,8L,7L,2L,15L,8L,7L,9L,7L,14L,1L,2L,12L,7L,13L,2L,14L,8L,7L,2L,15L,8L,7L,9L,7L,14L,1L,2L,16L,8L,7L,9L,7L,14L,1L,10L,7L,14L,1L,15L,8L,7L,1L,2L,13L,7L,13L,2L,14L,8L,7L,2L,15L,8L,7L,9L,7L,14L,1L,2L,16L,8L,7L,9L,7L,14L,1L,10L,7L,14L,1L,15L,8L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256490Inst : IEnumerable<long>
{
public static readonly long[] Value=A256490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256490.Bytes);
public long this[int i]=>Value[i];

public static A256490Inst Instance=new A256490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256491
{
public static readonly long[] Value={ 2L,5L,13L,23L,43L,59L,79L,97L,113L,157L,173L,211L,239L,257L,281L,331L,373L,389L,433L,461L,479L,523L,569L,607L,659L,691L,719L,751L,769L,811L,911L,947L,997L,1019L,1091L,1103L,1163L,1217L,1249L,1297L,1361L,1381L,1459L,1483L,1511L,1543L,1619L,1723L,1759L,1787L,1831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256491Inst : IEnumerable<long>
{
public static readonly long[] Value=A256491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256491.Bytes);
public long this[int i]=>Value[i];

public static A256491Inst Instance=new A256491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256492
{
public static readonly long[] Value={ 1L,2L,7L,24L,103L,416L,1998L,8822L,45661L,213674L,1167797L,5694690L,32445914L,163151262L,960580840L,4945645808L,29899013071L,156834641076L,968947169139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256492Inst : IEnumerable<long>
{
public static readonly long[] Value=A256492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256492.Bytes);
public long this[int i]=>Value[i];

public static A256492Inst Instance=new A256492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256493
{
public static readonly ulong[] Value={ 1L,3L,19L,171L,1675L,16683L,166699L,1666731L,16666795L,166666923L,1666667179L,16666667691L,166666668715L,1666666670763L,16666666674859L,166666666683051L,1666666666699435L,16666666666732203L,166666666666797739L,1666666666666928811L,16666666666667190955UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256493Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A256493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256493.Bytes);
public ulong this[int i]=>Value[i];

public static A256493Inst Instance=new A256493Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256494
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,7L,13L,26L,51L,103L,205L,410L,819L,1639L,3277L,6554L,13107L,26215L,52429L,104858L,209715L,419431L,838861L,1677722L,3355443L,6710887L,13421773L,26843546L,53687091L,107374183L,214748365L,429496730L,858993459L,1717986919L,3435973837L,6871947674L,13743895347L,27487790695L,54975581389L,109951162778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256494Inst : IEnumerable<long>
{
public static readonly long[] Value=A256494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256494.Bytes);
public long this[int i]=>Value[i];

public static A256494Inst Instance=new A256494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256495
{
public static readonly long[] Value={ 0L,1L,2L,11L,101L,111L,1001L,1111L,10001L,10101L,11011L,100001L,101101L,110011L,1000001L,1001001L,1010101L,1100011L,10000001L,10011001L,10100101L,11000011L,100000001L,100010001L,100101001L,101000101L,110000011L,1000000001L,1000110001L,1001001001L,1010000101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256495Inst : IEnumerable<long>
{
public static readonly long[] Value=A256495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256495.Bytes);
public long this[int i]=>Value[i];

public static A256495Inst Instance=new A256495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256496
{
public static readonly long[] Value={ 31L,32L,33L,34L,35L,6L,37L,38L,39L,10L,41L,12L,43L,44L,15L,16L,47L,18L,49L,20L,21L,22L,53L,24L,25L,26L,27L,28L,59L,0L,31L,32L,33L,34L,35L,6L,37L,38L,39L,10L,41L,12L,43L,44L,15L,16L,47L,18L,49L,20L,21L,22L,53L,24L,25L,26L,27L,28L,59L,0L,31L,32L,33L,34L,35L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256496Inst : IEnumerable<long>
{
public static readonly long[] Value=A256496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256496.Bytes);
public long this[int i]=>Value[i];

public static A256496Inst Instance=new A256496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256497
{
public static readonly long[] Value={ 9L,28L,35L,65L,72L,91L,126L,133L,152L,189L,217L,224L,243L,280L,341L,344L,351L,370L,407L,468L,559L,513L,520L,539L,576L,637L,728L,855L,730L,737L,756L,793L,854L,945L,1072L,1241L,1001L,1008L,1027L,1064L,1125L,1216L,1343L,1512L,1729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256497Inst : IEnumerable<long>
{
public static readonly long[] Value=A256497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256497.Bytes);
public long this[int i]=>Value[i];

public static A256497Inst Instance=new A256497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256498
{
public static readonly long[] Value={ 11L,15L,25L,31L,36L,37L,42L,45L,48L,75L,149L,156L,160L,182L,268L,444L,581L,1025L,1125L,2504L,6900L,10924L,11807L,25262L,26774L,28739L,29367L,34902L,43345L,53878L,74473L,107070L,170300L,178994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256498Inst : IEnumerable<long>
{
public static readonly long[] Value=A256498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256498.Bytes);
public long this[int i]=>Value[i];

public static A256498Inst Instance=new A256498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256499
{
public static readonly BigInteger[] Value={ 17L,257L,260609L,16580657L,527972353L,1054904321L,33590968001L,267934222337L,2137144350721L,BigInteger.Parse("279308966066204560897"),BigInteger.Parse("4904838477959792746889087209953222309396481"),BigInteger.Parse("623502124433801536413569315448615191583313921"),BigInteger.Parse("9936775914719167257001281976859570231260282873") };
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
public class A256499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256499Inst Instance=new A256499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256500
{
public static readonly long[] Value={ 1L,5L,9L,3L,6L,2L,4L,2L,6L,0L,0L,4L,0L,0L,4L,0L,0L,9L,2L,3L,2L,3L,0L,4L,1L,8L,7L,5L,8L,7L,5L,1L,6L,0L,2L,4L,1L,7L,8L,9L,0L,0L,2L,4L,2L,4L,8L,1L,8L,8L,5L,9L,3L,6L,4L,9L,9L,9L,5L,0L,4L,5L,1L,1L,6L,9L,6L,0L,8L,4L,9L,8L,4L,8L,1L,6L,1L,8L,7L,9L,5L,0L,2L,3L,2L,7L,4L,9L,9L,2L,7L,6L,6L,1L,8L,4L,4L,0L,7L,1L,4L,1L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256500Inst : IEnumerable<long>
{
public static readonly long[] Value=A256500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256500.Bytes);
public long this[int i]=>Value[i];

public static A256500Inst Instance=new A256500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256501
{
public static readonly long[] Value={ 3L,9L,2L,0L,6L,9L,0L,3L,9L,4L,8L,7L,2L,8L,8L,6L,3L,4L,3L,5L,6L,0L,8L,9L,1L,3L,5L,2L,6L,1L,3L,5L,3L,6L,2L,2L,0L,5L,2L,5L,6L,2L,7L,3L,7L,1L,2L,0L,7L,9L,8L,4L,5L,3L,0L,4L,0L,1L,1L,7L,5L,0L,0L,5L,7L,9L,0L,5L,0L,5L,6L,4L,8L,3L,6L,6L,7L,0L,5L,7L,5L,7L,4L,3L,3L,6L,5L,6L,6L,0L,1L,8L,9L,4L,8L,3L,6L,5L,8L,9L,0L,4L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256501Inst : IEnumerable<long>
{
public static readonly long[] Value=A256501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256501.Bytes);
public long this[int i]=>Value[i];

public static A256501Inst Instance=new A256501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256502
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,13L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,27L,27L,28L,28L,29L,30L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,36L,37L,38L,38L,39L,39L,40L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256502Inst : IEnumerable<long>
{
public static readonly long[] Value=A256502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256502.Bytes);
public long this[int i]=>Value[i];

public static A256502Inst Instance=new A256502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256503
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,2L,1L,0L,1L,0L,0L,1L,5L,1L,0L,0L,1L,5L,1L,0L,5L,1L,5L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,5L,1L,0L,0L,1L,0L,0L,0L,0L,1L,5L,0L,1L,5L,2L,0L,0L,0L,2L,0L,0L,0L,1L,0L,2L,5L,0L,1L,2L,0L,0L,1L,1L,0L,1L,0L,0L,0L,2L,0L,0L,1L,0L,5L,1L,0L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256503Inst : IEnumerable<long>
{
public static readonly long[] Value=A256503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256503.Bytes);
public long this[int i]=>Value[i];

public static A256503Inst Instance=new A256503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256504
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,6L,5L,1L,6L,7L,12L,10L,12L,11L,12L,1L,8L,16L,14L,17L,18L,18L,23L,13L,21L,18L,22L,23L,24L,19L,14L,1L,22L,20L,23L,24L,31L,27L,25L,26L,36L,28L,37L,29L,30L,42L,37L,22L,32L,37L,38L,35L,41L,36L,37L,43L,42L,37L,44L,44L,34L,33L,47L,1L,48L,49L,43L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256504Inst : IEnumerable<long>
{
public static readonly long[] Value=A256504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256504.Bytes);
public long this[int i]=>Value[i];

public static A256504Inst Instance=new A256504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256505
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256505Inst : IEnumerable<long>
{
public static readonly long[] Value=A256505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256505.Bytes);
public long this[int i]=>Value[i];

public static A256505Inst Instance=new A256505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256506
{
public static readonly BigInteger[] Value={ 0L,1L,7L,64L,711L,9307L,140316L,2394679L,45639217L,960818236L,22144458645L,554572284361L,14995596136392L,435426860239729L,13513228263567991L,446371959557983432L,15636531812792988111UL,BigInteger.Parse("578998049032898543539"),BigInteger.Parse("22596560444095836186132"),BigInteger.Parse("927037976256962182174951") };
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
public class A256506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256506Inst Instance=new A256506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256507
{
public static readonly long[] Value={ 1L,4L,7L,1L,2L,5L,7L,8L,11L,12L,14L,1L,2L,3L,6L,7L,9L,11L,12L,13L,16L,17L,19L,20L,22L,23L,1L,2L,3L,4L,7L,8L,10L,11L,13L,14L,16L,17L,18L,19L,22L,23L,24L,26L,27L,28L,30L,31L,33L,34L,1L,2L,3L,4L,5L,8L,9L,10L,12L,13L,14L,16L,17L,19L,20L,22L,23L,24L,25L,26L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256507Inst : IEnumerable<long>
{
public static readonly long[] Value=A256507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256507.Bytes);
public long this[int i]=>Value[i];

public static A256507Inst Instance=new A256507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256508
{
public static readonly long[] Value={ 1L,4L,6L,2L,10L,9L,14L,12L,3L,15L,22L,8L,26L,21L,20L,18L,34L,16L,38L,25L,28L,33L,46L,27L,5L,39L,30L,35L,58L,24L,62L,36L,44L,51L,42L,32L,74L,57L,52L,45L,82L,49L,86L,55L,50L,69L,94L,54L,7L,60L,68L,65L,106L,48L,66L,63L,76L,87L,118L,70L,122L,93L,77L,72L,78L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256508Inst : IEnumerable<long>
{
public static readonly long[] Value=A256508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256508.Bytes);
public long this[int i]=>Value[i];

public static A256508Inst Instance=new A256508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256509
{
public static readonly BigInteger[] Value={ -1L,-1L,-1L,713L,BigInteger.Parse("620448401733239439359975") };
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
public class A256509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256509Inst Instance=new A256509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256510
{
public static readonly long[] Value={ 3L,5L,17L,257L,977L,3257L,5189L,11717L,13367L,22937L,65537L,307397L,491537L,589409L,983777L,1659587L,2822717L,3137357L,5577827L,6475457L,7378373L,8698097L,10798727L,32235737L,37797437L,39220127L,39285437L,51555137L,52077197L,56992553L,63767927L,70075997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256510Inst : IEnumerable<long>
{
public static readonly long[] Value=A256510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256510.Bytes);
public long this[int i]=>Value[i];

public static A256510Inst Instance=new A256510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256511
{
public static readonly BigInteger[] Value={ 1L,6L,40320L,1307674368000L,BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("10333147966386144929666651337523200000000"),BigInteger.Parse("12413915592536072670862289047373375038521486354677760000000000") };
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
public class A256511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256511Inst Instance=new A256511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256512
{
public static readonly BigInteger[] Value={ 0L,3L,34L,651L,16388L,500005L,17915910L,737894535L,34359738376L,1785233613321L,102400000000010L,6427501315524619L,438244169232678924L,BigInteger.Parse("32254987351648575501"),BigInteger.Parse("2548827677619195478030"),BigInteger.Parse("215233605000000000000015"),BigInteger.Parse("19342813113834066795298832") };
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
public class A256512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256512Inst Instance=new A256512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256513
{
public static readonly long[] Value={ 1L,4L,9L,2L,25L,3L,49L,12L,6L,5L,132L,8L,169L,7L,10L,18L,289L,16L,399L,15L,14L,11L,529L,30L,20L,13L,24L,21L,841L,27L,961L,36L,22L,17L,28L,32L,1369L,19L,26L,70L,1681L,35L,1849L,33L,40L,23L,2209L,54L,42L,45L,34L,39L,2809L,48L,44L,133L,38L,29L,3481L,50L,3721L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256513Inst : IEnumerable<long>
{
public static readonly long[] Value=A256513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256513.Bytes);
public long this[int i]=>Value[i];

public static A256513Inst Instance=new A256513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256514
{
public static readonly long[] Value={ 2L,7L,8L,8L,2L,3L,1L,1L,2L,4L,1L,0L,7L,2L,0L,4L,3L,0L,1L,4L,2L,1L,5L,2L,1L,8L,4L,7L,5L,3L,0L,8L,9L,0L,7L,2L,7L,6L,1L,5L,9L,0L,8L,7L,2L,5L,4L,6L,4L,9L,4L,9L,3L,0L,5L,4L,6L,8L,7L,1L,8L,8L,5L,6L,6L,6L,0L,6L,7L,2L,2L,6L,5L,6L,5L,9L,0L,5L,8L,0L,4L,4L,7L,2L,5L,0L,2L,7L,9L,1L,7L,5L,7L,8L,8L,4L,0L,6L,7L,5L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256514Inst : IEnumerable<long>
{
public static readonly long[] Value=A256514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256514.Bytes);
public long this[int i]=>Value[i];

public static A256514Inst Instance=new A256514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256515
{
public static readonly long[] Value={ 56L,65L,5265L,5625L,5656L,6565L,12705L,44370L,50721L,51557L,55517L,56056L,59248L,65065L,71555L,75515L,84295L,139755L,273728L,360145L,481610L,523908L,541063L,557931L,560056L,560439L,565656L,606056L,621770L,650065L,650606L,656565L,697996L,699796L,809325L,827372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256515Inst : IEnumerable<long>
{
public static readonly long[] Value=A256515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256515.Bytes);
public long this[int i]=>Value[i];

public static A256515Inst Instance=new A256515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256516
{
public static readonly long[] Value={ 1L,2L,102L,249L,294L,1635L,3647L,5105L,6954L,357593L,416507L,497533L,821581L,1299504L,1457054L,39082410L,45969853L,47607985L,86389357L,121338042L,183331620L,191525092L,198003319L,388055713L,427238910L,570434345L,678096433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256516Inst : IEnumerable<long>
{
public static readonly long[] Value=A256516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256516.Bytes);
public long this[int i]=>Value[i];

public static A256516Inst Instance=new A256516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256517
{
public static readonly long[] Value={ 17L,37L,65L,80L,101L,145L,197L,26L,257L,325L,401L,197L,485L,577L,182L,677L,728L,177L,901L,1025L,485L,1157L,99L,1297L,1445L,170L,1601L,1765L,1937L,82L,2117L,2305L,1047L,2501L,577L,529L,2917L,1451L,3137L,721L,3365L,3601L,3845L,244L,4097L,99L,1945L,4625L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256517Inst : IEnumerable<long>
{
public static readonly long[] Value=A256517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256517.Bytes);
public long this[int i]=>Value[i];

public static A256517Inst Instance=new A256517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256518
{
public static readonly long[] Value={ 2112L,4224L,11110L,13104L,16128L,17136L,21120L,23184L,27216L,32256L,42240L,70224L,76608L,79632L,92736L,100128L,101101L,101808L,110110L,111100L,111375L,127008L,130104L,131040L,161280L,170170L,171360L,200112L,211200L,231840L,272160L,301125L,322560L,391092L,422400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256518Inst : IEnumerable<long>
{
public static readonly long[] Value=A256518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256518.Bytes);
public long this[int i]=>Value[i];

public static A256518Inst Instance=new A256518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256519
{
public static readonly long[] Value={ 25L,121L,169L,437L,551L,667L,721L,1037L,1159L,1273L,1349L,1403L,1541L,1769L,1943L,2209L,2329L,2363L,2419L,3071L,3713L,4087L,5041L,5111L,7313L,8357L,8479L,9017L,11357L,11983L,12673L,16117L,16343L,19043L,19099L,19879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256519Inst : IEnumerable<long>
{
public static readonly long[] Value=A256519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256519.Bytes);
public long this[int i]=>Value[i];

public static A256519Inst Instance=new A256519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256520
{
public static readonly long[] Value={ 83L,84L,95L,46L,443L,255L,182L,557L,1341L,1107L,526L,553L,923L,114L,1014L,2255L,1278L,880L,3039L,796L,1364L,5212L,2070L,1252L,1614L,1544L,496L,4554L,837L,3013L,3051L,1788L,1430L,1628L,7786L,160L,839L,5825L,5682L,941L,1066L,10506L,1977L,655L,1232L,2288L,4989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256520Inst : IEnumerable<long>
{
public static readonly long[] Value=A256520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256520.Bytes);
public long this[int i]=>Value[i];

public static A256520Inst Instance=new A256520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256521
{
public static readonly long[] Value={ 32L,50L,1L,54L,3L,6L,65L,37L,16L,9L,71L,40L,21L,15L,2L,77L,49L,28L,17L,19L,4L,85L,68L,33L,24L,23L,8L,7L,97L,94L,53L,25L,36L,10L,20L,13L,106L,95L,63L,27L,57L,31L,22L,29L,11L,116L,103L,73L,43L,59L,48L,41L,39L,18L,5L,121L,110L,76L,46L,60L,51L,69L,47L,26L,12L,49L,128L,138L,83L,64L,70L,61L,72L,56L,34L,14L,163L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256521Inst : IEnumerable<long>
{
public static readonly long[] Value=A256521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256521.Bytes);
public long this[int i]=>Value[i];

public static A256521Inst Instance=new A256521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256522
{
public static readonly long[] Value={ 3L,3L,2L,0L,5L,7L,3L,3L,6L,2L,1L,5L,1L,9L,6L,2L,9L,8L,9L,3L,7L,1L,8L,0L,0L,6L,2L,0L,1L,0L,5L,8L,2L,9L,6L,6L,5L,4L,7L,0L,9L,3L,5L,6L,1L,4L,1L,2L,6L,7L,9L,8L,1L,8L,1L,0L,0L,4L,4L,7L,5L,6L,4L,0L,1L,9L,8L,7L,2L,4L,1L,7L,4L,0L,1L,8L,0L,6L,4L,4L,0L,5L,0L,7L,0L,4L,9L,0L,7L,3L,1L,8L,5L,5L,1L,4L,6L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256522Inst : IEnumerable<long>
{
public static readonly long[] Value=A256522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256522.Bytes);
public long this[int i]=>Value[i];

public static A256522Inst Instance=new A256522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256523
{
public static readonly long[] Value={ 0L,1L,10L,11L,12L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,966L,967L,968L,969L,970L,971L,972L,973L,974L,975L,976L,977L,978L,979L,980L,981L,982L,983L,984L,985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256523Inst : IEnumerable<long>
{
public static readonly long[] Value=A256523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256523.Bytes);
public long this[int i]=>Value[i];

public static A256523Inst Instance=new A256523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256524
{
public static readonly long[] Value={ 1L,3L,9L,18L,34L,54L,84L,120L,169L,225L,297L,378L,478L,588L,720L,864L,1033L,1215L,1425L,1650L,1906L,2178L,2484L,2808L,3169L,3549L,3969L,4410L,4894L,5400L,5952L,6528L,7153L,7803L,8505L,9234L,10018L,10830L,11700L,12600L,13561L,14553L,15609L,16698L,17854L,19044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256524Inst : IEnumerable<long>
{
public static readonly long[] Value=A256524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256524.Bytes);
public long this[int i]=>Value[i];

public static A256524Inst Instance=new A256524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256525
{
public static readonly long[] Value={ 1L,3L,10L,23L,47L,84L,141L,221L,333L,480L,674L,918L,1226L,1602L,2062L,2611L,3266L,4033L,4932L,5969L,7166L,8529L,10083L,11835L,13811L,16019L,18487L,21224L,24260L,27604L,31289L,35324L,39744L,44559L,49806L,55496L,61667L,68331L,75529L,83273L,91606L,100540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256525Inst : IEnumerable<long>
{
public static readonly long[] Value=A256525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256525.Bytes);
public long this[int i]=>Value[i];

public static A256525Inst Instance=new A256525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256526
{
public static readonly long[] Value={ 16L,24L,458L,18341L,16641L,1116830L,10971256L,105969200L,193295556L,48221950695L,72585186028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256526Inst : IEnumerable<long>
{
public static readonly long[] Value=A256526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256526.Bytes);
public long this[int i]=>Value[i];

public static A256526Inst Instance=new A256526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256527
{
public static readonly long[] Value={ 1L,1L,15L,3L,14L,6L,6L,42L,30L,42L,168L,210L,210L,420L,840L,20790L,20790L,9240L,9240L,83160L,120120L,3984120L,5165160L,43825320L,26860680L,43825320L,1304863560L,569729160L,569729160L,16522145640L,18176198040L,563462139240L,1140028049160L,3844800479520L,1255683068640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256527Inst : IEnumerable<long>
{
public static readonly long[] Value=A256527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256527.Bytes);
public long this[int i]=>Value[i];

public static A256527Inst Instance=new A256527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256528
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,24L,33L,43L,55L,60L,74L,89L,96L,114L,135L,151L,178L,198L,231L,255L,266L,292L,314L,327L,355L,394L,426L,456L,500L,525L,559L,594L,611L,651L,702L,738L,806L,848L,900L,945L,983L,1031L,1050L,1096L,1153L,1176L,1230L,1299L,1349L,1412L,1467L,1516L,1576L,1632L,1697L,1755L,1825L,1854L,1916L,2003L,2034L,2100L,2193L,2257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256528Inst : IEnumerable<long>
{
public static readonly long[] Value=A256528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256528.Bytes);
public long this[int i]=>Value[i];

public static A256528Inst Instance=new A256528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256529
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,24L,33L,43L,55L,60L,74L,89L,96L,114L,135L,151L,178L,198L,231L,255L,266L,292L,314L,327L,355L,394L,426L,456L,490L,515L,532L,567L,618L,658L,700L,738L,774L,793L,837L,894L,940L,985L,1008L,1056L,1125L,1175L,1229L,1281L,1339L,1395L,1424L,1473L,1560L,1623L,1683L,1760L,1822L,1877L,1908L,1973L,2066L,2136L,2202L,2266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256529Inst : IEnumerable<long>
{
public static readonly long[] Value=A256529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256529.Bytes);
public long this[int i]=>Value[i];

public static A256529Inst Instance=new A256529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256530
{
public static readonly long[] Value={ 0L,1L,9L,21L,49L,61L,97L,157L,225L,237L,273L,333L,417L,525L,657L,813L,961L,973L,1009L,1069L,1153L,1261L,1393L,1549L,1729L,1933L,2161L,2413L,2689L,2989L,3313L,3661L,3969L,3981L,4017L,4077L,4161L,4269L,4401L,4557L,4737L,4941L,5169L,5421L,5697L,5997L,6321L,6669L,7041L,7437L,7857L,8301L,8769L,9261L,9777L,10317L,10881L,11469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256530Inst : IEnumerable<long>
{
public static readonly long[] Value=A256530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256530.Bytes);
public long this[int i]=>Value[i];

public static A256530Inst Instance=new A256530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256531
{
public static readonly long[] Value={ 0L,1L,8L,12L,28L,12L,36L,60L,68L,12L,36L,60L,84L,108L,132L,156L,148L,12L,36L,60L,84L,108L,132L,156L,180L,204L,228L,252L,276L,300L,324L,348L,308L,12L,36L,60L,84L,108L,132L,156L,180L,204L,228L,252L,276L,300L,324L,348L,372L,396L,420L,444L,468L,492L,516L,540L,564L,588L,612L,636L,660L,684L,708L,732L,628L,12L,36L,60L,84L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256531Inst : IEnumerable<long>
{
public static readonly long[] Value=A256531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256531.Bytes);
public long this[int i]=>Value[i];

public static A256531Inst Instance=new A256531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256532
{
public static readonly long[] Value={ 0L,0L,3L,4L,20L,18L,56L,64L,108L,130L,242L,204L,364L,434L,540L,576L,867L,846L,1216L,1220L,1470L,1694L,2254L,2040L,2575L,2912L,3375L,3472L,4379L,4140L,5177L,5344L,6072L,6698L,7630L,7128L,8621L,9424L,10491L,10320L,12177L,11928L,13975L,14432L,15255L,16468L,18941L,17952L,20286L,21000L,22899L,23608L,26765L,26568L,29095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256532Inst : IEnumerable<long>
{
public static readonly long[] Value=A256532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256532.Bytes);
public long this[int i]=>Value[i];

public static A256532Inst Instance=new A256532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256533
{
public static readonly long[] Value={ 1L,8L,24L,60L,105L,198L,287L,448L,621L,870L,1089L,1524L,1833L,2310L,2835L,3520L,4046L,4986L,5643L,6780L,7791L,8954L,9913L,11784L,13050L,14664L,16308L,18480L,20010L,22860L,24614L,27424L,29865L,32606L,35245L,39528L,42032L,45448L,48828L,53680L,56744L,62160L,65532L,70752L,75870L,80868L,84882L,92640L,97363L,104000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256533Inst : IEnumerable<long>
{
public static readonly long[] Value=A256533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256533.Bytes);
public long this[int i]=>Value[i];

public static A256533Inst Instance=new A256533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256534
{
public static readonly long[] Value={ 0L,4L,16L,28L,64L,76L,112L,172L,256L,268L,304L,364L,448L,556L,688L,844L,1024L,1036L,1072L,1132L,1216L,1324L,1456L,1612L,1792L,1996L,2224L,2476L,2752L,3052L,3376L,3724L,4096L,4108L,4144L,4204L,4288L,4396L,4528L,4684L,4864L,5068L,5296L,5548L,5824L,6124L,6448L,6796L,7168L,7564L,7984L,8428L,8896L,9388L,9904L,10444L,11008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256534Inst : IEnumerable<long>
{
public static readonly long[] Value=A256534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256534.Bytes);
public long this[int i]=>Value[i];

public static A256534Inst Instance=new A256534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256535
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,8L,11L,16L,19L,24L,29L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256535Inst : IEnumerable<long>
{
public static readonly long[] Value=A256535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256535.Bytes);
public long this[int i]=>Value[i];

public static A256535Inst Instance=new A256535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256536
{
public static readonly long[] Value={ 1L,4L,9L,18L,27L,36L,53L,78L,95L,104L,121L,150L,187L,220L,261L,318L,351L,360L,377L,406L,443L,480L,533L,618L,703L,752L,793L,866L,967L,1060L,1161L,1286L,1351L,1360L,1377L,1406L,1443L,1480L,1533L,1618L,1703L,1756L,1809L,1902L,2035L,2176L,2325L,2522L,2703L,2784L,2825L,2898L,2999L,3108L,3249L,3470L,3723L,3896L,4013L,4186L,4435L,4672L,4909L,5174L,5303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256536Inst : IEnumerable<long>
{
public static readonly long[] Value=A256536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256536.Bytes);
public long this[int i]=>Value[i];

public static A256536Inst Instance=new A256536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256537
{
public static readonly long[] Value={ 1L,3L,5L,9L,9L,9L,17L,25L,17L,9L,17L,29L,37L,33L,41L,57L,33L,9L,17L,29L,37L,37L,53L,85L,85L,49L,41L,73L,101L,93L,101L,125L,65L,9L,17L,29L,37L,37L,53L,85L,85L,53L,53L,93L,133L,141L,149L,197L,181L,81L,41L,73L,101L,109L,141L,221L,253L,173L,117L,173L,249L,237L,237L,265L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256537Inst : IEnumerable<long>
{
public static readonly long[] Value=A256537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256537.Bytes);
public long this[int i]=>Value[i];

public static A256537Inst Instance=new A256537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256538
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256538Inst : IEnumerable<long>
{
public static readonly long[] Value=A256538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256538.Bytes);
public long this[int i]=>Value[i];

public static A256538Inst Instance=new A256538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256539
{
public static readonly long[] Value={ 1L,5L,18L,47L,101L,192L,333L,540L,831L,1226L,1747L,2418L,3266L,4319L,5608L,7166L,9027L,11229L,13811L,16814L,20282L,24260L,28796L,33940L,39744L,46262L,53550L,61667L,70673L,80631L,91606L,103664L,116875L,131310L,147042L,164147L,182702L,202787L,224484L,247877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256539Inst : IEnumerable<long>
{
public static readonly long[] Value=A256539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256539.Bytes);
public long this[int i]=>Value[i];

public static A256539Inst Instance=new A256539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256540
{
public static readonly long[] Value={ 1L,5L,20L,58L,136L,282L,532L,931L,1540L,2432L,3692L,5427L,7760L,10829L,14800L,19858L,26207L,34085L,43752L,55491L,69624L,86499L,106491L,130019L,157532L,189509L,226479L,269005L,317683L,373165L,436140L,507334L,587535L,677571L,778311L,890691L,1015691L,1154336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256540Inst : IEnumerable<long>
{
public static readonly long[] Value=A256540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256540.Bytes);
public long this[int i]=>Value[i];

public static A256540Inst Instance=new A256540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256541
{
public static readonly long[] Value={ 1L,2L,-1L,5L,-1L,-1L,-1L,7L,-1L,-1L,-1L,7L,-1L,-1L,-1L,8L,-1L,-1L,-1L,-1L,7L,-1L,-1L,47L,-41L,-1L,-1L,-1L,14L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,133L,-121L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256541Inst : IEnumerable<long>
{
public static readonly long[] Value=A256541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256541.Bytes);
public long this[int i]=>Value[i];

public static A256541Inst Instance=new A256541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256542
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,4L,2L,6L,2L,4L,3L,5L,4L,4L,2L,4L,6L,2L,6L,2L,8L,2L,4L,4L,6L,4L,4L,3L,4L,4L,2L,9L,4L,4L,4L,6L,2L,8L,2L,8L,2L,8L,2L,6L,6L,4L,2L,10L,3L,6L,4L,6L,2L,8L,4L,8L,4L,4L,2L,12L,2L,4L,6L,7L,4L,8L,2L,6L,4L,10L,2L,8L,4L,6L,6L,4L,2L,12L,2L,8L,4L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256542Inst : IEnumerable<long>
{
public static readonly long[] Value=A256542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256542.Bytes);
public long this[int i]=>Value[i];

public static A256542Inst Instance=new A256542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256543
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,22L,23L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,71L,72L,73L,74L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256543Inst : IEnumerable<long>
{
public static readonly long[] Value=A256543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256543.Bytes);
public long this[int i]=>Value[i];

public static A256543Inst Instance=new A256543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256544
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,4L,5L,4L,6L,5L,6L,6L,6L,6L,8L,6L,8L,7L,9L,7L,9L,8L,8L,9L,9L,9L,10L,9L,9L,11L,9L,12L,10L,10L,9L,14L,10L,11L,11L,13L,9L,14L,10L,12L,15L,11L,13L,12L,14L,12L,12L,13L,15L,14L,14L,11L,16L,11L,17L,14L,14L,14L,16L,13L,16L,15L,17L,12L,15L,17L,15L,17L,15L,14L,20L,13L,15L,19L,14L,18L,16L,21L,12L,19L,15L,16L,22L,18L,15L,18L,14L,21L,19L,18L,18L,17L,19L,18L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256544Inst : IEnumerable<long>
{
public static readonly long[] Value=A256544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256544.Bytes);
public long this[int i]=>Value[i];

public static A256544Inst Instance=new A256544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256545
{
public static readonly long[] Value={ 6L,30L,434L,510L,616L,912L,1640L,2989L,3003L,5934L,7280L,8600L,10726L,12700L,13825L,14288L,18699L,19389L,54153L,59394L,59906L,70563L,72816L,116052L,117964L,121954L,131070L,134212L,140752L,177000L,206514L,210728L,274023L,319522L,418610L,437736L,456666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256545Inst : IEnumerable<long>
{
public static readonly long[] Value=A256545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256545.Bytes);
public long this[int i]=>Value[i];

public static A256545Inst Instance=new A256545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256546
{
public static readonly long[] Value={ 11L,17L,18L,22L,29L,32L,35L,39L,41L,44L,46L,49L,50L,51L,53L,55L,57L,59L,60L,61L,64L,66L,69L,70L,73L,75L,76L,77L,79L,81L,86L,92L,95L,96L,101L,102L,103L,107L,112L,113L,114L,116L,117L,118L,120L,125L,131L,133L,135L,137L,138L,141L,143L,144L,147L,148L,149L,150L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256546Inst : IEnumerable<long>
{
public static readonly long[] Value=A256546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256546.Bytes);
public long this[int i]=>Value[i];

public static A256546Inst Instance=new A256546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256547
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,4L,1L,1L,2L,0L,1L,1L,1L,29L,1L,0L,0L,29L,2L,29L,0L,29L,29L,1L,1L,1L,2L,0L,2L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,29L,1L,0L,5L,0L,9L,1L,0L,0L,0L,2L,0L,1L,0L,29L,0L,2L,0L,0L,0L,14L,1L,0L,9L,0L,1L,1L,0L,0L,29L,1L,0L,1L,0L,0L,0L,1L,0L,14L,0L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256547Inst : IEnumerable<long>
{
public static readonly long[] Value=A256547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256547.Bytes);
public long this[int i]=>Value[i];

public static A256547Inst Instance=new A256547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256548
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,2L,9L,13L,0L,6L,33L,78L,73L,0L,24L,150L,455L,730L,501L,0L,120L,822L,2925L,6205L,7515L,4051L,0L,720L,5292L,21112L,53655L,87675L,85071L,37633L,0L,5040L,39204L,170716L,494137L,981960L,1304422L,1053724L,394353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256548Inst : IEnumerable<long>
{
public static readonly long[] Value=A256548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256548.Bytes);
public long this[int i]=>Value[i];

public static A256548Inst Instance=new A256548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256549
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,1L,9L,13L,0L,1L,21L,78L,73L,0L,1L,45L,325L,730L,501L,0L,1L,93L,1170L,4745L,7515L,4051L,0L,1L,189L,3913L,25550L,70140L,85071L,37633L,0L,1L,381L,12558L,124173L,526050L,1077566L,1053724L,394353L,0L,1L,765L,39325L,567210L,3482451L,10718946L,17386446L,14196708L,4596553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256549Inst : IEnumerable<long>
{
public static readonly long[] Value=A256549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256549.Bytes);
public long this[int i]=>Value[i];

public static A256549Inst Instance=new A256549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256550
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,3L,1L,0L,5L,12L,6L,1L,0L,15L,50L,40L,10L,1L,0L,52L,225L,250L,100L,15L,1L,0L,203L,1092L,1575L,875L,210L,21L,1L,0L,877L,5684L,10192L,7350L,2450L,392L,28L,1L,0L,4140L,31572L,68208L,61152L,26460L,5880L,672L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256550Inst : IEnumerable<long>
{
public static readonly long[] Value=A256550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256550.Bytes);
public long this[int i]=>Value[i];

public static A256550Inst Instance=new A256550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256551
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,1L,-3L,1L,0L,1L,6L,-6L,1L,0L,-15L,10L,20L,-10L,1L,0L,48L,-225L,50L,50L,-15L,1L,0L,581L,1008L,-1575L,175L,105L,-21L,1L,0L,-11069L,16268L,9408L,-7350L,490L,196L,-28L,1L,0L,20784L,-398484L,195216L,56448L,-26460L,1176L,336L,-36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256551Inst : IEnumerable<long>
{
public static readonly long[] Value=A256551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256551.Bytes);
public long this[int i]=>Value[i];

public static A256551Inst Instance=new A256551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256552
{
public static readonly long[] Value={ 1L,-2L,-8L,16L,20L,-36L,0L,-32L,-75L,220L,104L,-128L,-44L,-392L,0L,256L,232L,474L,-536L,320L,168L,-1124L,0L,-576L,245L,852L,1248L,0L,-1668L,2040L,0L,-512L,-1368L,-2632L,-560L,-1200L,4756L,1428L,0L,3520L,656L,-3528L,-3224L,1664L,-4740L,2168L,0L,-2048L,1449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256552Inst : IEnumerable<long>
{
public static readonly long[] Value=A256552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256552.Bytes);
public long this[int i]=>Value[i];

public static A256552Inst Instance=new A256552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256553
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,7L,10L,12L,1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,15L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,20L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,20L,21L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256553Inst : IEnumerable<long>
{
public static readonly long[] Value=A256553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256553.Bytes);
public long this[int i]=>Value[i];

public static A256553Inst Instance=new A256553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256554
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,2L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,1L,1L,1L,4L,2L,4L,1L,5L,1L,1L,1L,1L,1L,1L,4L,3L,4L,1L,7L,1L,1L,1L,2L,2L,1L,1L,1L,1L,5L,3L,6L,2L,9L,1L,2L,1L,3L,4L,1L,1L,1L,1L,1L,1L,5L,3L,6L,2L,12L,1L,2L,1L,4L,1L,6L,2L,2L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256554Inst : IEnumerable<long>
{
public static readonly long[] Value=A256554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256554.Bytes);
public long this[int i]=>Value[i];

public static A256554Inst Instance=new A256554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256555
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,4L,5L,5L,6L,6L,6L,5L,7L,6L,6L,7L,7L,8L,7L,8L,9L,7L,10L,7L,7L,9L,9L,9L,9L,12L,11L,10L,12L,8L,10L,10L,10L,9L,9L,13L,11L,10L,13L,11L,11L,12L,10L,10L,14L,14L,12L,12L,15L,13L,13L,13L,12L,14L,14L,15L,14L,13L,19L,13L,13L,15L,11L,13L,13L,15L,16L,17L,19L,16L,16L,15L,17L,15L,15L,17L,17L,16L,20L,16L,16L,20L,17L,19L,17L,18L,20L,17L,21L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256555Inst : IEnumerable<long>
{
public static readonly long[] Value=A256555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256555.Bytes);
public long this[int i]=>Value[i];

public static A256555Inst Instance=new A256555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256556
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,42L,88L,184L,384L,800L,1664L,3456L,7168L,14848L,30L,93L,288L,891L,2754L,8505L,26244L,80919L,249318L,767637L,40L,164L,672L,2752L,11264L,46080L,188416L,770048L,3145728L,12845056L,50L,255L,1300L,6625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256556Inst : IEnumerable<long>
{
public static readonly long[] Value=A256556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256556.Bytes);
public long this[int i]=>Value[i];

public static A256556Inst Instance=new A256556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256557
{
public static readonly long[] Value={ 0L,3L,15L,8L,63L,48L,35L,24L,143L,120L,99L,80L,255L,224L,195L,168L,440L,399L,360L,323L,288L,575L,528L,483L,4760L,783L,728L,675L,624L,1520L,1443L,1368L,1295L,1224L,1155L,1088L,1023L,960L,899L,840L,1599L,1680L,1763L,1848L,1935L,2024L,2115L,2208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256557Inst : IEnumerable<long>
{
public static readonly long[] Value=A256557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256557.Bytes);
public long this[int i]=>Value[i];

public static A256557Inst Instance=new A256557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256558
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,2L,2L,3L,1L,3L,1L,4L,2L,3L,1L,3L,3L,3L,2L,4L,3L,2L,3L,4L,3L,2L,3L,1L,5L,3L,3L,3L,3L,3L,3L,3L,3L,4L,2L,3L,5L,3L,2L,6L,2L,5L,4L,4L,1L,6L,3L,4L,3L,3L,3L,5L,3L,4L,4L,2L,3L,6L,4L,5L,4L,2L,3L,5L,3L,5L,6L,2L,4L,6L,4L,5L,3L,3L,5L,5L,6L,3L,6L,2L,3L,6L,4L,4L,7L,3L,3L,5L,5L,3L,3L,2L,6L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256558Inst : IEnumerable<long>
{
public static readonly long[] Value=A256558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256558.Bytes);
public long this[int i]=>Value[i];

public static A256558Inst Instance=new A256558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256559
{
public static readonly long[] Value={ 5L,1L,9L,8L,7L,2L,13L,12L,11L,5L,17L,16L,15L,8L,22L,21L,20L,19L,12L,25L,24L,7L,170L,29L,28L,27L,16L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,21L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,23L,505L,81L,80L,79L,78L,77L,76L,75L,74L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256559Inst : IEnumerable<long>
{
public static readonly long[] Value=A256559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256559.Bytes);
public long this[int i]=>Value[i];

public static A256559Inst Instance=new A256559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256560
{
public static readonly long[] Value={ 14L,38L,48L,82L,92L,116L,152L,162L,186L,230L,254L,264L,288L,332L,402L,394L,404L,428L,472L,542L,644L,578L,588L,612L,656L,726L,828L,968L,812L,822L,846L,890L,960L,1062L,1202L,1386L,1102L,1112L,1136L,1180L,1250L,1352L,1492L,1676L,1910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256560Inst : IEnumerable<long>
{
public static readonly long[] Value=A256560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256560.Bytes);
public long this[int i]=>Value[i];

public static A256560Inst Instance=new A256560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256561
{
public static readonly long[] Value={ 2L,4L,8L,6L,10L,16L,21L,19L,23L,40L,38L,32L,42L,44L,48L,54L,60L,62L,68L,80L,78L,72L,91L,111L,114L,88L,86L,120L,118L,130L,137L,133L,150L,152L,168L,162L,97L,192L,188L,182L,176L,186L,160L,215L,280L,291L,122L,226L,222L,220L,240L,263L,275L,300L,245L,277L,329L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256561Inst : IEnumerable<long>
{
public static readonly long[] Value=A256561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256561.Bytes);
public long this[int i]=>Value[i];

public static A256561Inst Instance=new A256561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256562
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,10L,11L,12L,13L,14L,15L,15L,16L,16L,17L,18L,19L,19L,20L,21L,22L,22L,23L,23L,24L,25L,26L,27L,28L,28L,29L,30L,31L,31L,32L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,42L,43L,43L,44L,45L,46L,46L,47L,48L,49L,50L,51L,51L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256562Inst : IEnumerable<long>
{
public static readonly long[] Value=A256562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256562.Bytes);
public long this[int i]=>Value[i];

public static A256562Inst Instance=new A256562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256563
{
public static readonly long[] Value={ 3L,7L,12L,11L,15L,14L,17L,24L,29L,28L,36L,35L,34L,31L,30L,47L,50L,52L,56L,58L,59L,63L,66L,25L,77L,74L,92L,89L,102L,101L,109L,107L,106L,105L,83L,116L,128L,125L,124L,143L,142L,141L,135L,131L,147L,154L,155L,156L,103L,171L,99L,96L,95L,145L,189L,259L,178L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256563Inst : IEnumerable<long>
{
public static readonly long[] Value=A256563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256563.Bytes);
public long this[int i]=>Value[i];

public static A256563Inst Instance=new A256563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256564
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,7L,2L,5L,2L,11L,2L,3L,2L,3L,2L,13L,3L,2L,19L,2L,17L,2L,23L,2L,3L,2L,3L,2L,5L,3L,2L,37L,2L,5L,2L,3L,2L,31L,2L,29L,2L,41L,2L,43L,2L,3L,2L,47L,2L,7L,2L,3L,2L,53L,2L,5L,2L,3L,2L,59L,2L,61L,2L,3L,2L,5L,2L,67L,2L,3L,2L,79L,2L,7L,2L,3L,2L,73L,2L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256564Inst : IEnumerable<long>
{
public static readonly long[] Value=A256564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256564.Bytes);
public long this[int i]=>Value[i];

public static A256564Inst Instance=new A256564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256565
{
public static readonly long[] Value={ 5L,3L,20L,2L,6L,142L,183L,66L,294L,88L,34L,387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256565Inst : IEnumerable<long>
{
public static readonly long[] Value=A256565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256565.Bytes);
public long this[int i]=>Value[i];

public static A256565Inst Instance=new A256565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256566
{
public static readonly long[] Value={ 1L,3L,3L,3L,9L,9L,9L,2L,2L,2L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,38L,46L,46L,46L,46L,46L,46L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,58L,62L,62L,74L,74L,74L,74L,82L,82L,74L,74L,74L,62L,74L,74L,74L,74L,74L,62L,74L,74L,82L,82L,82L,82L,82L,82L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256566Inst : IEnumerable<long>
{
public static readonly long[] Value=A256566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256566.Bytes);
public long this[int i]=>Value[i];

public static A256566Inst Instance=new A256566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256567
{
public static readonly long[] Value={ 7L,11L,17L,19L,23L,37L,43L,53L,59L,61L,67L,79L,83L,89L,97L,101L,103L,107L,109L,113L,137L,149L,157L,167L,173L,181L,191L,199L,211L,223L,227L,229L,241L,251L,263L,271L,281L,283L,293L,307L,313L,317L,337L,347L,359L,367L,373L,379L,383L,389L,401L,419L,421L,431L,433L,449L,457L,463L,467L,479L,503L,521L,523L,557L,563L,569L,571L,593L,599L,607L,613L,617L,619L,631L,641L,643L,659L,661L,677L,691L,701L,709L,719L,727L,733L,743L,751L,757L,769L,773L,787L,797L,809L,821L,827L,829L,839L,853L,877L,881L,883L,907L,911L,919L,937L,941L,953L,971L,977L,983L,991L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256567Inst : IEnumerable<long>
{
public static readonly long[] Value=A256567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256567.Bytes);
public long this[int i]=>Value[i];

public static A256567Inst Instance=new A256567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256568
{
public static readonly long[] Value={ 4L,2L,6L,7L,1L,5L,2L,3L,6L,0L,9L,8L,4L,0L,9L,8L,8L,6L,5L,2L,3L,0L,1L,0L,9L,1L,8L,3L,4L,1L,8L,1L,5L,1L,2L,7L,8L,9L,2L,7L,8L,3L,3L,9L,5L,8L,0L,9L,2L,0L,5L,9L,1L,8L,2L,8L,5L,0L,5L,1L,6L,7L,0L,9L,8L,0L,3L,4L,0L,9L,0L,8L,0L,8L,1L,6L,2L,2L,3L,0L,2L,2L,6L,6L,0L,4L,7L,3L,7L,9L,5L,3L,0L,5L,4L,2L,3L,9L,4L,5L,3L,0L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256568Inst : IEnumerable<long>
{
public static readonly long[] Value=A256568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256568.Bytes);
public long this[int i]=>Value[i];

public static A256568Inst Instance=new A256568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256569
{
public static readonly long[] Value={ 1L,6L,21L,61L,171L,461L,1181L,2951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256569Inst : IEnumerable<long>
{
public static readonly long[] Value=A256569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256569.Bytes);
public long this[int i]=>Value[i];

public static A256569Inst Instance=new A256569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256570
{
public static readonly long[] Value={ 1L,2L,4L,5L,11L,16L,22L,24L,110L,232L,557L,566L,888L,1946L,2610L,3302L,10214L,41756L,89160L,120782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256570Inst : IEnumerable<long>
{
public static readonly long[] Value=A256570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256570.Bytes);
public long this[int i]=>Value[i];

public static A256570Inst Instance=new A256570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256571
{
public static readonly long[] Value={ 1L,6L,21L,56L,131L,281L,556L,1046L,1891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256571Inst : IEnumerable<long>
{
public static readonly long[] Value=A256571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256571.Bytes);
public long this[int i]=>Value[i];

public static A256571Inst Instance=new A256571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256572
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,1L,1L,2L,0L,0L,1L,0L,1L,0L,1L,3L,1L,1L,0L,0L,1L,1L,1L,1L,3L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,3L,3L,0L,1L,1L,0L,0L,1L,3L,3L,1L,1L,0L,0L,1L,1L,0L,1L,0L,3L,0L,1L,1L,1L,3L,0L,1L,3L,0L,1L,3L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,3L,1L,0L,3L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,3L,3L,0L,3L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,3L,1L,1L,3L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,3L,0L,3L,0L,1L,3L,1L,3L,0L,0L,0L,3L,1L,3L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256572Inst : IEnumerable<long>
{
public static readonly long[] Value=A256572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256572.Bytes);
public long this[int i]=>Value[i];

public static A256572Inst Instance=new A256572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256573
{
public static readonly long[] Value={ 0L,14L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256573Inst : IEnumerable<long>
{
public static readonly long[] Value=A256573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256573.Bytes);
public long this[int i]=>Value[i];

public static A256573Inst Instance=new A256573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256574
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256574Inst : IEnumerable<long>
{
public static readonly long[] Value=A256574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256574.Bytes);
public long this[int i]=>Value[i];

public static A256574Inst Instance=new A256574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256575
{
public static readonly long[] Value={ 315L,420L,495L,525L,585L,630L,660L,735L,765L,780L,819L,825L,840L,855L,945L,975L,990L,1020L,1035L,1050L,1071L,1092L,1140L,1170L,1260L,1275L,1287L,1320L,1380L,1425L,1428L,1470L,1485L,1530L,1540L,1560L,1575L,1638L,1650L,1665L,1680L,1683L,1710L,1716L,1725L,1755L,1815L,1820L,1827L,1845L,1881L,1890L,1911L,1925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256575Inst : IEnumerable<long>
{
public static readonly long[] Value=A256575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256575.Bytes);
public long this[int i]=>Value[i];

public static A256575Inst Instance=new A256575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256576
{
public static readonly long[] Value={ 1L,6L,2L,2L,7L,1L,9L,3L,9L,4L,7L,1L,4L,8L,3L,3L,9L,0L,7L,1L,5L,3L,5L,9L,5L,5L,1L,8L,0L,8L,0L,7L,1L,2L,0L,6L,4L,7L,3L,4L,9L,9L,7L,5L,1L,4L,0L,0L,3L,4L,6L,3L,1L,4L,2L,5L,8L,8L,6L,7L,2L,7L,2L,9L,3L,7L,8L,1L,1L,7L,2L,1L,2L,1L,0L,5L,0L,3L,9L,7L,1L,4L,2L,5L,2L,4L,0L,5L,3L,8L,0L,7L,9L,6L,7L,4L,9L,8L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256576Inst : IEnumerable<long>
{
public static readonly long[] Value=A256576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256576.Bytes);
public long this[int i]=>Value[i];

public static A256576Inst Instance=new A256576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256577
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,160L,161L,162L,163L,164L,165L,166L,167L,168L,169L,250L,251L,252L,253L,254L,255L,256L,257L,258L,259L,360L,361L,362L,363L,364L,365L,366L,367L,368L,369L,490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256577Inst : IEnumerable<long>
{
public static readonly long[] Value=A256577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256577.Bytes);
public long this[int i]=>Value[i];

public static A256577Inst Instance=new A256577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256578
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,3L,1L,6L,1L,5L,3L,8L,5L,7L,1L,7L,10L,1L,9L,1L,12L,1L,11L,23L,14L,9L,13L,5L,13L,19L,1L,18L,7L,17L,11L,16L,1L,15L,1L,20L,1L,21L,1L,22L,15L,23L,1L,24L,7L,25L,17L,26L,1L,27L,11L,28L,19L,29L,1L,30L,1L,31L,21L,32L,13L,33L,1L,34L,67L,40L,1L,39L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256578Inst : IEnumerable<long>
{
public static readonly long[] Value=A256578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256578.Bytes);
public long this[int i]=>Value[i];

public static A256578Inst Instance=new A256578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256579
{
public static readonly long[] Value={ 6L,12L,30L,60L,84L,168L,330L,546L,660L,1092L,1224L,1710L,2448L,3036L,3420L,6072L,6090L,7440L,12180L,12654L,14880L,17220L,19866L,25308L,25944L,34440L,37206L,39732L,51330L,51888L,56730L,74412L,75174L,89460L,97236L,102660L,113460L,123240L,142926L,150348L,176220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256579Inst : IEnumerable<long>
{
public static readonly long[] Value=A256579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256579.Bytes);
public long this[int i]=>Value[i];

public static A256579Inst Instance=new A256579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256580
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,2L,0L,3L,0L,2L,0L,2L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,2L,0L,0L,0L,4L,0L,4L,0L,0L,4L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,4L,4L,2L,0L,2L,0L,0L,2L,0L,4L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,2L,4L,2L,0L,0L,2L,0L,0L,0L,2L,0L,0L,4L,2L,2L,0L,4L,0L,0L,0L,0L,2L,4L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,2L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,2L,2L,0L,0L,4L,4L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,2L,0L,4L,0L,2L,2L,0L,0L,4L,4L,0L,4L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256580Inst : IEnumerable<long>
{
public static readonly long[] Value=A256580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256580.Bytes);
public long this[int i]=>Value[i];

public static A256580Inst Instance=new A256580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256581
{
public static readonly long[] Value={ 2L,3L,2L,7L,5L,7L,7L,11L,5L,7L,7L,31L,23L,11L,9L,15L,17L,31L,31L,47L,23L,15L,29L,47L,23L,15L,7L,15L,11L,31L,47L,95L,47L,15L,11L,127L,95L,47L,39L,63L,71L,63L,63L,95L,47L,31L,71L,95L,71L,47L,31L,31L,47L,63L,39L,47L,23L,15L,23L,255L,191L,127L,111L,95L,71L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256581Inst : IEnumerable<long>
{
public static readonly long[] Value=A256581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256581.Bytes);
public long this[int i]=>Value[i];

public static A256581Inst Instance=new A256581Inst();

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