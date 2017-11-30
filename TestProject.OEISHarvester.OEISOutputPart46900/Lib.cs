using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A054445
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,14L,9L,4L,1L,42L,28L,14L,5L,1L,132L,90L,48L,20L,6L,1L,429L,297L,165L,75L,27L,7L,1L,1430L,1001L,572L,275L,110L,35L,8L,1L,4862L,3432L,2002L,1001L,429L,154L,44L,9L,1L,16796L,11934L,7072L,3640L,1638L,637L,208L,54L,10L,1L,58786L,41990L,25194L,13260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054445Inst : IEnumerable<long>
{
public static readonly long[] Value=A054445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054445.Bytes);
public long this[int i]=>Value[i];

public static A054445Inst Instance=new A054445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054446
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,12L,9L,4L,1L,29L,24L,14L,5L,1L,70L,62L,42L,20L,6L,1L,169L,156L,118L,67L,27L,7L,1L,408L,387L,316L,205L,100L,35L,8L,1L,985L,951L,821L,588L,332L,142L,44L,9L,1L,2378L,2323L,2088L,1614L,1020L,509L,194L,54L,10L,1L,5741L,5652L,5232L,4290L,2966L,1671L,747L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054446Inst : IEnumerable<long>
{
public static readonly long[] Value=A054446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054446.Bytes);
public long this[int i]=>Value[i];

public static A054446Inst Instance=new A054446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054447
{
public static readonly long[] Value={ 1L,3L,9L,26L,73L,201L,545L,1460L,3873L,10191L,26633L,69198L,178889L,460437L,1180545L,3016552L,7684481L,19522203L,49473097L,125093506L,315654537L,795016545L,1998909985L,5017895196L,12578040097L,31485713511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054447Inst : IEnumerable<long>
{
public static readonly long[] Value=A054447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054447.Bytes);
public long this[int i]=>Value[i];

public static A054447Inst Instance=new A054447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054448
{
public static readonly long[] Value={ 1L,3L,1L,9L,4L,1L,26L,14L,5L,1L,73L,44L,20L,6L,1L,201L,131L,69L,27L,7L,1L,545L,376L,220L,102L,35L,8L,1L,1460L,1052L,665L,349L,144L,44L,9L,1L,3873L,2888L,1937L,1116L,528L,196L,54L,10L,1L,10191L,7813L,5490L,3402L,1788L,768L,259L,65L,11L,1L,26633L,20892L,15240L,10008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054448Inst : IEnumerable<long>
{
public static readonly long[] Value=A054448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054448.Bytes);
public long this[int i]=>Value[i];

public static A054448Inst Instance=new A054448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054449
{
public static readonly long[] Value={ 1L,4L,14L,46L,144L,436L,1287L,3724L,10603L,29788L,82748L,227658L,621122L,1682252L,4526845L,12111512L,32237253L,85407188L,225318042L,592141478L,1550688932L,4047787844L,10534503523L,27340763556L,70777265551L,182785072876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054449Inst : IEnumerable<long>
{
public static readonly long[] Value=A054449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054449.Bytes);
public long this[int i]=>Value[i];

public static A054449Inst Instance=new A054449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054450
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,5L,4L,4L,1L,1L,8L,8L,5L,5L,1L,1L,13L,12L,12L,6L,6L,1L,1L,21L,21L,17L,17L,7L,7L,1L,1L,34L,33L,33L,23L,23L,8L,8L,1L,1L,55L,55L,50L,50L,30L,30L,9L,9L,1L,1L,89L,88L,88L,73L,73L,38L,38L,10L,10L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054450Inst : IEnumerable<long>
{
public static readonly long[] Value=A054450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054450.Bytes);
public long this[int i]=>Value[i];

public static A054450Inst Instance=new A054450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054451
{
public static readonly long[] Value={ 1L,1L,4L,5L,12L,17L,33L,50L,88L,138L,232L,370L,609L,979L,1596L,2575L,4180L,6755L,10945L,17700L,28656L,46356L,75024L,121380L,196417L,317797L,514228L,832025L,1346268L,2178293L,3524577L,5702870L,9227464L,14930334L,24157816L,39088150L,63245985L,102334135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054451Inst : IEnumerable<long>
{
public static readonly long[] Value=A054451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054451.Bytes);
public long this[int i]=>Value[i];

public static A054451Inst Instance=new A054451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054452
{
public static readonly long[] Value={ 0L,0L,1L,5L,17L,50L,138L,370L,979L,2575L,6755L,17700L,46356L,121380L,317797L,832025L,2178293L,5702870L,14930334L,39088150L,102334135L,267914275L,701408711L,1836311880L,4807526952L,12586269000L,32951280073L,86267571245L,225851433689L,591286729850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054452Inst : IEnumerable<long>
{
public static readonly long[] Value=A054452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054452.Bytes);
public long this[int i]=>Value[i];

public static A054452Inst Instance=new A054452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054453
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,8L,5L,2L,1L,15L,10L,6L,2L,1L,28L,20L,12L,7L,2L,1L,51L,38L,26L,14L,8L,2L,1L,92L,71L,50L,33L,16L,9L,2L,1L,164L,130L,97L,64L,41L,18L,10L,2L,1L,290L,235L,180L,130L,80L,50L,20L,11L,2L,1L,509L,420L,332L,244L,171L,98L,60L,22L,12L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054453Inst : IEnumerable<long>
{
public static readonly long[] Value=A054453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054453.Bytes);
public long this[int i]=>Value[i];

public static A054453Inst Instance=new A054453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054454
{
public static readonly long[] Value={ 1L,2L,6L,12L,26L,50L,97L,180L,332L,600L,1076L,1908L,3361L,5878L,10226L,17700L,30510L,52390L,89665L,153000L,260376L,442032L,748776L,1265832L,2136001L,3598250L,6052062L,10164540L,17048642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054454Inst : IEnumerable<long>
{
public static readonly long[] Value=A054454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054454.Bytes);
public long this[int i]=>Value[i];

public static A054454Inst Instance=new A054454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054455
{
public static readonly long[] Value={ 1L,3L,7L,16L,34L,70L,140L,274L,527L,999L,1871L,3468L,6371L,11613L,21023L,37826L,67688L,120530L,213670L,377252L,663607L,1163361L,2033101L,3542808L,6157045L,10673703L,18460759L,31859716L,54872158L,94326622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054455Inst : IEnumerable<long>
{
public static readonly long[] Value=A054455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054455.Bytes);
public long this[int i]=>Value[i];

public static A054455Inst Instance=new A054455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054456
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,12L,14L,6L,1L,29L,44L,27L,8L,1L,70L,131L,104L,44L,10L,1L,169L,376L,366L,200L,65L,12L,1L,408L,1052L,1212L,810L,340L,90L,14L,1L,985L,2888L,3842L,3032L,1555L,532L,119L,16L,1L,2378L,7813L,11784L,10716L,6482L,2709L,784L,152L,18L,1L,5741L,20892L,35223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054456Inst : IEnumerable<long>
{
public static readonly long[] Value=A054456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054456.Bytes);
public long this[int i]=>Value[i];

public static A054456Inst Instance=new A054456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054457
{
public static readonly long[] Value={ 1L,6L,27L,104L,366L,1212L,3842L,11784L,35223L,103122L,296805L,842160L,2360780L,6549240L,18004980L,49106992L,132996957L,357948894L,957993823L,2550977112L,6761742234L,17848312884L,46932923478L,122980461816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054457Inst : IEnumerable<long>
{
public static readonly long[] Value=A054457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054457.Bytes);
public long this[int i]=>Value[i];

public static A054457Inst Instance=new A054457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054458
{
public static readonly long[] Value={ 1L,3L,1L,7L,6L,1L,17L,23L,9L,1L,41L,76L,48L,12L,1L,99L,233L,204L,82L,15L,1L,239L,682L,765L,428L,125L,18L,1L,577L,1935L,2649L,1907L,775L,177L,21L,1L,1393L,5368L,8680L,7656L,4010L,1272L,238L,24L,1L,3363L,14641L,27312L,28548L,18358L,7506L,1946L,308L,27L,1L,8119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054458Inst : IEnumerable<long>
{
public static readonly long[] Value=A054458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054458.Bytes);
public long this[int i]=>Value[i];

public static A054458Inst Instance=new A054458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054459
{
public static readonly long[] Value={ 1L,6L,23L,76L,233L,682L,1935L,5368L,14641L,39406L,104935L,276996L,725849L,1890258L,4896415L,12624752L,32419297L,82951766L,211573047L,538086716L,1364974409L,3454480250L,8724052271L,21989264232L,55326056977L,138975010110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054459Inst : IEnumerable<long>
{
public static readonly long[] Value=A054459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054459.Bytes);
public long this[int i]=>Value[i];

public static A054459Inst Instance=new A054459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054460
{
public static readonly long[] Value={ 1L,9L,48L,204L,765L,2649L,8680L,27312L,83313L,247985L,723624L,2077164L,5880797L,16454865L,45577200L,125130432L,340882113L,922265721L,2479938368L,6631802220L,17646603933L,46744464745L,123314065944L,324085913136L,848801213425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054460Inst : IEnumerable<long>
{
public static readonly long[] Value=A054460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054460.Bytes);
public long this[int i]=>Value[i];

public static A054460Inst Instance=new A054460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054461
{
public static readonly BigInteger[] Value={ 3L,11L,73L,45143873L,1043046721L,1182114430632237601L,BigInteger.Parse("49814113380273715457") };
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
public class A054461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A054461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A054461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A054461Inst Instance=new A054461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054462
{
public static readonly long[] Value={ 1L,2L,3L,8L,9L,15L,16L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054462Inst : IEnumerable<long>
{
public static readonly long[] Value=A054462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054462.Bytes);
public long this[int i]=>Value[i];

public static A054462Inst Instance=new A054462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054463
{
public static readonly long[] Value={ 2L,5L,6L,9L,24L,595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054463Inst : IEnumerable<long>
{
public static readonly long[] Value=A054463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054463.Bytes);
public long this[int i]=>Value[i];

public static A054463Inst Instance=new A054463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054464
{
public static readonly long[] Value={ 4L,34L,90L,175L,800L,2999L,3624L,30624L,60000L,390624L,499999L,4000000L,8890624L,17109375L,69999999L,200000000L,2787109375L,8999999999L,81787109375L,900000000000L,1918212890624L,1999999999999L,70000000000000L,89918212890624L,399999999999999L,659918212890624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054464Inst : IEnumerable<long>
{
public static readonly long[] Value=A054464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054464.Bytes);
public long this[int i]=>Value[i];

public static A054464Inst Instance=new A054464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054465
{
public static readonly long[] Value={ 4L,20L,349L,474L,3999L,4624L,5000L,35624L,390624L,499999L,1609375L,27109375L,40000000L,137109375L,149999999L,3000000000L,4787109375L,6787109375L,24999999999L,200000000000L,281787109375L,1581787109375L,3499999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054465Inst : IEnumerable<long>
{
public static readonly long[] Value=A054465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054465.Bytes);
public long this[int i]=>Value[i];

public static A054465Inst Instance=new A054465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054466
{
public static readonly long[] Value={ 163L,643L,1651L,3379L,5203L,8371L,11059L,16291L,20803L,26275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054466Inst : IEnumerable<long>
{
public static readonly long[] Value=A054466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054466.Bytes);
public long this[int i]=>Value[i];

public static A054466Inst Instance=new A054466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054467
{
public static readonly long[] Value={ 348L,5388L,17628L,46620L,129564L,211356L,342012L,518892L,736668L,1198044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054467Inst : IEnumerable<long>
{
public static readonly long[] Value=A054467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054467.Bytes);
public long this[int i]=>Value[i];

public static A054467Inst Instance=new A054467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054468
{
public static readonly long[] Value={ 764L,5108L,28892L,62708L,129716L,227108L,482060L,681308L,1019468L,1351292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054468Inst : IEnumerable<long>
{
public static readonly long[] Value=A054468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054468.Bytes);
public long this[int i]=>Value[i];

public static A054468Inst Instance=new A054468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054469
{
public static readonly long[] Value={ 1L,7L,28L,85L,218L,499L,1053L,2092L,3970L,7272L,12958L,22596L,38739L,65535L,109714L,182185L,300620L,493635L,807555L,1317360L,2144396L,3485032L,5657028L,9174560L,14869613L,24088399L,39009168L,63156437L,102233030L,165466347L,267786673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054469Inst : IEnumerable<long>
{
public static readonly long[] Value=A054469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054469.Bytes);
public long this[int i]=>Value[i];

public static A054469Inst Instance=new A054469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054470
{
public static readonly long[] Value={ 1L,8L,36L,121L,339L,838L,1891L,3983L,7953L,15225L,28183L,50779L,89518L,155053L,264767L,446952L,747572L,1241207L,2048762L,3366122L,5510518L,8995550L,14652578L,23827138L,38696751L,62785150L,101794318L,164950755L,267183785L,432650132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054470Inst : IEnumerable<long>
{
public static readonly long[] Value=A054470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054470.Bytes);
public long this[int i]=>Value[i];

public static A054470Inst Instance=new A054470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054471
{
public static readonly long[] Value={ 7L,3L,103L,53L,11L,79L,211L,41L,73L,281L,353L,37L,2393L,449L,3061L,1889L,137L,2467L,16189L,641L,3109L,4973L,11087L,1321L,101L,7151L,7669L,757L,38629L,1231L,49663L,12289L,859L,239L,27581L,9613L,18131L,13757L,33931L,9161L,118901L,6763L,18233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054471Inst : IEnumerable<long>
{
public static readonly long[] Value=A054471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054471.Bytes);
public long this[int i]=>Value[i];

public static A054471Inst Instance=new A054471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054472
{
public static readonly BigInteger[] Value={ 0L,1L,17824L,58130055L,18325477888L,1589459765875L,60935989677984L,1329871177501573L,19215358684143616L,202627758536996445L,1666666669200004000L,11212499922098481787UL,BigInteger.Parse("63895999889747261952"),BigInteger.Parse("316749396282749868607"),BigInteger.Parse("1394470923827552301472"),BigInteger.Parse("5542094550277768379625") };
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
public class A054472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A054472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A054472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A054472Inst Instance=new A054472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054473
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,15L,29L,41L,68L,98L,147L,202L,291L,386L,528L,688L,906L,1151L,1480L,1841L,2310L,2833L,3484L,4207L,5099L,6076L,7259L,8562L,10104L,11796L,13785L,15948L,18462L,21201L,24339L,27747L,31633L,35827L,40572L,45695L,51436L,57618L,64520L,71918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054473Inst : IEnumerable<long>
{
public static readonly long[] Value=A054473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054473.Bytes);
public long this[int i]=>Value[i];

public static A054473Inst Instance=new A054473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054474
{
public static readonly ulong[] Value={ 1L,4L,20L,176L,1876L,22064L,275568L,3584064L,47995476L,657037232L,9150655216L,129214858304L,1845409805168L,26606114089024L,386679996988736L,5658611409163008L,83302885723872852L,1232764004638179504L,18327520881735288432UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054474Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A054474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054474.Bytes);
public ulong this[int i]=>Value[i];

public static A054474Inst Instance=new A054474Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054475
{
public static readonly long[] Value={ 11L,35L,43L,47L,59L,131L,139L,143L,163L,175L,179L,187L,191L,203L,227L,235L,239L,251L,515L,523L,527L,547L,559L,563L,571L,575L,643L,655L,683L,691L,703L,707L,715L,719L,739L,751L,755L,763L,767L,779L,803L,811L,815L,827L,899L,907L,911L,931L,943L,947L,955L,959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054475Inst : IEnumerable<long>
{
public static readonly long[] Value=A054475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054475.Bytes);
public long this[int i]=>Value[i];

public static A054475Inst Instance=new A054475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054476
{
public static readonly long[] Value={ 13L,17L,19L,23L,53L,65L,67L,73L,77L,79L,85L,89L,94L,95L,97L,98L,103L,113L,115L,118L,119L,253L,263L,265L,269L,313L,317L,319L,323L,325L,329L,335L,337L,343L,347L,349L,353L,365L,367L,373L,377L,379L,385L,389L,394L,395L,397L,398L,425L,427L,437L,439L,443L,445L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054476Inst : IEnumerable<long>
{
public static readonly long[] Value=A054476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054476.Bytes);
public long this[int i]=>Value[i];

public static A054476Inst Instance=new A054476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054477
{
public static readonly long[] Value={ 1L,13L,64L,307L,1471L,7048L,33769L,161797L,775216L,3714283L,17796199L,85266712L,408537361L,1957420093L,9378563104L,44935395427L,215298414031L,1031556674728L,4942484959609L,23680868123317L,113461855656976L,543628410161563L,2604680195150839L,12479772565592632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054477Inst : IEnumerable<long>
{
public static readonly long[] Value=A054477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054477.Bytes);
public long this[int i]=>Value[i];

public static A054477Inst Instance=new A054477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054478
{
public static readonly long[] Value={ 17L,22L,23L,29L,34L,77L,89L,101L,107L,113L,130L,131L,137L,142L,143L,149L,161L,166L,167L,173L,174L,178L,179L,197L,202L,203L,209L,214L,437L,449L,461L,467L,509L,521L,527L,533L,539L,557L,563L,569L,581L,593L,599L,611L,617L,629L,641L,647L,653L,670L,671L,677L,682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054478Inst : IEnumerable<long>
{
public static readonly long[] Value=A054478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054478.Bytes);
public long this[int i]=>Value[i];

public static A054478Inst Instance=new A054478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054479
{
public static readonly BigInteger[] Value={ 1L,0L,6L,120L,6300L,514080L,62785800L,10676746080L,2413521910800L,700039083744000L,253445583029839200L,BigInteger.Parse("112033456760809584000"),BigInteger.Parse("59382041886244720843200"),BigInteger.Parse("37175286835046004765120000"),BigInteger.Parse("27139206193305890195912400000"),BigInteger.Parse("22852066417535931447551359680000") };
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
public class A054479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A054479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A054479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A054479Inst Instance=new A054479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054480
{
public static readonly long[] Value={ 1L,3L,8L,19L,43L,94L,202L,429L,905L,1901L,3983L,8332L,17413L,36370L,75938L,158519L,330862L,690523L,1441082L,3007369L,6275917L,13096737L,27330418L,57033206L,119016808L,248363751L,518283950L,1081551220L,2256972626L,4709831964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054480Inst : IEnumerable<long>
{
public static readonly long[] Value=A054480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054480.Bytes);
public long this[int i]=>Value[i];

public static A054480Inst Instance=new A054480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054481
{
public static readonly long[] Value={ 1L,2L,2L,6L,12L,12L,12L,12L,60L,60L,60L,120L,360L,120L,420L,420L,840L,2520L,2520L,2520L,5040L,5040L,5040L,2520L,2520L,5040L,5040L,27720L,27720L,55440L,55440L,55440L,55440L,166320L,55440L,110880L,55440L,360360L,360360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054481Inst : IEnumerable<long>
{
public static readonly long[] Value=A054481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054481.Bytes);
public long this[int i]=>Value[i];

public static A054481Inst Instance=new A054481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054482
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,3L,4L,1L,2L,3L,2L,1L,6L,2L,3L,2L,1L,2L,3L,2L,3L,4L,10L,11L,9L,10L,2L,3L,2L,3L,4L,5L,2L,9L,5L,12L,2L,3L,2L,3L,4L,5L,2L,9L,5L,4L,3L,5L,4L,2L,15L,17L,12L,5L,2L,9L,5L,4L,3L,5L,4L,2L,15L,19L,2L,15L,2L,19L,18L,5L,4L,3L,5L,4L,2L,3L,2L,3L,2L,6L,35L,92L,21L,23L,35L,92L,21L,2L,23L,21L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054482Inst : IEnumerable<long>
{
public static readonly long[] Value=A054482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054482.Bytes);
public long this[int i]=>Value[i];

public static A054482Inst Instance=new A054482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054483
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,4L,5L,2L,3L,4L,3L,2L,7L,3L,4L,3L,2L,3L,4L,3L,4L,5L,11L,18L,10L,11L,3L,4L,3L,4L,5L,6L,3L,10L,6L,13L,3L,4L,3L,4L,5L,6L,3L,10L,6L,5L,4L,6L,5L,3L,17L,20L,17L,6L,3L,10L,6L,5L,4L,6L,5L,3L,19L,20L,3L,19L,3L,20L,19L,6L,5L,4L,6L,5L,3L,4L,3L,4L,3L,7L,46L,105L,23L,28L,46L,105L,23L,3L,28L,23L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054483Inst : IEnumerable<long>
{
public static readonly long[] Value=A054483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054483.Bytes);
public long this[int i]=>Value[i];

public static A054483Inst Instance=new A054483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054484
{
public static readonly long[] Value={ 17L,19L,23L,25L,26L,31L,33L,34L,37L,38L,39L,41L,46L,47L,101L,103L,115L,117L,119L,121L,125L,131L,133L,137L,139L,143L,149L,151L,152L,161L,163L,167L,173L,175L,178L,179L,181L,182L,187L,188L,191L,193L,194L,199L,201L,202L,217L,221L,223L,227L,229L,230L,231L,233L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054484Inst : IEnumerable<long>
{
public static readonly long[] Value=A054484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054484.Bytes);
public long this[int i]=>Value[i];

public static A054484Inst Instance=new A054484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054485
{
public static readonly long[] Value={ 1L,7L,27L,101L,377L,1407L,5251L,19597L,73137L,272951L,1018667L,3801717L,14188201L,52951087L,197616147L,737513501L,2752437857L,10272237927L,38336513851L,143073817477L,533958756057L,1992761206751L,7437086070947L,27755583077037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054485Inst : IEnumerable<long>
{
public static readonly long[] Value=A054485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054485.Bytes);
public long this[int i]=>Value[i];

public static A054485Inst Instance=new A054485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054486
{
public static readonly long[] Value={ 1L,5L,14L,37L,97L,254L,665L,1741L,4558L,11933L,31241L,81790L,214129L,560597L,1467662L,3842389L,10059505L,26336126L,68948873L,180510493L,472582606L,1237237325L,3239129369L,8480150782L,22201322977L,58123818149L,152170131470L,398386576261L,1042989597313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054486Inst : IEnumerable<long>
{
public static readonly long[] Value=A054486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054486.Bytes);
public long this[int i]=>Value[i];

public static A054486Inst Instance=new A054486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054487
{
public static readonly long[] Value={ 1L,14L,90L,390L,1320L,3762L,9438L,21450L,45045L,88660L,165308L,294372L,503880L,833340L,1337220L,2089164L,3187041L,4758930L,6970150L,10031450L,14208480L,19832670L,27313650L,37153350L,49961925L,66475656L,87576984L,114316840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054487Inst : IEnumerable<long>
{
public static readonly long[] Value=A054487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054487.Bytes);
public long this[int i]=>Value[i];

public static A054487Inst Instance=new A054487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054488
{
public static readonly long[] Value={ 1L,8L,47L,274L,1597L,9308L,54251L,316198L,1842937L,10741424L,62605607L,364892218L,2126747701L,12395593988L,72246816227L,421085303374L,2454265004017L,14304504720728L,83372763320351L,485932075201378L,2832219687887917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054488Inst : IEnumerable<long>
{
public static readonly long[] Value=A054488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054488.Bytes);
public long this[int i]=>Value[i];

public static A054488Inst Instance=new A054488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054489
{
public static readonly long[] Value={ 1L,10L,59L,344L,2005L,11686L,68111L,396980L,2313769L,13485634L,78600035L,458114576L,2670087421L,15562409950L,90704372279L,528663823724L,3081278570065L,17959007596666L,104672767009931L,610077594462920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054489Inst : IEnumerable<long>
{
public static readonly long[] Value=A054489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054489.Bytes);
public long this[int i]=>Value[i];

public static A054489Inst Instance=new A054489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054490
{
public static readonly long[] Value={ 1L,11L,65L,379L,2209L,12875L,75041L,437371L,2549185L,14857739L,86597249L,504725755L,2941757281L,17145817931L,99933150305L,582453083899L,3394785353089L,19786259034635L,115322768854721L,672150354093691L,3917579355707425L,22833325780150859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054490Inst : IEnumerable<long>
{
public static readonly long[] Value=A054490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054490.Bytes);
public long this[int i]=>Value[i];

public static A054490Inst Instance=new A054490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054491
{
public static readonly long[] Value={ 1L,6L,23L,86L,321L,1198L,4471L,16686L,62273L,232406L,867351L,3236998L,12080641L,45085566L,168261623L,627960926L,2343582081L,8746367398L,32641887511L,121821182646L,454642843073L,1696750189646L,6332357915511L,23632681472398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054491Inst : IEnumerable<long>
{
public static readonly long[] Value=A054491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054491.Bytes);
public long this[int i]=>Value[i];

public static A054491Inst Instance=new A054491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054492
{
public static readonly long[] Value={ 1L,6L,17L,45L,118L,309L,809L,2118L,5545L,14517L,38006L,99501L,260497L,681990L,1785473L,4674429L,12237814L,32039013L,83879225L,219598662L,574916761L,1505151621L,3940538102L,10316462685L,27008849953L,70710087174L,185121411569L,484654147533L,1268841031030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054492Inst : IEnumerable<long>
{
public static readonly long[] Value=A054492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054492.Bytes);
public long this[int i]=>Value[i];

public static A054492Inst Instance=new A054492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054493
{
public static readonly long[] Value={ 1L,7L,36L,175L,841L,4032L,19321L,92575L,443556L,2125207L,10182481L,48787200L,233753521L,1119980407L,5366148516L,25710762175L,123187662361L,590227549632L,2827950085801L,13549522879375L,64919664311076L,311048798676007L,1490324329068961L,7140572846668800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054493Inst : IEnumerable<long>
{
public static readonly long[] Value=A054493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054493.Bytes);
public long this[int i]=>Value[i];

public static A054493Inst Instance=new A054493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054494
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,1L,8L,3L,5L,1L,3L,13L,2L,5L,8L,1L,3L,1L,5L,21L,2L,1L,8L,5L,13L,3L,2L,1L,5L,1L,8L,3L,34L,5L,3L,1L,2L,13L,8L,1L,21L,1L,2L,5L,2L,1L,8L,1L,5L,3L,13L,1L,3L,55L,8L,3L,2L,1L,5L,1L,2L,21L,8L,13L,3L,1L,34L,3L,5L,1L,8L,1L,2L,5L,2L,1L,13L,1L,8L,3L,2L,1L,21L,5L,2L,3L,8L,89L,5L,13L,2L,3L,2L,5L,8L,1L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054494Inst : IEnumerable<long>
{
public static readonly long[] Value=A054494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054494.Bytes);
public long this[int i]=>Value[i];

public static A054494Inst Instance=new A054494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054495
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,7L,1L,3L,2L,11L,4L,1L,7L,3L,2L,17L,6L,19L,4L,1L,11L,23L,3L,5L,2L,9L,14L,29L,6L,31L,4L,11L,1L,7L,12L,37L,19L,3L,5L,41L,2L,43L,22L,9L,23L,47L,6L,49L,10L,17L,4L,53L,18L,1L,7L,19L,29L,59L,12L,61L,31L,3L,8L,5L,22L,67L,2L,23L,14L,71L,9L,73L,37L,15L,38L,77L,6L,79L,10L,27L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054495Inst : IEnumerable<long>
{
public static readonly long[] Value=A054495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054495.Bytes);
public long this[int i]=>Value[i];

public static A054495Inst Instance=new A054495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054496
{
public static readonly long[] Value={ 1L,2L,3L,16L,5L,6L,7L,512L,81L,10L,11L,48L,13L,14L,15L,65536L,17L,162L,19L,80L,21L,22L,23L,1536L,625L,26L,19683L,112L,29L,30L,31L,33554432L,33L,34L,35L,1296L,37L,38L,39L,2560L,41L,42L,43L,176L,405L,46L,47L,196608L,2401L,1250L,51L,208L,53L,39366L,55L,3584L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054496Inst : IEnumerable<long>
{
public static readonly long[] Value=A054496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054496.Bytes);
public long this[int i]=>Value[i];

public static A054496Inst Instance=new A054496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054497
{
public static readonly long[] Value={ 1L,7L,31L,105L,300L,756L,1732L,3676L,7330L,13870L,25102L,43714L,73612L,120340L,191620L,298012L,453739L,677677L,994565L,1436435L,2044328L,2870296L,3979768L,5454280L,7394660L,9924668L,13195196L,17389028L,22726280L,29470520L,37935704L,48493928L,61584149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054497Inst : IEnumerable<long>
{
public static readonly long[] Value=A054497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054497.Bytes);
public long this[int i]=>Value[i];

public static A054497Inst Instance=new A054497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054498
{
public static readonly long[] Value={ 1L,4L,16L,44L,116L,260L,560L,1100L,2090L,3740L,6512L,10868L,17732L,28028L,43472L,65780L,97955L,143000L,205920L,291720L,408408L,563992L,770848L,1041352L,1394068L,1847560L,2428960L,3165400L,4095640L,5258440L,6708064L,8498776L,10705189L,13401916L,16689904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054498Inst : IEnumerable<long>
{
public static readonly long[] Value=A054498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054498.Bytes);
public long this[int i]=>Value[i];

public static A054498Inst Instance=new A054498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054499
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,17L,79L,554L,5283L,65346L,966156L,16411700L,312700297L,6589356711L,152041845075L,3811786161002L,103171594789775L,2998419746654530L,93127358763431113L,3078376375601255821L,BigInteger.Parse("107905191542909828013"),BigInteger.Parse("3997887336845307589431") };
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
public class A054499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A054499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A054499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A054499Inst Instance=new A054499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054500
{
public static readonly long[] Value={ 1L,5L,7L,11L,13L,13L,13L,13L,17L,17L,17L,17L,17L,19L,19L,19L,23L,23L,23L,25L,25L,25L,25L,25L,25L,25L,25L,29L,29L,29L,29L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054500Inst : IEnumerable<long>
{
public static readonly long[] Value=A054500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054500.Bytes);
public long this[int i]=>Value[i];

public static A054500Inst Instance=new A054500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054501
{
public static readonly long[] Value={ 1L,10L,28L,44L,26L,52L,338L,676L,34L,68L,578L,1156L,2312L,76L,1444L,2888L,92L,2116L,4232L,50L,100L,250L,500L,1000L,1250L,2500L,5000L,58L,116L,1682L,3364L,6728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054501Inst : IEnumerable<long>
{
public static readonly long[] Value=A054501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054501.Bytes);
public long this[int i]=>Value[i];

public static A054501Inst Instance=new A054501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054502
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,5L,1L,3L,23L,30L,40L,4L,132L,218L,5L,1859L,29517L,1L,2L,9L,18L,51L,470L,7170L,387830L,1L,6L,1215L,121487L,89997968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054502Inst : IEnumerable<long>
{
public static readonly long[] Value=A054502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054502.Bytes);
public long this[int i]=>Value[i];

public static A054502Inst Instance=new A054502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054503
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,2L,0L,2L,1L,4L,5L,3L,0L,1L,8L,2L,4L,9L,7L,3L,6L,5L,0L,1L,4L,2L,9L,5L,11L,3L,8L,10L,7L,6L,0L,14L,1L,12L,5L,15L,11L,10L,2L,3L,7L,13L,4L,9L,6L,8L,0L,1L,13L,2L,16L,14L,6L,3L,8L,17L,12L,15L,5L,7L,11L,4L,10L,9L,0L,2L,16L,4L,1L,18L,19L,6L,10L,3L,9L,20L,14L,21L,17L,8L,7L,12L,15L,5L,13L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054503Inst : IEnumerable<long>
{
public static readonly long[] Value=A054503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054503.Bytes);
public long this[int i]=>Value[i];

public static A054503Inst Instance=new A054503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054504
{
public static readonly long[] Value={ 6L,7L,11L,13L,14L,20L,21L,23L,29L,32L,34L,39L,42L,45L,46L,47L,51L,53L,58L,59L,60L,61L,62L,66L,67L,69L,70L,74L,75L,77L,78L,83L,84L,85L,86L,87L,88L,90L,93L,95L,96L,102L,103L,104L,109L,110L,111L,114L,115L,116L,118L,123L,124L,130L,133L,135L,137L,139L,140L,146L,147L,149L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054504Inst : IEnumerable<long>
{
public static readonly long[] Value=A054504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054504.Bytes);
public long this[int i]=>Value[i];

public static A054504Inst Instance=new A054504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054505
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,14L,1L,2L,1L,24L,1L,26L,27L,18L,1L,1L,1L,1L,6L,8L,4L,1L,16L,34L,1L,44L,1L,57L,12L,72L,1L,10L,1L,1L,70L,141L,1L,40L,1L,1L,1L,44L,34L,1L,106L,1L,180L,1L,21L,72L,66L,190L,235L,48L,190L,1L,154L,147L,204L,159L,1L,93L,22L,274L,1L,121L,304L,1L,1L,164L,314L,292L,1L,1L,134L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054505Inst : IEnumerable<long>
{
public static readonly long[] Value=A054505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054505.Bytes);
public long this[int i]=>Value[i];

public static A054505Inst Instance=new A054505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054506
{
public static readonly long[] Value={ 3L,1L,8L,4L,1L,13L,16L,5L,1L,26L,15L,1L,20L,17L,50L,6L,39L,26L,6L,1L,72L,1L,70L,69L,39L,70L,52L,1L,1L,72L,1L,41L,87L,81L,82L,101L,94L,27L,108L,56L,116L,84L,181L,1L,43L,1L,46L,208L,1L,74L,182L,16L,1L,50L,109L,117L,188L,1L,1L,157L,81L,164L,56L,249L,1L,314L,152L,26L,1L,186L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054506Inst : IEnumerable<long>
{
public static readonly long[] Value=A054506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054506.Bytes);
public long this[int i]=>Value[i];

public static A054506Inst Instance=new A054506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054507
{
public static readonly long[] Value={ 2L,4L,2L,2L,12L,2L,4L,2L,18L,2L,12L,12L,36L,2L,2L,2L,2L,12L,16L,8L,2L,32L,68L,2L,88L,2L,6L,24L,18L,2L,20L,2L,2L,140L,126L,2L,80L,2L,2L,2L,88L,68L,2L,14L,2L,138L,2L,42L,144L,132L,140L,220L,96L,118L,2L,38L,18L,128L,36L,2L,186L,44L,236L,2L,242L,272L,2L,2L,328L,270L,218L,2L,2L,268L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054507Inst : IEnumerable<long>
{
public static readonly long[] Value=A054507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054507.Bytes);
public long this[int i]=>Value[i];

public static A054507Inst Instance=new A054507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054508
{
public static readonly long[] Value={ 5L,4L,9L,5L,16L,1L,22L,20L,23L,22L,25L,1L,47L,6L,22L,15L,28L,1L,62L,27L,70L,1L,24L,1L,47L,76L,83L,87L,46L,75L,86L,104L,112L,1L,15L,1L,39L,138L,156L,50L,1L,89L,138L,132L,89L,11L,98L,165L,138L,138L,130L,55L,1L,208L,170L,1L,186L,233L,173L,1L,196L,39L,243L,236L,33L,277L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054508Inst : IEnumerable<long>
{
public static readonly long[] Value=A054508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054508.Bytes);
public long this[int i]=>Value[i];

public static A054508Inst Instance=new A054508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054509
{
public static readonly long[] Value={ 3L,9L,5L,15L,14L,18L,6L,25L,27L,1L,28L,38L,18L,51L,7L,40L,32L,14L,5L,73L,17L,8L,70L,83L,71L,1L,13L,73L,73L,11L,42L,88L,1L,67L,102L,134L,28L,109L,57L,160L,118L,182L,107L,44L,181L,47L,1L,73L,140L,132L,1L,49L,240L,110L,1L,59L,205L,160L,158L,174L,186L,18L,250L,122L,282L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054509Inst : IEnumerable<long>
{
public static readonly long[] Value=A054509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054509.Bytes);
public long this[int i]=>Value[i];

public static A054509Inst Instance=new A054509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054510
{
public static readonly long[] Value={ 7L,11L,11L,6L,19L,12L,28L,32L,39L,35L,32L,14L,18L,49L,23L,1L,33L,53L,8L,81L,31L,9L,4L,43L,40L,8L,115L,96L,42L,50L,142L,67L,147L,73L,118L,95L,171L,15L,171L,104L,146L,142L,139L,210L,154L,107L,222L,1L,1L,248L,85L,79L,19L,142L,22L,182L,278L,213L,116L,140L,123L,50L,81L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054510Inst : IEnumerable<long>
{
public static readonly long[] Value=A054510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054510.Bytes);
public long this[int i]=>Value[i];

public static A054510Inst Instance=new A054510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054511
{
public static readonly long[] Value={ 3L,3L,10L,3L,6L,3L,12L,3L,38L,39L,8L,3L,3L,3L,3L,18L,24L,12L,3L,48L,6L,3L,30L,3L,63L,36L,90L,3L,30L,3L,3L,60L,111L,3L,120L,3L,3L,3L,132L,102L,3L,120L,3L,96L,3L,63L,216L,198L,90L,205L,144L,46L,3L,192L,165L,52L,195L,3L,279L,66L,198L,3L,33L,240L,3L,3L,140L,226L,144L,3L,3L,20L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054511Inst : IEnumerable<long>
{
public static readonly long[] Value=A054511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054511.Bytes);
public long this[int i]=>Value[i];

public static A054511Inst Instance=new A054511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054512
{
public static readonly long[] Value={ 6L,8L,2L,8L,10L,10L,2L,16L,30L,2L,40L,34L,42L,12L,12L,52L,12L,2L,62L,2L,44L,38L,78L,34L,104L,2L,2L,14L,2L,82L,26L,12L,8L,40L,22L,54L,38L,112L,42L,168L,166L,2L,86L,2L,92L,188L,2L,148L,124L,32L,2L,100L,218L,234L,100L,2L,2L,22L,162L,18L,112L,182L,2L,292L,304L,52L,2L,14L,150L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054512Inst : IEnumerable<long>
{
public static readonly long[] Value=A054512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054512.Bytes);
public long this[int i]=>Value[i];

public static A054512Inst Instance=new A054512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054513
{
public static readonly long[] Value={ 5L,10L,3L,17L,3L,23L,14L,24L,8L,10L,19L,48L,7L,23L,16L,34L,9L,66L,28L,86L,35L,25L,45L,48L,25L,95L,33L,47L,85L,87L,105L,32L,142L,16L,41L,40L,139L,157L,94L,35L,90L,46L,133L,47L,12L,119L,5L,204L,88L,115L,103L,191L,209L,54L,148L,110L,110L,174L,94L,218L,1L,244L,27L,1L,278L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054513Inst : IEnumerable<long>
{
public static readonly long[] Value=A054513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054513.Bytes);
public long this[int i]=>Value[i];

public static A054513Inst Instance=new A054513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054514
{
public static readonly long[] Value={ 1L,1L,1L,5L,10L,16L,45L,109L,222L,540L,1341L,3065L,7328L,18112L,43530L,105390L,260254L,639244L,1570257L,3893805L,9669236L,24014264L,59903650L,149806494L,374982790L,940835404L,2365679689L,5955973237L,15018854005L,37935575685L,95942896837L,242954350457L,616034170069L,1563810857705L,3974000543475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054514Inst : IEnumerable<long>
{
public static readonly long[] Value=A054514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054514.Bytes);
public long this[int i]=>Value[i];

public static A054514Inst Instance=new A054514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054515
{
public static readonly long[] Value={ 1L,2L,6L,21L,78L,301L,1198L,4888L,20340L,85986L,368239L,1594183L,6965380L,30675399L,136026759L,606848034L,2721783023L,12265670909L,55511013680L,252193872912L,1149742659556L,5258257323304L,24117924005616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054515Inst : IEnumerable<long>
{
public static readonly long[] Value=A054515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054515.Bytes);
public long this[int i]=>Value[i];

public static A054515Inst Instance=new A054515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054516
{
public static readonly long[] Value={ 0L,2L,2L,6L,-4L,50L,-258L,1862L,-14824L,133506L,-1334950L,14684582L,-176214828L,2290792946L,-32071101034L,481066515750L,-7697064251728L,130850092279682L,-2355301661033934L,44750731559645126L,-895014631192902100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054516Inst : IEnumerable<long>
{
public static readonly long[] Value=A054516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054516.Bytes);
public long this[int i]=>Value[i];

public static A054516Inst Instance=new A054516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054517
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,32L,64L,103L,128L,171L,213L,256L,301L,342L,439L,475L,494L,512L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054517Inst : IEnumerable<long>
{
public static readonly long[] Value=A054517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054517.Bytes);
public long this[int i]=>Value[i];

public static A054517Inst Instance=new A054517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054518
{
public static readonly long[] Value={ 10L,12L,15L,18L,21L,24L,25L,26L,27L,28L,36L,39L,40L,42L,45L,46L,48L,49L,51L,52L,54L,56L,57L,58L,60L,62L,63L,64L,65L,68L,69L,72L,75L,78L,80L,81L,82L,84L,85L,86L,87L,90L,93L,94L,96L,100L,102L,105L,108L,114L,115L,116L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054518Inst : IEnumerable<long>
{
public static readonly long[] Value=A054518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054518.Bytes);
public long this[int i]=>Value[i];

public static A054518Inst Instance=new A054518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054519
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,11L,15L,17L,21L,24L,28L,30L,36L,38L,42L,46L,51L,53L,59L,61L,67L,71L,75L,77L,85L,88L,92L,96L,102L,104L,112L,114L,120L,124L,128L,132L,141L,143L,147L,151L,159L,161L,169L,171L,177L,183L,187L,189L,199L,202L,208L,212L,218L,220L,228L,232L,240L,244L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054519Inst : IEnumerable<long>
{
public static readonly long[] Value=A054519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054519.Bytes);
public long this[int i]=>Value[i];

public static A054519Inst Instance=new A054519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054520
{
public static readonly long[] Value={ 1L,25L,45L,65L,81L,85L,105L,117L,125L,145L,153L,165L,169L,185L,189L,205L,221L,225L,245L,261L,265L,273L,285L,289L,297L,305L,325L,333L,345L,357L,365L,369L,377L,385L,405L,425L,429L,441L,445L,465L,477L,481L,485L,493L,505L,513L,525L,533L,545L,549L,561L,565L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054520Inst : IEnumerable<long>
{
public static readonly long[] Value=A054520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054520.Bytes);
public long this[int i]=>Value[i];

public static A054520Inst Instance=new A054520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054521
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054521Inst : IEnumerable<long>
{
public static readonly long[] Value=A054521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054521.Bytes);
public long this[int i]=>Value[i];

public static A054521Inst Instance=new A054521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054522
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,0L,4L,1L,1L,2L,0L,0L,2L,1L,0L,0L,0L,0L,0L,6L,1L,1L,0L,2L,0L,0L,0L,4L,1L,0L,2L,0L,0L,0L,0L,0L,6L,1L,1L,0L,0L,4L,0L,0L,0L,0L,4L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,1L,1L,2L,2L,0L,2L,0L,0L,0L,0L,0L,4L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,1L,1L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054522Inst : IEnumerable<long>
{
public static readonly long[] Value=A054522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054522.Bytes);
public long this[int i]=>Value[i];

public static A054522Inst Instance=new A054522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054523
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,1L,0L,1L,4L,0L,0L,0L,1L,2L,2L,1L,0L,0L,1L,6L,0L,0L,0L,0L,0L,1L,4L,2L,0L,1L,0L,0L,0L,1L,6L,0L,2L,0L,0L,0L,0L,0L,1L,4L,4L,0L,0L,1L,0L,0L,0L,0L,1L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,4L,2L,2L,2L,0L,1L,0L,0L,0L,0L,0L,1L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054523Inst : IEnumerable<long>
{
public static readonly long[] Value=A054523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054523.Bytes);
public long this[int i]=>Value[i];

public static A054523Inst Instance=new A054523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054524
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,-1L,1L,-1L,0L,0L,1L,0L,0L,0L,-1L,1L,-1L,-1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,-1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054524Inst : IEnumerable<long>
{
public static readonly long[] Value=A054524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054524.Bytes);
public long this[int i]=>Value[i];

public static A054524Inst Instance=new A054524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054525
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,0L,0L,0L,1L,1L,-1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,0L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054525Inst : IEnumerable<long>
{
public static readonly long[] Value=A054525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054525.Bytes);
public long this[int i]=>Value[i];

public static A054525Inst Instance=new A054525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054526
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,4L,2L,1L,1L,2L,2L,4L,2L,6L,1L,1L,2L,2L,4L,2L,6L,4L,1L,1L,2L,2L,4L,2L,6L,4L,6L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,4L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054526Inst : IEnumerable<long>
{
public static readonly long[] Value=A054526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054526.Bytes);
public long this[int i]=>Value[i];

public static A054526Inst Instance=new A054526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054527
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,-1L,-1L,0L,-1L,1L,1L,-1L,-1L,0L,-1L,1L,-1L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054527Inst : IEnumerable<long>
{
public static readonly long[] Value=A054527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054527.Bytes);
public long this[int i]=>Value[i];

public static A054527Inst Instance=new A054527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054528
{
public static readonly long[] Value={ 1L,2L,0L,1L,0L,1L,2L,0L,2L,0L,1L,2L,2L,0L,1L,2L,0L,4L,2L,2L,0L,1L,0L,3L,8L,3L,0L,1L,2L,0L,10L,4L,6L,6L,2L,0L,1L,2L,8L,6L,14L,16L,4L,0L,1L,2L,0L,8L,12L,28L,22L,12L,8L,2L,0L,1L,2L,9L,22L,34L,34L,38L,26L,5L,0L,1L,2L,0L,10L,20L,60L,70L,64L,54L,26L,8L,2L,0L,1L,2L,14L,22L,67L,130L,132L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054528Inst : IEnumerable<long>
{
public static readonly long[] Value=A054528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054528.Bytes);
public long this[int i]=>Value[i];

public static A054528Inst Instance=new A054528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054529
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,10L,8L,8L,9L,10L,14L,20L,7L,14L,28L,16L,21L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054529Inst : IEnumerable<long>
{
public static readonly long[] Value=A054529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054529.Bytes);
public long this[int i]=>Value[i];

public static A054529Inst Instance=new A054529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054530
{
public static readonly long[] Value={ 0L,0L,2L,8L,4L,6L,12L,22L,20L,22L,24L,56L,54L,56L,76L,80L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054530Inst : IEnumerable<long>
{
public static readonly long[] Value=A054530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054530.Bytes);
public long this[int i]=>Value[i];

public static A054530Inst Instance=new A054530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054531
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,2L,4L,1L,5L,5L,5L,5L,1L,6L,3L,2L,3L,6L,1L,7L,7L,7L,7L,7L,7L,1L,8L,4L,8L,2L,8L,4L,8L,1L,9L,9L,3L,9L,9L,3L,9L,9L,1L,10L,5L,10L,5L,2L,5L,10L,5L,10L,1L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,1L,12L,6L,4L,3L,12L,2L,12L,3L,4L,6L,12L,1L,13L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054531Inst : IEnumerable<long>
{
public static readonly long[] Value=A054531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054531.Bytes);
public long this[int i]=>Value[i];

public static A054531Inst Instance=new A054531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054532
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,2L,1L,1L,-1L,2L,1L,-1L,-1L,0L,4L,1L,1L,2L,-2L,-1L,2L,1L,-1L,-1L,0L,-1L,1L,6L,1L,1L,-1L,2L,-1L,-1L,-1L,4L,1L,-1L,2L,0L,-1L,-2L,-1L,0L,6L,1L,1L,-1L,-2L,4L,-1L,-1L,0L,0L,4L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,10L,1L,1L,2L,2L,-1L,2L,-1L,-4L,-3L,-1L,-1L,4L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054532Inst : IEnumerable<long>
{
public static readonly long[] Value=A054532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054532.Bytes);
public long this[int i]=>Value[i];

public static A054532Inst Instance=new A054532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054533
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-1L,2L,0L,-2L,0L,2L,-1L,-1L,-1L,-1L,4L,1L,-1L,-2L,-1L,1L,2L,-1L,-1L,-1L,-1L,-1L,-1L,6L,0L,0L,0L,-4L,0L,0L,0L,4L,0L,0L,-3L,0L,0L,-3L,0L,0L,6L,1L,-1L,1L,-1L,-4L,-1L,1L,-1L,1L,4L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L,0L,2L,0L,-2L,0L,-4L,0L,-2L,0L,2L,0L,4L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054533Inst : IEnumerable<long>
{
public static readonly long[] Value=A054533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054533.Bytes);
public long this[int i]=>Value[i];

public static A054533Inst Instance=new A054533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054534
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,0L,1L,1L,2L,-2L,-1L,1L,-1L,-1L,0L,-1L,1L,1L,1L,-1L,2L,-1L,-1L,-1L,1L,-1L,2L,0L,-1L,-2L,-1L,0L,1L,1L,-1L,-2L,4L,-1L,-1L,0L,0L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,1L,1L,2L,2L,-1L,2L,-1L,-4L,-3L,-1L,-1L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,1L,1L,-1L,-2L,-1L,-1L,6L,0L,0L,-1L,-1L,2L,-1L,1L,-1L,2L,0L,4L,-2L,-1L,0L,-3L,-4L,-1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054534Inst : IEnumerable<long>
{
public static readonly long[] Value=A054534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054534.Bytes);
public long this[int i]=>Value[i];

public static A054534Inst Instance=new A054534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054535
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,1L,0L,-1L,-1L,1L,-1L,-2L,2L,1L,1L,1L,-1L,0L,-1L,-1L,1L,-1L,-1L,-1L,2L,-1L,1L,1L,0L,-1L,-2L,-1L,0L,2L,-1L,1L,0L,0L,-1L,-1L,4L,-2L,-1L,1L,1L,1L,0L,0L,-1L,1L,-1L,0L,-1L,-1L,1L,-1L,-1L,-3L,-4L,-1L,2L,-1L,2L,2L,1L,1L,0L,-1L,1L,0L,0L,-1L,1L,-1L,0L,-1L,-1L,1L,-1L,2L,-1L,-1L,0L,0L,6L,-1L,-1L,-2L,-1L,1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054535Inst : IEnumerable<long>
{
public static readonly long[] Value=A054535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054535.Bytes);
public long this[int i]=>Value[i];

public static A054535Inst Instance=new A054535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054536
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,2L,4L,4L,6L,8L,12L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054536Inst : IEnumerable<long>
{
public static readonly long[] Value=A054536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054536.Bytes);
public long this[int i]=>Value[i];

public static A054536Inst Instance=new A054536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054537
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,4L,4L,6L,8L,12L,16L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054537Inst : IEnumerable<long>
{
public static readonly long[] Value=A054537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054537.Bytes);
public long this[int i]=>Value[i];

public static A054537Inst Instance=new A054537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054538
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,10L,15L,28L,47L,90L,158L,298L,548L,1034L,1928L,3658L,6899L,13136L,24970L,47710L,91181L,174858L,335546L,645436L,1242767L,2397044L,4628198L,8948416L,17318417L,33555466L,65075294L,126324496L,245426708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054538Inst : IEnumerable<long>
{
public static readonly long[] Value=A054538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054538.Bytes);
public long this[int i]=>Value[i];

public static A054538Inst Instance=new A054538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054539
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,15L,26L,47L,86L,158L,293L,548L,1024L,1928L,3643L,6899L,13108L,24970L,47663L,91181L,174768L,335546L,645278L,1242767L,2396746L,4628198L,8947868L,17318417L,33554432L,65075294L,126322568L,245426708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054539Inst : IEnumerable<long>
{
public static readonly long[] Value=A054539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054539.Bytes);
public long this[int i]=>Value[i];

public static A054539Inst Instance=new A054539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054540
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,12L,19L,31L,34L,53L,118L,171L,289L,323L,441L,612L,730L,1171L,1783L,2513L,4296L,12276L,16572L,20868L,25164L,46032L,48545L,52841L,73709L,78005L,151714L,229719L,537443L,714321L,792326L,944040L,1022045L,1251764L,3755292L,3985011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054540Inst : IEnumerable<long>
{
public static readonly long[] Value=A054540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054540.Bytes);
public long this[int i]=>Value[i];

public static A054540Inst Instance=new A054540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054541
{
public static readonly long[] Value={ 2L,1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,6L,4L,2L,4L,6L,6L,2L,6L,4L,2L,6L,4L,6L,8L,4L,2L,4L,2L,4L,14L,4L,6L,2L,10L,2L,6L,6L,4L,6L,6L,2L,10L,2L,4L,2L,12L,12L,4L,2L,4L,6L,2L,10L,6L,6L,6L,2L,6L,4L,2L,10L,14L,4L,2L,4L,14L,6L,10L,2L,4L,6L,8L,6L,6L,4L,6L,8L,4L,8L,10L,2L,10L,2L,6L,4L,6L,8L,4L,2L,4L,12L,8L,4L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054541Inst : IEnumerable<long>
{
public static readonly long[] Value=A054541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054541.Bytes);
public long this[int i]=>Value[i];

public static A054541Inst Instance=new A054541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054542
{
public static readonly long[] Value={ 1L,2L,4L,12L,36L,116L,382L,1287L,4420L,15397L,54264L,193154L,693374L,2507288L,9124560L,33393355L,122821380L,453756765L,1683107800L,6265751310L,23402516280L,87670790155L,329337229104L,1240292449350L,4681874312510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054542Inst : IEnumerable<long>
{
public static readonly long[] Value=A054542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054542.Bytes);
public long this[int i]=>Value[i];

public static A054542Inst Instance=new A054542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054543
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,5L,5L,12L,13L,41L,110L,172L,248L,309L,3146L,5919L,21959L,22299L,30892L,401838L,1719239L,30576561L,262313756L,630913752L,3242181301L,3250783944L,13827502849L,40152067840L,137791590233L,2514510232695L,3217773878849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054543Inst : IEnumerable<long>
{
public static readonly long[] Value=A054543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054543.Bytes);
public long this[int i]=>Value[i];

public static A054543Inst Instance=new A054543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A054544
{
public static readonly long[] Value={ 1L,1L,2L,3L,9L,70L,117L,503L,648L,1078L,12868L,41235L,178650L,377670L,394301L,546185L,2600672L,8729780L,41318679L,83367169L,525961060L,561571346L,1556964264L,1868773845L,15139200289L,27297789005L,30324107039L,56699922000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A054544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A054544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A054544Inst : IEnumerable<long>
{
public static readonly long[] Value=A054544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A054544.Bytes);
public long this[int i]=>Value[i];

public static A054544Inst Instance=new A054544Inst();

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