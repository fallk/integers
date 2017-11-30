using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A111541
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,0L,14L,5L,3L,0L,84L,22L,8L,4L,0L,600L,128L,36L,12L,5L,0L,4908L,896L,212L,58L,17L,6L,0L,44952L,7220L,1496L,360L,90L,23L,7L,0L,454344L,65336L,12128L,2652L,602L,134L,30L,8L,0L,5016768L,653720L,110288L,22320L,4736L,974L,192L,38L,9L,0L,60062352L,7155104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111541Inst : IEnumerable<long>
{
public static readonly long[] Value=A111541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111541.Bytes);
public long this[int i]=>Value[i];

public static A111541Inst Instance=new A111541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111542
{
public static readonly long[] Value={ 0L,2L,5L,22L,128L,896L,7220L,65336L,653720L,7155104L,84998768L,1089232160L,14981704736L,220233312896L,3447195190592L,57261708795776L,1006401042534272L,18663532970127872L,364283224523605760L,7466218532765196800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111542Inst : IEnumerable<long>
{
public static readonly long[] Value=A111542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111542.Bytes);
public long this[int i]=>Value[i];

public static A111542Inst Instance=new A111542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111543
{
public static readonly ulong[] Value={ 0L,3L,8L,36L,212L,1496L,12128L,110288L,1108064L,12171872L,145061120L,1864321472L,25710635648L,378871778432L,5943632568320L,98936446059776L,1742232571097600L,32367994818881024L,632845309575139328L,12991224275641441280UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111543Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A111543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111543.Bytes);
public ulong this[int i]=>Value[i];

public static A111543Inst Instance=new A111543Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111544
{
public static readonly long[] Value={ 1L,1L,1L,5L,2L,1L,33L,9L,3L,1L,261L,57L,15L,4L,1L,2361L,441L,99L,23L,5L,1L,23805L,3933L,783L,165L,33L,6L,1L,263313L,39249L,7083L,1383L,261L,45L,7L,1L,3161781L,430677L,71415L,13083L,2361L,393L,59L,8L,1L,40907241L,5137641L,789939L,136863L,23805L,3861L,567L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111544Inst : IEnumerable<long>
{
public static readonly long[] Value=A111544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111544.Bytes);
public long this[int i]=>Value[i];

public static A111544Inst Instance=new A111544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111545
{
public static readonly ulong[] Value={ 1L,2L,9L,57L,441L,3933L,39249L,430677L,5137641L,66103533L,911973249L,13428837477L,210259505241L,3489291147933L,61200522593649L,1131630622515477L,22007781151434441L,449197758198576333L,9603342828706622049UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111545Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A111545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111545.Bytes);
public ulong this[int i]=>Value[i];

public static A111545Inst Instance=new A111545Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111546
{
public static readonly long[] Value={ 1L,3L,15L,99L,783L,7083L,71415L,789939L,9485343L,122721723L,1701224775L,25156450179L,395362560303L,6583219735563L,115817825451735L,2147443419579219L,41868118883289663L,856527397513863003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111546Inst : IEnumerable<long>
{
public static readonly long[] Value=A111546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111546.Bytes);
public long this[int i]=>Value[i];

public static A111546Inst Instance=new A111546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111547
{
public static readonly long[] Value={ 1L,4L,23L,165L,1383L,13083L,136863L,1562715L,19301319L,256191363L,3636036783L,54956529675L,881578601559L,14964805041363L,268105552191423L,5057384615702235L,100224731537223399L,2082402995330965923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111547Inst : IEnumerable<long>
{
public static readonly long[] Value=A111547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111547.Bytes);
public long this[int i]=>Value[i];

public static A111547Inst Instance=new A111547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111548
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,-2L,1L,-15L,-3L,-3L,1L,-99L,-15L,-3L,-4L,1L,-783L,-99L,-15L,-3L,-5L,1L,-7083L,-783L,-99L,-15L,-3L,-6L,1L,-71415L,-7083L,-783L,-99L,-15L,-3L,-7L,1L,-789939L,-71415L,-7083L,-783L,-99L,-15L,-3L,-8L,1L,-9485343L,-789939L,-71415L,-7083L,-783L,-99L,-15L,-3L,-9L,1L,-122721723L,-9485343L,-789939L,-71415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111548Inst : IEnumerable<long>
{
public static readonly long[] Value=A111548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111548.Bytes);
public long this[int i]=>Value[i];

public static A111548Inst Instance=new A111548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111549
{
public static readonly long[] Value={ 0L,1L,0L,4L,2L,0L,23L,6L,3L,0L,165L,32L,9L,4L,0L,1383L,222L,47L,13L,5L,0L,13083L,1824L,321L,70L,18L,6L,0L,136863L,17016L,2607L,486L,103L,24L,7L,0L,1562715L,176112L,24099L,3990L,747L,148L,31L,8L,0L,19301319L,1993392L,247527L,37182L,6351L,1140L,207L,39L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111549Inst : IEnumerable<long>
{
public static readonly long[] Value=A111549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111549.Bytes);
public long this[int i]=>Value[i];

public static A111549Inst Instance=new A111549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111550
{
public static readonly long[] Value={ 0L,2L,6L,32L,222L,1824L,17016L,176112L,1993392L,24438960L,322294896L,4548010032L,68385367152L,1091838106800L,18454096189296L,329306074785072L,6189015238217712L,122232512688657840L,2531600753529542256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111550Inst : IEnumerable<long>
{
public static readonly long[] Value=A111550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111550.Bytes);
public long this[int i]=>Value[i];

public static A111550Inst Instance=new A111550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111551
{
public static readonly long[] Value={ 0L,3L,9L,47L,321L,2607L,24099L,247527L,2783331L,33924303L,445016619L,6249234807L,93541817331L,1487200667103L,25037315924859L,445123900236807L,8336458657796931L,164100631571947503L,3388128151043405259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111551Inst : IEnumerable<long>
{
public static readonly long[] Value=A111551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111551.Bytes);
public long this[int i]=>Value[i];

public static A111551Inst Instance=new A111551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111552
{
public static readonly long[] Value={ 1L,2L,8L,46L,338L,2930L,28726L,311342L,3679778L,47000002L,644538614L,9443216366L,147222001954L,2434125748082L,42555399987686L,784634319490894L,15221022251713538L,309977607819594818L,6613678784212854646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111552Inst : IEnumerable<long>
{
public static readonly long[] Value=A111552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111552.Bytes);
public long this[int i]=>Value[i];

public static A111552Inst Instance=new A111552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111553
{
public static readonly long[] Value={ 1L,1L,1L,6L,2L,1L,46L,10L,3L,1L,416L,72L,16L,4L,1L,4256L,632L,116L,24L,5L,1L,48096L,6352L,1016L,184L,34L,6L,1L,591536L,70912L,10176L,1664L,282L,46L,7L,1L,7840576L,864192L,113216L,17024L,2696L,416L,60L,8L,1L,111226816L,11371072L,1375456L,192384L,28792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111553Inst : IEnumerable<long>
{
public static readonly long[] Value=A111553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111553.Bytes);
public long this[int i]=>Value[i];

public static A111553Inst Instance=new A111553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111554
{
public static readonly long[] Value={ 1L,2L,10L,72L,632L,6352L,70912L,864192L,11371072L,160333952L,2409420032L,38428442112L,648333665792L,11538313372672L,216092576714752L,4249731095212032L,87591291183296512L,1888669450881032192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111554Inst : IEnumerable<long>
{
public static readonly long[] Value=A111554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111554.Bytes);
public long this[int i]=>Value[i];

public static A111554Inst Instance=new A111554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111555
{
public static readonly long[] Value={ 1L,3L,16L,116L,1016L,10176L,113216L,1375456L,18047296L,253815936L,3805221376L,60558070016L,1019617312256L,18111737604096L,338602832961536L,6648048064792576L,136810876329865216L,2945671077411987456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111555Inst : IEnumerable<long>
{
public static readonly long[] Value=A111555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111555.Bytes);
public long this[int i]=>Value[i];

public static A111555Inst Instance=new A111555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111556
{
public static readonly long[] Value={ 1L,4L,24L,184L,1664L,17024L,192384L,2366144L,31362304L,444907264L,6720628224L,107674883584L,1823884857344L,32575705493504L,612054254936064L,12071987619713024L,249477777420304384L,5392386599983366144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111556Inst : IEnumerable<long>
{
public static readonly long[] Value=A111556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111556.Bytes);
public long this[int i]=>Value[i];

public static A111556Inst Instance=new A111556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111557
{
public static readonly ulong[] Value={ 1L,5L,34L,282L,2696L,28792L,337072L,4273632L,58195072L,846038912L,13072140032L,213897731712L,3695682017792L,67254929193472L,1286282280266752L,25802708552696832L,541894309127053312L,11894387852938452992UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111557Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A111557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111557.Bytes);
public ulong this[int i]=>Value[i];

public static A111557Inst Instance=new A111557Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111558
{
public static readonly long[] Value={ 1L,2L,9L,60L,509L,5034L,55689L,674624L,8838189L,124199454L,1861297049L,29618273604L,498716980989L,8860512190034L,165694162575369L,3254269731689064L,66994569450549869L,1443024570035017254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111558Inst : IEnumerable<long>
{
public static readonly long[] Value=A111558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111558.Bytes);
public long this[int i]=>Value[i];

public static A111558Inst Instance=new A111558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111559
{
public static readonly long[] Value={ 1L,-1L,1L,-4L,-2L,1L,-24L,-4L,-3L,1L,-184L,-24L,-4L,-4L,1L,-1664L,-184L,-24L,-4L,-5L,1L,-17024L,-1664L,-184L,-24L,-4L,-6L,1L,-192384L,-17024L,-1664L,-184L,-24L,-4L,-7L,1L,-2366144L,-192384L,-17024L,-1664L,-184L,-24L,-4L,-8L,1L,-31362304L,-2366144L,-192384L,-17024L,-1664L,-184L,-24L,-4L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111559Inst : IEnumerable<long>
{
public static readonly long[] Value=A111559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111559.Bytes);
public long this[int i]=>Value[i];

public static A111559Inst Instance=new A111559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111560
{
public static readonly long[] Value={ 0L,1L,0L,5L,2L,0L,34L,7L,3L,0L,282L,44L,10L,4L,0L,2696L,354L,60L,14L,5L,0L,28792L,3328L,470L,84L,19L,6L,0L,337072L,35144L,4344L,654L,118L,25L,7L,0L,4273632L,407984L,45320L,6008L,936L,164L,32L,8L,0L,58195072L,5137824L,521200L,62344L,8704L,1352L,224L,40L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111560Inst : IEnumerable<long>
{
public static readonly long[] Value=A111560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111560.Bytes);
public long this[int i]=>Value[i];

public static A111560Inst Instance=new A111560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111561
{
public static readonly ulong[] Value={ 0L,2L,7L,44L,354L,3328L,35144L,407984L,5137824L,69566144L,1006372864L,15481560064L,252326173824L,4344015683584L,78793242566144L,1502374856981504L,30052439647908864L,629485600310349824L,13783057303819485184UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111561Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A111561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111561.Bytes);
public ulong this[int i]=>Value[i];

public static A111561Inst Instance=new A111561Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111562
{
public static readonly ulong[] Value={ 0L,3L,10L,60L,470L,4344L,45320L,521200L,6513280L,87613440L,1260188800L,19286781440L,312884243840L,5363632995840L,96904980170240L,1840977689943040L,36700487712701440L,766296476640215040L,16728728381231472640UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111562Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A111562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111562.Bytes);
public ulong this[int i]=>Value[i];

public static A111562Inst Instance=new A111562Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111563
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,46L,172L,777L,3783L,20074L,111604L,646409L,3846640L,23410035L,144965988L,910898943L,5794179218L,37248630398L,241676806702L,1580880366039L,10416314047854L,69080674190341L,460841447382976L,3090747326749823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111563Inst : IEnumerable<long>
{
public static readonly long[] Value=A111563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111563.Bytes);
public long this[int i]=>Value[i];

public static A111563Inst Instance=new A111563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111564
{
public static readonly long[] Value={ 1L,2L,4L,10L,25L,80L,277L,1150L,5291L,26918L,145744L,828856L,4872771L,29395784L,180857382L,1130700488L,7163245811L,45895629266L,296937363511L,1937625709854L,12739784808937L,84331837321404L,561647630439975L,3761221057579892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111564Inst : IEnumerable<long>
{
public static readonly long[] Value=A111564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111564.Bytes);
public long this[int i]=>Value[i];

public static A111564Inst Instance=new A111564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111565
{
public static readonly long[] Value={ 2L,0L,2L,3L,0L,2L,0L,0L,2L,3L,2L,0L,0L,2L,5L,0L,3L,2L,0L,2L,0L,0L,0L,3L,0L,0L,2L,0L,2L,3L,0L,2L,7L,5L,0L,2L,3L,0L,2L,0L,0L,2L,0L,3L,2L,0L,0L,2L,0L,0L,3L,0L,5L,2L,0L,0L,2L,3L,0L,2L,0L,0L,0L,2L,3L,0L,2L,0L,0L,0L,2L,7L,3L,5L,0L,2L,0L,0L,3L,0L,0L,2L,0L,0L,2L,3L,0L,0L,2L,11L,0L,0L,2L,5L,3L,2L,0L,0L,2L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111565Inst : IEnumerable<long>
{
public static readonly long[] Value=A111565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111565.Bytes);
public long this[int i]=>Value[i];

public static A111565Inst Instance=new A111565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111566
{
public static readonly long[] Value={ 1L,6L,22L,76L,260L,888L,3032L,10352L,35344L,120672L,412000L,1406656L,4802624L,16397184L,55983488L,191139584L,652591360L,2228086272L,7607162368L,25972476928L,88675582976L,302757378048L,1033678346240L,3529198628864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111566Inst : IEnumerable<long>
{
public static readonly long[] Value=A111566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111566.Bytes);
public long this[int i]=>Value[i];

public static A111566Inst Instance=new A111566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111567
{
public static readonly long[] Value={ 1L,5L,18L,62L,212L,724L,2472L,8440L,28816L,98384L,335904L,1146848L,3915584L,13368640L,45643392L,155836288L,532058368L,1816560896L,6202126848L,21175385600L,72297288704L,246838383616L,842758957056L,2877359060992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111567Inst : IEnumerable<long>
{
public static readonly long[] Value=A111567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111567.Bytes);
public long this[int i]=>Value[i];

public static A111567Inst Instance=new A111567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111568
{
public static readonly long[] Value={ 1L,1L,3L,1L,9L,17L,1L,43L,85L,127L,1L,313L,625L,937L,1249L,1L,3111L,6221L,9331L,12441L,15551L,1L,39217L,78433L,117649L,156865L,196081L,235297L,1L,599187L,1198373L,1797559L,2396745L,2995931L,3595117L,4194303L,1L,10761681L,21523361L,32285041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111568Inst : IEnumerable<long>
{
public static readonly long[] Value=A111568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111568.Bytes);
public long this[int i]=>Value[i];

public static A111568Inst Instance=new A111568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111569
{
public static readonly long[] Value={ -1L,1L,2L,1L,1L,4L,7L,9L,14L,25L,41L,64L,103L,169L,274L,441L,713L,1156L,1871L,3025L,4894L,7921L,12817L,20736L,33551L,54289L,87842L,142129L,229969L,372100L,602071L,974169L,1576238L,2550409L,4126649L,6677056L,10803703L,17480761L,28284466L,45765225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111569Inst : IEnumerable<long>
{
public static readonly long[] Value=A111569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111569.Bytes);
public long this[int i]=>Value[i];

public static A111569Inst Instance=new A111569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111570
{
public static readonly long[] Value={ 2L,5L,4L,7L,14L,23L,34L,55L,92L,149L,238L,385L,626L,1013L,1636L,2647L,4286L,6935L,11218L,18151L,29372L,47525L,76894L,124417L,201314L,325733L,527044L,852775L,1379822L,2232599L,3612418L,5845015L,9457436L,15302453L,24759886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111570Inst : IEnumerable<long>
{
public static readonly long[] Value=A111570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111570.Bytes);
public long this[int i]=>Value[i];

public static A111570Inst Instance=new A111570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111571
{
public static readonly long[] Value={ 1L,1L,-2L,-1L,1L,0L,-3L,-3L,-2L,-5L,-11L,-16L,-23L,-39L,-66L,-105L,-167L,-272L,-443L,-715L,-1154L,-1869L,-3027L,-4896L,-7919L,-12815L,-20738L,-33553L,-54287L,-87840L,-142131L,-229971L,-372098L,-602069L,-974171L,-1576240L,-2550407L,-4126647L,-6677058L,-10803705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111571Inst : IEnumerable<long>
{
public static readonly long[] Value=A111571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111571.Bytes);
public long this[int i]=>Value[i];

public static A111571Inst Instance=new A111571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111572
{
public static readonly long[] Value={ -1L,3L,2L,1L,3L,8L,11L,15L,26L,45L,71L,112L,183L,299L,482L,777L,1259L,2040L,3299L,5335L,8634L,13973L,22607L,36576L,59183L,95763L,154946L,250705L,405651L,656360L,1062011L,1718367L,2780378L,4498749L,7279127L,11777872L,19056999L,30834875L,49891874L,80726745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111572Inst : IEnumerable<long>
{
public static readonly long[] Value=A111572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111572.Bytes);
public long this[int i]=>Value[i];

public static A111572Inst Instance=new A111572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111573
{
public static readonly long[] Value={ 0L,1L,3L,3L,4L,8L,14L,21L,33L,55L,90L,144L,232L,377L,611L,987L,1596L,2584L,4182L,6765L,10945L,17711L,28658L,46368L,75024L,121393L,196419L,317811L,514228L,832040L,1346270L,2178309L,3524577L,5702887L,9227466L,14930352L,24157816L,39088169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111573Inst : IEnumerable<long>
{
public static readonly long[] Value=A111573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111573.Bytes);
public long this[int i]=>Value[i];

public static A111573Inst Instance=new A111573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111574
{
public static readonly long[] Value={ 1L,-1L,2L,3L,3L,4L,9L,15L,22L,35L,59L,96L,153L,247L,402L,651L,1051L,1700L,2753L,4455L,7206L,11659L,18867L,30528L,49393L,79919L,129314L,209235L,338547L,547780L,886329L,1434111L,2320438L,3754547L,6074987L,9829536L,15904521L,25734055L,41638578L,67372635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111574Inst : IEnumerable<long>
{
public static readonly long[] Value=A111574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111574.Bytes);
public long this[int i]=>Value[i];

public static A111574Inst Instance=new A111574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111575
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,3L,9L,9L,9L,9L,27L,27L,27L,27L,81L,81L,81L,81L,243L,243L,243L,243L,729L,729L,729L,729L,2187L,2187L,2187L,2187L,6561L,6561L,6561L,6561L,19683L,19683L,19683L,19683L,59049L,59049L,59049L,59049L,177147L,177147L,177147L,177147L,531441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111575Inst : IEnumerable<long>
{
public static readonly long[] Value=A111575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111575.Bytes);
public long this[int i]=>Value[i];

public static A111575Inst Instance=new A111575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111576
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,22L,51L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111576Inst : IEnumerable<long>
{
public static readonly long[] Value=A111576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111576.Bytes);
public long this[int i]=>Value[i];

public static A111576Inst Instance=new A111576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111577
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,21L,12L,1L,1L,85L,105L,22L,1L,1L,341L,820L,325L,35L,1L,1L,1365L,6081L,4070L,780L,51L,1L,1L,5461L,43932L,46781L,14210L,1596L,70L,1L,1L,21845L,312985L,511742L,231511L,39746L,2926L,92L,1L,1L,87381L,2212740L,5430405L,3521385L,867447L,95340L,4950L,117L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111577Inst : IEnumerable<long>
{
public static readonly long[] Value=A111577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111577.Bytes);
public long this[int i]=>Value[i];

public static A111577Inst Instance=new A111577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111578
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,31L,15L,1L,1L,156L,166L,28L,1L,1L,781L,1650L,530L,45L,1L,1L,3906L,15631L,8540L,1295L,66L,1L,1L,19531L,144585L,126651L,30555L,2681L,91L,1L,1L,97656L,1320796L,1791048L,646086L,86856L,4956L,120L,1L,1L,488281L,11984820L,24604420L,12774510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111578Inst : IEnumerable<long>
{
public static readonly long[] Value=A111578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111578.Bytes);
public long this[int i]=>Value[i];

public static A111578Inst Instance=new A111578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111579
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,8L,5L,2L,1L,1L,16L,15L,6L,2L,1L,1L,32L,52L,24L,7L,2L,1L,1L,64L,203L,116L,35L,8L,2L,1L,1L,128L,877L,648L,214L,48L,9L,2L,1L,1L,256L,4140L,4088L,1523L,352L,63L,10L,2L,1L,1L,512L,21147L,28640L,12349L,3008L,536L,80L,11L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111579Inst : IEnumerable<long>
{
public static readonly long[] Value=A111579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111579.Bytes);
public long this[int i]=>Value[i];

public static A111579Inst Instance=new A111579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111580
{
public static readonly long[] Value={ 1L,-2L,-2L,4L,1L,4L,-6L,-8L,7L,-2L,12L,-8L,-12L,12L,-2L,16L,-16L,-14L,20L,4L,12L,-24L,-22L,16L,1L,24L,-20L,-24L,30L,4L,32L,-32L,-24L,32L,-6L,28L,-36L,-40L,24L,-8L,42L,-24L,-42L,48L,7L,44L,-46L,-32L,43L,-2L,32L,-48L,-52L,40L,12L,48L,-40L,-60L,60L,-8L,62L,-64L,-42L,64L,-12L,48L,-66L,-64L,44L,12L,72L,-56L,-72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111580Inst : IEnumerable<long>
{
public static readonly long[] Value=A111580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111580.Bytes);
public long this[int i]=>Value[i];

public static A111580Inst Instance=new A111580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111581
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,5L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,14L,14L,15L,16L,16L,17L,17L,18L,19L,19L,21L,20L,21L,22L,22L,24L,24L,25L,26L,27L,29L,29L,31L,32L,32L,34L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,44L,45L,46L,47L,48L,49L,49L,50L,50L,51L,51L,52L,53L,53L,55L,55L,56L,57L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111581Inst : IEnumerable<long>
{
public static readonly long[] Value=A111581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111581.Bytes);
public long this[int i]=>Value[i];

public static A111581Inst Instance=new A111581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111582
{
public static readonly long[] Value={ 1L,3L,6L,11L,16L,22L,28L,33L,41L,51L,61L,76L,93L,107L,125L,144L,159L,178L,200L,215L,233L,256L,271L,288L,314L,332L,349L,377L,391L,407L,435L,450L,466L,497L,517L,538L,574L,595L,619L,653L,679L,705L,750L,784L,816L,859L,888L,919L,961L,1002L,1039L,1102L,1145L,1186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111582Inst : IEnumerable<long>
{
public static readonly long[] Value=A111582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111582.Bytes);
public long this[int i]=>Value[i];

public static A111582Inst Instance=new A111582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111583
{
public static readonly long[] Value={ 1L,4L,14L,38L,93L,202L,400L,736L,1260L,2046L,3158L,4676L,6672L,9231L,12441L,16353L,21130L,26779L,33463L,41379L,50568L,61238L,73726L,88348L,104915L,124266L,146833L,172020L,200771L,233777L,270598L,310894L,356778L,407734L,462317L,523410L,591008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111583Inst : IEnumerable<long>
{
public static readonly long[] Value=A111583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111583.Bytes);
public long this[int i]=>Value[i];

public static A111583Inst Instance=new A111583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111584
{
public static readonly long[] Value={ 1L,5L,23L,76L,242L,622L,1527L,3218L,6464L,11752L,20368L,33492L,52492L,80282L,118073L,170602L,242147L,336135L,463260L,627797L,841613L,1125132L,1481186L,1941049L,2526815L,3263039L,4198666L,5341194L,6774802L,8564045L,10712300L,13360856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111584Inst : IEnumerable<long>
{
public static readonly long[] Value=A111584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111584.Bytes);
public long this[int i]=>Value[i];

public static A111584Inst Instance=new A111584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111585
{
public static readonly long[] Value={ 1L,8L,58L,331L,1786L,8339L,36732L,145822L,547140L,1892180L,6204220L,19012264L,55425015L,152433682L,400145401L,997800881L,2382495077L,5433427757L,11903695647L,25025392965L,50712232586L,99047934945L,187153799666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111585Inst : IEnumerable<long>
{
public static readonly long[] Value=A111585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111585.Bytes);
public long this[int i]=>Value[i];

public static A111585Inst Instance=new A111585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111586
{
public static readonly long[] Value={ 0L,1L,2L,5L,12L,28L,62L,136L,299L,661L,1456L,3213L,7085L,15628L,34467L,76021L,167668L,369805L,815629L,1798928L,3967659L,8750949L,19300824L,42569309L,93889565L,207079956L,456729219L,1007348005L,2221775964L,4900281149L,10807910301L,23837596568L,52575474283L,115958858869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111586Inst : IEnumerable<long>
{
public static readonly long[] Value=A111586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111586.Bytes);
public long this[int i]=>Value[i];

public static A111586Inst Instance=new A111586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111587
{
public static readonly long[] Value={ 1L,4L,9L,20L,49L,120L,289L,696L,1681L,4060L,9801L,23660L,57121L,137904L,332929L,803760L,1940449L,4684660L,11309769L,27304196L,65918161L,159140520L,384199201L,927538920L,2239277041L,5406093004L,13051463049L,31509019100L,76069501249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111587Inst : IEnumerable<long>
{
public static readonly long[] Value=A111587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111587.Bytes);
public long this[int i]=>Value[i];

public static A111587Inst Instance=new A111587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111588
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,2L,2L,1L,8L,1L,2L,2L,10L,1L,8L,1L,8L,2L,2L,1L,33L,2L,2L,4L,8L,1L,13L,1L,26L,2L,2L,2L,57L,1L,2L,2L,33L,1L,13L,1L,8L,8L,2L,1L,140L,2L,8L,2L,8L,1L,33L,2L,33L,2L,2L,1L,125L,1L,2L,8L,71L,2L,13L,1L,8L,2L,13L,1L,348L,1L,2L,8L,8L,2L,13L,1L,140L,10L,2L,1L,122L,2L,2L,2L,33L,1L,118L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111588Inst : IEnumerable<long>
{
public static readonly long[] Value=A111588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111588.Bytes);
public long this[int i]=>Value[i];

public static A111588Inst Instance=new A111588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111589
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,9L,8L,1L,4L,18L,32L,21L,1L,5L,30L,80L,105L,55L,1L,6L,45L,160L,315L,330L,144L,1L,7L,63L,280L,735L,1155L,1008L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111589Inst : IEnumerable<long>
{
public static readonly long[] Value=A111589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111589.Bytes);
public long this[int i]=>Value[i];

public static A111589Inst Instance=new A111589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111590
{
public static readonly long[] Value={ 9L,9L,9L,6L,9L,5L,4L,1L,3L,5L,0L,9L,5L,4L,7L,8L,6L,5L,0L,0L,3L,1L,2L,1L,7L,2L,0L,0L,2L,1L,9L,6L,4L,9L,8L,2L,2L,4L,7L,6L,1L,8L,1L,5L,3L,3L,3L,4L,9L,9L,8L,3L,8L,6L,5L,5L,1L,9L,5L,0L,2L,0L,4L,0L,0L,5L,4L,7L,4L,3L,0L,9L,4L,5L,9L,1L,6L,6L,3L,2L,6L,2L,7L,4L,7L,5L,2L,2L,6L,7L,2L,3L,2L,1L,1L,1L,8L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111590Inst : IEnumerable<long>
{
public static readonly long[] Value=A111590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111590.Bytes);
public long this[int i]=>Value[i];

public static A111590Inst Instance=new A111590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111591
{
public static readonly long[] Value={ 9L,9L,9L,5L,4L,3L,1L,5L,5L,0L,5L,5L,9L,3L,6L,8L,9L,7L,8L,1L,3L,8L,8L,1L,6L,8L,3L,7L,2L,0L,2L,9L,5L,2L,8L,3L,9L,1L,7L,2L,9L,3L,3L,0L,5L,6L,2L,9L,3L,3L,5L,8L,3L,7L,8L,5L,4L,1L,0L,0L,8L,4L,9L,5L,9L,1L,5L,6L,6L,6L,2L,9L,2L,6L,0L,8L,7L,2L,4L,9L,1L,2L,0L,6L,8L,0L,7L,5L,5L,3L,5L,2L,4L,4L,0L,1L,6L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111591Inst : IEnumerable<long>
{
public static readonly long[] Value=A111591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111591.Bytes);
public long this[int i]=>Value[i];

public static A111591Inst Instance=new A111591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111592
{
public static readonly long[] Value={ 12L,20L,24L,30L,40L,42L,54L,56L,66L,70L,78L,84L,88L,102L,104L,114L,120L,138L,140L,174L,186L,222L,224L,234L,246L,258L,270L,282L,308L,318L,354L,364L,366L,368L,402L,426L,438L,464L,474L,476L,498L,532L,534L,582L,606L,618L,642L,644L,650L,654L,672L,678L,762L,786L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111592Inst : IEnumerable<long>
{
public static readonly long[] Value=A111592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111592.Bytes);
public long this[int i]=>Value[i];

public static A111592Inst Instance=new A111592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111593
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,-2L,0L,1L,0L,0L,-8L,0L,1L,0L,16L,0L,-20L,0L,1L,0L,0L,136L,0L,-40L,0L,1L,0L,-272L,0L,616L,0L,-70L,0L,1L,0L,0L,-3968L,0L,2016L,0L,-112L,0L,1L,0L,7936L,0L,-28160L,0L,5376L,0L,-168L,0L,1L,0L,0L,176896L,0L,-135680L,0L,12432L,0L,-240L,0L,1L,0L,-353792L,0L,1805056L,0L,-508640L,0L,25872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111593Inst : IEnumerable<long>
{
public static readonly long[] Value=A111593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111593.Bytes);
public long this[int i]=>Value[i];

public static A111593Inst Instance=new A111593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111594
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,8L,0L,1L,0L,24L,0L,20L,0L,1L,0L,0L,184L,0L,40L,0L,1L,0L,720L,0L,784L,0L,70L,0L,1L,0L,0L,8448L,0L,2464L,0L,112L,0L,1L,0L,40320L,0L,52352L,0L,6384L,0L,168L,0L,1L,0L,0L,648576L,0L,229760L,0L,14448L,0L,240L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111594Inst : IEnumerable<long>
{
public static readonly long[] Value=A111594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111594.Bytes);
public long this[int i]=>Value[i];

public static A111594Inst Instance=new A111594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111595
{
public static readonly long[] Value={ 1L,0L,1L,1L,-2L,1L,0L,9L,-6L,1L,9L,-36L,42L,-12L,1L,0L,225L,-300L,130L,-20L,1L,225L,-1350L,2475L,-1380L,315L,-30L,1L,0L,11025L,-22050L,15435L,-4620L,651L,-42L,1L,11025L,-88200L,220500L,-182280L,67830L,-12600L,1204L,-56L,1L,0L,893025L,-2381400L,2302020L,-1020600L,235494L,-29736L,2052L,-72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111595Inst : IEnumerable<long>
{
public static readonly long[] Value=A111595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111595.Bytes);
public long this[int i]=>Value[i];

public static A111595Inst Instance=new A111595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111596
{
public static readonly long[] Value={ 1L,0L,1L,0L,-2L,1L,0L,6L,-6L,1L,0L,-24L,36L,-12L,1L,0L,120L,-240L,120L,-20L,1L,0L,-720L,1800L,-1200L,300L,-30L,1L,0L,5040L,-15120L,12600L,-4200L,630L,-42L,1L,0L,-40320L,141120L,-141120L,58800L,-11760L,1176L,-56L,1L,0L,362880L,-1451520L,1693440L,-846720L,211680L,-28224L,2016L,-72L,1L,0L,-3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111596Inst : IEnumerable<long>
{
public static readonly long[] Value=A111596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111596.Bytes);
public long this[int i]=>Value[i];

public static A111596Inst Instance=new A111596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111597
{
public static readonly BigInteger[] Value={ 1L,56L,2016L,60480L,1663200L,43908480L,1141620480L,29682132480L,779155977600L,20777492736000L,565147802419200L,15721384321843200L,448059453172531200L,13097122477350912000UL,BigInteger.Parse("392913674320527360000"),BigInteger.Parse("12101741169072242688000") };
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
public class A111597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111597Inst Instance=new A111597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111598
{
public static readonly BigInteger[] Value={ 1L,72L,3240L,118800L,3920400L,122316480L,3710266560L,111307996800L,3339239904000L,100919250432000L,3088129063219200L,96012739965542400L,3040403432242176000L,BigInteger.Parse("98228418580131840000"),BigInteger.Parse("3241537813144350720000") };
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
public class A111598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111598.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111598Inst Instance=new A111598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111599
{
public static readonly BigInteger[] Value={ 1L,90L,4950L,217800L,8494200L,309188880L,10821610800L,371026656000L,12614906304000L,428906814336000L,14668613050291200L,506733905373696000L,17735686688079360000UL,BigInteger.Parse("630299019222512640000"),BigInteger.Parse("22780807409042242560000") };
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
public class A111599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111599Inst Instance=new A111599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111600
{
public static readonly BigInteger[] Value={ 1L,110L,7260L,377520L,17177160L,721440720L,28857628800L,1121325004800L,42890681433600L,1629845894476800L,61934143990118400L,2364758225077248000L,BigInteger.Parse("91043191665474048000"),BigInteger.Parse("3543681152517682176000"),BigInteger.Parse("139722285442125754368000") };
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
public class A111600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111600Inst Instance=new A111600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111601
{
public static readonly long[] Value={ 1L,2L,9L,36L,225L,1350L,11025L,88200L,893025L,8930250L,108056025L,1296672300L,18261468225L,255660555150L,4108830350625L,65741285610000L,1187451971330625L,21374135483951250L,428670161650355625L,8573403233007112500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111601Inst : IEnumerable<long>
{
public static readonly long[] Value=A111601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111601.Bytes);
public long this[int i]=>Value[i];

public static A111601Inst Instance=new A111601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111602
{
public static readonly long[] Value={ 1L,6L,42L,300L,2475L,22050L,220500L,2381400L,28279125L,360186750L,4970577150L,73045872900L,1150472498175L,19174541636250L,339663308985000L,6333077180430000L,124682456989715625L,2572020969902133750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111602Inst : IEnumerable<long>
{
public static readonly long[] Value=A111602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111602.Bytes);
public long this[int i]=>Value[i];

public static A111602Inst Instance=new A111602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111603
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,2L,3L,4L,1L,1L,2L,1L,2L,5L,1L,1L,2L,3L,4L,5L,6L,1L,1L,1L,3L,3L,5L,3L,7L,1L,1L,2L,3L,4L,5L,2L,7L,8L,1L,1L,2L,3L,4L,1L,3L,7L,4L,9L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,1L,1L,3L,1L,5L,6L,7L,2L,3L,5L,11L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,1L,1L,3L,4L,5L,3L,1L,4L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111603Inst : IEnumerable<long>
{
public static readonly long[] Value=A111603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111603.Bytes);
public long this[int i]=>Value[i];

public static A111603Inst Instance=new A111603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111604
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,4L,3L,2L,1L,1L,2L,1L,2L,5L,1L,1L,6L,5L,4L,3L,2L,1L,1L,1L,3L,3L,5L,3L,7L,1L,1L,8L,7L,2L,5L,4L,3L,2L,1L,1L,2L,3L,4L,1L,3L,7L,4L,9L,1L,1L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,1L,1L,3L,1L,5L,6L,7L,2L,3L,5L,11L,1L,1L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,1L,1L,3L,4L,5L,3L,1L,4L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111604Inst : IEnumerable<long>
{
public static readonly long[] Value=A111604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111604.Bytes);
public long this[int i]=>Value[i];

public static A111604Inst Instance=new A111604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111605
{
public static readonly long[] Value={ 1L,1L,2L,2L,8L,-40L,144L,2448L,-17280L,-71424L,0L,1198080L,0L,-18063360L,418037760L,-7498137600L,-115688079360L,-587977850880L,12300343050240L,-540240522117120L,-36548032147292160L,487948583538524160L,-2339225182084792320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111605Inst : IEnumerable<long>
{
public static readonly long[] Value=A111605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111605.Bytes);
public long this[int i]=>Value[i];

public static A111605Inst Instance=new A111605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111606
{
public static readonly long[] Value={ 2L,3L,0L,10L,-48L,168L,3456L,-29376L,-178560L,0L,2995200L,0L,-45158400L,1045094400L,-14636482560L,-122918584320L,-370845941760L,12983695441920L,-1545691830681600L,-62521904633610240L,785989658251100160L,-2445553599452282880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111606Inst : IEnumerable<long>
{
public static readonly long[] Value=A111606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111606.Bytes);
public long this[int i]=>Value[i];

public static A111606Inst Instance=new A111606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111607
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,3L,7L,2L,9L,10L,11L,9L,13L,7L,15L,4L,17L,18L,19L,15L,21L,11L,23L,6L,25L,26L,27L,21L,29L,15L,31L,8L,33L,34L,35L,27L,37L,19L,39L,10L,41L,42L,43L,33L,45L,23L,47L,12L,49L,50L,51L,39L,53L,27L,55L,14L,57L,58L,59L,45L,61L,31L,63L,16L,65L,66L,67L,51L,69L,35L,71L,18L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111607Inst : IEnumerable<long>
{
public static readonly long[] Value=A111607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111607.Bytes);
public long this[int i]=>Value[i];

public static A111607Inst Instance=new A111607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111608
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,6L,7L,4L,3L,5L,11L,4L,13L,14L,10L,8L,17L,3L,19L,20L,21L,22L,23L,12L,25L,13L,9L,28L,29L,10L,31L,16L,22L,17L,35L,24L,37L,38L,39L,20L,41L,21L,43L,44L,15L,46L,47L,40L,49L,25L,34L,52L,53L,36L,55L,28L,57L,29L,59L,60L,61L,62L,21L,32L,65L,55L,67L,68L,46L,70L,71L,12L,73L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111608Inst : IEnumerable<long>
{
public static readonly long[] Value=A111608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111608.Bytes);
public long this[int i]=>Value[i];

public static A111608Inst Instance=new A111608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111609
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,3L,7L,7L,9L,10L,11L,12L,13L,7L,15L,10L,17L,18L,19L,15L,21L,11L,23L,9L,25L,26L,27L,14L,29L,15L,31L,4L,33L,34L,35L,9L,37L,19L,39L,35L,41L,42L,43L,44L,45L,23L,47L,30L,49L,50L,51L,39L,53L,27L,55L,21L,57L,58L,59L,30L,61L,31L,63L,8L,65L,66L,67L,17L,69L,35L,71L,63L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111609Inst : IEnumerable<long>
{
public static readonly long[] Value=A111609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111609.Bytes);
public long this[int i]=>Value[i];

public static A111609Inst Instance=new A111609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111610
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,7L,8L,1L,10L,11L,8L,13L,14L,10L,16L,17L,2L,19L,20L,14L,22L,23L,24L,25L,26L,3L,28L,29L,10L,31L,32L,33L,34L,35L,4L,37L,38L,13L,40L,41L,14L,43L,44L,5L,46L,47L,48L,49L,50L,17L,52L,53L,6L,55L,56L,57L,58L,59L,40L,61L,62L,7L,64L,65L,44L,67L,68L,46L,70L,71L,8L,73L,74L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111610Inst : IEnumerable<long>
{
public static readonly long[] Value=A111610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111610.Bytes);
public long this[int i]=>Value[i];

public static A111610Inst Instance=new A111610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111611
{
public static readonly long[] Value={ 1L,1L,3L,4L,4L,6L,7L,8L,9L,3L,11L,6L,13L,14L,15L,8L,17L,9L,19L,20L,21L,22L,23L,24L,5L,13L,27L,14L,29L,6L,31L,16L,33L,17L,14L,36L,37L,38L,39L,16L,41L,21L,43L,22L,27L,46L,47L,24L,49L,5L,51L,52L,53L,54L,44L,56L,57L,29L,59L,18L,61L,62L,63L,32L,65L,33L,67L,68L,69L,70L,71L,72L,73L,37L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111611Inst : IEnumerable<long>
{
public static readonly long[] Value=A111611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111611.Bytes);
public long this[int i]=>Value[i];

public static A111611Inst Instance=new A111611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111612
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,6L,7L,4L,6L,5L,11L,6L,13L,14L,5L,12L,17L,18L,19L,5L,21L,22L,23L,8L,25L,13L,9L,28L,29L,10L,31L,8L,33L,17L,35L,21L,37L,38L,26L,20L,41L,21L,43L,22L,45L,46L,47L,44L,49L,25L,34L,13L,53L,9L,55L,56L,19L,29L,59L,20L,61L,62L,42L,16L,65L,22L,67L,51L,23L,70L,71L,72L,73L,37L,75L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111612Inst : IEnumerable<long>
{
public static readonly long[] Value=A111612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111612.Bytes);
public long this[int i]=>Value[i];

public static A111612Inst Instance=new A111612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111613
{
public static readonly long[] Value={ 9L,9L,9L,3L,9L,0L,9L,1L,9L,7L,9L,2L,0L,2L,5L,8L,9L,5L,9L,5L,4L,7L,6L,7L,0L,5L,5L,1L,0L,2L,4L,9L,6L,8L,6L,0L,5L,4L,3L,7L,9L,0L,3L,6L,0L,8L,8L,3L,0L,2L,6L,0L,7L,8L,5L,8L,0L,1L,9L,9L,6L,5L,5L,1L,1L,7L,7L,5L,1L,7L,0L,7L,1L,3L,5L,5L,5L,1L,5L,5L,6L,6L,6L,0L,4L,1L,3L,4L,1L,8L,6L,9L,1L,5L,4L,6L,3L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111613Inst : IEnumerable<long>
{
public static readonly long[] Value=A111613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111613.Bytes);
public long this[int i]=>Value[i];

public static A111613Inst Instance=new A111613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111614
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,6L,1L,7L,1L,3L,1L,6L,1L,3L,12L,3L,1L,6L,1L,11L,18L,3L,1L,24L,1L,3L,1L,8L,1L,21L,1L,11L,20L,20L,23L,16L,1L,22L,34L,21L,1L,14L,1L,22L,24L,26L,1L,2L,1L,43L,6L,26L,1L,33L,17L,46L,43L,32L,1L,25L,1L,34L,47L,35L,63L,25L,1L,8L,49L,31L,1L,48L,1L,40L,32L,73L,21L,58L,1L,80L,28L,44L,1L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111614Inst : IEnumerable<long>
{
public static readonly long[] Value=A111614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111614.Bytes);
public long this[int i]=>Value[i];

public static A111614Inst Instance=new A111614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111615
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,8L,9L,5L,11L,12L,13L,14L,15L,16L,17L,9L,19L,10L,21L,11L,23L,24L,25L,26L,27L,28L,29L,15L,31L,32L,33L,17L,35L,18L,37L,19L,39L,40L,41L,42L,43L,22L,45L,46L,47L,48L,49L,25L,51L,26L,53L,54L,55L,28L,57L,29L,59L,60L,61L,31L,63L,64L,65L,66L,67L,68L,69L,70L,71L,36L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111615Inst : IEnumerable<long>
{
public static readonly long[] Value=A111615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111615.Bytes);
public long this[int i]=>Value[i];

public static A111615Inst Instance=new A111615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111616
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111616Inst : IEnumerable<long>
{
public static readonly long[] Value=A111616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111616.Bytes);
public long this[int i]=>Value[i];

public static A111616Inst Instance=new A111616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111617
{
public static readonly long[] Value={ 6L,10L,18L,20L,22L,30L,34L,36L,38L,44L,50L,52L,56L,58L,62L,72L,78L,84L,86L,90L,92L,96L,98L,100L,102L,104L,110L,116L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111617Inst : IEnumerable<long>
{
public static readonly long[] Value=A111617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111617.Bytes);
public long this[int i]=>Value[i];

public static A111617Inst Instance=new A111617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111618
{
public static readonly long[] Value={ 1L,3L,2L,5L,3L,7L,4L,9L,10L,11L,6L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,23L,12L,25L,26L,27L,14L,29L,30L,31L,16L,33L,17L,35L,18L,37L,38L,39L,20L,41L,42L,43L,22L,45L,46L,47L,48L,49L,50L,51L,52L,53L,27L,55L,56L,57L,29L,59L,30L,61L,31L,63L,32L,65L,66L,67L,34L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111618Inst : IEnumerable<long>
{
public static readonly long[] Value=A111618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111618.Bytes);
public long this[int i]=>Value[i];

public static A111618Inst Instance=new A111618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111619
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,6L,14L,8L,9L,10L,11L,12L,26L,14L,30L,16L,17L,18L,38L,20L,42L,22L,46L,48L,50L,52L,27L,56L,29L,30L,31L,32L,66L,34L,70L,72L,74L,76L,78L,40L,82L,84L,86L,88L,90L,92L,94L,48L,49L,100L,51L,104L,106L,108L,110L,112L,114L,58L,118L,120L,122L,124L,126L,64L,65L,66L,134L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111619Inst : IEnumerable<long>
{
public static readonly long[] Value=A111619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111619.Bytes);
public long this[int i]=>Value[i];

public static A111619Inst Instance=new A111619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111620
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111620Inst : IEnumerable<long>
{
public static readonly long[] Value=A111620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111620.Bytes);
public long this[int i]=>Value[i];

public static A111620Inst Instance=new A111620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111621
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111621Inst : IEnumerable<long>
{
public static readonly long[] Value=A111621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111621.Bytes);
public long this[int i]=>Value[i];

public static A111621Inst Instance=new A111621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111622
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,15L,17L,19L,21L,23L,27L,31L,33L,35L,39L,43L,53L,57L,59L,61L,63L,67L,79L,95L,97L,101L,115L,127L,129L,131L,135L,137L,139L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111622Inst : IEnumerable<long>
{
public static readonly long[] Value=A111622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111622.Bytes);
public long this[int i]=>Value[i];

public static A111622Inst Instance=new A111622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111623
{
public static readonly long[] Value={ 9L,9L,9L,2L,3L,8L,7L,0L,7L,7L,1L,4L,2L,8L,2L,9L,5L,5L,7L,9L,9L,2L,2L,4L,1L,4L,2L,6L,7L,5L,6L,3L,8L,7L,1L,6L,6L,2L,9L,1L,0L,7L,9L,5L,2L,0L,1L,9L,7L,8L,9L,8L,7L,7L,0L,8L,2L,2L,4L,0L,9L,8L,1L,0L,4L,0L,8L,5L,9L,5L,8L,9L,3L,4L,6L,1L,8L,8L,4L,5L,9L,1L,7L,6L,4L,9L,0L,0L,3L,0L,0L,1L,9L,1L,9L,5L,7L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111623Inst : IEnumerable<long>
{
public static readonly long[] Value=A111623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111623.Bytes);
public long this[int i]=>Value[i];

public static A111623Inst Instance=new A111623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111624
{
public static readonly long[] Value={ 1L,4L,5L,2L,7L,8L,3L,10L,11L,8L,13L,14L,5L,16L,17L,12L,19L,20L,14L,22L,23L,24L,25L,26L,9L,28L,29L,10L,31L,32L,33L,34L,35L,24L,37L,38L,26L,40L,41L,14L,43L,44L,15L,46L,47L,16L,49L,50L,51L,52L,53L,36L,55L,56L,38L,58L,59L,60L,61L,62L,63L,64L,65L,22L,67L,68L,46L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111624Inst : IEnumerable<long>
{
public static readonly long[] Value=A111624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111624.Bytes);
public long this[int i]=>Value[i];

public static A111624Inst Instance=new A111624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111625
{
public static readonly long[] Value={ 3L,1L,1L,3L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111625Inst : IEnumerable<long>
{
public static readonly long[] Value=A111625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111625.Bytes);
public long this[int i]=>Value[i];

public static A111625Inst Instance=new A111625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111626
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111626Inst : IEnumerable<long>
{
public static readonly long[] Value=A111626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111626.Bytes);
public long this[int i]=>Value[i];

public static A111626Inst Instance=new A111626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111627
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111627Inst : IEnumerable<long>
{
public static readonly long[] Value=A111627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111627.Bytes);
public long this[int i]=>Value[i];

public static A111627Inst Instance=new A111627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111628
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111628Inst : IEnumerable<long>
{
public static readonly long[] Value=A111628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111628.Bytes);
public long this[int i]=>Value[i];

public static A111628Inst Instance=new A111628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111629
{
public static readonly long[] Value={ 1L,3L,3L,1L,3L,3L,3L,3L,3L,1L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,3L,1L,3L,3L,1L,3L,3L,2L,3L,3L,1L,3L,3L,3L,3L,3L,2L,3L,3L,1L,3L,3L,2L,3L,3L,2L,3L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111629Inst : IEnumerable<long>
{
public static readonly long[] Value=A111629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111629.Bytes);
public long this[int i]=>Value[i];

public static A111629Inst Instance=new A111629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111630
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,3L,1L,1L,3L,2L,2L,1L,1L,1L,3L,2L,2L,3L,3L,1L,2L,3L,3L,2L,1L,3L,3L,1L,2L,1L,2L,2L,3L,2L,1L,2L,2L,2L,1L,1L,1L,1L,2L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111630Inst : IEnumerable<long>
{
public static readonly long[] Value=A111630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111630.Bytes);
public long this[int i]=>Value[i];

public static A111630Inst Instance=new A111630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111631
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,17L,13L,6L,9L,8L,14L,0L,22L,26L,15L,401L,21L,12L,16L,0L,18L,20L,77L,226L,28L,65L,44L,626L,52L,32L,50L,125L,91L,24L,221L,404L,212L,42L,81L,45L,63L,40L,75L,66L,36L,56L,64L,338L,88L,104L,130L,153L,154L,152L,190L,328L,175L,48L,184L,245L,286L,182L,100L,105L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111631Inst : IEnumerable<long>
{
public static readonly long[] Value=A111631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111631.Bytes);
public long this[int i]=>Value[i];

public static A111631Inst Instance=new A111631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111632
{
public static readonly long[] Value={ 1L,2L,3L,5L,17L,22L,26L,401L,626L,730L,1025L,1813L,4925L,7572L,19053L,28925L,51996L,115625L,175208L,374560L,435825L,687500L,978144L,1333976L,1346072L,2600466L,2867085L,4509012L,5146875L,8948550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111632Inst : IEnumerable<long>
{
public static readonly long[] Value=A111632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111632.Bytes);
public long this[int i]=>Value[i];

public static A111632Inst Instance=new A111632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111633
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,2L,3L,6L,10L,15L,21L,28L,36L,1L,3L,3L,2L,4L,10L,20L,35L,56L,84L,1L,4L,6L,4L,2L,5L,15L,35L,70L,126L,1L,5L,10L,10L,5L,2L,6L,21L,56L,126L,1L,6L,15L,20L,15L,6L,2L,7L,28L,84L,1L,7L,21L,35L,35L,21L,7L,2L,8L,36L,1L,8L,28L,56L,70L,56L,28L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111633Inst : IEnumerable<long>
{
public static readonly long[] Value=A111633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111633.Bytes);
public long this[int i]=>Value[i];

public static A111633Inst Instance=new A111633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111634
{
public static readonly long[] Value={ 1L,11L,13L,14L,15L,16L,17L,18L,19L,25L,205L,1139L,1149L,1159L,26L,206L,1189L,1199L,1259L,36L,27L,207L,1268L,1269L,1274L,1275L,1276L,28L,208L,1279L,1283L,1284L,1285L,1286L,37L,29L,209L,1291L,1293L,1294L,1295L,1296L,1297L,1298L,1299L,2259L,22059L,2368L,2278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111634Inst : IEnumerable<long>
{
public static readonly long[] Value=A111634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111634.Bytes);
public long this[int i]=>Value[i];

public static A111634Inst Instance=new A111634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111635
{
public static readonly BigInteger[] Value={ 2L,5L,17L,257L,65537L,BigInteger.Parse("3512911982806776822251393039617"),BigInteger.Parse("4457915690803004131256192897205630962697827851093882159977969339137"),BigInteger.Parse("1638935311392320153195136107636665419978585455388636669548298482694235538906271958706896595665141002450684974003603106305516970574177405212679151205373697500164072550932748470956551681") };
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
public class A111635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111635Inst Instance=new A111635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111636
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,12L,12L,1L,1L,32L,96L,32L,1L,1L,80L,640L,640L,80L,1L,1L,192L,3840L,10240L,3840L,192L,1L,1L,448L,21504L,143360L,143360L,21504L,448L,1L,1L,1024L,114688L,1835008L,4587520L,1835008L,114688L,1024L,1L,1L,2304L,589824L,22020096L,132120576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111636Inst : IEnumerable<long>
{
public static readonly long[] Value=A111636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111636.Bytes);
public long this[int i]=>Value[i];

public static A111636Inst Instance=new A111636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111637
{
public static readonly BigInteger[] Value={ 1L,4L,96L,10240L,4587520L,8455716864L,63496796504064L,1932044240141942784L,BigInteger.Parse("237409596228641929297920"),BigInteger.Parse("117555946699326540948428554240"),BigInteger.Parse("234206054295766751302924897412448256") };
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
public class A111637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111637Inst Instance=new A111637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111638
{
public static readonly long[] Value={ 3L,5L,7L,8L,9L,10L,13L,14L,15L,16L,18L,24L,25L,36L,38L,50L,53L,55L,60L,69L,81L,83L,99L,110L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111638Inst : IEnumerable<long>
{
public static readonly long[] Value=A111638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111638.Bytes);
public long this[int i]=>Value[i];

public static A111638Inst Instance=new A111638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111639
{
public static readonly long[] Value={ -3L,10L,-33L,114L,-403L,1450L,-5281L,19394L,-71619L,265450L,-986241L,3670002L,-13670803L,50957770L,-190026433L,708824834L,-2644492803L,9867263050L,-36820012641L,137401810674L,-512760729619L,1913577130090L,-7141393334881L,26651623320002L,-99464199710403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111639Inst : IEnumerable<long>
{
public static readonly long[] Value=A111639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111639.Bytes);
public long this[int i]=>Value[i];

public static A111639Inst Instance=new A111639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111640
{
public static readonly long[] Value={ 1L,-9L,45L,-195L,793L,-3117L,12013L,-45751L,172961L,-650849L,2441917L,-9144539L,34203161L,-127829669L,477505565L,-1783134255L,6657304833L,-24851573497L,92762239373L,-346229372851L,1292232479961L,-4822886991709L,17999765604237L,-67177262104679L,250711906290721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111640Inst : IEnumerable<long>
{
public static readonly long[] Value=A111640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111640.Bytes);
public long this[int i]=>Value[i];

public static A111640Inst Instance=new A111640Inst();

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