using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A121441
{
public static readonly long[] Value={ 1L,-4L,1L,3L,-6L,1L,-12L,9L,-9L,1L,-117L,-26L,26L,-13L,1L,-1656L,-216L,-69L,63L,-18L,1L,-28506L,-3396L,-294L,-212L,132L,-24L,1L,-578274L,-63116L,-5766L,-124L,-620L,248L,-31L,1L,-13504179L,-1365546L,-116116L,-8892L,1170L,-1612L,429L,-39L,1L,-356633784L,-33696726L,-2696316L,-186860L,-15000L,6228L,-3736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121441Inst : IEnumerable<long>
{
public static readonly long[] Value=A121441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121441.Bytes);
public long this[int i]=>Value[i];

public static A121441Inst Instance=new A121441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121442
{
public static readonly long[] Value={ 1L,1L,9L,17L,97L,241L,1097L,3169L,12801L,40225L,152265L,501489L,1831649L,6192785L,22176137L,76079553L,269472001L,932011841L,3281180297L,11399814865L,39998425697L,139315579185L,487901595593L,1701743382561L,5953542163713L,20781331011169L,72661467102025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121442Inst : IEnumerable<long>
{
public static readonly long[] Value=A121442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121442.Bytes);
public long this[int i]=>Value[i];

public static A121442Inst Instance=new A121442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121443
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,3L,8L,1L,9L,6L,12L,3L,14L,8L,18L,1L,18L,9L,20L,6L,24L,12L,24L,3L,31L,14L,27L,8L,30L,18L,32L,1L,36L,18L,48L,9L,38L,20L,42L,6L,42L,24L,44L,12L,54L,24L,48L,3L,57L,31L,54L,14L,54L,27L,72L,8L,60L,30L,60L,18L,62L,32L,72L,1L,84L,36L,68L,18L,72L,48L,72L,9L,74L,38L,93L,20L,96L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121443Inst : IEnumerable<long>
{
public static readonly long[] Value=A121443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121443.Bytes);
public long this[int i]=>Value[i];

public static A121443Inst Instance=new A121443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121444
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,2L,1L,1L,0L,1L,2L,1L,0L,2L,1L,1L,1L,1L,1L,1L,2L,1L,0L,0L,1L,2L,2L,1L,1L,0L,3L,0L,1L,1L,0L,2L,0L,1L,1L,2L,2L,1L,1L,0L,1L,1L,1L,2L,1L,1L,0L,1L,2L,1L,0L,3L,0L,0L,1L,1L,2L,1L,1L,1L,1L,3L,1L,0L,1L,0L,2L,0L,1L,1L,1L,2L,1L,0L,0L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121444Inst : IEnumerable<long>
{
public static readonly long[] Value=A121444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121444.Bytes);
public long this[int i]=>Value[i];

public static A121444Inst Instance=new A121444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121445
{
public static readonly long[] Value={ 3L,3L,9L,10L,18L,27L,42L,69L,81L,81L,198L,312L,351L,324L,243L,1001L,1540L,1701L,1566L,1215L,729L,5304L,8034L,8784L,8100L,6480L,4374L,2187L,29070L,43554L,47313L,43713L,35640L,25515L,15309L,6561L,163438L,242896L,262684L,243108L,200745L,148716L,96957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121445Inst : IEnumerable<long>
{
public static readonly long[] Value=A121445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121445.Bytes);
public long this[int i]=>Value[i];

public static A121445Inst Instance=new A121445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121446
{
public static readonly long[] Value={ 3L,3L,10L,42L,198L,1001L,5304L,29070L,163438L,937365L,5462730L,32256120L,192565800L,1160346492L,7048030544L,43108428198L,265276342782L,1641229898525L,10202773534590L,63698396932170L,399223286267190L,2510857763851185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121446Inst : IEnumerable<long>
{
public static readonly long[] Value=A121446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121446.Bytes);
public long this[int i]=>Value[i];

public static A121446Inst Instance=new A121446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121447
{
public static readonly long[] Value={ 3L,21L,127L,747L,4386L,25897L,154077L,923910L,5581485L,33949836L,207787668L,1278900412L,7911394686L,49165322241L,306809507561L,1921849861260L,12079999018605L,76170034283805L,481680300300255L,3054157623774495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121447Inst : IEnumerable<long>
{
public static readonly long[] Value=A121447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121447.Bytes);
public long this[int i]=>Value[i];

public static A121447Inst Instance=new A121447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121448
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,4L,0L,6L,0L,8L,2L,0L,24L,0L,16L,0L,20L,0L,80L,0L,32L,5L,0L,120L,0L,240L,0L,64L,0L,70L,0L,560L,0L,672L,0L,128L,14L,0L,560L,0L,2240L,0L,1792L,0L,256L,0L,252L,0L,3360L,0L,8064L,0L,4608L,0L,512L,42L,0L,2520L,0L,16800L,0L,26880L,0L,11520L,0L,1024L,0L,924L,0L,18480L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121448Inst : IEnumerable<long>
{
public static readonly long[] Value=A121448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121448.Bytes);
public long this[int i]=>Value[i];

public static A121448Inst Instance=new A121448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121449
{
public static readonly long[] Value={ 1L,1L,3L,8L,22L,61L,170L,475L,1329L,3721L,10422L,29196L,81797L,229178L,642125L,1799169L,5041123L,14124860L,39576902L,110891905L,310712054L,870595599L,2439354329L,6834918465L,19151015274L,53659951372L,150351841201L,421276495414L,1180390506681L,3307380699281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121449Inst : IEnumerable<long>
{
public static readonly long[] Value=A121449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121449.Bytes);
public long this[int i]=>Value[i];

public static A121449Inst Instance=new A121449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121450
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,2L,1L,0L,-1L,1L,-2L,0L,1L,2L,0L,-2L,-1L,2L,-1L,0L,-2L,0L,0L,0L,1L,3L,-2L,-1L,0L,2L,2L,0L,-1L,0L,-2L,0L,-1L,2L,0L,-2L,-2L,2L,0L,0L,0L,2L,0L,0L,1L,1L,-3L,-2L,-2L,2L,1L,0L,0L,0L,-2L,0L,2L,2L,0L,0L,-1L,4L,0L,0L,-2L,0L,0L,0L,-1L,2L,-2L,-3L,0L,0L,2L,0L,-2L,1L,-2L,0L,0L,4L,0L,-2L,0L,2L,-2L,0L,0L,0L,0L,0L,1L,2L,-1L,0L,-3L,2L,2L,0L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121450Inst : IEnumerable<long>
{
public static readonly long[] Value=A121450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121450.Bytes);
public long this[int i]=>Value[i];

public static A121450Inst Instance=new A121450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121451
{
public static readonly long[] Value={ 0L,2L,0L,4L,5L,8L,10L,16L,20L,32L,40L,64L,80L,128L,160L,256L,320L,512L,640L,1024L,1280L,2048L,2560L,4096L,5120L,8192L,10240L,16384L,20480L,32768L,40960L,65536L,81920L,131072L,163840L,262144L,327680L,524288L,655360L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121451Inst : IEnumerable<long>
{
public static readonly long[] Value=A121451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121451.Bytes);
public long this[int i]=>Value[i];

public static A121451Inst Instance=new A121451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121452
{
public static readonly long[] Value={ 1L,1L,1L,4L,13L,71L,391L,2836L,21729L,198829L,1939501L,21515836L,254169301L,3319328299L,45979476635L,691443303916L,10979537304961L,186915474027321L,3345563762493049L,63613875064443796L,1266776073045809341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121452Inst : IEnumerable<long>
{
public static readonly long[] Value=A121452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121452.Bytes);
public long this[int i]=>Value[i];

public static A121452Inst Instance=new A121452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121453
{
public static readonly long[] Value={ 9L,24L,33L,48L,69L,84L,93L,108L,129L,144L,153L,168L,189L,204L,213L,228L,249L,264L,273L,288L,309L,324L,333L,348L,369L,384L,393L,408L,429L,444L,453L,468L,489L,504L,513L,528L,549L,564L,573L,588L,609L,624L,633L,648L,669L,684L,693L,708L,729L,744L,753L,768L,789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121453Inst : IEnumerable<long>
{
public static readonly long[] Value=A121453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121453.Bytes);
public long this[int i]=>Value[i];

public static A121453Inst Instance=new A121453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121454
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,0L,1L,-1L,1L,0L,2L,0L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,-2L,2L,0L,1L,0L,0L,-1L,2L,0L,0L,-1L,0L,0L,0L,-1L,2L,0L,0L,0L,0L,0L,2L,-2L,0L,-2L,0L,0L,1L,-1L,0L,0L,2L,0L,0L,-1L,0L,-2L,0L,0L,0L,0L,1L,-1L,0L,0L,2L,0L,0L,0L,2L,-1L,0L,-2L,0L,0L,2L,0L,2L,0L,1L,0L,0L,0L,0L,-2L,0L,-2L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,-1L,2L,-1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121454Inst : IEnumerable<long>
{
public static readonly long[] Value=A121454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121454.Bytes);
public long this[int i]=>Value[i];

public static A121454Inst Instance=new A121454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121455
{
public static readonly long[] Value={ 1L,-4L,4L,0L,6L,-16L,8L,0L,13L,-24L,12L,0L,14L,-32L,24L,0L,18L,-52L,20L,0L,32L,-48L,24L,0L,31L,-56L,40L,0L,30L,-96L,32L,0L,48L,-72L,48L,0L,38L,-80L,56L,0L,42L,-128L,44L,0L,78L,-96L,48L,0L,57L,-124L,72L,0L,54L,-160L,72L,0L,80L,-120L,60L,0L,62L,-128L,104L,0L,84L,-192L,68L,0L,96L,-192L,72L,0L,74L,-152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121455Inst : IEnumerable<long>
{
public static readonly long[] Value=A121455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121455.Bytes);
public long this[int i]=>Value[i];

public static A121455Inst Instance=new A121455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121456
{
public static readonly long[] Value={ 1L,-2L,1L,-4L,6L,-2L,8L,-8L,1L,-12L,12L,-4L,14L,-16L,6L,-16L,18L,-2L,20L,-24L,8L,-24L,24L,-8L,31L,-28L,1L,-32L,30L,-12L,32L,-32L,12L,-36L,48L,-4L,38L,-40L,14L,-48L,42L,-16L,44L,-48L,6L,-48L,48L,-16L,57L,-62L,18L,-56L,54L,-2L,72L,-64L,20L,-60L,60L,-24L,62L,-64L,8L,-64L,84L,-24L,68L,-72L,24L,-96L,72L,-8L,74L,-76L,31L,-80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121456Inst : IEnumerable<long>
{
public static readonly long[] Value=A121456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121456.Bytes);
public long this[int i]=>Value[i];

public static A121456Inst Instance=new A121456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121457
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,6L,6L,8L,6L,12L,24L,24L,30L,20L,40L,30L,60L,120L,120L,144L,90L,80L,180L,120L,90L,240L,180L,360L,720L,720L,840L,504L,420L,1008L,630L,560L,420L,1260L,840L,630L,1680L,1260L,2520L,5040L,5040L,5760L,3360L,2688L,2520L,6720L,4032L,3360L,2520L,2240L,8064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121457Inst : IEnumerable<long>
{
public static readonly long[] Value=A121457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121457.Bytes);
public long this[int i]=>Value[i];

public static A121457Inst Instance=new A121457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121458
{
public static readonly long[] Value={ 1L,1L,19L,28L,406L,721L,8722L,17983L,188209L,438697L,4078270L,10530100L,88714549L,249679990L,1936716229L,5864281633L,42418800739L,136706927896L,931844786950L,3167777090989L,20525689021222L,73046232419419L,453213909082585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121458Inst : IEnumerable<long>
{
public static readonly long[] Value=A121458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121458.Bytes);
public long this[int i]=>Value[i];

public static A121458Inst Instance=new A121458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121459
{
public static readonly long[] Value={ 0L,-3L,-14L,-18L,-7L,-9L,-47L,-51L,0L,-15L,-15L,-48L,-17L,-36L,57L,-151L,0L,-63L,0L,-11L,0L,25L,26L,368L,29L,-5L,-96L,-33L,0L,-144L,16927L,-466L,-180L,9033L,10192L,0L,-43L,316L,0L,0L,47L,-302L,49L,152L,1122L,945L,9145L,71914L,8041L,9591L,121L,54L,23142L,0L,177L,12813L,1665L,-5L,3255L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121459Inst : IEnumerable<long>
{
public static readonly long[] Value=A121459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121459.Bytes);
public long this[int i]=>Value[i];

public static A121459Inst Instance=new A121459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121460
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,4L,3L,1L,13L,9L,7L,4L,1L,34L,22L,16L,11L,5L,1L,89L,56L,38L,27L,16L,6L,1L,233L,145L,94L,65L,43L,22L,7L,1L,610L,378L,239L,159L,108L,65L,29L,8L,1L,1597L,988L,617L,398L,267L,173L,94L,37L,9L,1L,4181L,2585L,1605L,1015L,665L,440L,267L,131L,46L,10L,1L,10946L,6766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121460Inst : IEnumerable<long>
{
public static readonly long[] Value=A121460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121460.Bytes);
public long this[int i]=>Value[i];

public static A121460Inst Instance=new A121460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121461
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,8L,3L,1L,1L,21L,8L,3L,1L,1L,55L,21L,8L,3L,1L,1L,144L,55L,21L,8L,3L,1L,1L,377L,144L,55L,21L,8L,3L,1L,1L,987L,377L,144L,55L,21L,8L,3L,1L,1L,2584L,987L,377L,144L,55L,21L,8L,3L,1L,1L,6765L,2584L,987L,377L,144L,55L,21L,8L,3L,1L,1L,17711L,6765L,2584L,987L,377L,144L,55L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121461Inst : IEnumerable<long>
{
public static readonly long[] Value=A121461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121461.Bytes);
public long this[int i]=>Value[i];

public static A121461Inst Instance=new A121461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121462
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,4L,0L,1L,4L,8L,0L,1L,5L,12L,16L,0L,1L,6L,18L,32L,32L,0L,1L,7L,25L,56L,80L,64L,0L,1L,8L,33L,88L,160L,192L,128L,0L,1L,9L,42L,129L,280L,432L,448L,256L,0L,1L,10L,52L,180L,450L,832L,1120L,1024L,512L,0L,1L,11L,63L,242L,681L,1452L,2352L,2816L,2304L,1024L,0L,1L,12L,75L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121462Inst : IEnumerable<long>
{
public static readonly long[] Value=A121462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121462.Bytes);
public long this[int i]=>Value[i];

public static A121462Inst Instance=new A121462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121463
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,11L,1L,1L,26L,7L,1L,57L,30L,1L,1L,120L,102L,10L,1L,247L,303L,58L,1L,1L,502L,825L,256L,13L,1L,1013L,2116L,955L,95L,1L,1L,2036L,5200L,3178L,515L,16L,1L,4083L,12381L,9740L,2310L,141L,1L,1L,8178L,28779L,28064L,9078L,906L,19L,1L,16369L,65658L,77093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121463Inst : IEnumerable<long>
{
public static readonly long[] Value=A121463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121463.Bytes);
public long this[int i]=>Value[i];

public static A121463Inst Instance=new A121463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121464
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,2L,1L,4L,2L,3L,3L,1L,12L,6L,5L,6L,4L,1L,33L,18L,11L,11L,10L,5L,1L,88L,51L,29L,22L,21L,15L,6L,1L,232L,139L,80L,51L,43L,36L,21L,7L,1L,609L,371L,219L,131L,94L,79L,57L,28L,8L,1L,1596L,980L,590L,350L,225L,173L,136L,85L,36L,9L,1L,4180L,2576L,1570L,940L,575L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121464Inst : IEnumerable<long>
{
public static readonly long[] Value=A121464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121464.Bytes);
public long this[int i]=>Value[i];

public static A121464Inst Instance=new A121464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121465
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,1L,0L,0L,4L,4L,1L,0L,0L,8L,12L,4L,2L,0L,0L,16L,33L,12L,8L,4L,0L,0L,32L,88L,33L,24L,16L,8L,0L,0L,64L,232L,88L,66L,48L,32L,16L,0L,0L,128L,609L,232L,176L,132L,96L,64L,32L,0L,0L,256L,1596L,609L,464L,352L,264L,192L,128L,64L,0L,0L,512L,4180L,1596L,1218L,928L,704L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121465Inst : IEnumerable<long>
{
public static readonly long[] Value=A121465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121465.Bytes);
public long this[int i]=>Value[i];

public static A121465Inst Instance=new A121465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121466
{
public static readonly long[] Value={ 1L,2L,4L,1L,8L,5L,16L,17L,1L,32L,49L,8L,64L,129L,39L,1L,128L,321L,150L,11L,256L,769L,501L,70L,1L,512L,1793L,1524L,338L,14L,1024L,4097L,4339L,1375L,110L,1L,2048L,9217L,11762L,4973L,640L,17L,4096L,20481L,30705L,16508L,3075L,159L,1L,8192L,45057L,77808L,51340L,12918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121466Inst : IEnumerable<long>
{
public static readonly long[] Value=A121466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121466.Bytes);
public long this[int i]=>Value[i];

public static A121466Inst Instance=new A121466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121467
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,0L,0L,1L,0L,3L,0L,2L,0L,3L,0L,2L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,4L,0L,4L,0L,5L,0L,5L,0L,4L,0L,4L,0L,3L,0L,2L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,5L,0L,7L,0L,8L,0L,10L,0L,8L,0L,11L,0L,9L,0L,7L,0L,6L,0L,6L,0L,4L,0L,3L,0L,2L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,6L,0L,11L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121467Inst : IEnumerable<long>
{
public static readonly long[] Value=A121467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121467.Bytes);
public long this[int i]=>Value[i];

public static A121467Inst Instance=new A121467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121468
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,18L,9L,4L,1L,53L,28L,12L,5L,1L,154L,85L,38L,15L,6L,1L,443L,253L,117L,48L,18L,7L,1L,1264L,742L,352L,149L,58L,21L,8L,1L,3582L,2151L,1041L,451L,181L,68L,24L,9L,1L,10092L,6177L,3038L,1340L,550L,213L,78L,27L,10L,1L,28291L,17600L,8772L,3925L,1639L,649L,245L,88L,30L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121468Inst : IEnumerable<long>
{
public static readonly long[] Value=A121468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121468.Bytes);
public long this[int i]=>Value[i];

public static A121468Inst Instance=new A121468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121469
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,3L,0L,1L,3L,4L,5L,0L,1L,6L,13L,7L,7L,0L,1L,14L,28L,27L,10L,9L,0L,1L,31L,70L,62L,45L,13L,11L,0L,1L,70L,164L,171L,108L,67L,16L,13L,0L,1L,157L,392L,429L,325L,166L,93L,19L,15L,0L,1L,353L,926L,1101L,862L,540L,236L,123L,22L,17L,0L,1L,793L,2189L,2766L,2355L,1499L,824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121469Inst : IEnumerable<long>
{
public static readonly long[] Value=A121469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121469.Bytes);
public long this[int i]=>Value[i];

public static A121469Inst Instance=new A121469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121470
{
public static readonly long[] Value={ 1L,7L,16L,31L,49L,73L,100L,133L,169L,211L,256L,307L,361L,421L,484L,553L,625L,703L,784L,871L,961L,1057L,1156L,1261L,1369L,1483L,1600L,1723L,1849L,1981L,2116L,2257L,2401L,2551L,2704L,2863L,3025L,3193L,3364L,3541L,3721L,3907L,4096L,4291L,4489L,4693L,4900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121470Inst : IEnumerable<long>
{
public static readonly long[] Value=A121470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121470.Bytes);
public long this[int i]=>Value[i];

public static A121470Inst Instance=new A121470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121471
{
public static readonly long[] Value={ 1L,3L,11L,22L,39L,59L,85L,114L,149L,187L,231L,278L,331L,387L,449L,514L,585L,659L,739L,822L,911L,1003L,1101L,1202L,1309L,1419L,1535L,1654L,1779L,1907L,2041L,2178L,2321L,2467L,2619L,2774L,2935L,3099L,3269L,3442L,3621L,3803L,3991L,4182L,4379L,4579L,4785L,4994L,5209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121471Inst : IEnumerable<long>
{
public static readonly long[] Value=A121471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121471.Bytes);
public long this[int i]=>Value[i];

public static A121471Inst Instance=new A121471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121472
{
public static readonly long[] Value={ 8L,5L,7L,2L,8L,2L,3L,8L,3L,1L,0L,3L,4L,0L,6L,1L,7L,7L,5L,1L,1L,9L,0L,3L,3L,0L,8L,5L,0L,9L,7L,3L,3L,9L,9L,7L,5L,9L,0L,9L,8L,8L,3L,1L,2L,0L,9L,3L,1L,4L,6L,9L,2L,2L,2L,5L,7L,8L,2L,4L,2L,9L,2L,4L,6L,0L,6L,9L,3L,3L,3L,3L,2L,6L,8L,3L,3L,6L,3L,4L,8L,2L,8L,9L,1L,0L,8L,1L,1L,5L,2L,4L,9L,3L,5L,4L,1L,1L,2L,7L,0L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121472Inst : IEnumerable<long>
{
public static readonly long[] Value=A121472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121472.Bytes);
public long this[int i]=>Value[i];

public static A121472Inst Instance=new A121472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121473
{
public static readonly BigInteger[] Value={ 0L,1L,6L,146L,8L,BigInteger.Parse("37783544111994270385152"),BigInteger.Parse("784637716923335095479473680436259502469253233551410733056"),BigInteger.Parse("309485009821345068724781056") };
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
public class A121473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121473Inst Instance=new A121473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121474
{
public static readonly long[] Value={ 2L,3L,3L,0L,7L,2L,4L,0L,7L,0L,4L,5L,0L,0L,9L,7L,8L,4L,7L,3L,5L,7L,2L,7L,2L,6L,4L,0L,1L,7L,8L,0L,9L,3L,5L,3L,8L,6L,0L,3L,1L,4L,8L,6L,1L,0L,1L,4L,3L,8L,7L,5L,6L,5L,0L,3L,2L,1L,0L,8L,2L,4L,3L,3L,1L,6L,6L,7L,2L,1L,0L,5L,5L,0L,5L,8L,6L,4L,0L,0L,5L,0L,3L,8L,2L,0L,0L,0L,6L,2L,3L,0L,8L,5L,2L,3L,5L,4L,2L,4L,8L,9L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121474Inst : IEnumerable<long>
{
public static readonly long[] Value=A121474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121474.Bytes);
public long this[int i]=>Value[i];

public static A121474Inst Instance=new A121474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121475
{
public static readonly BigInteger[] Value={ 2L,3L,42L,4L,4512412933881984L,BigInteger.Parse("2722258935367507708887588480171556995584"),2305843009213693952L,BigInteger.Parse("6277101735386680763835789423207666416102355444464034512896") };
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
public class A121475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121475Inst Instance=new A121475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121476
{
public static readonly long[] Value={ 9L,171L,252L,333L,414L,10701L,11511L,12321L,13131L,20502L,21312L,22122L,30303L,31113L,40104L,1007001L,1015101L,1023201L,1031301L,1105011L,1113111L,1121211L,1203021L,1211121L,2005002L,2013102L,2021202L,2103012L,2111112L,2201022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121476Inst : IEnumerable<long>
{
public static readonly long[] Value=A121476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121476.Bytes);
public long this[int i]=>Value[i];

public static A121476Inst Instance=new A121476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121477
{
public static readonly long[] Value={ 9L,171L,252L,333L,414L,11511L,12321L,13131L,21321L,22122L,31113L,1113111L,1121211L,1211121L,2111112L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121477Inst : IEnumerable<long>
{
public static readonly long[] Value=A121477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121477.Bytes);
public long this[int i]=>Value[i];

public static A121477Inst Instance=new A121477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121478
{
public static readonly long[] Value={ 66L,78L,105L,120L,190L,231L,276L,300L,378L,406L,435L,465L,528L,561L,595L,666L,741L,820L,861L,903L,946L,1035L,1128L,1176L,1275L,1378L,1485L,1653L,1953L,2016L,2080L,2211L,2278L,2485L,2556L,2628L,2775L,3081L,3160L,3240L,3655L,3741L,3916L,4005L,4371L,4465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121478Inst : IEnumerable<long>
{
public static readonly long[] Value=A121478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121478.Bytes);
public long this[int i]=>Value[i];

public static A121478Inst Instance=new A121478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121479
{
public static readonly long[] Value={ 210L,630L,780L,990L,1326L,1540L,1596L,1770L,1830L,2145L,2346L,2415L,2850L,2926L,3003L,3486L,3570L,3828L,4095L,4186L,4278L,4560L,4950L,5460L,5565L,6105L,6216L,6555L,6670L,6786L,7140L,7260L,7626L,8385L,8646L,8778L,9180L,9730L,9870L,10296L,10440L,10878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121479Inst : IEnumerable<long>
{
public static readonly long[] Value=A121479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121479.Bytes);
public long this[int i]=>Value[i];

public static A121479Inst Instance=new A121479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121480
{
public static readonly long[] Value={ 2L,1L,0L,1L,3L,2L,5L,4L,9L,8L,7L,6L,6L,5L,12L,11L,10L,9L,9L,8L,10L,9L,8L,7L,17L,16L,15L,14L,13L,12L,12L,11L,14L,13L,12L,11L,10L,9L,13L,12L,11L,10L,10L,9L,21L,20L,19L,18L,20L,19L,18L,17L,16L,15L,18L,17L,16L,15L,14L,13L,13L,12L,18L,17L,16L,15L,14L,13L,14L,13L,12L,11L,11L,10L,17L,16L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121480Inst : IEnumerable<long>
{
public static readonly long[] Value=A121480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121480.Bytes);
public long this[int i]=>Value[i];

public static A121480Inst Instance=new A121480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121481
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,3L,0L,1L,3L,3L,6L,0L,1L,5L,14L,5L,9L,0L,1L,12L,22L,35L,7L,12L,0L,1L,22L,68L,53L,65L,9L,15L,0L,1L,49L,127L,203L,97L,104L,11L,18L,0L,1L,94L,329L,390L,444L,153L,152L,13L,21L,0L,1L,201L,664L,1157L,873L,816L,221L,209L,15L,24L,0L,1L,396L,1576L,2456L,2925L,1627L,1345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121481Inst : IEnumerable<long>
{
public static readonly long[] Value=A121481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121481.Bytes);
public long this[int i]=>Value[i];

public static A121481Inst Instance=new A121481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121482
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,5L,12L,22L,49L,94L,201L,396L,828L,1656L,3421L,6899L,14160L,28686L,58672L,119156L,243253L,494688L,1008860L,2053168L,4184892L,8520248L,17361293L,35354517L,72028485L,146696143L,298840769L,608670551L,1239888694L,2525459305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121482Inst : IEnumerable<long>
{
public static readonly long[] Value=A121482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121482.Bytes);
public long this[int i]=>Value[i];

public static A121482Inst Instance=new A121482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121483
{
public static readonly long[] Value={ 1L,2L,6L,19L,56L,167L,487L,1411L,4047L,11527L,32617L,91790L,257065L,716896L,1991792L,5515535L,15227846L,41930133L,115176023L,315676425L,863475561L,2357539227L,6425887551L,17487572124L,47522431681L,128969086382L,349567320762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121483Inst : IEnumerable<long>
{
public static readonly long[] Value=A121483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121483.Bytes);
public long this[int i]=>Value[i];

public static A121483Inst Instance=new A121483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121484
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,6L,2L,1L,8L,13L,10L,2L,1L,16L,34L,23L,13L,2L,1L,33L,74L,75L,32L,16L,2L,1L,66L,178L,180L,124L,40L,19L,2L,1L,136L,390L,497L,321L,180L,48L,22L,2L,1L,274L,895L,1192L,1004L,488L,244L,56L,25L,2L,1L,562L,1958L,3033L,2598L,1701L,682L,317L,64L,28L,2L,1L,1138L,4374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121484Inst : IEnumerable<long>
{
public static readonly long[] Value=A121484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121484.Bytes);
public long this[int i]=>Value[i];

public static A121484Inst Instance=new A121484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121485
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,33L,66L,136L,274L,562L,1138L,2327L,4725L,9645L,19613L,39997L,81397L,165906L,337773L,688260L,1401565L,2855432L,5815477L,11846941L,24129498L,49152840L,100116607L,203936639L,415394872L,846143795L,1723513075L,3510704795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121485Inst : IEnumerable<long>
{
public static readonly long[] Value=A121485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121485.Bytes);
public long this[int i]=>Value[i];

public static A121485Inst Instance=new A121485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121486
{
public static readonly long[] Value={ 0L,1L,4L,13L,43L,132L,400L,1184L,3461L,9999L,28634L,81383L,229860L,645731L,1805582L,5028189L,13952221L,38590922L,106434540L,292792026L,803565215L,2200694791L,6015268164L,16412564173L,44708036568L,121600924117L,330277253560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121486Inst : IEnumerable<long>
{
public static readonly long[] Value=A121486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121486.Bytes);
public long this[int i]=>Value[i];

public static A121486Inst Instance=new A121486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121487
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,5L,2L,1L,5L,13L,5L,2L,1L,13L,34L,13L,5L,2L,1L,34L,89L,34L,13L,5L,2L,1L,89L,233L,89L,34L,13L,5L,2L,1L,233L,610L,233L,89L,34L,13L,5L,2L,1L,610L,1597L,610L,233L,89L,34L,13L,5L,2L,1L,1597L,4181L,1597L,610L,233L,89L,34L,13L,5L,2L,1L,4181L,10946L,4181L,1597L,610L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121487Inst : IEnumerable<long>
{
public static readonly long[] Value=A121487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121487.Bytes);
public long this[int i]=>Value[i];

public static A121487Inst Instance=new A121487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121488
{
public static readonly long[] Value={ 4L,7L,8L,7L,4L,32L,31L,28L,23L,16L,7L,63L,56L,47L,36L,23L,8L,92L,79L,64L,47L,28L,7L,119L,100L,79L,56L,31L,4L,144L,119L,92L,63L,32L,196L,167L,136L,103L,68L,31L,223L,188L,151L,112L,71L,28L,248L,207L,164L,119L,72L,23L,271L,224L,175L,124L,71L,16L,292L,239L,184L,127L,68L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121488Inst : IEnumerable<long>
{
public static readonly long[] Value=A121488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121488.Bytes);
public long this[int i]=>Value[i];

public static A121488Inst Instance=new A121488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121489
{
public static readonly long[] Value={ 3L,1L,9L,17L,19L,9L,18L,17L,55L,24L,38L,36L,12L,65L,106L,129L,128L,97L,30L,100L,148L,168L,154L,100L,251L,113L,198L,249L,260L,225L,138L,356L,163L,297L,389L,433L,423L,353L,217L,9L,248L,441L,17L,80L,79L,8L,506L,297L,687L,316L,574L,17L,119L,145L,89L,784L,568L,252L,737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121489Inst : IEnumerable<long>
{
public static readonly long[] Value=A121489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121489.Bytes);
public long this[int i]=>Value[i];

public static A121489Inst Instance=new A121489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121490
{
public static readonly long[] Value={ 3L,2L,5L,1L,1L,7L,5L,4L,7L,9L,4L,9L,9L,4L,11L,3L,5L,13L,1L,14L,13L,2L,1L,4L,17L,6L,9L,15L,1L,8L,10L,1L,21L,13L,2L,17L,7L,4L,1L,4L,19L,25L,22L,16L,19L,6L,13L,9L,9L,19L,16L,29L,4L,7L,21L,5L,9L,19L,16L,21L,9L,11L,33L,13L,25L,23L,4L,5L,10L,25L,25L,4L,30L,4L,37L,24L,14L,25L,3L,1L,1L,9L,31L,1L,18L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121490Inst : IEnumerable<long>
{
public static readonly long[] Value=A121490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121490.Bytes);
public long this[int i]=>Value[i];

public static A121490Inst Instance=new A121490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121491
{
public static readonly long[] Value={ 47594118L,94664704L,77288171L,77627916L,85442051L,65167154L,98844528L,73424122L,88754790L,41360150L,51283441L,79519132L,28940018L,65620408L,9269369L,13195485L,3496152L,80411496L,49464390L,37680959L,66662049L,33227112L,64223569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121491Inst : IEnumerable<long>
{
public static readonly long[] Value=A121491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121491.Bytes);
public long this[int i]=>Value[i];

public static A121491Inst Instance=new A121491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121492
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,12L,14L,20L,22L,30L,32L,34L,36L,44L,52L,72L,86L,96L,112L,114L,118L,132L,148L,154L,180L,210L,220L,222L,234L,248L,250L,282L,288L,292L,320L,336L,354L,382L,384L,394L,456L,464L,468L,474L,486L,490L,500L,514L,516L,532L,534L,540L,582L,588L,602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121492Inst : IEnumerable<long>
{
public static readonly long[] Value=A121492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121492.Bytes);
public long this[int i]=>Value[i];

public static A121492Inst Instance=new A121492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121493
{
public static readonly BigInteger[] Value={ 2L,60L,360360L,232792560L,144403552893600L,BigInteger.Parse("164249358725037825439200"),BigInteger.Parse("71876675494548945530447225706507529440"),BigInteger.Parse("33312720618553145840562713089120360606823375590405920630576000") };
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
public class A121493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121493Inst Instance=new A121493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121494
{
public static readonly long[] Value={ 4L,10L,27L,34L,38L,46L,55L,57L,62L,76L,77L,91L,93L,106L,118L,123L,129L,133L,136L,143L,145L,159L,161L,177L,185L,201L,203L,205L,206L,212L,213L,218L,226L,232L,235L,259L,267L,291L,295L,297L,298L,305L,310L,314L,322L,327L,334L,335L,339L,343L,357L,358L,365L,370L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121494Inst : IEnumerable<long>
{
public static readonly long[] Value=A121494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121494.Bytes);
public long this[int i]=>Value[i];

public static A121494Inst Instance=new A121494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121495
{
public static readonly long[] Value={ 14L,21L,33L,34L,38L,57L,65L,69L,77L,85L,86L,93L,94L,105L,110L,114L,118L,122L,129L,133L,141L,142L,145L,154L,158L,165L,177L,182L,185L,186L,194L,201L,202L,205L,209L,213L,214L,217L,218L,221L,230L,237L,246L,253L,254L,258L,265L,266L,273L,285L,286L,290L,298L,301L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121495Inst : IEnumerable<long>
{
public static readonly long[] Value=A121495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121495.Bytes);
public long this[int i]=>Value[i];

public static A121495Inst Instance=new A121495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121496
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,4L,4L,3L,5L,6L,6L,5L,7L,8L,8L,7L,9L,10L,10L,9L,11L,12L,12L,11L,13L,14L,14L,13L,15L,16L,16L,15L,17L,18L,18L,17L,19L,20L,20L,19L,21L,22L,22L,21L,23L,24L,24L,23L,25L,26L,26L,25L,27L,28L,28L,27L,29L,30L,30L,29L,31L,32L,32L,31L,33L,34L,34L,33L,35L,36L,36L,35L,37L,38L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121496Inst : IEnumerable<long>
{
public static readonly long[] Value=A121496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121496.Bytes);
public long this[int i]=>Value[i];

public static A121496Inst Instance=new A121496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121497
{
public static readonly long[] Value={ 0L,0L,1L,4L,10L,21L,41L,78L,148L,282L,537L,1013L,1882L,3446L,6267L,11468L,21416L,41209L,81771L,166042L,340994L,700570L,1429375L,2886777L,5771828L,11453105L,22638215L,44742141L,88681674L,176545766L,352992931L,707922077L,1421120880L,2849433326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121497Inst : IEnumerable<long>
{
public static readonly long[] Value=A121497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121497.Bytes);
public long this[int i]=>Value[i];

public static A121497Inst Instance=new A121497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121498
{
public static readonly BigInteger[] Value={ 1L,840L,706442L,594117717L,499653000011L,420208173009209L,353395073500744901L,BigInteger.Parse("297205256814126461312"),BigInteger.Parse("249949620980680353964822"),BigInteger.Parse("210207631244752177684410440"),BigInteger.Parse("176784617876836581432589196836") };
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
public class A121498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121498Inst Instance=new A121498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121499
{
public static readonly BigInteger[] Value={ 1L,841L,707281L,594823321L,500246412961L,420707233300201L,353814783205469041L,BigInteger.Parse("297558232675799463481"),BigInteger.Parse("250246473680347348787521"),BigInteger.Parse("210457284365172120330305161"),BigInteger.Parse("176994576151109753197786640401") };
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
public class A121499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121499Inst Instance=new A121499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121500
{
public static readonly long[] Value={ 3L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,26L,26L,27L,28L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,35L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121500Inst : IEnumerable<long>
{
public static readonly long[] Value=A121500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121500.Bytes);
public long this[int i]=>Value[i];

public static A121500Inst Instance=new A121500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121501
{
public static readonly long[] Value={ 3L,5L,6L,8L,11L,14L,15L,17L,18L,21L,31L,38L,48L,65L,82L,89L,99L,106L,123L,181L,222L,280L,379L,478L,519L,577L,618L,717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121501Inst : IEnumerable<long>
{
public static readonly long[] Value=A121501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121501.Bytes);
public long this[int i]=>Value[i];

public static A121501Inst Instance=new A121501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121502
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,10L,11L,12L,13L,15L,22L,27L,34L,46L,58L,63L,70L,75L,87L,128L,157L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121502Inst : IEnumerable<long>
{
public static readonly long[] Value=A121502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121502.Bytes);
public long this[int i]=>Value[i];

public static A121502Inst Instance=new A121502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121503
{
public static readonly ulong[] Value={ 13L,203L,1615L,51595L,412529L,6599099L,52788535L,3378355987L,27026481101L,432421205841L,3459361042977L,110699432952143L,885595037556565L,14169517557800915L,113356129507566775L,14509583941597490435UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121503Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A121503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121503.Bytes);
public ulong this[int i]=>Value[i];

public static A121503Inst Instance=new A121503Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121504
{
public static readonly long[] Value={ 3L,53L,433L,13941L,111759L,1789509L,14320329L,916611309L,7333257267L,117334608047L,938685468127L,30038055403185L,240304869286059L,3844880951681069L,30759058568289097L,3937160132112061181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121504Inst : IEnumerable<long>
{
public static readonly long[] Value=A121504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121504.Bytes);
public long this[int i]=>Value[i];

public static A121504Inst Instance=new A121504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121505
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121505Inst : IEnumerable<long>
{
public static readonly long[] Value=A121505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121505.Bytes);
public long this[int i]=>Value[i];

public static A121505Inst Instance=new A121505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121506
{
public static readonly long[] Value={ 3L,5L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,21L,22L,24L,25L,27L,28L,30L,31L,32L,34L,35L,37L,38L,39L,41L,42L,44L,45L,47L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,64L,65L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121506Inst : IEnumerable<long>
{
public static readonly long[] Value=A121506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121506.Bytes);
public long this[int i]=>Value[i];

public static A121506Inst Instance=new A121506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121507
{
public static readonly long[] Value={ 220L,284L,562L,1064L,1184L,1188L,1210L,1308L,1336L,1380L,1420L,1490L,1604L,1690L,1692L,1772L,1816L,1898L,2008L,2122L,2152L,2172L,2362L,2542L,2620L,2630L,2652L,2676L,2678L,2856L,2924L,2930L,2950L,2974L,3124L,3162L,3202L,3278L,3286L,3332L,3350L,3360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121507Inst : IEnumerable<long>
{
public static readonly long[] Value=A121507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121507.Bytes);
public long this[int i]=>Value[i];

public static A121507Inst Instance=new A121507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121508
{
public static readonly long[] Value={ 562L,1064L,1188L,1308L,1336L,1380L,1420L,1490L,1604L,1690L,1692L,1772L,1816L,1898L,2008L,2122L,2152L,2172L,2362L,2542L,2630L,2652L,2676L,2678L,2856L,2930L,2950L,2974L,3124L,3162L,3202L,3278L,3286L,3332L,3350L,3360L,3596L,3712L,3750L,3850L,3938L,3944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121508Inst : IEnumerable<long>
{
public static readonly long[] Value=A121508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121508.Bytes);
public long this[int i]=>Value[i];

public static A121508Inst Instance=new A121508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121509
{
public static readonly long[] Value={ 1L,3L,11L,23L,41L,63L,91L,123L,161L,203L,251L,303L,361L,423L,491L,563L,641L,723L,811L,903L,1001L,1103L,1211L,1323L,1441L,1563L,1691L,1823L,1961L,2103L,2251L,2403L,2561L,2723L,2891L,3063L,3241L,3423L,3611L,3803L,4001L,4203L,4411L,4623L,4841L,5063L,5291L,5523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121509Inst : IEnumerable<long>
{
public static readonly long[] Value=A121509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121509.Bytes);
public long this[int i]=>Value[i];

public static A121509Inst Instance=new A121509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121510
{
public static readonly long[] Value={ 1L,2L,3L,5L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121510Inst : IEnumerable<long>
{
public static readonly long[] Value=A121510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121510.Bytes);
public long this[int i]=>Value[i];

public static A121510Inst Instance=new A121510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121511
{
public static readonly long[] Value={ 1L,5L,13L,25L,5L,9L,17L,29L,9L,13L,21L,33L,13L,17L,25L,37L,17L,21L,29L,41L,21L,25L,33L,45L,25L,29L,37L,49L,29L,33L,41L,53L,33L,37L,45L,57L,37L,41L,49L,61L,41L,45L,53L,65L,45L,49L,57L,69L,49L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121511Inst : IEnumerable<long>
{
public static readonly long[] Value=A121511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121511.Bytes);
public long this[int i]=>Value[i];

public static A121511Inst Instance=new A121511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121512
{
public static readonly long[] Value={ 1L,4L,10L,4L,7L,13L,7L,10L,16L,10L,13L,19L,13L,16L,22L,16L,19L,25L,19L,22L,28L,22L,25L,31L,25L,28L,34L,28L,31L,37L,31L,34L,40L,34L,37L,43L,37L,40L,46L,40L,43L,49L,43L,46L,52L,46L,49L,55L,49L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121512Inst : IEnumerable<long>
{
public static readonly long[] Value=A121512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121512.Bytes);
public long this[int i]=>Value[i];

public static A121512Inst Instance=new A121512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121513
{
public static readonly long[] Value={ 1L,61L,181L,349L,685L,1045L,1549L,2209L,2929L,3889L,4969L,6061L,7381L,8725L,10645L,12805L,14989L,17437L,19957L,22645L,25645L,29065L,32665L,36505L,40585L,45445L,50341L,55381L,60757L,66373L,72133L,78181L,84253L,91093L,98293L,105793L,113353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121513Inst : IEnumerable<long>
{
public static readonly long[] Value=A121513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121513.Bytes);
public long this[int i]=>Value[i];

public static A121513Inst Instance=new A121513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121514
{
public static readonly long[] Value={ 2L,2L,4L,14L,6L,12L,30L,4L,4L,20L,15L,70L,30L,18L,10L,10L,48L,72L,24L,25L,133L,7L,7L,42L,240L,40L,33L,182L,6L,6L,66L,126L,24L,104L,84L,6L,6L,84L,260L,24L,44L,4L,4L,4L,276L,660L,21L,390L,57L,3L,3L,102L,72L,1680L,1232L,6006L,8L,8L,6552L,1440L,5698L,40L,1380L,70L,70L,54L,6048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121514Inst : IEnumerable<long>
{
public static readonly long[] Value=A121514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121514.Bytes);
public long this[int i]=>Value[i];

public static A121514Inst Instance=new A121514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121515
{
public static readonly BigInteger[] Value={ 3L,33L,315L,26163L,235953L,2125035L,19129689L,172180323L,1549662273L,13947078555L,125524061289L,1129717614483L,10167461718993L,91507165036875L,823564514029689L,7412080712360643L,66708726669526113L,600378540800575995L,5403406869529706889L,BigInteger.Parse("48630661832740930803") };
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
public class A121515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121515Inst Instance=new A121515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121516
{
public static readonly BigInteger[] Value={ 2L,10L,84L,788L,8188L,90110L,1035456L,12269932L,148886048L,1840585914L,23099713808L,293535000452L,3769200628592L,48831588116862L,637501117219024L,8378367468484212L,110760388293651950L,1471854299855109782L,BigInteger.Parse("19649723961974718686"),BigInteger.Parse("263422552838889748560") };
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
public class A121516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121516Inst Instance=new A121516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121517
{
public static readonly long[] Value={ 1L,1L,7L,31L,151L,721L,3457L,16561L,79351L,380191L,1821607L,8727841L,41817601L,200360161L,959983207L,4599555871L,22037796151L,105589424881L,505909328257L,2423957216401L,11613876753751L,55645426552351L,266613256008007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121517Inst : IEnumerable<long>
{
public static readonly long[] Value=A121517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121517.Bytes);
public long this[int i]=>Value[i];

public static A121517Inst Instance=new A121517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121518
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,28L,30L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,82L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121518Inst : IEnumerable<long>
{
public static readonly long[] Value=A121518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121518.Bytes);
public long this[int i]=>Value[i];

public static A121518Inst Instance=new A121518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121519
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,12L,16L,22L,24L,28L,40L,52L,64L,72L,82L,84L,88L,112L,128L,130L,132L,144L,156L,172L,178L,190L,192L,232L,238L,250L,252L,276L,280L,292L,324L,358L,384L,396L,400L,418L,424L,430L,442L,448L,480L,490L,508L,520L,544L,552L,592L,612L,640L,652L,658L,682L,712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121519Inst : IEnumerable<long>
{
public static readonly long[] Value=A121519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121519.Bytes);
public long this[int i]=>Value[i];

public static A121519Inst Instance=new A121519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121520
{
public static readonly BigInteger[] Value={ 1L,11L,10201L,1003003001L,10004000600040001L,BigInteger.Parse("10000500010000100000500001"),BigInteger.Parse("1000006000015000020000015000006000001"),BigInteger.Parse("10000007000002100000350000035000002100000070000001") };
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
public class A121520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A121520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A121520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A121520Inst Instance=new A121520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121521
{
public static readonly long[] Value={ 1L,2L,10L,2L,16L,12L,220L,60L,112L,222L,112L,30L,618L,348L,156L,248L,10L,290L,256L,2346L,118L,570L,738L,348L,1356L,4352L,1402L,470L,736L,300L,10428L,4962L,4882L,1382L,580L,948L,5112L,776L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121521Inst : IEnumerable<long>
{
public static readonly long[] Value=A121521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121521.Bytes);
public long this[int i]=>Value[i];

public static A121521Inst Instance=new A121521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121522
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,6L,1L,1L,8L,15L,9L,1L,1L,11L,30L,34L,12L,1L,1L,14L,55L,85L,62L,15L,1L,1L,17L,89L,185L,200L,99L,18L,1L,1L,20L,132L,365L,510L,402L,145L,21L,1L,1L,23L,184L,650L,1160L,1220L,718L,200L,24L,1L,1L,26L,245L,1067L,2400L,3155L,2585L,1175L,264L,27L,1L,1L,29L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121522Inst : IEnumerable<long>
{
public static readonly long[] Value=A121522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121522.Bytes);
public long this[int i]=>Value[i];

public static A121522Inst Instance=new A121522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121523
{
public static readonly long[] Value={ 1L,3L,10L,33L,103L,315L,941L,2770L,8051L,23171L,66138L,187486L,528365L,1481501L,4135756L,11500721L,31871625L,88054825L,242609585L,666783380L,1828452021L,5003697403L,13667302500L,37267071708L,101455834153L,275797332135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121523Inst : IEnumerable<long>
{
public static readonly long[] Value=A121523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121523.Bytes);
public long this[int i]=>Value[i];

public static A121523Inst Instance=new A121523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121524
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,5L,1L,1L,9L,15L,8L,1L,1L,12L,34L,30L,11L,1L,1L,15L,62L,85L,55L,14L,1L,1L,18L,99L,200L,185L,89L,17L,1L,1L,21L,145L,402L,510L,365L,132L,20L,1L,1L,24L,200L,718L,1220L,1160L,650L,184L,23L,1L,1L,27L,264L,1175L,2585L,3155L,2400L,1067L,245L,26L,1L,1L,30L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121524Inst : IEnumerable<long>
{
public static readonly long[] Value=A121524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121524.Bytes);
public long this[int i]=>Value[i];

public static A121524Inst Instance=new A121524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121525
{
public static readonly long[] Value={ 0L,1L,5L,19L,67L,219L,690L,2110L,6322L,18639L,54268L,156398L,446960L,1268351L,3577679L,10039583L,28046201L,78039545L,216388938L,598136340L,1648730940L,4533180211L,12435470410L,34042090044L,93012717072L,253692955789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121525Inst : IEnumerable<long>
{
public static readonly long[] Value=A121525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121525.Bytes);
public long this[int i]=>Value[i];

public static A121525Inst Instance=new A121525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121526
{
public static readonly long[] Value={ 2L,2L,4L,14L,6L,26L,16L,130L,24L,36L,18L,198L,34L,420L,210L,86L,40L,98L,52L,30L,58L,122L,42L,720L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121526Inst : IEnumerable<long>
{
public static readonly long[] Value=A121526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121526.Bytes);
public long this[int i]=>Value[i];

public static A121526Inst Instance=new A121526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121527
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,6L,7L,23L,9L,21L,11L,29L,19L,27L,22L,16L,25L,43L,19L,73L,21L,43L,25L,89L,26L,26L,40L,28L,31L,97L,32L,47L,65L,35L,103L,37L,81L,41L,101L,59L,117L,44L,50L,65L,89L,57L,93L,59L,173L,52L,76L,82L,53L,133L,55L,167L,83L,117L,73L,143L,61L,123L,78L,70L,97L,173L,110L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121527Inst : IEnumerable<long>
{
public static readonly long[] Value=A121527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121527.Bytes);
public long this[int i]=>Value[i];

public static A121527Inst Instance=new A121527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121528
{
public static readonly long[] Value={ 1L,2L,4L,4L,5L,11L,10L,8L,16L,10L,11L,23L,29L,27L,17L,31L,18L,18L,27L,41L,21L,43L,24L,24L,32L,26L,50L,30L,29L,61L,31L,101L,41L,81L,35L,107L,37L,113L,42L,42L,41L,83L,76L,44L,67L,91L,58L,85L,97L,79L,151L,64L,61L,211L,57L,139L,57L,135L,59L,131L,103L,135L,63L,159L,65L,197L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121528Inst : IEnumerable<long>
{
public static readonly long[] Value=A121528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121528.Bytes);
public long this[int i]=>Value[i];

public static A121528Inst Instance=new A121528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121529
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,10L,2L,1L,19L,14L,1L,33L,50L,5L,1L,55L,132L,45L,1L,90L,301L,205L,13L,1L,146L,631L,680L,139L,1L,236L,1255L,1892L,763L,34L,1L,381L,2409L,4717L,3019L,419L,1L,615L,4509L,10920L,9846L,2677L,89L,1L,993L,8283L,23974L,28292L,12241L,1241L,1L,1604L,14998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121529Inst : IEnumerable<long>
{
public static readonly long[] Value=A121529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121529.Bytes);
public long this[int i]=>Value[i];

public static A121529Inst Instance=new A121529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121530
{
public static readonly long[] Value={ 0L,1L,4L,14L,47L,148L,454L,1359L,4004L,11644L,33521L,95696L,271300L,764605L,2143964L,5985186L,16643779L,46124692L,127433562L,351106955L,964976460L,2646158176L,7241414949L,19779499584L,53933402472L,146828245753L,399137621524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121530Inst : IEnumerable<long>
{
public static readonly long[] Value=A121530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121530.Bytes);
public long this[int i]=>Value[i];

public static A121530Inst Instance=new A121530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121531
{
public static readonly long[] Value={ 1L,2L,4L,1L,7L,6L,12L,20L,2L,20L,51L,18L,33L,115L,80L,5L,54L,240L,262L,54L,88L,477L,725L,294L,13L,143L,916L,1803L,1158L,161L,232L,1716L,4170L,3768L,1026L,34L,376L,3155L,9152L,10815L,4684L,475L,609L,5717L,19311L,28418L,17432L,3449L,89L,986L,10240L,39520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121531Inst : IEnumerable<long>
{
public static readonly long[] Value=A121531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121531.Bytes);
public long this[int i]=>Value[i];

public static A121531Inst Instance=new A121531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121532
{
public static readonly long[] Value={ 0L,0L,1L,6L,24L,87L,290L,926L,2861L,8640L,25634L,75015L,217100L,622620L,1772097L,5011394L,14093980L,39448623L,109954398L,305344314L,845165725L,2332485420L,6420202246L,17629525871L,48304680504L,132092031672L,360557665825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121532Inst : IEnumerable<long>
{
public static readonly long[] Value=A121532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121532.Bytes);
public long this[int i]=>Value[i];

public static A121532Inst Instance=new A121532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121533
{
public static readonly long[] Value={ 3L,5L,13L,89L,233L,1597L,2971215073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121533Inst : IEnumerable<long>
{
public static readonly long[] Value=A121533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121533.Bytes);
public long this[int i]=>Value[i];

public static A121533Inst Instance=new A121533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121534
{
public static readonly long[] Value={ 7L,11L,29L,199L,521L,3571L,6643838879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121534Inst : IEnumerable<long>
{
public static readonly long[] Value=A121534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121534.Bytes);
public long this[int i]=>Value[i];

public static A121534Inst Instance=new A121534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121535
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,54L,271L,7846L,937767L,605772815L,87246282837L,547880799393L,2399113322502L,4137547470482L,45252394397843L,1531558595686560L,1281758695960501L,2008670909471090L,3385200300351842L,6108670309471325L,7985400400619556L,8253670509407076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121535Inst : IEnumerable<long>
{
public static readonly long[] Value=A121535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121535.Bytes);
public long this[int i]=>Value[i];

public static A121535Inst Instance=new A121535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121536
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121536Inst : IEnumerable<long>
{
public static readonly long[] Value=A121536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121536.Bytes);
public long this[int i]=>Value[i];

public static A121536Inst Instance=new A121536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121537
{
public static readonly long[] Value={ 1L,5L,6L,7L,8L,9L,11L,13L,17L,19L,23L,25L,29L,30L,31L,35L,37L,40L,41L,42L,43L,45L,47L,48L,49L,53L,54L,55L,56L,59L,61L,63L,64L,65L,66L,67L,71L,72L,73L,77L,78L,79L,81L,83L,85L,88L,89L,91L,95L,97L,99L,101L,102L,103L,104L,107L,109L,113L,114L,115L,117L,119L,121L,125L,127L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121537Inst : IEnumerable<long>
{
public static readonly long[] Value=A121537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121537.Bytes);
public long this[int i]=>Value[i];

public static A121537Inst Instance=new A121537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121538
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,8L,10L,11L,12L,14L,16L,18L,19L,20L,22L,24L,26L,27L,28L,30L,31L,32L,34L,35L,36L,38L,40L,42L,43L,44L,46L,47L,48L,50L,51L,52L,54L,56L,58L,59L,60L,62L,64L,66L,67L,68L,70L,72L,74L,75L,76L,78L,79L,80L,82L,83L,84L,86L,88L,90L,91L,92L,94L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121538Inst : IEnumerable<long>
{
public static readonly long[] Value=A121538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121538.Bytes);
public long this[int i]=>Value[i];

public static A121538Inst Instance=new A121538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121539
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,8L,10L,11L,12L,14L,15L,16L,18L,19L,20L,22L,24L,26L,27L,28L,30L,32L,34L,35L,36L,38L,40L,42L,43L,44L,46L,47L,48L,50L,51L,52L,54L,56L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,72L,74L,75L,76L,78L,79L,80L,82L,83L,84L,86L,88L,90L,91L,92L,94L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121539Inst : IEnumerable<long>
{
public static readonly long[] Value=A121539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121539.Bytes);
public long this[int i]=>Value[i];

public static A121539Inst Instance=new A121539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A121540
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,10L,12L,14L,15L,16L,18L,19L,20L,22L,23L,24L,26L,27L,28L,30L,32L,34L,35L,36L,38L,40L,42L,43L,44L,46L,48L,50L,51L,52L,54L,56L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,72L,74L,75L,76L,78L,79L,80L,82L,83L,84L,86L,88L,90L,91L,92L,94L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A121540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A121540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A121540Inst : IEnumerable<long>
{
public static readonly long[] Value=A121540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A121540.Bytes);
public long this[int i]=>Value[i];

public static A121540Inst Instance=new A121540Inst();

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