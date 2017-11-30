using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A194705
{
public static readonly long[] Value={ 7L,4L,3L,2L,2L,3L,1L,1L,3L,2L,0L,1L,1L,2L,3L,1L,0L,1L,1L,2L,2L,0L,1L,0L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194705Inst : IEnumerable<long>
{
public static readonly long[] Value=A194705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194705.Bytes);
public long this[int i]=>Value[i];

public static A194705Inst Instance=new A194705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194706
{
public static readonly long[] Value={ 11L,3L,8L,2L,3L,6L,1L,3L,2L,5L,1L,1L,2L,3L,4L,0L,1L,1L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194706Inst : IEnumerable<long>
{
public static readonly long[] Value=A194706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194706.Bytes);
public long this[int i]=>Value[i];

public static A194706Inst Instance=new A194706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194707
{
public static readonly long[] Value={ 15L,8L,7L,3L,6L,6L,3L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194707Inst : IEnumerable<long>
{
public static readonly long[] Value=A194707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194707.Bytes);
public long this[int i]=>Value[i];

public static A194707Inst Instance=new A194707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194708
{
public static readonly long[] Value={ 22L,7L,15L,6L,6L,10L,2L,5L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194708Inst : IEnumerable<long>
{
public static readonly long[] Value=A194708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194708.Bytes);
public long this[int i]=>Value[i];

public static A194708Inst Instance=new A194708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194709
{
public static readonly long[] Value={ 30L,15L,15L,6L,10L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194709Inst : IEnumerable<long>
{
public static readonly long[] Value=A194709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194709.Bytes);
public long this[int i]=>Value[i];

public static A194709Inst Instance=new A194709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194710
{
public static readonly long[] Value={ 42L,15L,27L,10L,14L,18L,5L,10L,10L,17L,4L,5L,8L,10L,15L,2L,5L,4L,8L,9L,14L,2L,2L,4L,5L,7L,9L,13L,1L,2L,2L,4L,4L,8L,8L,13L,1L,1L,2L,2L,4L,4L,7L,9L,12L,0L,1L,1L,2L,2L,4L,4L,7L,8L,13L,1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L,0L,1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194710Inst : IEnumerable<long>
{
public static readonly long[] Value=A194710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194710.Bytes);
public long this[int i]=>Value[i];

public static A194710Inst Instance=new A194710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194711
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,3L,1L,0L,1L,5L,1L,1L,0L,1L,7L,2L,1L,1L,0L,1L,11L,2L,2L,1L,1L,0L,1L,15L,4L,2L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194711Inst : IEnumerable<long>
{
public static readonly long[] Value=A194711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194711.Bytes);
public long this[int i]=>Value[i];

public static A194711Inst Instance=new A194711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194712
{
public static readonly long[] Value={ 1L,2L,6L,10L,12L,14L,18L,20L,24L,30L,36L,42L,48L,60L,66L,72L,90L,96L,120L,126L,150L,210L,240L,270L,330L,390L,420L,462L,510L,546L,570L,630L,660L,690L,714L,780L,840L,870L,930L,990L,1050L,1110L,1140L,1170L,1260L,1320L,1470L,1530L,1560L,1680L,1710L,1890L,1950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194712Inst : IEnumerable<long>
{
public static readonly long[] Value=A194712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194712.Bytes);
public long this[int i]=>Value[i];

public static A194712Inst Instance=new A194712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194713
{
public static readonly long[] Value={ 0L,13L,78L,195L,364L,585L,858L,1183L,1560L,1989L,2470L,3003L,3588L,4225L,4914L,5655L,6448L,7293L,8190L,9139L,10140L,11193L,12298L,13455L,14664L,15925L,17238L,18603L,20020L,21489L,23010L,24583L,26208L,27885L,29614L,31395L,33228L,35113L,37050L,39039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194713Inst : IEnumerable<long>
{
public static readonly long[] Value=A194713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194713.Bytes);
public long this[int i]=>Value[i];

public static A194713Inst Instance=new A194713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194714
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,9L,14L,18L,26L,32L,48L,57L,82L,102L,138L,169L,230L,278L,370L,450L,584L,709L,914L,1102L,1400L,1692L,2124L,2555L,3186L,3818L,4720L,5649L,6926L,8269L,10078L,11989L,14526L,17249L,20782L,24603L,29508L,34843L,41600L,49008L,58258L,68468L,81098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194714Inst : IEnumerable<long>
{
public static readonly long[] Value=A194714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194714.Bytes);
public long this[int i]=>Value[i];

public static A194714Inst Instance=new A194714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194715
{
public static readonly long[] Value={ 0L,15L,45L,90L,150L,225L,315L,420L,540L,675L,825L,990L,1170L,1365L,1575L,1800L,2040L,2295L,2565L,2850L,3150L,3465L,3795L,4140L,4500L,4875L,5265L,5670L,6090L,6525L,6975L,7440L,7920L,8415L,8925L,9450L,9990L,10545L,11115L,11700L,12300L,12915L,13545L,14190L,14850L,15525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194715Inst : IEnumerable<long>
{
public static readonly long[] Value=A194715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194715.Bytes);
public long this[int i]=>Value[i];

public static A194715Inst Instance=new A194715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194716
{
public static readonly long[] Value={ 0L,1L,35L,181L,523L,1145L,2131L,3565L,5531L,8113L,11395L,15461L,20395L,26281L,33203L,41245L,50491L,61025L,72931L,86293L,101195L,117721L,135955L,155981L,177883L,201745L,227651L,255685L,285931L,318473L,353395L,390781L,430715L,473281L,518563L,566645L,617611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194716Inst : IEnumerable<long>
{
public static readonly long[] Value=A194716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194716.Bytes);
public long this[int i]=>Value[i];

public static A194716Inst Instance=new A194716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194717
{
public static readonly long[] Value={ 0L,1L,126L,1181L,4966L,14289L,32966L,65821L,118686L,198401L,312814L,470781L,682166L,957841L,1309686L,1750589L,2294446L,2956161L,3751646L,4697821L,5812614L,7114961L,8624806L,10363101L,12351806L,14613889L,17173326L,20055101L,23285206L,26890641L,30899414L,35340541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194717Inst : IEnumerable<long>
{
public static readonly long[] Value=A194717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194717.Bytes);
public long this[int i]=>Value[i];

public static A194717Inst Instance=new A194717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194718
{
public static readonly long[] Value={ 0L,1L,462L,7941L,48838L,185193L,530526L,1265677L,2654646L,5060433L,8960878L,14964501L,23826342L,36463801L,53972478L,77642013L,108971926L,149687457L,201755406L,267399973L,349118598L,449697801L,572229022L,720124461L,897132918L,1107355633L,1355262126L,1645706037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194718Inst : IEnumerable<long>
{
public static readonly long[] Value=A194718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194718.Bytes);
public long this[int i]=>Value[i];

public static A194718Inst Instance=new A194718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194719
{
public static readonly long[] Value={ 0L,1L,1716L,54573L,492724L,2467137L,8786436L,25066621L,61189668L,133071009L,264735892L,490704621L,858686676L,1432583713L,2295801444L,3554870397L,5343375556L,7826194881L,11204046708L,15718346029L,21656369652L,29356730241L,39215159236L,51690598653L,67311601764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194719Inst : IEnumerable<long>
{
public static readonly long[] Value=A194719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194719.Bytes);
public long this[int i]=>Value[i];

public static A194719Inst Instance=new A194719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194720
{
public static readonly long[] Value={ 0L,1L,6435L,381333L,5068915L,33563481L,148733571L,507709165L,1443039123L,3581326065L,8006545891L,16475259141L,31690921395L,57644499913L,100028603715L,166732334301L,268424064211L,419229350625L,637511191203L,946759829365L,1376599316211L,1963918036281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194720Inst : IEnumerable<long>
{
public static readonly long[] Value=A194720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194720.Bytes);
public long this[int i]=>Value[i];

public static A194720Inst Instance=new A194720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194721
{
public static readonly long[] Value={ 0L,1L,24310L,2699837L,52955950L,464221105L,2561439806L,10466643805L,34648845862L,98156060225L,246643289830L,563506356061L,1191627482750L,2363434581937L,4441172224750L,7969478316605L,13742556531766L,22888430598145L,36972962559062L,58126513174525L,89196318660430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194721Inst : IEnumerable<long>
{
public static readonly long[] Value=A194721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194721.Bytes);
public long this[int i]=>Value[i];

public static A194721Inst Instance=new A194721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194722
{
public static readonly long[] Value={ 0L,1L,92378L,19319845L,560198962L,6507351113L,44731364266L,218878998733L,844131474530L,2730108129937L,7711583225338L,19564269083381L,45486599105938L,98378219490265L,200201768681162L,386776488742813L,714420272913346L,1268930908616993L,2177477525153050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194722Inst : IEnumerable<long>
{
public static readonly long[] Value=A194722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194722.Bytes);
public long this[int i]=>Value[i];

public static A194722Inst Instance=new A194722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194723
{
public static readonly long[] Value={ 1L,1L,5L,29L,181L,1181L,7941L,54573L,381333L,2699837L,19319845L,139480397L,1014536117L,7426790749L,54669443141L,404388938349L,3004139083221L,22402851226749L,167640057210981L,1258340276153229L,9471952718661621L,71481616200910749L,540715584181142661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194723Inst : IEnumerable<long>
{
public static readonly long[] Value=A194723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194723.Bytes);
public long this[int i]=>Value[i];

public static A194723Inst Instance=new A194723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194724
{
public static readonly BigInteger[] Value={ 1L,1L,7L,58L,523L,4966L,48838L,492724L,5068915L,52955950L,560198962L,5987822380L,64563867454L,701383563388L,7668869344108L,84326618668648L,931894610845123L,10344218506421758L,115280448164645818L,1289346114476360188L,14467472108268263818UL,BigInteger.Parse("162816535672067515828") };
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
public class A194724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194724Inst Instance=new A194724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194725
{
public static readonly BigInteger[] Value={ 1L,1L,9L,97L,1145L,14289L,185193L,2467137L,33563481L,464221105L,6507351113L,92236247841L,1319640776249L,19031570387857L,276368559434025L,4037555902072065L,59299855337012505L,875056238174271345L,12967283824008178185UL,BigInteger.Parse("192889769468751321825"),BigInteger.Parse("2879117809973276680185") };
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
public class A194725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194725Inst Instance=new A194725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194726
{
public static readonly BigInteger[] Value={ 1L,1L,11L,146L,2131L,32966L,530526L,8786436L,148733571L,2561439806L,44731364266L,790211926076L,14095578557486L,253519929631996L,4592415708939356L,83709533881191816L,1534227271236577251L,BigInteger.Parse("28256420350942562286"),BigInteger.Parse("522675506718404898546"),BigInteger.Parse("9706083027629177910156") };
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
public class A194726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194726Inst Instance=new A194726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194727
{
public static readonly BigInteger[] Value={ 1L,1L,13L,205L,3565L,65821L,1265677L,25066621L,507709165L,10466643805L,218878998733L,4631531585341L,98980721277613L,2133274258946845L,46313701181477005L,1011889827742935805L,BigInteger.Parse("22232378278653590125"),BigInteger.Parse("490899296804667191005"),BigInteger.Parse("10887346288742800406605") };
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
public class A194727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194727Inst Instance=new A194727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194728
{
public static readonly BigInteger[] Value={ 1L,1L,15L,274L,5531L,118686L,2654646L,61189668L,1443039123L,34648845862L,844131474530L,20813234394492L,518373091849502L,13021801045587244L,329543346098061516L,8393705745623980104L,BigInteger.Parse("215009056951891319811"),BigInteger.Parse("5535306699430995140214"),BigInteger.Parse("143144289829339089562986") };
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
public class A194728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194728Inst Instance=new A194728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194729
{
public static readonly BigInteger[] Value={ 1L,1L,17L,353L,8113L,198401L,5060433L,133071009L,3581326065L,98156060225L,2730108129937L,76862217117665L,2186096427128369L,62718004238927233L,1812849590253944273L,BigInteger.Parse("52742324721313632033"),BigInteger.Parse("1543272031837984426353"),BigInteger.Parse("45386639860532255882433"),BigInteger.Parse("1340844916965007902013713") };
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
public class A194729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194729.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194729Inst Instance=new A194729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194730
{
public static readonly BigInteger[] Value={ 1L,1L,19L,442L,11395L,312814L,8960878L,264735892L,8006545891L,246643289830L,7711583225338L,244082045341036L,7805301802531534L,251791585570781452L,8183989442287618300L,BigInteger.Parse("267755464909548758440"),BigInteger.Parse("8810802978165549384355"),BigInteger.Parse("291414010749705281701270") };
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
public class A194730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194730Inst Instance=new A194730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194731
{
public static readonly long[] Value={ 1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L,6L,7L,5L,9L,1L,8L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194731Inst : IEnumerable<long>
{
public static readonly long[] Value=A194731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194731.Bytes);
public long this[int i]=>Value[i];

public static A194731Inst Instance=new A194731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194732
{
public static readonly long[] Value={ 1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L,3L,6L,5L,0L,1L,8L,1L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194732Inst : IEnumerable<long>
{
public static readonly long[] Value=A194732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194732.Bytes);
public long this[int i]=>Value[i];

public static A194732Inst Instance=new A194732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194733
{
public static readonly long[] Value={ 0L,1L,0L,2L,4L,1L,4L,0L,4L,8L,2L,7L,12L,4L,10L,1L,8L,15L,4L,12L,0L,9L,18L,4L,14L,24L,8L,19L,2L,14L,26L,7L,20L,33L,12L,26L,4L,19L,34L,10L,26L,1L,18L,35L,8L,26L,44L,15L,34L,4L,24L,44L,12L,33L,0L,22L,44L,9L,32L,55L,18L,42L,4L,29L,54L,14L,40L,66L,24L,51L,8L,36L,64L,19L,48L,2L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194733Inst : IEnumerable<long>
{
public static readonly long[] Value=A194733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194733.Bytes);
public long this[int i]=>Value[i];

public static A194733Inst Instance=new A194733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194734
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,4L,2L,7L,4L,1L,8L,4L,0L,9L,4L,14L,8L,2L,14L,7L,20L,12L,4L,19L,10L,1L,18L,8L,26L,15L,4L,24L,12L,0L,22L,9L,32L,18L,4L,29L,14L,40L,24L,8L,36L,19L,2L,32L,14L,45L,26L,7L,40L,20L,54L,33L,12L,48L,26L,4L,42L,19L,58L,34L,10L,51L,26L,1L,44L,18L,62L,35L,8L,54L,26L,73L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194734Inst : IEnumerable<long>
{
public static readonly long[] Value=A194734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194734.Bytes);
public long this[int i]=>Value[i];

public static A194734Inst Instance=new A194734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194735
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,2L,0L,5L,2L,8L,4L,0L,8L,3L,12L,6L,16L,9L,2L,14L,6L,19L,10L,1L,16L,6L,22L,11L,28L,16L,4L,23L,10L,30L,16L,2L,24L,9L,32L,16L,0L,25L,8L,34L,16L,43L,24L,5L,34L,14L,44L,23L,2L,34L,12L,45L,22L,56L,32L,8L,44L,19L,56L,30L,4L,43L,16L,56L,28L,0L,42L,13L,56L,26L,70L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194735Inst : IEnumerable<long>
{
public static readonly long[] Value=A194735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194735.Bytes);
public long this[int i]=>Value[i];

public static A194735Inst Instance=new A194735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194736
{
public static readonly long[] Value={ 1L,1L,3L,2L,5L,3L,1L,6L,3L,9L,5L,1L,9L,4L,13L,7L,17L,10L,3L,15L,7L,20L,11L,2L,17L,7L,23L,12L,29L,17L,5L,24L,11L,31L,17L,3L,25L,10L,33L,17L,1L,26L,9L,35L,17L,44L,25L,6L,35L,15L,45L,24L,3L,35L,13L,46L,23L,57L,33L,9L,45L,20L,57L,31L,5L,44L,17L,57L,29L,1L,43L,14L,57L,27L,71L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194736Inst : IEnumerable<long>
{
public static readonly long[] Value=A194736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194736.Bytes);
public long this[int i]=>Value[i];

public static A194736Inst Instance=new A194736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194737
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,3L,6L,2L,6L,1L,6L,11L,4L,10L,2L,9L,0L,8L,16L,5L,14L,2L,12L,22L,8L,19L,4L,16L,0L,13L,26L,8L,22L,3L,18L,33L,12L,28L,6L,23L,40L,16L,34L,9L,28L,2L,22L,42L,14L,35L,6L,28L,50L,19L,42L,10L,34L,1L,26L,51L,16L,42L,6L,33L,60L,22L,50L,11L,40L,69L,28L,58L,16L,47L,4L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194737Inst : IEnumerable<long>
{
public static readonly long[] Value=A194737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194737.Bytes);
public long this[int i]=>Value[i];

public static A194737Inst Instance=new A194737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194738
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,1L,7L,5L,3L,1L,10L,7L,4L,15L,11L,7L,3L,17L,12L,7L,2L,19L,13L,7L,1L,21L,14L,7L,29L,21L,13L,5L,30L,21L,12L,3L,31L,21L,11L,1L,32L,21L,10L,43L,31L,19L,7L,43L,30L,17L,4L,43L,29L,15L,56L,41L,26L,11L,55L,39L,23L,7L,54L,37L,20L,3L,53L,35L,17L,69L,50L,31L,12L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194738Inst : IEnumerable<long>
{
public static readonly long[] Value=A194738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194738.Bytes);
public long this[int i]=>Value[i];

public static A194738Inst Instance=new A194738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194739
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,4L,6L,1L,4L,7L,10L,2L,6L,10L,0L,5L,10L,15L,2L,8L,14L,20L,4L,11L,18L,25L,6L,14L,22L,1L,10L,19L,28L,4L,14L,24L,34L,7L,18L,29L,40L,10L,22L,34L,2L,15L,28L,41L,6L,20L,34L,48L,10L,25L,40L,0L,16L,32L,48L,5L,22L,39L,56L,10L,28L,46L,64L,15L,34L,53L,2L,22L,42L,62L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194739Inst : IEnumerable<long>
{
public static readonly long[] Value=A194739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194739.Bytes);
public long this[int i]=>Value[i];

public static A194739Inst Instance=new A194739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194740
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,5L,7L,2L,5L,8L,11L,3L,7L,11L,1L,6L,11L,16L,3L,9L,15L,21L,5L,12L,19L,26L,7L,15L,23L,2L,11L,20L,29L,5L,15L,25L,35L,8L,19L,30L,41L,11L,23L,35L,3L,16L,29L,42L,7L,21L,35L,49L,11L,26L,41L,1L,17L,33L,49L,6L,23L,40L,57L,11L,29L,47L,65L,16L,35L,54L,3L,23L,43L,63L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194740Inst : IEnumerable<long>
{
public static readonly long[] Value=A194740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194740.Bytes);
public long this[int i]=>Value[i];

public static A194740Inst Instance=new A194740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194741
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,1L,0L,6L,4L,2L,0L,9L,6L,3L,14L,10L,6L,2L,16L,11L,6L,1L,18L,12L,6L,0L,20L,13L,6L,28L,20L,12L,4L,29L,20L,11L,2L,30L,20L,10L,0L,31L,20L,9L,42L,30L,18L,6L,42L,29L,16L,3L,42L,28L,14L,55L,40L,25L,10L,54L,38L,22L,6L,53L,36L,19L,2L,52L,34L,16L,68L,49L,30L,11L,66L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194741Inst : IEnumerable<long>
{
public static readonly long[] Value=A194741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194741.Bytes);
public long this[int i]=>Value[i];

public static A194741Inst Instance=new A194741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194742
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,3L,5L,7L,1L,4L,7L,10L,1L,5L,9L,13L,1L,6L,11L,16L,21L,5L,11L,17L,23L,4L,11L,18L,25L,3L,11L,19L,27L,2L,11L,20L,29L,38L,9L,19L,29L,39L,7L,18L,29L,40L,5L,17L,29L,41L,3L,16L,29L,42L,55L,13L,27L,41L,55L,10L,25L,40L,55L,7L,23L,39L,55L,4L,21L,38L,55L,72L,17L,35L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194742Inst : IEnumerable<long>
{
public static readonly long[] Value=A194742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194742.Bytes);
public long this[int i]=>Value[i];

public static A194742Inst Instance=new A194742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194743
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,3L,2L,1L,8L,6L,4L,2L,12L,9L,6L,3L,16L,12L,8L,4L,0L,17L,12L,7L,2L,22L,16L,10L,4L,27L,20L,13L,6L,32L,24L,16L,8L,0L,30L,21L,12L,3L,36L,26L,16L,6L,42L,31L,20L,9L,48L,36L,24L,12L,0L,43L,30L,17L,4L,50L,36L,22L,8L,57L,42L,27L,12L,64L,48L,32L,16L,0L,56L,39L,22L,5L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194743Inst : IEnumerable<long>
{
public static readonly long[] Value=A194743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194743.Bytes);
public long this[int i]=>Value[i];

public static A194743Inst Instance=new A194743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194744
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,4L,3L,2L,9L,7L,5L,3L,13L,10L,7L,4L,17L,13L,9L,5L,1L,18L,13L,8L,3L,23L,17L,11L,5L,28L,21L,14L,7L,33L,25L,17L,9L,1L,31L,22L,13L,4L,37L,27L,17L,7L,43L,32L,21L,10L,49L,37L,25L,13L,1L,44L,31L,18L,5L,51L,37L,23L,9L,58L,43L,28L,13L,65L,49L,33L,17L,1L,57L,40L,23L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194744Inst : IEnumerable<long>
{
public static readonly long[] Value=A194744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194744.Bytes);
public long this[int i]=>Value[i];

public static A194744Inst Instance=new A194744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194745
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,2L,4L,6L,0L,3L,6L,9L,0L,4L,8L,12L,0L,5L,10L,15L,20L,4L,10L,16L,22L,3L,10L,17L,24L,2L,10L,18L,26L,1L,10L,19L,28L,37L,8L,18L,28L,38L,6L,17L,28L,39L,4L,16L,28L,40L,2L,15L,28L,41L,54L,12L,26L,40L,54L,9L,24L,39L,54L,6L,22L,38L,54L,3L,20L,37L,54L,71L,16L,34L,52L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194745Inst : IEnumerable<long>
{
public static readonly long[] Value=A194745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194745.Bytes);
public long this[int i]=>Value[i];

public static A194745Inst Instance=new A194745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194746
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,11L,5L,11L,4L,11L,3L,11L,2L,11L,20L,9L,19L,7L,18L,5L,17L,3L,16L,1L,15L,29L,12L,27L,9L,25L,6L,23L,3L,21L,39L,17L,36L,13L,33L,9L,30L,5L,27L,1L,24L,47L,19L,43L,14L,39L,9L,35L,4L,31L,58L,25L,53L,19L,48L,13L,43L,7L,38L,1L,33L,65L,26L,59L,19L,53L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194746Inst : IEnumerable<long>
{
public static readonly long[] Value=A194746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194746.Bytes);
public long this[int i]=>Value[i];

public static A194746Inst Instance=new A194746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194747
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,2L,6L,3L,8L,4L,0L,7L,2L,10L,4L,13L,6L,16L,8L,0L,12L,3L,16L,6L,20L,9L,24L,12L,28L,15L,2L,20L,6L,25L,10L,30L,14L,35L,18L,1L,24L,6L,30L,11L,36L,16L,42L,21L,48L,26L,4L,33L,10L,40L,16L,47L,22L,54L,28L,2L,36L,9L,44L,16L,52L,23L,60L,30L,68L,37L,6L,46L,14L,55L,22L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194747Inst : IEnumerable<long>
{
public static readonly long[] Value=A194747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194747.Bytes);
public long this[int i]=>Value[i];

public static A194747Inst Instance=new A194747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194748
{
public static readonly long[] Value={ 1L,1L,3L,2L,5L,3L,7L,4L,9L,5L,1L,8L,3L,11L,5L,14L,7L,17L,9L,1L,13L,4L,17L,7L,21L,10L,25L,13L,29L,16L,3L,21L,7L,26L,11L,31L,15L,36L,19L,2L,25L,7L,31L,12L,37L,17L,43L,22L,49L,27L,5L,34L,11L,41L,17L,48L,23L,55L,29L,3L,37L,10L,45L,17L,53L,24L,61L,31L,69L,38L,7L,47L,15L,56L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194748Inst : IEnumerable<long>
{
public static readonly long[] Value=A194748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194748.Bytes);
public long this[int i]=>Value[i];

public static A194748Inst Instance=new A194748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194749
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,3L,0L,4L,0L,5L,10L,4L,10L,3L,10L,2L,10L,1L,10L,19L,8L,18L,6L,17L,4L,16L,2L,15L,0L,14L,28L,11L,26L,8L,24L,5L,22L,2L,20L,38L,16L,35L,12L,32L,8L,29L,4L,26L,0L,23L,46L,18L,42L,13L,38L,8L,34L,3L,30L,57L,24L,52L,18L,47L,12L,42L,6L,37L,0L,32L,64L,25L,58L,18L,52L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194749Inst : IEnumerable<long>
{
public static readonly long[] Value=A194749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194749.Bytes);
public long this[int i]=>Value[i];

public static A194749Inst Instance=new A194749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194750
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,1L,7L,5L,3L,11L,8L,5L,2L,13L,9L,5L,18L,13L,8L,3L,19L,13L,7L,25L,18L,11L,4L,25L,17L,9L,32L,23L,14L,5L,31L,21L,11L,1L,30L,19L,8L,39L,27L,15L,3L,37L,24L,11L,47L,33L,19L,5L,44L,29L,14L,55L,39L,23L,7L,51L,34L,17L,63L,45L,27L,9L,58L,39L,20L,71L,51L,31L,11L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194750Inst : IEnumerable<long>
{
public static readonly long[] Value=A194750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194750.Bytes);
public long this[int i]=>Value[i];

public static A194750Inst Instance=new A194750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194751
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,4L,6L,1L,4L,7L,0L,4L,8L,12L,2L,7L,12L,0L,6L,12L,18L,3L,10L,17L,0L,8L,16L,24L,4L,13L,22L,0L,10L,20L,30L,5L,16L,27L,38L,10L,22L,34L,4L,17L,30L,43L,10L,24L,38L,3L,18L,33L,48L,10L,26L,42L,2L,19L,36L,53L,10L,28L,46L,1L,20L,39L,58L,10L,30L,50L,0L,21L,42L,63L,10L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194751Inst : IEnumerable<long>
{
public static readonly long[] Value=A194751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194751.Bytes);
public long this[int i]=>Value[i];

public static A194751Inst Instance=new A194751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194752
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,5L,7L,2L,5L,8L,1L,5L,9L,13L,3L,8L,13L,1L,7L,13L,19L,4L,11L,18L,1L,9L,17L,25L,5L,14L,23L,1L,11L,21L,31L,6L,17L,28L,39L,11L,23L,35L,5L,18L,31L,44L,11L,25L,39L,4L,19L,34L,49L,11L,27L,43L,3L,20L,37L,54L,11L,29L,47L,2L,21L,40L,59L,11L,31L,51L,1L,22L,43L,64L,11L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194752Inst : IEnumerable<long>
{
public static readonly long[] Value=A194752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194752.Bytes);
public long this[int i]=>Value[i];

public static A194752Inst Instance=new A194752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194753
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,1L,0L,6L,4L,2L,10L,7L,4L,1L,12L,8L,4L,17L,12L,7L,2L,18L,12L,6L,24L,17L,10L,3L,24L,16L,8L,31L,22L,13L,4L,30L,20L,10L,0L,29L,18L,7L,38L,26L,14L,2L,36L,23L,10L,46L,32L,18L,4L,43L,28L,13L,54L,38L,22L,6L,50L,33L,16L,62L,44L,26L,8L,57L,38L,19L,70L,50L,30L,10L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194753Inst : IEnumerable<long>
{
public static readonly long[] Value=A194753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194753.Bytes);
public long this[int i]=>Value[i];

public static A194753Inst Instance=new A194753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194754
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,1L,3L,5L,7L,9L,11L,13L,1L,4L,7L,10L,13L,16L,19L,1L,5L,9L,13L,17L,21L,25L,1L,6L,11L,16L,21L,26L,31L,1L,7L,13L,19L,25L,31L,37L,1L,8L,15L,22L,29L,36L,43L,1L,9L,17L,25L,33L,41L,49L,1L,10L,19L,28L,37L,46L,55L,1L,11L,21L,31L,41L,51L,61L,1L,12L,23L,34L,45L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194754Inst : IEnumerable<long>
{
public static readonly long[] Value=A194754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194754.Bytes);
public long this[int i]=>Value[i];

public static A194754Inst Instance=new A194754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194755
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,7L,6L,5L,4L,3L,2L,1L,14L,12L,10L,8L,6L,4L,2L,21L,18L,15L,12L,9L,6L,3L,28L,24L,20L,16L,12L,8L,4L,35L,30L,25L,20L,15L,10L,5L,42L,36L,30L,24L,18L,12L,6L,49L,42L,35L,28L,21L,14L,7L,56L,48L,40L,32L,24L,16L,8L,63L,54L,45L,36L,27L,18L,9L,70L,60L,50L,40L,30L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194755Inst : IEnumerable<long>
{
public static readonly long[] Value=A194755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194755.Bytes);
public long this[int i]=>Value[i];

public static A194755Inst Instance=new A194755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194756
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,8L,7L,6L,5L,4L,3L,2L,15L,13L,11L,9L,7L,5L,3L,22L,19L,16L,13L,10L,7L,4L,29L,25L,21L,17L,13L,9L,5L,36L,31L,26L,21L,16L,11L,6L,43L,37L,31L,25L,19L,13L,7L,50L,43L,36L,29L,22L,15L,8L,57L,49L,41L,33L,25L,17L,9L,64L,55L,46L,37L,28L,19L,10L,71L,61L,51L,41L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194756Inst : IEnumerable<long>
{
public static readonly long[] Value=A194756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194756.Bytes);
public long this[int i]=>Value[i];

public static A194756Inst Instance=new A194756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194757
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,0L,2L,4L,6L,8L,10L,12L,0L,3L,6L,9L,12L,15L,18L,0L,4L,8L,12L,16L,20L,24L,0L,5L,10L,15L,20L,25L,30L,0L,6L,12L,18L,24L,30L,36L,0L,7L,14L,21L,28L,35L,42L,0L,8L,16L,24L,32L,40L,48L,0L,9L,18L,27L,36L,45L,54L,0L,10L,20L,30L,40L,50L,60L,0L,11L,22L,33L,44L,55L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194757Inst : IEnumerable<long>
{
public static readonly long[] Value=A194757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194757.Bytes);
public long this[int i]=>Value[i];

public static A194757Inst Instance=new A194757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194758
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,7L,5L,3L,10L,7L,4L,1L,11L,7L,3L,15L,10L,5L,19L,13L,7L,23L,16L,9L,2L,21L,13L,5L,26L,17L,8L,31L,21L,11L,36L,25L,14L,3L,31L,19L,7L,37L,24L,11L,43L,29L,15L,49L,34L,19L,4L,41L,25L,9L,48L,31L,14L,55L,37L,19L,62L,43L,24L,5L,51L,31L,11L,59L,38L,17L,67L,45L,23L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194758Inst : IEnumerable<long>
{
public static readonly long[] Value=A194758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194758.Bytes);
public long this[int i]=>Value[i];

public static A194758Inst Instance=new A194758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194759
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,4L,0L,3L,6L,0L,4L,8L,12L,3L,8L,13L,2L,8L,14L,1L,8L,15L,0L,8L,16L,24L,6L,15L,24L,4L,14L,24L,2L,13L,24L,0L,12L,24L,36L,9L,22L,35L,6L,20L,34L,3L,18L,33L,0L,16L,32L,48L,12L,29L,46L,8L,26L,44L,4L,23L,42L,0L,20L,40L,60L,15L,36L,57L,10L,32L,54L,5L,28L,51L,0L,24L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194759Inst : IEnumerable<long>
{
public static readonly long[] Value=A194759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194759.Bytes);
public long this[int i]=>Value[i];

public static A194759Inst Instance=new A194759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194760
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,5L,1L,4L,7L,1L,5L,9L,13L,4L,9L,14L,3L,9L,15L,2L,9L,16L,1L,9L,17L,25L,7L,16L,25L,5L,15L,25L,3L,14L,25L,1L,13L,25L,37L,10L,23L,36L,7L,21L,35L,4L,19L,34L,1L,17L,33L,49L,13L,30L,47L,9L,27L,45L,5L,24L,43L,1L,21L,41L,61L,16L,37L,58L,11L,33L,55L,6L,29L,52L,1L,25L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194760Inst : IEnumerable<long>
{
public static readonly long[] Value=A194760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194760.Bytes);
public long this[int i]=>Value[i];

public static A194760Inst Instance=new A194760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194761
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,1L,6L,4L,2L,9L,6L,3L,0L,10L,6L,2L,14L,9L,4L,18L,12L,6L,22L,15L,8L,1L,20L,12L,4L,25L,16L,7L,30L,20L,10L,35L,24L,13L,2L,30L,18L,6L,36L,23L,10L,42L,28L,14L,48L,33L,18L,3L,40L,24L,8L,47L,30L,13L,54L,36L,18L,61L,42L,23L,4L,50L,30L,10L,58L,37L,16L,66L,44L,22L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194761Inst : IEnumerable<long>
{
public static readonly long[] Value=A194761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194761.Bytes);
public long this[int i]=>Value[i];

public static A194761Inst Instance=new A194761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194762
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,5L,7L,2L,5L,8L,11L,3L,7L,11L,15L,4L,9L,14L,19L,5L,11L,17L,23L,6L,13L,20L,1L,9L,17L,25L,3L,12L,21L,30L,5L,15L,25L,35L,7L,18L,29L,40L,9L,21L,33L,45L,11L,24L,37L,50L,13L,27L,41L,2L,17L,32L,47L,5L,21L,37L,53L,8L,25L,42L,59L,11L,29L,47L,65L,14L,33L,52L,71L,17L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194762Inst : IEnumerable<long>
{
public static readonly long[] Value=A194762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194762.Bytes);
public long this[int i]=>Value[i];

public static A194762Inst Instance=new A194762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194763
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,1L,0L,6L,4L,2L,0L,9L,6L,3L,0L,12L,8L,4L,0L,15L,10L,5L,0L,18L,12L,6L,26L,19L,12L,5L,28L,20L,12L,4L,30L,21L,12L,3L,32L,22L,12L,2L,34L,23L,12L,1L,36L,24L,12L,0L,38L,25L,12L,52L,38L,24L,10L,53L,38L,23L,8L,54L,38L,22L,6L,55L,38L,21L,4L,56L,38L,20L,2L,57L,38L,19L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194763Inst : IEnumerable<long>
{
public static readonly long[] Value=A194763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194763.Bytes);
public long this[int i]=>Value[i];

public static A194763Inst Instance=new A194763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194764
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,2L,1L,7L,5L,3L,1L,10L,7L,4L,1L,13L,9L,5L,1L,16L,11L,6L,1L,19L,13L,7L,27L,20L,13L,6L,29L,21L,13L,5L,31L,22L,13L,4L,33L,23L,13L,3L,35L,24L,13L,2L,37L,25L,13L,1L,39L,26L,13L,53L,39L,25L,11L,54L,39L,24L,9L,55L,39L,23L,7L,56L,39L,22L,5L,57L,39L,21L,3L,58L,39L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194764Inst : IEnumerable<long>
{
public static readonly long[] Value=A194764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194764.Bytes);
public long this[int i]=>Value[i];

public static A194764Inst Instance=new A194764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194765
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,4L,6L,1L,4L,7L,10L,2L,6L,10L,14L,3L,8L,13L,18L,4L,10L,16L,22L,5L,12L,19L,0L,8L,16L,24L,2L,11L,20L,29L,4L,14L,24L,34L,6L,17L,28L,39L,8L,20L,32L,44L,10L,23L,36L,49L,12L,26L,40L,1L,16L,31L,46L,4L,20L,36L,52L,7L,24L,41L,58L,10L,28L,46L,64L,13L,32L,51L,70L,16L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194765Inst : IEnumerable<long>
{
public static readonly long[] Value=A194765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194765.Bytes);
public long this[int i]=>Value[i];

public static A194765Inst Instance=new A194765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194766
{
public static readonly long[] Value={ 128L,175L,384L,672L,735L,1296L,6144L,18432L,23328L,34992L,82944L,442368L,1492992L,2333772L,2612736L,3981312L,4128768L,9289728L,12192768L,13226976L,13395375L,13436928L,21233664L,22127616L,27869184L,49787136L,161243136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194766Inst : IEnumerable<long>
{
public static readonly long[] Value=A194766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194766.Bytes);
public long this[int i]=>Value[i];

public static A194766Inst Instance=new A194766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194767
{
public static readonly long[] Value={ 2L,2L,12L,20L,10L,42L,56L,24L,90L,110L,44L,156L,182L,70L,240L,272L,102L,342L,380L,140L,462L,506L,184L,600L,650L,234L,756L,812L,290L,930L,992L,352L,1122L,1190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194767Inst : IEnumerable<long>
{
public static readonly long[] Value=A194767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194767.Bytes);
public long this[int i]=>Value[i];

public static A194767Inst Instance=new A194767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194768
{
public static readonly long[] Value={ 1L,32L,33L,243L,244L,275L,276L,1024L,1025L,1056L,1057L,1267L,1268L,1299L,1300L,3125L,3126L,3157L,3158L,3368L,3369L,3400L,3401L,4149L,4150L,4181L,4182L,4392L,4393L,4424L,4425L,7776L,7777L,7808L,7809L,8019L,8020L,8051L,8052L,8800L,8801L,8832L,8833L,9043L,9044L,9075L,9076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194768Inst : IEnumerable<long>
{
public static readonly long[] Value=A194768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194768.Bytes);
public long this[int i]=>Value[i];

public static A194768Inst Instance=new A194768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194769
{
public static readonly long[] Value={ 1L,64L,65L,729L,730L,793L,794L,4096L,4097L,4160L,4161L,4825L,4826L,4889L,4890L,15625L,15626L,15689L,15690L,16354L,16355L,16418L,16419L,19721L,19722L,19785L,19786L,20450L,20451L,20514L,20515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194769Inst : IEnumerable<long>
{
public static readonly long[] Value=A194769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194769.Bytes);
public long this[int i]=>Value[i];

public static A194769Inst Instance=new A194769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194770
{
public static readonly BigInteger[] Value={ 1L,-1L,0L,6L,-24L,0L,720L,-5040L,0L,362880L,-3628800L,0L,479001600L,-6227020800L,0L,1307674368000L,-20922789888000L,0L,6402373705728000L,-121645100408832000L,0L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("-1124000727777607680000") };
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
public class A194770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194770Inst Instance=new A194770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194771
{
public static readonly long[] Value={ 2L,12L,56L,240L,992L,1344L,16256L,60480L,65520L,1047552L,4357080L,47139840L,67100672L,91065600L,285981696L,919636480L,2758909440L,2952609792L,17179738112L,28364878080L,63996791040L,87722956800L,102002360320L,132867440640L,137438691328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194771Inst : IEnumerable<long>
{
public static readonly long[] Value=A194771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194771.Bytes);
public long this[int i]=>Value[i];

public static A194771Inst Instance=new A194771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194772
{
public static readonly long[] Value={ 7L,17L,41L,95L,219L,493L,1101L,2427L,5311L,11529L,24881L,53399L,114083L,242725L,514581L,1087411L,2291335L,4815681L,10097401L,21126863L,44117867L,91963997L,191384541L,397682155L,825190479L,1710033273L,3539371201L,7317351687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194772Inst : IEnumerable<long>
{
public static readonly long[] Value=A194772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194772.Bytes);
public long this[int i]=>Value[i];

public static A194772Inst Instance=new A194772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194773
{
public static readonly long[] Value={ 43L,105L,265L,655L,1641L,4069L,10121L,25025L,61809L,152019L,372979L,912017L,2224175L,5408825L,13120905L,31752431L,76673045L,184762437L,444388957L,1066954113L,2557518625L,6121119363L,14629468735L,34918297649L,83242029523L,198212839881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194773Inst : IEnumerable<long>
{
public static readonly long[] Value=A194773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194773.Bytes);
public long this[int i]=>Value[i];

public static A194773Inst Instance=new A194773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194774
{
public static readonly long[] Value={ 268L,672L,1736L,4464L,11686L,30608L,80961L,214469L,570921L,1521287L,4061881L,10847647L,28982750L,77406210L,206655490L,551301206L,1469565060L,3913609398L,10412354243L,27674510615L,73480819187L,194908131709L,516485443463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194774Inst : IEnumerable<long>
{
public static readonly long[] Value=A194774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194774.Bytes);
public long this[int i]=>Value[i];

public static A194774Inst Instance=new A194774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194775
{
public static readonly long[] Value={ 1740L,4490L,11857L,31429L,84727L,229869L,631373L,1745459L,4867831L,13649561L,38503606L,109050858L,310061698L,883972100L,2526165997L,7230962925L,20725462609L,59454601239L,170659921683L,490024454069L,1407237659011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194775Inst : IEnumerable<long>
{
public static readonly long[] Value=A194775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194775.Bytes);
public long this[int i]=>Value[i];

public static A194775Inst Instance=new A194775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194776
{
public static readonly long[] Value={ 11862L,31466L,85007L,231395L,639325L,1782111L,5029741L,14321783L,41203606L,119499674L,349498634L,1029170664L,3050715488L,9092629968L,27237137985L,81930133845L,247359353107L,749090477957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194776Inst : IEnumerable<long>
{
public static readonly long[] Value=A194776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194776.Bytes);
public long this[int i]=>Value[i];

public static A194776Inst Instance=new A194776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194777
{
public static readonly long[] Value={ 85013L,231445L,639753L,1784723L,5044981L,14399939L,41587186L,121261490L,357312638L,1062459348L,3188769448L,9649809740L,29439886715L,90469050263L,279932030931L,871510145365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194777Inst : IEnumerable<long>
{
public static readonly long[] Value=A194777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194777.Bytes);
public long this[int i]=>Value[i];

public static A194777Inst Instance=new A194777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194778
{
public static readonly long[] Value={ 1L,7L,3L,43L,17L,6L,268L,105L,41L,12L,1740L,672L,265L,95L,23L,11862L,4490L,1736L,655L,219L,43L,85013L,31466L,11857L,4464L,1641L,493L,79L,639760L,231445L,85007L,31429L,11686L,4069L,1101L,143L,5045610L,1784788L,639753L,231395L,84727L,30608L,10121L,2427L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194778Inst : IEnumerable<long>
{
public static readonly long[] Value=A194778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194778.Bytes);
public long this[int i]=>Value[i];

public static A194778Inst Instance=new A194778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194779
{
public static readonly long[] Value={ 1L,7L,43L,268L,1740L,11862L,85013L,639760L,5045610L,41615165L,358185399L,3210667490L,29914284833L,289187621900L,2895861006415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194779Inst : IEnumerable<long>
{
public static readonly long[] Value=A194779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194779.Bytes);
public long this[int i]=>Value[i];

public static A194779Inst Instance=new A194779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194780
{
public static readonly long[] Value={ 3L,17L,105L,672L,4490L,31466L,231445L,1784788L,14404218L,121421075L,1066906979L,9753108510L,92586250999L,911156724048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194780Inst : IEnumerable<long>
{
public static readonly long[] Value=A194780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194780.Bytes);
public long this[int i]=>Value[i];

public static A194780Inst Instance=new A194780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194781
{
public static readonly long[] Value={ 6L,41L,265L,1736L,11857L,85007L,639753L,5045602L,41615156L,358185389L,3210667479L,29914284821L,289187621887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194781Inst : IEnumerable<long>
{
public static readonly long[] Value=A194781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194781.Bytes);
public long this[int i]=>Value[i];

public static A194781Inst Instance=new A194781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194782
{
public static readonly long[] Value={ 12L,95L,655L,4464L,31429L,231395L,1784723L,14404136L,121420974L,1066906857L,9753108365L,92586250829L,911156723851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194782Inst : IEnumerable<long>
{
public static readonly long[] Value=A194782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194782.Bytes);
public long this[int i]=>Value[i];

public static A194782Inst Instance=new A194782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194783
{
public static readonly long[] Value={ 23L,219L,1641L,11686L,84727L,639325L,5044981L,41614291L,358184223L,3210665949L,29914282858L,289187619416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194783Inst : IEnumerable<long>
{
public static readonly long[] Value=A194783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194783.Bytes);
public long this[int i]=>Value[i];

public static A194783Inst Instance=new A194783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194784
{
public static readonly long[] Value={ 43L,493L,4069L,30608L,229869L,1782111L,14399939L,121414559L,1066897441L,9753094999L,92586232382L,911156698994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194784Inst : IEnumerable<long>
{
public static readonly long[] Value=A194784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194784.Bytes);
public long this[int i]=>Value[i];

public static A194784Inst Instance=new A194784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194785
{
public static readonly long[] Value={ 79L,1101L,10121L,80961L,631373L,5029741L,41587186L,358138793L,3210593393L,29914171526L,289187454251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194785Inst : IEnumerable<long>
{
public static readonly long[] Value=A194785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194785.Bytes);
public long this[int i]=>Value[i];

public static A194785Inst Instance=new A194785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194786
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,108L,1360L,21780L,424998L,9774912L,259012080L,7769656800L,260283596760L,9631680917760L,390185658289128L,17175153440774784L,816267894739416000L,BigInteger.Parse("41658264473400852480"),BigInteger.Parse("2272233977181361580160"),BigInteger.Parse("131913883517800157429760"),BigInteger.Parse("8121310193676734923381056") };
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
public class A194786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194786Inst Instance=new A194786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194787
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,272L,3630L,60714L,1221864L,28779120L,776965680L,23662145160L,802640076480L,30014281406856L,1226796674341056L,54417859649294400L,2603641529587553280L,BigInteger.Parse("133660822187138916480"),BigInteger.Parse("7328549084322230968320"),BigInteger.Parse("427437378614564995967424") };
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
public class A194787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194787Inst Instance=new A194787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194788
{
public static readonly long[] Value={ 0L,0L,0L,0L,242L,51504L,2484382L,44601420L,450193818L,3112919712L,16471667554L,71393226972L,265069706646L,869583076752L,2577681275622L,7020477731884L,17794428237522L,42397762374912L,95726217156906L,206149749502012L,425731784898894L,846919172059632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194788Inst : IEnumerable<long>
{
public static readonly long[] Value=A194788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194788.Bytes);
public long this[int i]=>Value[i];

public static A194788Inst Instance=new A194788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194789
{
public static readonly long[] Value={ 6L,9L,7L,3L,8L,7L,9L,4L,5L,7L,6L,2L,1L,4L,3L,0L,7L,0L,4L,0L,7L,5L,3L,2L,3L,6L,7L,3L,5L,4L,9L,0L,4L,2L,3L,4L,5L,7L,7L,0L,3L,5L,5L,1L,8L,6L,1L,0L,5L,0L,2L,9L,8L,3L,6L,3L,7L,6L,2L,5L,3L,0L,4L,8L,2L,0L,4L,8L,5L,2L,0L,3L,2L,2L,4L,6L,9L,5L,4L,9L,3L,4L,3L,8L,1L,9L,0L,3L,5L,5L,5L,6L,1L,8L,7L,0L,5L,7L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194789Inst : IEnumerable<long>
{
public static readonly long[] Value=A194789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194789.Bytes);
public long this[int i]=>Value[i];

public static A194789Inst Instance=new A194789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194790
{
public static readonly BigInteger[] Value={ 1L,9L,252L,11160L,779544L,86082552L,15042748752L,4162973481720L,1825584767007624L,1269014066306135784L,BigInteger.Parse("1398647178389920392360"),BigInteger.Parse("2444528051373276536144472"),BigInteger.Parse("6776054483832917004333974184") };
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
public class A194790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194790Inst Instance=new A194790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194791
{
public static readonly BigInteger[] Value={ 1L,10L,942L,267856L,187321720L,320268943536L,1338718951693520L,13681233554467188752UL,BigInteger.Parse("341845510164048367758144"),BigInteger.Parse("20883629381235404306727327808"),BigInteger.Parse("3119284181051765188519492660687792") };
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
public class A194791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194791Inst Instance=new A194791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194792
{
public static readonly BigInteger[] Value={ 1L,10L,1530L,1587724L,6012771932L,76835222989340L,3302081001560127592L,BigInteger.Parse("477232970093526846547868"),BigInteger.Parse("231946991234978104864701810980"),BigInteger.Parse("379107829075672054750390251800219732") };
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
public class A194792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194792Inst Instance=new A194792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194793
{
public static readonly BigInteger[] Value={ 1L,10L,1719L,4018152L,55882468218L,3454550787171726L,BigInteger.Parse("921229375293720351150"),BigInteger.Parse("1058115897991435552912456494"),BigInteger.Parse("5234423089116609084311564185372068"),BigInteger.Parse("111525513162694816614399225360134812623972") };
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
public class A194793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194793Inst Instance=new A194793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194794
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,4L,0L,0L,1L,9L,12L,0L,0L,1L,10L,252L,32L,0L,0L,1L,10L,942L,11160L,80L,0L,0L,1L,10L,1530L,267856L,779544L,192L,0L,0L,1L,10L,1719L,1587724L,187321720L,86082552L,448L,0L,0L,1L,10L,1743L,4018152L,6012771932L,320268943536L,15042748752L,1024L,0L,0L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194794Inst : IEnumerable<long>
{
public static readonly long[] Value=A194794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194794.Bytes);
public long this[int i]=>Value[i];

public static A194794Inst Instance=new A194794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194795
{
public static readonly long[] Value={ 0L,-1L,0L,-2L,0L,-4L,0L,-7L,1L,-11L,3L,-18L,6L,-28L,13L,-42L,24L,-64L,41L,-96L,69L,-141L,112L,-208L,175L,-303L,271L,-437L,410L,-629L,609L,-898L,896L,-1271L,1302L,-1792L,1868L,-2510L,2660L,-3493L,3752L,-4839L,5248L,-6666L,7293L,-9131L,10065L,-12454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194795Inst : IEnumerable<long>
{
public static readonly long[] Value=A194795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194795.Bytes);
public long this[int i]=>Value[i];

public static A194795Inst Instance=new A194795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194796
{
public static readonly long[] Value={ 0L,-1L,0L,-3L,0L,-8L,0L,-17L,3L,-31L,10L,-58L,22L,-101L,52L,-167L,104L,-278L,191L,-451L,344L,-711L,594L,-1119L,983L,-1730L,1606L,-2635L,2555L,-3990L,3978L,-5972L,6118L,-8835L,9269L,-12986L,13835L,-18917L,20454L,-27320L,29900L,-39204L,43268L,-55846L,62112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194796Inst : IEnumerable<long>
{
public static readonly long[] Value=A194796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194796.Bytes);
public long this[int i]=>Value[i];

public static A194796Inst Instance=new A194796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194797
{
public static readonly long[] Value={ 0L,-2L,1L,-7L,3L,-21L,7L,-49L,23L,-97L,57L,-195L,117L,-359L,256L,-624L,498L,-1086L,909L,-1831L,1634L,-2986L,2833L,-4847L,4728L,-7700L,7798L,-12026L,12537L,-18633L,19745L,-28479L,30723L,-42955L,47100L,-64284L,71136L,-95228L,106402L,-139718L,157327L,-203495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194797Inst : IEnumerable<long>
{
public static readonly long[] Value=A194797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194797.Bytes);
public long this[int i]=>Value[i];

public static A194797Inst Instance=new A194797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194798
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,10L,13L,17L,22L,23L,26L,28L,29L,30L,33L,34L,35L,37L,39L,40L,41L,42L,43L,46L,49L,50L,51L,53L,58L,61L,62L,63L,64L,66L,67L,69L,70L,71L,73L,74L,77L,78L,80L,81L,83L,84L,85L,86L,87L,89L,91L,93L,94L,95L,96L,98L,99L,100L,105L,106L,107L,108L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194798Inst : IEnumerable<long>
{
public static readonly long[] Value=A194798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194798.Bytes);
public long this[int i]=>Value[i];

public static A194798Inst Instance=new A194798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194799
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,4L,2L,2L,1L,1L,1L,4L,4L,2L,2L,1L,1L,1L,7L,4L,4L,2L,2L,1L,1L,1L,8L,7L,4L,4L,2L,2L,1L,1L,1L,12L,8L,7L,4L,4L,2L,2L,1L,1L,1L,14L,12L,8L,7L,4L,4L,2L,2L,1L,1L,1L,21L,14L,12L,8L,7L,4L,4L,2L,2L,1L,1L,1L,24L,21L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194799Inst : IEnumerable<long>
{
public static readonly long[] Value=A194799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194799.Bytes);
public long this[int i]=>Value[i];

public static A194799Inst Instance=new A194799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194800
{
public static readonly long[] Value={ 0L,3L,11L,17L,31L,39L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194800Inst : IEnumerable<long>
{
public static readonly long[] Value=A194800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194800.Bytes);
public long this[int i]=>Value[i];

public static A194800Inst Instance=new A194800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194801
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,1L,1L,3L,0L,1L,2L,4L,1L,0L,1L,3L,5L,4L,6L,0L,1L,4L,6L,7L,9L,3L,0L,1L,5L,7L,10L,12L,9L,10L,0L,1L,6L,8L,13L,15L,15L,16L,6L,0L,1L,7L,9L,16L,18L,21L,22L,16L,15L,0L,1L,8L,10L,19L,21L,27L,28L,26L,25L,10L,0L,1L,9L,11L,22L,24L,33L,34L,36L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194801Inst : IEnumerable<long>
{
public static readonly long[] Value=A194801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194801.Bytes);
public long this[int i]=>Value[i];

public static A194801Inst Instance=new A194801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194802
{
public static readonly long[] Value={ 0L,5L,9L,23L,29L,45L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194802Inst : IEnumerable<long>
{
public static readonly long[] Value=A194802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194802.Bytes);
public long this[int i]=>Value[i];

public static A194802Inst Instance=new A194802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194803
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,11L,17L,23L,33L,46L,64L,86L,121L,161L,217L,291L,388L,507L,671L,870L,1131L,1458L,1872L,2383L,3042L,3840L,4841L,6076L,7605L,9460L,11765L,14544L,17950L,22073L,27077L,33092L,40395L,49113L,59611L,72162L,87185L,105035L,126366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194803Inst : IEnumerable<long>
{
public static readonly long[] Value=A194803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194803.Bytes);
public long this[int i]=>Value[i];

public static A194803Inst Instance=new A194803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194804
{
public static readonly long[] Value={ 0L,1L,4L,8L,15L,23L,40L,59L,92L,137L,202L,285L,418L,577L,802L,1106L,1511L,2019L,2724L,3598L,4755L,6226L,8107L,10462L,13523L,17280L,22029L,27953L,35350L,44416L,55763L,69579L,86634L,107459L,132914L,163768L,201475L,246841L,301822L,368033L,447790L,543206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194804Inst : IEnumerable<long>
{
public static readonly long[] Value=A194804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194804.Bytes);
public long this[int i]=>Value[i];

public static A194804Inst Instance=new A194804Inst();

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