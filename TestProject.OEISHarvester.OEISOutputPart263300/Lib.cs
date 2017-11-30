using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019928
{
public static readonly long[] Value={ 1L,20L,269L,3040L,31161L,300300L,2775109L,24887960L,218303921L,1882786180L,16026538749L,135010883280L,1127921219881L,9359429537660L,77233958267189L,634411837477000L,5191228487083041L,42342127346986740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019928Inst : IEnumerable<long>
{
public static readonly long[] Value=A019928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019928.Bytes);
public long this[int i]=>Value[i];

public static A019928Inst Instance=new A019928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019929
{
public static readonly long[] Value={ 6L,0L,0L,8L,6L,0L,6L,1L,9L,0L,2L,7L,5L,6L,0L,4L,1L,4L,8L,7L,8L,6L,6L,4L,4L,2L,6L,3L,5L,4L,6L,6L,4L,4L,6L,3L,1L,5L,8L,5L,5L,5L,2L,3L,0L,8L,2L,3L,2L,4L,0L,7L,9L,1L,2L,2L,2L,5L,4L,2L,6L,1L,5L,5L,6L,6L,8L,3L,4L,2L,5L,8L,6L,1L,5L,4L,0L,9L,0L,8L,3L,5L,2L,4L,5L,4L,8L,5L,0L,3L,0L,4L,0L,6L,9L,0L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019929Inst : IEnumerable<long>
{
public static readonly long[] Value=A019929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019929.Bytes);
public long this[int i]=>Value[i];

public static A019929Inst Instance=new A019929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019930
{
public static readonly long[] Value={ 6L,2L,4L,8L,6L,9L,3L,5L,1L,9L,0L,9L,3L,2L,7L,5L,0L,9L,7L,8L,0L,5L,1L,0L,8L,2L,7L,9L,4L,9L,4L,3L,6L,6L,5L,8L,3L,1L,0L,8L,7L,0L,2L,0L,2L,8L,4L,2L,7L,0L,4L,9L,6L,6L,7L,6L,3L,6L,5L,7L,3L,8L,0L,3L,3L,2L,9L,3L,3L,6L,4L,7L,5L,9L,6L,3L,9L,4L,8L,5L,8L,4L,4L,1L,0L,3L,8L,2L,7L,8L,8L,6L,1L,4L,6L,8L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019930Inst : IEnumerable<long>
{
public static readonly long[] Value=A019930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019930.Bytes);
public long this[int i]=>Value[i];

public static A019930Inst Instance=new A019930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019931
{
public static readonly long[] Value={ 6L,4L,9L,4L,0L,7L,5L,9L,3L,1L,9L,7L,5L,1L,0L,5L,7L,6L,9L,8L,2L,0L,6L,2L,9L,1L,1L,3L,1L,1L,4L,4L,8L,6L,1L,5L,7L,3L,3L,5L,2L,5L,6L,7L,5L,3L,0L,9L,6L,2L,8L,6L,4L,6L,6L,8L,6L,6L,4L,5L,1L,2L,9L,0L,0L,1L,2L,7L,6L,4L,5L,2L,2L,8L,1L,5L,0L,7L,4L,2L,6L,3L,8L,6L,5L,2L,4L,9L,1L,3L,5L,9L,1L,2L,5L,9L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019931Inst : IEnumerable<long>
{
public static readonly long[] Value=A019931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019931.Bytes);
public long this[int i]=>Value[i];

public static A019931Inst Instance=new A019931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019932
{
public static readonly long[] Value={ 6L,7L,4L,5L,0L,8L,5L,1L,6L,8L,4L,2L,4L,2L,6L,6L,3L,2L,1L,4L,2L,4L,6L,0L,8L,6L,1L,9L,9L,4L,6L,0L,9L,4L,8L,7L,5L,3L,5L,0L,8L,6L,5L,9L,1L,3L,1L,6L,2L,7L,3L,7L,4L,7L,8L,4L,1L,6L,2L,9L,4L,4L,3L,0L,2L,8L,0L,1L,7L,6L,0L,9L,8L,1L,7L,1L,4L,5L,1L,9L,3L,2L,1L,7L,1L,4L,0L,5L,9L,7L,1L,6L,6L,4L,0L,1L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019932Inst : IEnumerable<long>
{
public static readonly long[] Value=A019932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019932.Bytes);
public long this[int i]=>Value[i];

public static A019932Inst Instance=new A019932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020125
{
public static readonly long[] Value={ 1L,1L,2L,5L,17L,81L,468L,3197L,25043L,221209L,2175217L,23564851L,278850731L,3578584369L,49503750433L,734305631413L,11626505830702L,195712848150141L,3490212458677515L,65732334638426517L,1303691303662125906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020125Inst : IEnumerable<long>
{
public static readonly long[] Value=A020125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020125.Bytes);
public long this[int i]=>Value[i];

public static A020125Inst Instance=new A020125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020126
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,6L,29L,178L,1270L,10366L,95020L,966033L,10787363L,131246246L,1728075563L,24481070470L,371296235456L,6002622473193L,103045019123133L,1871984514070245L,35879703186346360L,723574014257984911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020126Inst : IEnumerable<long>
{
public static readonly long[] Value=A020126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020126.Bytes);
public long this[int i]=>Value[i];

public static A020126Inst Instance=new A020126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020127
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,74L,427L,2901L,22625L,199095L,1951128L,21072176L,248651669L,3182741352L,43921830648L,650043093589L,10270680878694L,172547438762056L,3071344409964595L,57741274907334371L,1143277243165220534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020127Inst : IEnumerable<long>
{
public static readonly long[] Value=A020127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020127.Bytes);
public long this[int i]=>Value[i];

public static A020127Inst Instance=new A020127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020128
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,42L,232L,1528L,11611L,99851L,958562L,10160756L,117864769L,1485096082L,20197306709L,294880677942L,4600138575888L,76362300359741L,1343976486331426L,24997962645764523L,489960067856984639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020128Inst : IEnumerable<long>
{
public static readonly long[] Value=A020128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020128.Bytes);
public long this[int i]=>Value[i];

public static A020128Inst Instance=new A020128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020129
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,21L,109L,695L,5143L,43194L,406017L,4222570L,48137292L,596902409L,7998492274L,115178288737L,1773745646540L,29089428603256L,506156057696642L,9313271461618196L,180677466355392996L,3685820313650017112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020129Inst : IEnumerable<long>
{
public static readonly long[] Value=A020129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020129.Bytes);
public long this[int i]=>Value[i];

public static A020129Inst Instance=new A020129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020130
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,8L,37L,229L,1648L,13508L,124269L,1267543L,14196478L,173197025L,2286200719L,32464050200L,493453563030L,7993947721072L,137495900802424L,2502425394604114L,48046567576398987L,970540665043259526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020130Inst : IEnumerable<long>
{
public static readonly long[] Value=A020130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020130.Bytes);
public long this[int i]=>Value[i];

public static A020130Inst Instance=new A020130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020131
{
public static readonly long[] Value={ 1L,1L,2L,4L,14L,65L,370L,2496L,19339L,169215L,1649844L,17735823L,208395916L,2657047924L,36534408954L,538882532061L,8487399879955L,142163947989233L,2523410076808877L,47313938940166439L,934450294068287158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020131Inst : IEnumerable<long>
{
public static readonly long[] Value=A020131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020131.Bytes);
public long this[int i]=>Value[i];

public static A020131Inst Instance=new A020131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020132
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,10L,51L,319L,2311L,19061L,176311L,1807182L,20330789L,249052162L,3299941146L,47024161318L,717118460091L,11653174976469L,201017268344079L,3668565147279424L,70619879085128904L,1430052551473860293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020132Inst : IEnumerable<long>
{
public static readonly long[] Value=A020132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020132.Bytes);
public long this[int i]=>Value[i];

public static A020132Inst Instance=new A020132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020133
{
public static readonly long[] Value={ 1L,1L,2L,3L,11L,51L,288L,1916L,14685L,127263L,1230202L,13122150L,153091745L,1939162101L,26501882046L,388694270001L,6089543563341L,101492392722343L,1793032271428053L,33469935733323642L,658242069422031619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020133Inst : IEnumerable<long>
{
public static readonly long[] Value=A020133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020133.Bytes);
public long this[int i]=>Value[i];

public static A020133Inst Instance=new A020133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020134
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,15L,80L,506L,3711L,30921L,288592L,2982110L,33797241L,416832634L,5557768441L,79661347642L,1221473997165L,19950741953682L,345812860530488L,6339902443058942L,122571447232472866L,2492286093726948269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020134Inst : IEnumerable<long>
{
public static readonly long[] Value=A020134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020134.Bytes);
public long this[int i]=>Value[i];

public static A020134Inst Instance=new A020134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020135
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,30L,163L,1056L,7919L,67304L,639384L,6713531L,77205602L,965070018L,13028445232L,188912455861L,2928143065835L,48314360586265L,845501310259628L,15641774239803108L,305014597676160594L,6252799252361292174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020135Inst : IEnumerable<long>
{
public static readonly long[] Value=A020135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020135.Bytes);
public long this[int i]=>Value[i];

public static A020135Inst Instance=new A020135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020136
{
public static readonly long[] Value={ 15L,85L,91L,341L,435L,451L,561L,645L,703L,1105L,1247L,1271L,1387L,1581L,1695L,1729L,1891L,1905L,2047L,2071L,2465L,2701L,2821L,3133L,3277L,3367L,3683L,4033L,4369L,4371L,4681L,4795L,4859L,5461L,5551L,6601L,6643L,7957L,8321L,8481L,8695L,8911L,9061L,9131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020136Inst : IEnumerable<long>
{
public static readonly long[] Value=A020136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020136.Bytes);
public long this[int i]=>Value[i];

public static A020136Inst Instance=new A020136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020137
{
public static readonly long[] Value={ 9L,21L,45L,63L,65L,105L,117L,133L,153L,231L,273L,341L,481L,511L,561L,585L,645L,651L,861L,949L,1001L,1105L,1281L,1365L,1387L,1417L,1541L,1649L,1661L,1729L,1785L,1905L,2047L,2169L,2465L,2501L,2701L,2821L,3145L,3171L,3201L,3277L,3605L,3641L,4005L,4033L,4097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020137Inst : IEnumerable<long>
{
public static readonly long[] Value=A020137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020137.Bytes);
public long this[int i]=>Value[i];

public static A020137Inst Instance=new A020137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020138
{
public static readonly long[] Value={ 4L,8L,28L,52L,91L,121L,205L,286L,364L,511L,532L,616L,671L,697L,703L,946L,949L,1036L,1105L,1288L,1387L,1541L,1729L,1891L,2465L,2501L,2665L,2701L,2806L,2821L,2926L,3052L,3281L,3367L,3751L,4376L,4636L,4961L,5356L,5551L,6364L,6601L,6643L,7081L,7381L,7913L,8401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020138Inst : IEnumerable<long>
{
public static readonly long[] Value=A020138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020138.Bytes);
public long this[int i]=>Value[i];

public static A020138Inst Instance=new A020138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020139
{
public static readonly long[] Value={ 10L,15L,70L,133L,190L,259L,305L,481L,645L,703L,793L,1105L,1330L,1729L,2047L,2257L,2465L,2821L,4577L,4921L,5041L,5185L,6601L,7869L,8113L,8170L,8695L,8911L,9730L,10585L,12403L,13333L,14521L,14981L,15841L,16705L,17711L,18705L,23377L,24130L,24727L,26335L,26467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020139Inst : IEnumerable<long>
{
public static readonly long[] Value=A020139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020139.Bytes);
public long this[int i]=>Value[i];

public static A020139Inst Instance=new A020139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020140
{
public static readonly long[] Value={ 65L,91L,133L,143L,145L,247L,377L,385L,703L,1045L,1099L,1105L,1649L,1729L,1885L,1891L,2041L,2233L,2465L,2701L,2821L,2983L,3367L,3553L,5005L,5365L,5551L,5785L,6061L,6305L,6601L,8911L,9073L,10585L,11077L,12403L,12673L,12905L,13051L,13333L,13345L,13585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020140Inst : IEnumerable<long>
{
public static readonly long[] Value=A020140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020140.Bytes);
public long this[int i]=>Value[i];

public static A020140Inst Instance=new A020140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020205
{
public static readonly long[] Value={ 4L,38L,39L,57L,65L,76L,247L,285L,703L,741L,969L,1105L,1387L,1513L,1653L,1891L,2465L,2701L,2806L,2965L,3705L,4033L,4371L,4636L,5073L,5461L,5713L,5785L,6305L,6441L,6533L,6541L,7633L,7709L,7957L,10081L,10585L,10777L,11229L,12871L,13051L,16017L,16745L,17081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020205Inst : IEnumerable<long>
{
public static readonly long[] Value=A020205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020205.Bytes);
public long this[int i]=>Value[i];

public static A020205Inst Instance=new A020205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020206
{
public static readonly long[] Value={ 77L,341L,385L,451L,553L,703L,869L,1045L,1247L,1271L,1441L,1849L,1921L,2047L,2465L,2765L,3097L,4061L,4187L,4345L,4577L,5371L,6031L,6083L,6085L,6545L,6601L,8321L,8911L,8965L,10585L,13333L,13981L,15211L,15251L,15841L,17711L,17767L,20689L,22801L,23281L,23617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020206Inst : IEnumerable<long>
{
public static readonly long[] Value=A020206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020206.Bytes);
public long this[int i]=>Value[i];

public static A020206Inst Instance=new A020206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020207
{
public static readonly long[] Value={ 6L,15L,26L,39L,49L,65L,78L,91L,195L,301L,559L,561L,637L,1105L,1649L,1729L,2107L,2465L,2626L,2665L,2701L,2821L,3201L,3913L,4215L,4753L,5055L,6305L,6533L,6601L,7051L,7107L,7361L,7543L,8149L,8321L,8911L,9331L,9773L,9881L,10585L,10621L,12001L,14491L,14689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020207Inst : IEnumerable<long>
{
public static readonly long[] Value=A020207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020207.Bytes);
public long this[int i]=>Value[i];

public static A020207Inst Instance=new A020207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020208
{
public static readonly long[] Value={ 9L,27L,49L,81L,169L,237L,301L,333L,481L,553L,561L,637L,711L,891L,1221L,1377L,1557L,1729L,1813L,1891L,2107L,2133L,2553L,2821L,2871L,2997L,3321L,3397L,3439L,3537L,3577L,3871L,3913L,5461L,6253L,6399L,6401L,6533L,6601L,6697L,7107L,7189L,7613L,7821L,8261L,8281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020208Inst : IEnumerable<long>
{
public static readonly long[] Value=A020208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020208.Bytes);
public long this[int i]=>Value[i];

public static A020208Inst Instance=new A020208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020209
{
public static readonly long[] Value={ 4L,8L,10L,16L,20L,28L,40L,52L,70L,80L,85L,91L,112L,121L,130L,176L,190L,205L,208L,232L,280L,286L,292L,364L,370L,451L,496L,511L,520L,532L,616L,671L,697L,703L,730L,742L,910L,946L,949L,965L,976L,1036L,1105L,1168L,1261L,1288L,1387L,1435L,1456L,1541L,1606L,1729L,1891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020209Inst : IEnumerable<long>
{
public static readonly long[] Value=A020209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020209.Bytes);
public long this[int i]=>Value[i];

public static A020209Inst Instance=new A020209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020210
{
public static readonly long[] Value={ 9L,25L,27L,45L,81L,91L,225L,249L,325L,405L,481L,511L,561L,645L,747L,793L,891L,925L,949L,1105L,1245L,1247L,1345L,1377L,1387L,1431L,1525L,1541L,1729L,1825L,2025L,2071L,2101L,2241L,2257L,2421L,2465L,2701L,2821L,2871L,2905L,3825L,4033L,4239L,4453L,5185L,5611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020210Inst : IEnumerable<long>
{
public static readonly long[] Value=A020210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020210.Bytes);
public long this[int i]=>Value[i];

public static A020210Inst Instance=new A020210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020211
{
public static readonly long[] Value={ 21L,65L,82L,105L,123L,133L,205L,231L,265L,273L,287L,451L,533L,561L,689L,697L,703L,861L,1001L,1105L,1113L,1241L,1365L,1558L,1729L,1785L,1891L,2173L,2465L,2569L,2665L,2821L,2993L,3034L,3277L,3445L,4081L,4305L,4411L,4505L,4641L,4745L,5565L,5713L,6541L,6601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020211Inst : IEnumerable<long>
{
public static readonly long[] Value=A020211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020211.Bytes);
public long this[int i]=>Value[i];

public static A020211Inst Instance=new A020211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020212
{
public static readonly long[] Value={ 85L,415L,481L,703L,1105L,1111L,1411L,1615L,2465L,2501L,2509L,2981L,3145L,3655L,3667L,4141L,5713L,6161L,6533L,6973L,7055L,7141L,7201L,7885L,8401L,8695L,9061L,10585L,11441L,13019L,13579L,13981L,14023L,14383L,14491L,15181L,15251L,15355L,15521L,16405L,16745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020212Inst : IEnumerable<long>
{
public static readonly long[] Value=A020212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020212.Bytes);
public long this[int i]=>Value[i];

public static A020212Inst Instance=new A020212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020213
{
public static readonly long[] Value={ 4L,6L,12L,14L,21L,28L,42L,84L,129L,231L,259L,276L,301L,341L,481L,532L,651L,703L,781L,903L,1281L,1351L,1491L,1591L,1729L,2047L,2201L,2509L,2701L,2821L,3097L,3201L,3277L,3311L,3913L,3972L,4371L,4564L,4577L,4681L,4859L,5289L,5662L,6031L,6601L,7141L,7161L,7543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020213Inst : IEnumerable<long>
{
public static readonly long[] Value=A020213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020213.Bytes);
public long this[int i]=>Value[i];

public static A020213Inst Instance=new A020213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020214
{
public static readonly long[] Value={ 15L,51L,65L,85L,87L,145L,221L,255L,377L,435L,451L,493L,561L,595L,703L,1015L,1105L,1479L,1729L,1885L,1891L,2091L,2465L,2755L,2821L,2845L,3091L,3451L,4033L,5365L,5685L,6409L,6601L,7395L,7397L,7483L,7701L,8695L,8911L,9061L,9673L,10585L,10991L,11041L,11305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020214Inst : IEnumerable<long>
{
public static readonly long[] Value=A020214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020214.Bytes);
public long this[int i]=>Value[i];

public static A020214Inst Instance=new A020214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020215
{
public static readonly long[] Value={ 86L,91L,133L,217L,247L,301L,385L,403L,473L,559L,589L,817L,1045L,1105L,1111L,1333L,1661L,1705L,1729L,2047L,2365L,2626L,2651L,2821L,3553L,3565L,3785L,3913L,4123L,4141L,4681L,5005L,5461L,5719L,6533L,6601L,7471L,7483L,7657L,8029L,8041L,8401L,8686L,8911L,9331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020215Inst : IEnumerable<long>
{
public static readonly long[] Value=A020215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020215.Bytes);
public long this[int i]=>Value[i];

public static A020215Inst Instance=new A020215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020216
{
public static readonly long[] Value={ 87L,91L,133L,145L,217L,247L,267L,403L,445L,481L,589L,645L,1105L,1247L,1729L,1885L,1891L,2047L,2465L,2581L,2611L,2821L,3165L,3565L,4123L,4331L,4849L,4921L,5365L,5551L,5785L,6119L,6601L,6697L,7087L,7657L,7743L,7745L,8029L,8911L,9073L,10585L,11481L,11563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020216Inst : IEnumerable<long>
{
public static readonly long[] Value=A020216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020216.Bytes);
public long this[int i]=>Value[i];

public static A020216Inst Instance=new A020216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020217
{
public static readonly long[] Value={ 4L,8L,9L,15L,22L,33L,44L,45L,55L,85L,88L,99L,153L,165L,169L,341L,385L,495L,561L,765L,1035L,1045L,1105L,1165L,1309L,1387L,1441L,1541L,1581L,1649L,1729L,2097L,2465L,2529L,2611L,2701L,2805L,2821L,2977L,3015L,3201L,3961L,4015L,4061L,4187L,4371L,4777L,4849L,5005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020217Inst : IEnumerable<long>
{
public static readonly long[] Value=A020217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020217.Bytes);
public long this[int i]=>Value[i];

public static A020217Inst Instance=new A020217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020218
{
public static readonly long[] Value={ 91L,623L,703L,793L,1001L,1157L,1729L,2047L,2413L,2821L,3091L,3367L,4033L,4699L,6281L,6601L,8099L,8321L,8401L,8911L,11521L,11557L,12403L,13021L,13333L,13981L,14701L,14981L,15841L,17701L,19307L,19951L,20017L,20263L,24641L,24661L,25571L,29341L,31021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020218Inst : IEnumerable<long>
{
public static readonly long[] Value=A020218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020218.Bytes);
public long this[int i]=>Value[i];

public static A020218Inst Instance=new A020218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020219
{
public static readonly long[] Value={ 6L,9L,10L,15L,18L,30L,45L,66L,69L,90L,115L,205L,207L,341L,345L,369L,435L,505L,561L,909L,1035L,1065L,1387L,1446L,1541L,1845L,2047L,2059L,2465L,2651L,2701L,2829L,2871L,3015L,4005L,4141L,4187L,4371L,4545L,5963L,6273L,6533L,6969L,7471L,8646L,9361L,9881L,10585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020219Inst : IEnumerable<long>
{
public static readonly long[] Value=A020219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020219.Bytes);
public long this[int i]=>Value[i];

public static A020219Inst Instance=new A020219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020220
{
public static readonly long[] Value={ 21L,39L,65L,91L,93L,105L,217L,231L,273L,301L,341L,403L,451L,465L,559L,561L,651L,861L,1001L,1085L,1105L,1209L,1271L,1333L,1365L,1393L,1661L,1729L,2465L,2587L,2701L,2821L,3171L,3731L,3781L,3913L,4033L,4123L,4371L,4641L,4681L,5565L,6045L,6169L,6191L,6697L,7161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020220Inst : IEnumerable<long>
{
public static readonly long[] Value=A020220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020220.Bytes);
public long this[int i]=>Value[i];

public static A020220Inst Instance=new A020220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020253
{
public static readonly long[] Value={ 121L,133L,259L,365L,703L,1649L,1891L,3281L,4921L,5461L,8401L,8911L,9809L,9841L,9881L,10585L,12403L,13019L,13073L,13333L,16531L,18721L,19345L,21901L,23521L,26467L,26599L,29891L,31621L,35371L,37969L,44287L,47197L,48133L,50171L,52801L,55537L,55969L,63139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020253Inst : IEnumerable<long>
{
public static readonly long[] Value=A020253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020253.Bytes);
public long this[int i]=>Value[i];

public static A020253Inst Instance=new A020253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020254
{
public static readonly long[] Value={ 9L,27L,361L,529L,785L,1431L,2041L,4699L,5149L,8401L,14981L,17767L,27133L,28009L,32551L,33227L,35443L,38503L,43213L,68143L,80137L,81317L,82513L,96139L,97567L,97831L,113521L,123391L,124501L,133141L,146507L,146611L,159259L,187461L,219781L,220585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020254Inst : IEnumerable<long>
{
public static readonly long[] Value=A020254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020254.Bytes);
public long this[int i]=>Value[i];

public static A020254Inst Instance=new A020254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020255
{
public static readonly long[] Value={ 15L,91L,341L,469L,871L,2257L,4371L,4411L,5149L,6097L,8401L,11581L,12431L,15577L,16471L,19093L,25681L,28009L,29539L,31417L,33001L,48133L,49141L,54913L,79003L,111361L,131773L,136741L,157651L,164737L,170431L,180571L,188191L,191351L,217801L,218791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020255Inst : IEnumerable<long>
{
public static readonly long[] Value=A020255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020255.Bytes);
public long this[int i]=>Value[i];

public static A020255Inst Instance=new A020255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020256
{
public static readonly long[] Value={ 49L,133L,341L,403L,871L,901L,931L,2059L,2077L,3277L,6031L,8023L,8401L,9881L,11041L,17593L,24929L,26599L,27001L,27133L,33227L,38503L,42127L,43213L,48133L,54961L,66197L,79003L,96049L,106597L,127697L,135137L,137801L,148417L,149761L,163081L,170431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020256Inst : IEnumerable<long>
{
public static readonly long[] Value=A020256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020256.Bytes);
public long this[int i]=>Value[i];

public static A020256Inst Instance=new A020256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020257
{
public static readonly long[] Value={ 15L,49L,133L,481L,931L,6241L,8911L,9131L,10963L,11041L,14191L,17767L,29341L,56033L,58969L,68251L,79003L,83333L,87061L,88183L,113527L,130561L,131407L,164737L,190861L,197209L,206981L,210337L,229633L,244949L,264223L,269011L,270943L,347263L,389777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020257Inst : IEnumerable<long>
{
public static readonly long[] Value=A020257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020257.Bytes);
public long this[int i]=>Value[i];

public static A020257Inst Instance=new A020257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020258
{
public static readonly long[] Value={ 25L,33L,205L,217L,325L,793L,1025L,1057L,1525L,2047L,2665L,2761L,3277L,4033L,4141L,4681L,6697L,8321L,9017L,9073L,12025L,12083L,12505L,15457L,15841L,17173L,18631L,19729L,19825L,20263L,22177L,27379L,27613L,28085L,29341L,32767L,33025L,35425L,42799L,44561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020258Inst : IEnumerable<long>
{
public static readonly long[] Value=A020258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020258.Bytes);
public long this[int i]=>Value[i];

public static A020258Inst Instance=new A020258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020259
{
public static readonly long[] Value={ 545L,1057L,1417L,2501L,5461L,5713L,5833L,6533L,9073L,12403L,24727L,26797L,30857L,30889L,33227L,43033L,49141L,54289L,63631L,75241L,87913L,96641L,100717L,115669L,141571L,145351L,153481L,163831L,193561L,194923L,197209L,197633L,211069L,227767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020259Inst : IEnumerable<long>
{
public static readonly long[] Value=A020259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020259.Bytes);
public long this[int i]=>Value[i];

public static A020259Inst Instance=new A020259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020260
{
public static readonly long[] Value={ 33L,35L,671L,1157L,2059L,2071L,6533L,7861L,8911L,10745L,13897L,14111L,14689L,15505L,16237L,22177L,24929L,31417L,49051L,53585L,54161L,75241L,88537L,94657L,96049L,97693L,104653L,117157L,133141L,136001L,136681L,145351L,146611L,148417L,162835L,196093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020260Inst : IEnumerable<long>
{
public static readonly long[] Value=A020260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020260.Bytes);
public long this[int i]=>Value[i];

public static A020260Inst Instance=new A020260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020261
{
public static readonly long[] Value={ 9L,1261L,2701L,2871L,5083L,11041L,13051L,15051L,16441L,16589L,22681L,23959L,31201L,31621L,38081L,39091L,44749L,49601L,49771L,50737L,54223L,74023L,79381L,100081L,113527L,117157L,151061L,151313L,154201L,160147L,169801L,203841L,282133L,304057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020261Inst : IEnumerable<long>
{
public static readonly long[] Value=A020261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020261.Bytes);
public long this[int i]=>Value[i];

public static A020261Inst Instance=new A020261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020262
{
public static readonly long[] Value={ 35L,217L,301L,481L,1111L,1261L,1333L,2701L,3421L,3565L,3589L,4123L,4495L,5713L,6533L,8365L,8911L,9331L,11041L,14315L,14701L,20017L,25327L,29341L,30535L,31021L,31411L,31621L,34441L,35371L,36301L,37231L,39305L,39493L,42127L,43621L,44801L,45451L,46657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020262Inst : IEnumerable<long>
{
public static readonly long[] Value=A020262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020262.Bytes);
public long this[int i]=>Value[i];

public static A020262Inst Instance=new A020262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020263
{
public static readonly long[] Value={ 9L,451L,469L,589L,685L,817L,1333L,3781L,8905L,9271L,18631L,19517L,20591L,25327L,34237L,45551L,46981L,47587L,48133L,59563L,61337L,68101L,68251L,73633L,79381L,79501L,83333L,84151L,96727L,111361L,113527L,127697L,175111L,178709L,188191L,191351L,219781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020263Inst : IEnumerable<long>
{
public static readonly long[] Value=A020263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020263.Bytes);
public long this[int i]=>Value[i];

public static A020263Inst Instance=new A020263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020264
{
public static readonly long[] Value={ 39L,85L,91L,289L,469L,871L,1445L,4033L,4681L,5461L,6031L,6097L,6931L,7449L,7613L,10649L,15051L,16129L,17767L,21097L,22177L,25829L,28991L,31021L,34997L,38311L,42121L,49141L,54871L,73801L,75241L,81217L,88831L,94831L,104653L,117157L,127697L,133141L,145351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020264Inst : IEnumerable<long>
{
public static readonly long[] Value=A020264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020264.Bytes);
public long this[int i]=>Value[i];

public static A020264Inst Instance=new A020264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020265
{
public static readonly long[] Value={ 133L,1561L,2047L,3053L,3439L,4141L,4237L,5921L,6533L,8149L,8911L,12431L,16589L,20567L,22681L,23521L,29659L,31021L,31201L,38503L,48391L,49051L,50737L,53971L,58213L,58769L,61579L,76591L,76861L,79381L,84169L,94657L,114017L,117157L,119341L,132193L,136681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020265Inst : IEnumerable<long>
{
public static readonly long[] Value=A020265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020265.Bytes);
public long this[int i]=>Value[i];

public static A020265Inst Instance=new A020265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020266
{
public static readonly long[] Value={ 39L,121L,289L,451L,703L,1561L,1921L,4961L,5729L,6601L,7111L,7201L,10897L,11041L,12403L,13333L,14023L,14701L,15211L,15793L,23521L,26797L,27133L,32657L,38081L,38503L,43213L,43621L,48133L,67721L,72433L,85879L,94249L,97393L,104977L,113201L,128143L,161701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020266Inst : IEnumerable<long>
{
public static readonly long[] Value=A020266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020266.Bytes);
public long this[int i]=>Value[i];

public static A020266Inst Instance=new A020266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020267
{
public static readonly long[] Value={ 21L,231L,671L,703L,841L,1281L,1387L,1417L,2701L,3829L,8321L,8911L,10933L,13019L,14091L,20591L,21667L,25909L,43213L,43273L,45221L,45449L,47197L,48133L,51319L,60551L,74089L,76861L,79381L,80137L,84941L,86331L,91669L,106491L,109981L,110293L,111361L,113401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020267Inst : IEnumerable<long>
{
public static readonly long[] Value=A020267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020267.Bytes);
public long this[int i]=>Value[i];

public static A020267Inst Instance=new A020267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020268
{
public static readonly long[] Value={ 451L,529L,1247L,1541L,1765L,1807L,1991L,7421L,9773L,11041L,12167L,13333L,14491L,14981L,17611L,18721L,23521L,27511L,31417L,35443L,65305L,65641L,68101L,74089L,79003L,81631L,96727L,102719L,104653L,105271L,109061L,128143L,130561L,145351L,161101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020268Inst : IEnumerable<long>
{
public static readonly long[] Value=A020268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020268.Bytes);
public long this[int i]=>Value[i];

public static A020268Inst Instance=new A020268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020381
{
public static readonly long[] Value={ 571L,724L,889L,907L,1081L,1348L,1477L,1576L,1619L,1633L,1636L,1732L,1786L,1841L,2073L,2167L,2253L,2276L,2339L,2344L,2433L,2493L,2518L,2611L,2819L,2821L,2896L,2901L,2939L,3039L,3070L,3142L,3154L,3203L,3284L,3430L,3439L,3467L,3513L,3523L,3546L,3556L,3573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020381Inst : IEnumerable<long>
{
public static readonly long[] Value=A020381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020381.Bytes);
public long this[int i]=>Value[i];

public static A020381Inst Instance=new A020381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020382
{
public static readonly long[] Value={ 1153L,1709L,1777L,2129L,2458L,2741L,3226L,3649L,3701L,3961L,4729L,4877L,5818L,5821L,6161L,6473L,6746L,7034L,7274L,7433L,8117L,8273L,9277L,9370L,9626L,10345L,11125L,11194L,11197L,11530L,11633L,11821L,11861L,12209L,12437L,12701L,12938L,13274L,13289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020382Inst : IEnumerable<long>
{
public static readonly long[] Value=A020382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020382.Bytes);
public long this[int i]=>Value[i];

public static A020382Inst Instance=new A020382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020383
{
public static readonly long[] Value={ 604L,766L,796L,823L,1084L,1198L,1231L,1423L,1589L,1964L,2039L,2049L,2059L,2092L,2095L,2104L,2321L,2395L,2656L,2733L,2779L,2874L,2876L,2911L,2935L,3151L,3452L,3453L,3773L,3777L,3788L,4313L,4314L,4336L,4396L,4453L,4574L,4604L,4708L,4734L,4768L,4792L,4926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020383Inst : IEnumerable<long>
{
public static readonly long[] Value=A020383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020383.Bytes);
public long this[int i]=>Value[i];

public static A020383Inst Instance=new A020383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020384
{
public static readonly long[] Value={ 1249L,1321L,1753L,2113L,2549L,2729L,2833L,3085L,3557L,3581L,3833L,4285L,4673L,4885L,5065L,5389L,5573L,6257L,6317L,6977L,8093L,8753L,8765L,9257L,9914L,10433L,10690L,11002L,11597L,12233L,12965L,13477L,13985L,14033L,14065L,14578L,14681L,14837L,15013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020384Inst : IEnumerable<long>
{
public static readonly long[] Value=A020384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020384.Bytes);
public long this[int i]=>Value[i];

public static A020384Inst Instance=new A020384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020385
{
public static readonly long[] Value={ 694L,739L,859L,883L,1174L,1459L,1499L,1569L,1828L,2203L,2317L,2489L,2494L,2506L,2536L,2577L,2776L,2803L,3321L,3406L,3487L,3524L,3544L,3547L,3622L,3643L,3681L,3716L,3837L,3979L,4091L,4369L,4438L,4451L,4502L,4642L,4696L,4906L,4965L,4997L,5093L,5139L,5608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020385Inst : IEnumerable<long>
{
public static readonly long[] Value=A020385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020385.Bytes);
public long this[int i]=>Value[i];

public static A020385Inst Instance=new A020385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020386
{
public static readonly long[] Value={ 1069L,1993L,2801L,2969L,3589L,3865L,4241L,4289L,4337L,4618L,5981L,6089L,6109L,6173L,6833L,7457L,8629L,9194L,11909L,12113L,14666L,15353L,15973L,16066L,17002L,17009L,19450L,19858L,21346L,21722L,24370L,25189L,26485L,26861L,29597L,30269L,30986L,31090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020386Inst : IEnumerable<long>
{
public static readonly long[] Value=A020386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020386.Bytes);
public long this[int i]=>Value[i];

public static A020386Inst Instance=new A020386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020387
{
public static readonly long[] Value={ 631L,844L,1006L,1341L,1441L,1663L,1689L,1783L,1822L,1837L,1871L,2062L,2287L,2413L,2479L,2517L,2572L,2591L,2846L,2853L,3103L,3184L,3273L,3309L,3340L,3376L,3448L,3521L,3537L,3767L,4109L,4361L,4497L,4526L,4585L,4750L,4766L,4833L,4849L,4921L,4986L,5118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020387Inst : IEnumerable<long>
{
public static readonly long[] Value=A020387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020387.Bytes);
public long this[int i]=>Value[i];

public static A020387Inst Instance=new A020387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020388
{
public static readonly long[] Value={ 1021L,1597L,2617L,2746L,2861L,3041L,3881L,4049L,6469L,6737L,8497L,9677L,9970L,10049L,10181L,11114L,12829L,12973L,14426L,14842L,15145L,16141L,16277L,18265L,19357L,19385L,20605L,21002L,22738L,24842L,26002L,26489L,26938L,27733L,28922L,29362L,29789L,30025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020388Inst : IEnumerable<long>
{
public static readonly long[] Value=A020388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020388.Bytes);
public long this[int i]=>Value[i];

public static A020388Inst Instance=new A020388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020389
{
public static readonly long[] Value={ 1051L,1318L,1483L,1588L,1829L,2194L,2564L,2649L,2830L,2921L,2973L,3091L,3236L,3299L,3586L,3659L,3974L,4019L,4066L,4196L,4197L,4299L,4432L,4523L,4566L,4659L,4756L,5091L,5125L,5140L,5323L,5357L,5425L,5444L,5461L,5483L,5606L,5638L,5706L,5846L,5921L,6131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020389Inst : IEnumerable<long>
{
public static readonly long[] Value=A020389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020389.Bytes);
public long this[int i]=>Value[i];

public static A020389Inst Instance=new A020389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020390
{
public static readonly long[] Value={ 1201L,1933L,2017L,2437L,2953L,3037L,5189L,5657L,6353L,6865L,7793L,8237L,8513L,8665L,10522L,10546L,10861L,10897L,11962L,12373L,14657L,15077L,15346L,15802L,16138L,16393L,16405L,16690L,16945L,17585L,18097L,18362L,19345L,19466L,20722L,21493L,22717L,22765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020390Inst : IEnumerable<long>
{
public static readonly long[] Value=A020390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020390.Bytes);
public long this[int i]=>Value[i];

public static A020390Inst Instance=new A020390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020391
{
public static readonly long[] Value={ 751L,1303L,1543L,2174L,2481L,2503L,2647L,2654L,2794L,2839L,2841L,3118L,3149L,3424L,3489L,3565L,3566L,3607L,4039L,4076L,4252L,4300L,4412L,4529L,4617L,4735L,4855L,4903L,5132L,5324L,5549L,5793L,5969L,6004L,6125L,6126L,6143L,6287L,6356L,6538L,6638L,6775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020391Inst : IEnumerable<long>
{
public static readonly long[] Value=A020391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020391.Bytes);
public long this[int i]=>Value[i];

public static A020391Inst Instance=new A020391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020392
{
public static readonly long[] Value={ 1669L,1873L,3089L,3329L,3466L,3761L,5153L,5482L,5485L,5501L,5693L,6761L,6857L,7186L,7253L,8857L,10154L,11897L,12085L,12554L,13109L,16265L,17410L,17429L,17914L,18698L,20089L,20186L,20873L,20954L,21145L,22313L,22634L,22637L,23153L,23402L,23545L,27985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020392Inst : IEnumerable<long>
{
public static readonly long[] Value=A020392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020392.Bytes);
public long this[int i]=>Value[i];

public static A020392Inst Instance=new A020392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020393
{
public static readonly long[] Value={ 886L,1747L,1821L,2361L,2404L,2662L,2899L,2998L,3097L,3307L,3412L,3796L,3907L,4061L,4166L,4246L,4377L,4459L,4724L,4769L,4819L,4866L,4911L,5044L,5079L,5147L,5171L,5299L,5531L,5561L,5574L,5599L,5665L,5860L,5889L,5987L,6011L,6059L,6190L,6262L,6265L,6323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020393Inst : IEnumerable<long>
{
public static readonly long[] Value=A020393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020393.Bytes);
public long this[int i]=>Value[i];

public static A020393Inst Instance=new A020393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020394
{
public static readonly long[] Value={ 2381L,4141L,5317L,5386L,5749L,5941L,6569L,7669L,8065L,8698L,8986L,9577L,10537L,10601L,11065L,11393L,11717L,11986L,14537L,14717L,14813L,15082L,18397L,18649L,20353L,20753L,20885L,20905L,21617L,22193L,22853L,23321L,23537L,23741L,23773L,24466L,25345L,25349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020394Inst : IEnumerable<long>
{
public static readonly long[] Value=A020394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020394.Bytes);
public long this[int i]=>Value[i];

public static A020394Inst Instance=new A020394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020395
{
public static readonly long[] Value={ 1039L,1852L,1948L,2188L,2497L,2529L,3022L,3343L,3799L,3884L,3911L,3937L,4079L,4124L,4390L,4405L,4423L,4540L,4679L,4943L,5433L,5646L,5764L,6141L,6244L,6332L,6334L,6428L,6505L,7017L,7255L,7495L,7525L,7708L,7792L,7806L,7813L,7821L,7852L,7882L,7916L,8071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020395Inst : IEnumerable<long>
{
public static readonly long[] Value=A020395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020395.Bytes);
public long this[int i]=>Value[i];

public static A020395Inst Instance=new A020395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020396
{
public static readonly long[] Value={ 1453L,1609L,2593L,4297L,4474L,4937L,5914L,6385L,6442L,7066L,7309L,7853L,8425L,8593L,8741L,9137L,9193L,10057L,10133L,10973L,11117L,11554L,12641L,13613L,13957L,14185L,14585L,14633L,15137L,15866L,17285L,17354L,18077L,18241L,18413L,19666L,20290L,20794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020396Inst : IEnumerable<long>
{
public static readonly long[] Value=A020396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020396.Bytes);
public long this[int i]=>Value[i];

public static A020396Inst Instance=new A020396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020413
{
public static readonly long[] Value={ 2038L,2083L,3193L,3369L,3499L,3841L,3909L,4211L,4219L,4601L,5257L,5446L,5949L,6070L,6457L,6614L,6742L,7169L,7211L,7819L,8193L,8365L,8491L,8626L,8656L,8788L,8833L,9057L,9142L,9227L,9334L,9457L,9557L,9832L,9889L,10036L,10054L,10147L,10259L,10339L,10441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020413Inst : IEnumerable<long>
{
public static readonly long[] Value=A020413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020413.Bytes);
public long this[int i]=>Value[i];

public static A020413Inst Instance=new A020413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020414
{
public static readonly long[] Value={ 3217L,3313L,7237L,9209L,9466L,10249L,10765L,11521L,11785L,12442L,12757L,13709L,13757L,14125L,15577L,16897L,19421L,19577L,19786L,19913L,21562L,22277L,22837L,29765L,31517L,31741L,32458L,32489L,33202L,33893L,34165L,35153L,36506L,41845L,42314L,42802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020414Inst : IEnumerable<long>
{
public static readonly long[] Value=A020414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020414.Bytes);
public long this[int i]=>Value[i];

public static A020414Inst Instance=new A020414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020415
{
public static readonly long[] Value={ 1516L,2446L,2551L,4663L,5001L,5014L,5029L,5533L,5756L,6129L,6607L,6881L,6911L,6979L,7099L,7166L,7269L,7886L,8111L,8134L,8189L,8453L,8908L,9134L,9514L,9532L,9767L,10276L,10343L,10449L,10687L,10799L,11572L,11582L,11584L,11852L,11873L,12029L,12295L,12478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020415Inst : IEnumerable<long>
{
public static readonly long[] Value=A020415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020415.Bytes);
public long this[int i]=>Value[i];

public static A020415Inst Instance=new A020415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020416
{
public static readonly long[] Value={ 5857L,5861L,6101L,7001L,7141L,7834L,8314L,8429L,8989L,10289L,10789L,11041L,11101L,11482L,11581L,11626L,12377L,13217L,13309L,13997L,14261L,16433L,16949L,17386L,20521L,21178L,21277L,21785L,22013L,22753L,27877L,28493L,28793L,29285L,29333L,29341L,30169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020416Inst : IEnumerable<long>
{
public static readonly long[] Value=A020416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020416.Bytes);
public long this[int i]=>Value[i];

public static A020416Inst Instance=new A020416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020417
{
public static readonly long[] Value={ 1894L,2539L,3241L,3862L,4417L,4691L,4989L,5158L,5251L,5366L,5489L,5977L,6139L,6393L,6514L,6628L,7081L,7286L,7414L,7576L,7941L,8699L,8913L,9019L,9186L,9329L,9491L,9547L,9764L,10105L,10157L,10351L,10436L,10456L,10821L,10916L,11012L,11153L,11469L,11586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020417Inst : IEnumerable<long>
{
public static readonly long[] Value=A020417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020417.Bytes);
public long this[int i]=>Value[i];

public static A020417Inst Instance=new A020417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020418
{
public static readonly long[] Value={ 1621L,3001L,3637L,4153L,5113L,5653L,7114L,8026L,9161L,12538L,12569L,13261L,14177L,18058L,19373L,21625L,25733L,25981L,26297L,28277L,28394L,29674L,30122L,32201L,32393L,32861L,33773L,34801L,35746L,36137L,36185L,36257L,36994L,39049L,39701L,41429L,43721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020418Inst : IEnumerable<long>
{
public static readonly long[] Value=A020418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020418.Bytes);
public long this[int i]=>Value[i];

public static A020418Inst Instance=new A020418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020419
{
public static readonly long[] Value={ 1759L,1981L,2206L,2764L,2989L,3559L,3628L,3694L,3817L,3868L,3921L,4041L,4333L,5006L,5293L,5294L,5407L,5647L,5877L,6193L,6281L,6718L,6847L,6892L,7660L,8039L,8137L,8359L,8561L,8596L,9487L,9788L,9989L,10014L,10495L,10579L,10697L,10737L,10882L,11006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020419Inst : IEnumerable<long>
{
public static readonly long[] Value=A020419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020419.Bytes);
public long this[int i]=>Value[i];

public static A020419Inst Instance=new A020419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020420
{
public static readonly long[] Value={ 3169L,3697L,5233L,6269L,6521L,9521L,9754L,9946L,10169L,12149L,12202L,12385L,13738L,15461L,15706L,15898L,17321L,18922L,19853L,20065L,20341L,21977L,21985L,23333L,24154L,24457L,24953L,25013L,25034L,25181L,27109L,27781L,27802L,28114L,28249L,28786L,28873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020420Inst : IEnumerable<long>
{
public static readonly long[] Value=A020420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020420.Bytes);
public long this[int i]=>Value[i];

public static A020420Inst Instance=new A020420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020421
{
public static readonly long[] Value={ 2164L,2614L,2641L,2644L,3067L,3397L,4468L,4723L,5059L,5062L,6106L,6249L,6937L,7021L,7291L,7499L,7654L,8243L,8434L,8516L,9206L,9307L,9361L,9561L,9569L,9694L,9777L,10053L,10173L,10349L,10469L,10677L,11133L,11171L,11241L,11416L,11845L,11860L,11899L,12219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020421Inst : IEnumerable<long>
{
public static readonly long[] Value=A020421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020421.Bytes);
public long this[int i]=>Value[i];

public static A020421Inst Instance=new A020421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020422
{
public static readonly long[] Value={ 4657L,6449L,8681L,9041L,9929L,10177L,11461L,12253L,13162L,13337L,15997L,17065L,17557L,17593L,17674L,20557L,20665L,20717L,21914L,22109L,23242L,23689L,23794L,24869L,26561L,29170L,31162L,31258L,31474L,32381L,32698L,33730L,37397L,38933L,39341L,40333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020422Inst : IEnumerable<long>
{
public static readonly long[] Value=A020422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020422.Bytes);
public long this[int i]=>Value[i];

public static A020422Inst Instance=new A020422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020423
{
public static readonly long[] Value={ 1831L,1999L,2149L,2791L,3292L,4126L,4237L,4393L,4639L,4897L,5121L,5279L,5534L,5971L,5996L,6621L,6729L,7209L,7214L,7661L,7737L,8014L,8129L,8251L,8361L,8457L,8577L,8674L,8812L,8817L,8947L,9356L,9376L,9469L,9541L,9753L,10063L,10113L,10487L,11157L,11229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020423Inst : IEnumerable<long>
{
public static readonly long[] Value=A020423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020423.Bytes);
public long this[int i]=>Value[i];

public static A020423Inst Instance=new A020423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020424
{
public static readonly long[] Value={ 2689L,3529L,4993L,6029L,6689L,6826L,7354L,7477L,10378L,11365L,12106L,13093L,14389L,14821L,17125L,17473L,17581L,18713L,19553L,20362L,25946L,26813L,28817L,29066L,29306L,30853L,32122L,32933L,34829L,35410L,35969L,36065L,36181L,36469L,37217L,40346L,41050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020424Inst : IEnumerable<long>
{
public static readonly long[] Value=A020424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020424.Bytes);
public long this[int i]=>Value[i];

public static A020424Inst Instance=new A020424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020425
{
public static readonly long[] Value={ 2179L,2854L,2881L,3409L,4117L,4341L,4804L,5173L,5227L,5349L,5601L,5961L,6429L,6433L,6491L,6836L,7012L,7108L,7617L,7867L,7972L,8422L,8797L,9496L,9641L,10649L,10819L,10867L,11204L,11371L,11419L,11782L,11889L,12145L,12406L,12659L,12737L,12982L,13301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020425Inst : IEnumerable<long>
{
public static readonly long[] Value=A020425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020425.Bytes);
public long this[int i]=>Value[i];

public static A020425Inst Instance=new A020425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020426
{
public static readonly long[] Value={ 3049L,3769L,7261L,8053L,8485L,8746L,13553L,15233L,17785L,19226L,19585L,20029L,20149L,20897L,20921L,21929L,22037L,22585L,25681L,26977L,29497L,31069L,31253L,32666L,33113L,33874L,36473L,38245L,38393L,38861L,40193L,41333L,42202L,42829L,43117L,44845L,45098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020426Inst : IEnumerable<long>
{
public static readonly long[] Value=A020426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020426.Bytes);
public long this[int i]=>Value[i];

public static A020426Inst Instance=new A020426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020427
{
public static readonly long[] Value={ 1726L,2284L,2734L,2974L,3823L,4222L,5541L,5773L,5932L,6094L,6652L,6959L,7646L,7855L,7924L,8413L,8793L,8824L,9239L,9369L,9451L,9535L,9609L,10109L,10126L,10391L,11017L,11212L,11337L,11493L,11575L,11740L,11896L,12079L,12633L,12671L,12691L,12761L,12871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020427Inst : IEnumerable<long>
{
public static readonly long[] Value=A020427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020427.Bytes);
public long this[int i]=>Value[i];

public static A020427Inst Instance=new A020427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020428
{
public static readonly long[] Value={ 2389L,3613L,4129L,4957L,5689L,7121L,7841L,7901L,8377L,8506L,9529L,10529L,12689L,13369L,13402L,13465L,14057L,15049L,15269L,16529L,19729L,20122L,21881L,22186L,23257L,23425L,24961L,27409L,28433L,29101L,30497L,31765L,31945L,32573L,35009L,35173L,36298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020428Inst : IEnumerable<long>
{
public static readonly long[] Value=A020428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020428.Bytes);
public long this[int i]=>Value[i];

public static A020428Inst Instance=new A020428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020429
{
public static readonly long[] Value={ 2851L,4051L,4449L,4873L,5284L,6388L,6517L,6526L,6659L,6859L,6973L,7243L,7702L,7771L,8261L,8486L,8614L,8966L,9226L,9862L,10519L,10809L,11081L,11477L,11876L,12164L,12881L,12904L,12910L,13479L,13531L,13859L,13861L,14646L,14799L,14804L,15014L,15310L,15940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020429Inst : IEnumerable<long>
{
public static readonly long[] Value=A020429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020429.Bytes);
public long this[int i]=>Value[i];

public static A020429Inst Instance=new A020429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020430
{
public static readonly long[] Value={ 4057L,8293L,10589L,11801L,11969L,12346L,12349L,12809L,17665L,17729L,19661L,19793L,20017L,20506L,21706L,21898L,23753L,26417L,28909L,29221L,29453L,31357L,32237L,32429L,32693L,34781L,40538L,41885L,41957L,43273L,43565L,45145L,46786L,47057L,49477L,52357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020430Inst : IEnumerable<long>
{
public static readonly long[] Value=A020430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020430.Bytes);
public long this[int i]=>Value[i];

public static A020430Inst Instance=new A020430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020431
{
public static readonly long[] Value={ 2461L,2524L,3532L,3943L,4249L,4681L,4783L,5221L,5479L,5596L,6031L,6799L,7132L,7281L,7294L,7929L,8599L,8997L,9136L,9573L,9679L,9838L,9844L,10165L,11104L,12014L,12214L,12631L,12734L,13006L,13228L,13327L,13504L,13679L,13744L,14188L,15205L,15571L,16003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020431Inst : IEnumerable<long>
{
public static readonly long[] Value=A020431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020431.Bytes);
public long this[int i]=>Value[i];

public static A020431Inst Instance=new A020431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020432
{
public static readonly long[] Value={ 4549L,5737L,6217L,7529L,8009L,8849L,10477L,12013L,14593L,14785L,14897L,16193L,17833L,18085L,18937L,18985L,19093L,19937L,20177L,21341L,22073L,22346L,23357L,26218L,26501L,29569L,31753L,32554L,35554L,37021L,38557L,38593L,41441L,41557L,42257L,44762L,47389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020432Inst : IEnumerable<long>
{
public static readonly long[] Value=A020432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020432.Bytes);
public long this[int i]=>Value[i];

public static A020432Inst Instance=new A020432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020433
{
public static readonly long[] Value={ 2011L,2326L,2374L,4276L,4701L,4996L,5851L,6436L,6502L,6547L,6861L,6982L,7027L,7041L,7078L,7153L,7429L,8054L,8141L,8171L,8219L,8443L,8452L,9011L,9993L,10186L,10196L,10497L,10633L,10646L,10979L,11249L,11366L,11506L,12163L,12307L,12509L,12547L,12766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020433Inst : IEnumerable<long>
{
public static readonly long[] Value=A020433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020433.Bytes);
public long this[int i]=>Value[i];

public static A020433Inst Instance=new A020433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020434
{
public static readonly long[] Value={ 3361L,4969L,5101L,6553L,7297L,9817L,10513L,11146L,11369L,13021L,13177L,13913L,16493L,19001L,20393L,21253L,24565L,24874L,24977L,25357L,25957L,26393L,27901L,29153L,29377L,30298L,30538L,30706L,34141L,36293L,41389L,42970L,43345L,44453L,45053L,46289L,46997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020434Inst : IEnumerable<long>
{
public static readonly long[] Value=A020434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020434.Bytes);
public long this[int i]=>Value[i];

public static A020434Inst Instance=new A020434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020435
{
public static readonly long[] Value={ 2311L,2956L,3631L,3661L,4327L,5023L,5374L,5469L,5769L,6009L,6046L,7151L,7342L,8156L,8206L,8257L,8611L,9148L,9346L,9806L,10144L,10364L,10473L,10516L,10732L,10798L,11134L,11503L,11950L,12271L,12273L,12364L,12521L,12799L,12814L,12897L,12934L,13354L,13579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020435Inst : IEnumerable<long>
{
public static readonly long[] Value=A020435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020435.Bytes);
public long this[int i]=>Value[i];

public static A020435Inst Instance=new A020435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020436
{
public static readonly long[] Value={ 4561L,9629L,12277L,13873L,17669L,18346L,19165L,19333L,19417L,19861L,20602L,23185L,23365L,25073L,25549L,26458L,26701L,27418L,28309L,29021L,29125L,29434L,32717L,34609L,34949L,35377L,40049L,41413L,42877L,43226L,45874L,46001L,46693L,46985L,47717L,47797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020436Inst : IEnumerable<long>
{
public static readonly long[] Value=A020436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020436.Bytes);
public long this[int i]=>Value[i];

public static A020436Inst Instance=new A020436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020437
{
public static readonly long[] Value={ 4603L,4609L,5377L,6067L,7507L,9031L,9043L,9067L,10091L,10264L,10372L,11579L,11869L,12086L,12154L,12356L,12493L,12886L,13157L,13773L,14359L,14373L,14566L,14635L,14723L,14854L,15262L,15301L,15467L,15505L,15835L,15853L,15954L,15971L,15999L,16291L,16314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020437Inst : IEnumerable<long>
{
public static readonly long[] Value=A020437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020437.Bytes);
public long this[int i]=>Value[i];

public static A020437Inst Instance=new A020437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020438
{
public static readonly long[] Value={ 4201L,4801L,5449L,6073L,7333L,7741L,8369L,11089L,12073L,13121L,13621L,15754L,16285L,17389L,18385L,19429L,21589L,21697L,23962L,24181L,24685L,25997L,26281L,26513L,26842L,29098L,29593L,29914L,33053L,35461L,36149L,37090L,39637L,39733L,40265L,42293L,43669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020438Inst : IEnumerable<long>
{
public static readonly long[] Value=A020438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020438.Bytes);
public long this[int i]=>Value[i];

public static A020438Inst Instance=new A020438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020439
{
public static readonly long[] Value={ 2629L,3646L,4924L,5692L,5833L,5836L,6172L,6703L,6801L,7389L,7438L,8158L,8287L,8551L,8654L,9103L,10041L,10079L,10096L,10629L,10936L,11038L,11068L,11116L,11335L,11383L,11519L,11824L,11863L,11995L,12016L,12044L,12494L,12751L,12811L,12895L,13372L,13569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020439Inst : IEnumerable<long>
{
public static readonly long[] Value=A020439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020439.Bytes);
public long this[int i]=>Value[i];

public static A020439Inst Instance=new A020439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020440
{
public static readonly long[] Value={ 13L,21L,31L,57L,61L,67L,73L,74L,92L,106L,108L,109L,111L,112L,116L,129L,137L,158L,161L,162L,183L,185L,193L,204L,207L,236L,237L,243L,246L,251L,261L,262L,265L,273L,274L,275L,282L,297L,298L,308L,314L,317L,329L,332L,341L,346L,351L,355L,364L,375L,381L,383L,384L,388L,406L,412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020440Inst : IEnumerable<long>
{
public static readonly long[] Value=A020440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020440.Bytes);
public long this[int i]=>Value[i];

public static A020440Inst Instance=new A020440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020441
{
public static readonly long[] Value={ 91L,304L,319L,432L,539L,555L,595L,671L,696L,703L,760L,891L,935L,1175L,1512L,1643L,1695L,1971L,2075L,2088L,2223L,2295L,2299L,2507L,2552L,2555L,2679L,2727L,3219L,3240L,3344L,3416L,3471L,3611L,4023L,4075L,4331L,4347L,4371L,5291L,5320L,5355L,5616L,5712L,6016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020441Inst : IEnumerable<long>
{
public static readonly long[] Value=A020441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020441.Bytes);
public long this[int i]=>Value[i];

public static A020441Inst Instance=new A020441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020442
{
public static readonly long[] Value={ 43L,44L,46L,58L,76L,86L,93L,103L,113L,160L,172L,179L,184L,186L,191L,199L,213L,233L,242L,245L,268L,281L,284L,307L,313L,337L,344L,345L,348L,366L,376L,389L,391L,409L,411L,415L,419L,422L,425L,426L,430L,431L,446L,468L,469L,477L,496L,500L,512L,516L,517L,522L,550L,554L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020442Inst : IEnumerable<long>
{
public static readonly long[] Value=A020442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020442.Bytes);
public long this[int i]=>Value[i];

public static A020442Inst Instance=new A020442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020443
{
public static readonly long[] Value={ 115L,135L,247L,464L,611L,744L,767L,1064L,1479L,2079L,2200L,2291L,2360L,2875L,3096L,3283L,3367L,3800L,4187L,4255L,4408L,4672L,4720L,4995L,5151L,5375L,5568L,5611L,5983L,6235L,6431L,6643L,6816L,6840L,6895L,7335L,7367L,7600L,8151L,8208L,8507L,8755L,8843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020443Inst : IEnumerable<long>
{
public static readonly long[] Value=A020443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020443.Bytes);
public long this[int i]=>Value[i];

public static A020443Inst Instance=new A020443Inst();

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