using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A187045
{
public static readonly long[] Value={ 1L,4L,5L,0L,-5L,0L,9L,0L,-14L,0L,19L,0L,-34L,0L,55L,0L,-69L,0L,104L,0L,-164L,0L,209L,0L,-283L,0L,413L,0L,-539L,0L,712L,0L,-968L,0L,1248L,0L,-1642L,0L,2167L,0L,-2731L,0L,3526L,0L,-4592L,0L,5736L,0L,-7244L,0L,9255L,0L,-11520L,0L,14378L,0L,-18018L,0L,22238L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187045Inst : IEnumerable<long>
{
public static readonly long[] Value=A187045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187045.Bytes);
public long this[int i]=>Value[i];

public static A187045Inst Instance=new A187045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187046
{
public static readonly long[] Value={ 1L,4L,0L,9L,4L,0L,16L,20L,0L,0L,25L,52L,28L,0L,0L,36L,100L,136L,24L,0L,0L,49L,164L,360L,272L,8L,0L,0L,64L,244L,696L,1084L,456L,0L,0L,0L,81L,340L,1144L,2660L,2896L,584L,0L,0L,0L,100L,452L,1704L,5032L,9216L,6952L,400L,0L,0L,0L,121L,580L,2376L,8164L,20648L,29500L,14024L,80L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187046Inst : IEnumerable<long>
{
public static readonly long[] Value=A187046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187046.Bytes);
public long this[int i]=>Value[i];

public static A187046Inst Instance=new A187046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187047
{
public static readonly long[] Value={ 0L,0L,28L,136L,360L,696L,1144L,1704L,2376L,3160L,4056L,5064L,6184L,7416L,8760L,10216L,11784L,13464L,15256L,17160L,19176L,21304L,23544L,25896L,28360L,30936L,33624L,36424L,39336L,42360L,45496L,48744L,52104L,55576L,59160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187047Inst : IEnumerable<long>
{
public static readonly long[] Value=A187047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187047.Bytes);
public long this[int i]=>Value[i];

public static A187047Inst Instance=new A187047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187048
{
public static readonly long[] Value={ 0L,0L,24L,272L,1084L,2660L,5032L,8164L,12056L,16708L,22120L,28292L,35224L,42916L,51368L,60580L,70552L,81284L,92776L,105028L,118040L,131812L,146344L,161636L,177688L,194500L,212072L,230404L,249496L,269348L,289960L,311332L,333464L,356356L,380008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187048Inst : IEnumerable<long>
{
public static readonly long[] Value=A187048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187048.Bytes);
public long this[int i]=>Value[i];

public static A187048Inst Instance=new A187048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187049
{
public static readonly long[] Value={ 0L,0L,8L,456L,2896L,9216L,20648L,37472L,59524L,86656L,118868L,156160L,198532L,245984L,298516L,356128L,418820L,486592L,559444L,637376L,720388L,808480L,901652L,999904L,1103236L,1211648L,1325140L,1443712L,1567364L,1696096L,1829908L,1968800L,2112772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187049Inst : IEnumerable<long>
{
public static readonly long[] Value=A187049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187049.Bytes);
public long this[int i]=>Value[i];

public static A187049Inst Instance=new A187049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187050
{
public static readonly long[] Value={ 0L,0L,0L,584L,6952L,29500L,79088L,162320L,281320L,435436L,623508L,845084L,1100164L,1388748L,1710836L,2066428L,2455524L,2878124L,3334228L,3823836L,4346948L,4903564L,5493684L,6117308L,6774436L,7465068L,8189204L,8946844L,9737988L,10562636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187050Inst : IEnumerable<long>
{
public static readonly long[] Value=A187050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187050.Bytes);
public long this[int i]=>Value[i];

public static A187050Inst Instance=new A187050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187051
{
public static readonly long[] Value={ 0L,0L,0L,400L,14024L,86608L,285048L,668176L,1272720L,2110944L,3180724L,4475176L,5989600L,7722744L,9674608L,11845192L,14234496L,16842520L,19669264L,22714728L,25978912L,29461816L,33163440L,37083784L,41222848L,45580632L,50157136L,54952360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187051Inst : IEnumerable<long>
{
public static readonly long[] Value=A187051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187051.Bytes);
public long this[int i]=>Value[i];

public static A187051Inst Instance=new A187051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187116
{
public static readonly BigInteger[] Value={ 1L,4L,20L,138L,1258L,14476L,202655L,3354848L,64246776L,1398909332L,34157026526L,924757926320L,27503093599024L,891534666547216L,31289986924954924L,1182213869836721036L,BigInteger.Parse("47846600590876178320"),BigInteger.Parse("2065282617724684345208") };
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
public class A187116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187116Inst Instance=new A187116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187117
{
public static readonly BigInteger[] Value={ 1L,6L,39L,318L,3242L,40348L,598083L,10337402L,204706486L,4577520108L,114208773268L,3147671423964L,95023271024164L,3119560618275648L,110684959354534001L,4221624141483353436L,BigInteger.Parse("172274971776090819870") };
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
public class A187117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187117Inst Instance=new A187117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187118
{
public static readonly BigInteger[] Value={ 1L,3L,12L,67L,512L,5143L,64988L,995334L,17948683L,372703529L,8759307844L,229843336284L,6660078541359L,211201170221925L,7274712426981184L,270441300892307916L,10791919593795653296UL,BigInteger.Parse("460087687818627367809") };
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
public class A187118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187118Inst Instance=new A187118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187119
{
public static readonly long[] Value={ 1L,-2L,4L,-12L,36L,-140L,519L,-2632L,11776L,-82020L,426990L,-4149112L,22719260L,-309921456L,1487214652L,-31477804596L,82495148888L,-4227929653508L,-7155535440434L,-767565126075852L,-6245080462329816L,-194907866415800464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187119Inst : IEnumerable<long>
{
public static readonly long[] Value=A187119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187119.Bytes);
public long this[int i]=>Value[i];

public static A187119Inst Instance=new A187119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187120
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,15L,1L,9L,42L,112L,1L,12L,81L,377L,1128L,1L,15L,132L,855L,4248L,14373L,1L,18L,195L,1606L,10758L,58269L,221952L,1L,21L,270L,2690L,22416L,159633L,947117L,4029915L,1L,24L,357L,4167L,41340L,359616L,2750067L,17848872L,84135510L,1L,27L,456L,6097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187120Inst : IEnumerable<long>
{
public static readonly long[] Value=A187120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187120.Bytes);
public long this[int i]=>Value[i];

public static A187120Inst Instance=new A187120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187121
{
public static readonly BigInteger[] Value={ 1L,6L,42L,377L,4248L,58269L,947117L,17848872L,383237040L,9243654925L,247586590398L,7293962774574L,234458181733224L,8167132024738422L,306500617604837898L,12329458457556027538UL,BigInteger.Parse("529269910501209999900") };
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
public class A187121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187121Inst Instance=new A187121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187122
{
public static readonly BigInteger[] Value={ 1L,9L,81L,855L,10758L,159633L,2750067L,54178485L,1204443432L,29871630837L,818490738402L,24571782872034L,802459134168208L,28332664539686670L,1075700621922471621L,BigInteger.Parse("43710289920461797346"),BigInteger.Parse("1893011243289589171122") };
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
public class A187122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187122Inst Instance=new A187122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187123
{
public static readonly BigInteger[] Value={ 1L,4L,22L,164L,1599L,19624L,292799L,5162063L,105139954L,2430528374L,62877375426L,1799698534522L,56461862815496L,1926534563625822L,71024188655886038L,2813193432059656268L,BigInteger.Parse("119136308527407025379"),BigInteger.Parse("5371507426340905440926") };
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
public class A187123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187123Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187123.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187123Inst Instance=new A187123Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187124
{
public static readonly long[] Value={ 1L,-3L,6L,-18L,48L,-195L,549L,-3465L,7452L,-112707L,-5994L,-6866904L,-25659292L,-700243362L,-5594278734L,-106900155574L,-1284177510456L,-22692117042216L,-348993455353854L,-6343625959542180L,-114598750263323292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187124Inst : IEnumerable<long>
{
public static readonly long[] Value=A187124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187124.Bytes);
public long this[int i]=>Value[i];

public static A187124Inst Instance=new A187124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187125
{
public static readonly long[] Value={ 1074107L,1076107L,1079107L,1093109L,1098109L,1114111L,1117111L,1131113L,1134113L,1171117L,1191119L,1193119L,1196119L,1212121L,1215121L,1218121L,1273127L,1294129L,1297129L,1311131L,1317131L,1333133L,1336133L,1371137L,1373137L,1377137L,1379137L,1398139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187125Inst : IEnumerable<long>
{
public static readonly long[] Value=A187125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187125.Bytes);
public long this[int i]=>Value[i];

public static A187125Inst Instance=new A187125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187126
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,10L,11L,15L,16L,20L,21L,25L,26L,28L,30L,31L,35L,36L,40L,41L,45L,46L,50L,51L,55L,56L,60L,61L,65L,66L,70L,71L,75L,76L,78L,80L,81L,85L,86L,90L,91L,95L,96L,100L,101L,105L,106L,110L,111L,115L,116L,120L,121L,125L,126L,128L,130L,131L,135L,136L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187126Inst : IEnumerable<long>
{
public static readonly long[] Value=A187126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187126.Bytes);
public long this[int i]=>Value[i];

public static A187126Inst Instance=new A187126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187127
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,10L,11L,15L,16L,20L,21L,25L,26L,28L,30L,31L,35L,36L,40L,41L,45L,46L,50L,51L,53L,55L,56L,60L,61L,65L,66L,70L,71L,75L,76L,78L,80L,81L,85L,86L,90L,91L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187127Inst : IEnumerable<long>
{
public static readonly long[] Value=A187127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187127.Bytes);
public long this[int i]=>Value[i];

public static A187127Inst Instance=new A187127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187128
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,5L,2L,2L,3L,2L,5L,2L,3L,7L,2L,2L,3L,2L,2L,3L,5L,2L,2L,7L,2L,3L,5L,2L,2L,11L,3L,7L,2L,2L,3L,2L,11L,2L,5L,2L,3L,13L,2L,5L,7L,2L,3L,2L,2L,3L,7L,2L,2L,11L,3L,2L,5L,13L,2L,2L,3L,11L,5L,2L,17L,7L,2L,13L,3L,2L,2L,3L,2L,17L,2L,5L,2L,3L,19L,11L,2L,2L,5L,3L,13L,2L,2L,7L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187128Inst : IEnumerable<long>
{
public static readonly long[] Value=A187128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187128.Bytes);
public long this[int i]=>Value[i];

public static A187128Inst Instance=new A187128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187129
{
public static readonly long[] Value={ 2L,3L,5L,12L,7L,18L,24L,24L,30L,47L,49L,55L,40L,59L,48L,100L,102L,50L,89L,120L,109L,136L,181L,158L,117L,199L,133L,170L,252L,133L,261L,300L,98L,267L,324L,279L,303L,419L,244L,303L,494L,345L,260L,593L,302L,343L,503L,207L,452L,612L,399L,488L,668L,526L,619L,872L,574L,540L,1082L,352L,475L,920L,273L,691L,865L,598L,523L,822L,725L,864L,1211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187129Inst : IEnumerable<long>
{
public static readonly long[] Value=A187129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187129.Bytes);
public long this[int i]=>Value[i];

public static A187129Inst Instance=new A187129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187130
{
public static readonly long[] Value={ 1L,-3L,2L,0L,1L,0L,0L,0L,-2L,0L,-2L,0L,2L,0L,4L,0L,3L,0L,-4L,0L,-8L,0L,-4L,0L,5L,0L,14L,0L,7L,0L,-8L,0L,-20L,0L,-12L,0L,14L,0L,28L,0L,17L,0L,-20L,0L,-44L,0L,-24L,0L,28L,0L,66L,0L,36L,0L,-40L,0L,-90L,0L,-52L,0L,56L,0L,124L,0L,71L,0L,-80L,0L,-176L,0L,-96L,0L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187130Inst : IEnumerable<long>
{
public static readonly long[] Value=A187130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187130.Bytes);
public long this[int i]=>Value[i];

public static A187130Inst Instance=new A187130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187131
{
public static readonly BigInteger[] Value={ 1L,1L,9L,1521L,71622369L,233297499911422401L,BigInteger.Parse("3390052406222940758260506721830900609"),BigInteger.Parse("934785860242188709610961043825803400592180434378516146129897302939414193921") };
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
public class A187131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187131Inst Instance=new A187131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187148
{
public static readonly long[] Value={ 1L,-3L,6L,-4L,-3L,12L,-8L,-12L,30L,-20L,-30L,72L,-46L,-60L,156L,-96L,-117L,300L,-188L,-228L,552L,-344L,-420L,1008L,-603L,-732L,1770L,-1048L,-1245L,2976L,-1776L,-2088L,4908L,-2900L,-3420L,7992L,-4658L,-5460L,12756L,-7408L,-8583L,19944L,-11564L,-13344L,30756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187148Inst : IEnumerable<long>
{
public static readonly long[] Value=A187148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187148.Bytes);
public long this[int i]=>Value[i];

public static A187148Inst Instance=new A187148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187149
{
public static readonly long[] Value={ 1L,-4L,4L,0L,2L,0L,-8L,0L,-5L,16L,4L,0L,-10L,0L,-8L,0L,9L,-8L,0L,0L,14L,0L,16L,0L,-10L,-32L,4L,0L,0L,0L,8L,0L,14L,20L,-20L,0L,2L,0L,0L,0L,-11L,16L,-20L,0L,-32L,0L,16L,0L,0L,40L,4L,0L,14L,0L,-8L,0L,-9L,-32L,-20L,0L,26L,0L,0L,0L,2L,-36L,28L,0L,0L,0L,16L,0L,16L,0L,28L,0L,-22L,0L,0L,0L,14L,-56L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187149Inst : IEnumerable<long>
{
public static readonly long[] Value=A187149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187149.Bytes);
public long this[int i]=>Value[i];

public static A187149Inst Instance=new A187149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187150
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,0L,4L,1L,2L,-5L,0L,-5L,4L,1L,-2L,-5L,0L,7L,4L,7L,0L,-4L,-10L,7L,-8L,0L,4L,0L,-8L,2L,0L,1L,-2L,0L,2L,0L,14L,7L,0L,-5L,10L,-11L,-8L,-10L,-2L,0L,10L,-4L,4L,0L,0L,-5L,-8L,-11L,10L,0L,0L,14L,-2L,20L,0L,-11L,4L,13L,2L,-5L,-14L,0L,-14L,13L,0L,-11L,-14L,8L,-2L,0L,10L,13L,-18L,0L,0L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187150Inst : IEnumerable<long>
{
public static readonly long[] Value=A187150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187150.Bytes);
public long this[int i]=>Value[i];

public static A187150Inst Instance=new A187150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187151
{
public static readonly long[] Value={ 1L,2L,8L,26L,108L,382L,1586L,5812L,24044L,89846L,370398L,1401292L,5759826L,21977516L,90111820L,345994216L,1415691244L,5461770406L,22308412934L,86392108636L,352334866238L,1368640564996L,5574504569620L,21708901408216L,88320660937298L,344680279929532L,1400902293406676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187151Inst : IEnumerable<long>
{
public static readonly long[] Value=A187151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187151.Bytes);
public long this[int i]=>Value[i];

public static A187151Inst Instance=new A187151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187152
{
public static readonly long[] Value={ 2L,3L,7L,3L,10L,22L,3L,10L,32L,71L,3L,10L,32L,103L,228L,3L,10L,32L,103L,331L,733L,3L,10L,32L,103L,331L,1064L,2356L,3L,10L,32L,103L,331L,1064L,3420L,7573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187152Inst : IEnumerable<long>
{
public static readonly long[] Value=A187152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187152.Bytes);
public long this[int i]=>Value[i];

public static A187152Inst Instance=new A187152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187153
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,-2L,3L,8L,5L,-7L,-18L,-12L,15L,38L,24L,-30L,-75L,-46L,57L,140L,86L,-104L,-252L,-152L,183L,439L,262L,-313L,-744L,-442L,522L,1232L,725L,-852L,-1998L,-1168L,1365L,3182L,1852L,-2150L,-4986L,-2886L,3336L,7700L,4436L,-5106L,-11736L,-6736L,7719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187153Inst : IEnumerable<long>
{
public static readonly long[] Value=A187153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187153.Bytes);
public long this[int i]=>Value[i];

public static A187153Inst Instance=new A187153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187154
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,26L,44L,72L,114L,178L,272L,408L,605L,884L,1276L,1824L,2580L,3616L,5028L,6936L,9498L,12922L,17468L,23472L,31369L,41700L,55156L,72616L,95172L,124202L,161436L,209016L,269616L,346562L,443952L,566856L,721530L,915642L,1158608L,1461968L,1839789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187154Inst : IEnumerable<long>
{
public static readonly long[] Value=A187154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187154.Bytes);
public long this[int i]=>Value[i];

public static A187154Inst Instance=new A187154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187155
{
public static readonly long[] Value={ 1L,4L,0L,9L,4L,0L,16L,16L,0L,0L,25L,36L,20L,0L,0L,36L,64L,64L,8L,0L,0L,49L,100L,132L,92L,0L,0L,0L,64L,144L,224L,248L,72L,0L,0L,0L,81L,196L,340L,476L,388L,56L,0L,0L,0L,100L,256L,480L,776L,904L,456L,16L,0L,0L,0L,121L,324L,644L,1148L,1620L,1588L,544L,0L,0L,0L,0L,144L,400L,832L,1592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187155Inst : IEnumerable<long>
{
public static readonly long[] Value=A187155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187155.Bytes);
public long this[int i]=>Value[i];

public static A187155Inst Instance=new A187155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187156
{
public static readonly long[] Value={ 0L,0L,20L,64L,132L,224L,340L,480L,644L,832L,1044L,1280L,1540L,1824L,2132L,2464L,2820L,3200L,3604L,4032L,4484L,4960L,5460L,5984L,6532L,7104L,7700L,8320L,8964L,9632L,10324L,11040L,11780L,12544L,13332L,14144L,14980L,15840L,16724L,17632L,18564L,19520L,20500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187156Inst : IEnumerable<long>
{
public static readonly long[] Value=A187156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187156.Bytes);
public long this[int i]=>Value[i];

public static A187156Inst Instance=new A187156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187157
{
public static readonly long[] Value={ 0L,0L,8L,92L,248L,476L,776L,1148L,1592L,2108L,2696L,3356L,4088L,4892L,5768L,6716L,7736L,8828L,9992L,11228L,12536L,13916L,15368L,16892L,18488L,20156L,21896L,23708L,25592L,27548L,29576L,31676L,33848L,36092L,38408L,40796L,43256L,45788L,48392L,51068L,53816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187157Inst : IEnumerable<long>
{
public static readonly long[] Value=A187157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187157.Bytes);
public long this[int i]=>Value[i];

public static A187157Inst Instance=new A187157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187158
{
public static readonly long[] Value={ 0L,0L,0L,72L,388L,904L,1620L,2536L,3652L,4968L,6484L,8200L,10116L,12232L,14548L,17064L,19780L,22696L,25812L,29128L,32644L,36360L,40276L,44392L,48708L,53224L,57940L,62856L,67972L,73288L,78804L,84520L,90436L,96552L,102868L,109384L,116100L,123016L,130132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187158Inst : IEnumerable<long>
{
public static readonly long[] Value=A187158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187158.Bytes);
public long this[int i]=>Value[i];

public static A187158Inst Instance=new A187158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187159
{
public static readonly long[] Value={ 0L,0L,0L,56L,456L,1588L,3288L,5556L,8392L,11796L,15768L,20308L,25416L,31092L,37336L,44148L,51528L,59476L,67992L,77076L,86728L,96948L,107736L,119092L,131016L,143508L,156568L,170196L,184392L,199156L,214488L,230388L,246856L,263892L,281496L,299668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187159Inst : IEnumerable<long>
{
public static readonly long[] Value=A187159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187159.Bytes);
public long this[int i]=>Value[i];

public static A187159Inst Instance=new A187159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187160
{
public static readonly long[] Value={ 0L,0L,0L,16L,544L,2328L,6172L,11576L,18540L,27064L,37148L,48792L,61996L,76760L,93084L,110968L,130412L,151416L,173980L,198104L,223788L,251032L,279836L,310200L,342124L,375608L,410652L,447256L,485420L,525144L,566428L,609272L,653676L,699640L,747164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187160Inst : IEnumerable<long>
{
public static readonly long[] Value=A187160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187160.Bytes);
public long this[int i]=>Value[i];

public static A187160Inst Instance=new A187160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187161
{
public static readonly long[] Value={ 0L,0L,0L,0L,472L,3504L,10576L,23340L,40448L,61900L,87696L,117836L,152320L,191148L,234320L,281836L,333696L,389900L,450448L,515340L,584576L,658156L,736080L,818348L,904960L,995916L,1091216L,1190860L,1294848L,1403180L,1515856L,1632876L,1754240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187161Inst : IEnumerable<long>
{
public static readonly long[] Value=A187161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187161.Bytes);
public long this[int i]=>Value[i];

public static A187161Inst Instance=new A187161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187162
{
public static readonly long[] Value={ 1L,8L,0L,27L,24L,0L,64L,108L,48L,0L,125L,288L,342L,96L,0L,216L,600L,1056L,1104L,144L,0L,343L,1080L,2370L,3984L,3240L,240L,0L,512L,1764L,4464L,9612L,14256L,9504L,192L,0L,729L,2688L,7518L,18888L,37470L,51504L,25344L,144L,0L,1000L,3888L,11712L,32712L,77184L,148224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187162Inst : IEnumerable<long>
{
public static readonly long[] Value=A187162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187162.Bytes);
public long this[int i]=>Value[i];

public static A187162Inst Instance=new A187162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187163
{
public static readonly long[] Value={ 0L,24L,108L,288L,600L,1080L,1764L,2688L,3888L,5400L,7260L,9504L,12168L,15288L,18900L,23040L,27744L,33048L,38988L,45600L,52920L,60984L,69828L,79488L,90000L,101400L,113724L,127008L,141288L,156600L,172980L,190464L,209088L,228888L,249900L,272160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187163Inst : IEnumerable<long>
{
public static readonly long[] Value=A187163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187163.Bytes);
public long this[int i]=>Value[i];

public static A187163Inst Instance=new A187163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187196
{
public static readonly long[] Value={ 1L,-2L,-1L,0L,7L,0L,-9L,0L,10L,0L,-23L,0L,38L,0L,-47L,0L,75L,0L,-112L,0L,148L,0L,-217L,0L,293L,0L,-385L,0L,553L,0L,-728L,0L,928L,0L,-1272L,0L,1670L,0L,-2111L,0L,2765L,0L,-3566L,0L,4504L,0L,-5784L,0L,7300L,0L,-9123L,0L,11592L,0L,-14458L,0L,17838L,0L,-22342L,0L,27668L,0L,-33884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187196Inst : IEnumerable<long>
{
public static readonly long[] Value=A187196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187196.Bytes);
public long this[int i]=>Value[i];

public static A187196Inst Instance=new A187196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187197
{
public static readonly long[] Value={ 1L,2L,-1L,0L,7L,0L,-9L,0L,10L,0L,-23L,0L,38L,0L,-47L,0L,75L,0L,-112L,0L,148L,0L,-217L,0L,293L,0L,-385L,0L,553L,0L,-728L,0L,928L,0L,-1272L,0L,1670L,0L,-2111L,0L,2765L,0L,-3566L,0L,4504L,0L,-5784L,0L,7300L,0L,-9123L,0L,11592L,0L,-14458L,0L,17838L,0L,-22342L,0L,27668L,0L,-33884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187197Inst : IEnumerable<long>
{
public static readonly long[] Value=A187197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187197.Bytes);
public long this[int i]=>Value[i];

public static A187197Inst Instance=new A187197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187198
{
public static readonly long[] Value={ 1L,5L,14L,36L,85L,180L,360L,684L,1246L,2196L,3754L,6264L,10226L,16380L,25804L,40032L,61275L,92628L,138452L,204804L,300040L,435672L,627356L,896400L,1271525L,1791324L,2507426L,3488472L,4825531L,6638688L,9085888L,12373992L,16772908L,22633812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187198Inst : IEnumerable<long>
{
public static readonly long[] Value=A187198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187198.Bytes);
public long this[int i]=>Value[i];

public static A187198Inst Instance=new A187198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187199
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,5L,2L,3L,3L,4L,6L,3L,6L,4L,2L,5L,4L,6L,4L,3L,5L,7L,4L,5L,7L,5L,4L,6L,6L,5L,5L,6L,6L,4L,8L,5L,5L,9L,10L,7L,9L,8L,7L,5L,8L,11L,5L,6L,6L,7L,8L,7L,6L,6L,7L,7L,7L,9L,4L,4L,8L,8L,10L,5L,7L,8L,7L,9L,8L,12L,6L,10L,6L,8L,6L,10L,7L,9L,9L,8L,7L,8L,7L,9L,8L,7L,8L,8L,9L,9L,10L,8L,10L,9L,8L,11L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187199Inst : IEnumerable<long>
{
public static readonly long[] Value=A187199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187199.Bytes);
public long this[int i]=>Value[i];

public static A187199Inst Instance=new A187199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187200
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,5L,4L,5L,5L,6L,6L,5L,5L,6L,6L,7L,7L,7L,8L,7L,6L,8L,9L,6L,6L,10L,7L,8L,8L,7L,8L,7L,11L,7L,9L,8L,9L,8L,10L,9L,8L,9L,8L,9L,9L,9L,12L,10L,10L,9L,10L,9L,11L,10L,13L,12L,10L,10L,11L,11L,11L,10L,11L,11L,14L,11L,12L,12L,11L,13L,10L,12L,12L,11L,12L,13L,12L,13L,14L,13L,11L,13L,14L,15L,14L,13L,16L,15L,12L,12L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187200Inst : IEnumerable<long>
{
public static readonly long[] Value=A187200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187200.Bytes);
public long this[int i]=>Value[i];

public static A187200Inst Instance=new A187200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187201
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,3L,4L,2L,2L,3L,3L,3L,4L,3L,2L,3L,4L,3L,5L,4L,6L,3L,4L,4L,2L,7L,3L,4L,3L,5L,5L,5L,8L,3L,4L,5L,5L,5L,4L,2L,5L,5L,6L,4L,7L,4L,6L,5L,5L,6L,6L,6L,5L,4L,2L,8L,3L,7L,6L,6L,8L,6L,3L,9L,10L,10L,9L,7L,7L,9L,10L,10L,9L,7L,7L,6L,5L,4L,8L,10L,8L,8L,4L,7L,6L,3L,8L,5L,6L,9L,4L,7L,8L,10L,11L,11L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187201Inst : IEnumerable<long>
{
public static readonly long[] Value=A187201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187201.Bytes);
public long this[int i]=>Value[i];

public static A187201Inst Instance=new A187201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187202
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,1L,4L,0L,10L,1L,12L,-2L,8L,1L,16L,12L,18L,-11L,8L,-6L,22L,-12L,16L,-8L,8L,-3L,28L,50L,30L,1L,8L,-12L,28L,-11L,36L,-14L,8L,-66L,40L,104L,42L,13L,24L,-18L,46L,-103L,36L,-16L,8L,21L,52L,88L,36L,48L,8L,-24L,58L,-667L,60L,-26L,-8L,1L,40L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187202Inst : IEnumerable<long>
{
public static readonly long[] Value=A187202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187202.Bytes);
public long this[int i]=>Value[i];

public static A187202Inst Instance=new A187202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187203
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,1L,4L,0L,10L,1L,12L,2L,8L,1L,16L,4L,18L,1L,8L,6L,22L,2L,16L,8L,8L,3L,28L,4L,30L,1L,8L,12L,24L,1L,36L,14L,8L,0L,40L,4L,42L,3L,20L,18L,46L,1L,36L,0L,8L,3L,52L,8L,36L,0L,8L,24L,58L,3L,60L,26L,4L,1L,40L,12L,66L,3L,8L,2L,70L,4L,72L,32L,32L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187203Inst : IEnumerable<long>
{
public static readonly long[] Value=A187203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187203.Bytes);
public long this[int i]=>Value[i];

public static A187203Inst Instance=new A187203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187204
{
public static readonly long[] Value={ 10L,171L,1947L,2619L,265105L,478834027L,974622397L,11373118351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187204Inst : IEnumerable<long>
{
public static readonly long[] Value=A187204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187204.Bytes);
public long this[int i]=>Value[i];

public static A187204Inst Instance=new A187204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187205
{
public static readonly long[] Value={ 10L,40L,50L,56L,104L,130L,136L,160L,170L,171L,224L,230L,232L,250L,290L,310L,312L,370L,392L,410L,430L,459L,470L,520L,530L,560L,590L,610L,624L,640L,648L,670L,710L,730L,790L,830L,890L,896L,970L,1000L,1010L,1030L,1070L,1088L,1090L,1130L,1160L,1216L,1218L,1221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187205Inst : IEnumerable<long>
{
public static readonly long[] Value=A187205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187205.Bytes);
public long this[int i]=>Value[i];

public static A187205Inst Instance=new A187205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187206
{
public static readonly long[] Value={ 138L,282L,426L,570L,714L,858L,1002L,1146L,1290L,1434L,1578L,1722L,1866L,2010L,2154L,2298L,2442L,2586L,2730L,2874L,3018L,3162L,3306L,3450L,3594L,3738L,3882L,4026L,4170L,4314L,4458L,4602L,4746L,4890L,5034L,5178L,5322L,5466L,5610L,5754L,5898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187206Inst : IEnumerable<long>
{
public static readonly long[] Value=A187206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187206.Bytes);
public long this[int i]=>Value[i];

public static A187206Inst Instance=new A187206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187207
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,2L,4L,2L,1L,2L,1L,1L,5L,1L,4L,6L,3L,2L,1L,3L,1L,1L,2L,0L,2L,7L,1L,6L,8L,4L,2L,1L,4L,2L,1L,2L,1L,1L,9L,3L,1L,6L,2L,4L,10L,5L,2L,1L,5L,3L,1L,2L,2L,0L,11L,1L,10L,12L,6L,4L,3L,2L,1L,6L,2L,1L,1L,1L,4L,1L,0L,0L,3L,1L,0L,2L,1L,1L,13L,1L,12L,14L,7L,2L,1L,7L,5L,1L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187207Inst : IEnumerable<long>
{
public static readonly long[] Value=A187207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187207.Bytes);
public long this[int i]=>Value[i];

public static A187207Inst Instance=new A187207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187208
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,20L,32L,36L,48L,64L,80L,108L,112L,128L,156L,192L,204L,220L,252L,256L,260L,272L,304L,320L,324L,368L,396L,448L,476L,484L,512L,544L,608L,656L,660L,688L,768L,972L,1008L,1024L,1044L,1120L,1184L,1248L,1280L,1300L,1332L,1476L,1764L,1792L,1908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187208Inst : IEnumerable<long>
{
public static readonly long[] Value=A187208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187208.Bytes);
public long this[int i]=>Value[i];

public static A187208Inst Instance=new A187208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187209
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,9L,6L,11L,12L,13L,10L,24L,12L,21L,30L,26L,16L,43L,18L,40L,40L,37L,22L,59L,40L,45L,50L,52L,28L,89L,30L,57L,60L,61L,86L,90L,36L,69L,70L,103L,40L,125L,42L,88L,140L,85L,46L,128L,84L,97L,90L,106L,52L,165L,130L,113L,100L,109L,58L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187209Inst : IEnumerable<long>
{
public static readonly long[] Value=A187209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187209.Bytes);
public long this[int i]=>Value[i];

public static A187209Inst Instance=new A187209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187210
{
public static readonly long[] Value={ 0L,1L,5L,12L,24L,46L,66L,88L,128L,182L,222L,244L,284L,338L,394L,464L,584L,718L,790L,812L,852L,906L,962L,1032L,1152L,1286L,1374L,1444L,1564L,1714L,1882L,2128L,2488L,2814L,2950L,2972L,3012L,3066L,3122L,3192L,3312L,3446L,3534L,3604L,3724L,3874L,4042L,4288L,4648L,4974L,5126L,5196L,5316L,5466L,5634L,5880L,6240L,6582L,6814L,7060L,7436L,7890L,8458L,9296L,10328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187210Inst : IEnumerable<long>
{
public static readonly long[] Value=A187210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187210.Bytes);
public long this[int i]=>Value[i];

public static A187210Inst Instance=new A187210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187211
{
public static readonly long[] Value={ 0L,1L,4L,7L,12L,22L,20L,22L,40L,54L,40L,22L,40L,54L,56L,70L,120L,134L,72L,22L,40L,54L,56L,70L,120L,134L,88L,70L,120L,150L,168L,246L,360L,326L,136L,22L,40L,54L,56L,70L,120L,134L,88L,70L,120L,150L,168L,246L,360L,326L,152L,70L,120L,150L,168L,246L,360L,342L,232L,246L,376L,454L,568L,838L,1032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187211Inst : IEnumerable<long>
{
public static readonly long[] Value=A187211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187211.Bytes);
public long this[int i]=>Value[i];

public static A187211Inst Instance=new A187211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187244
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,17L,7L,78L,42L,463L,247L,10L,3315L,1550L,175L,27164L,11049L,2107L,247975L,92596L,22029L,280L,2492539L,906427L,220734L,9100L,27422698L,10044963L,2264724L,184415L,328607417L,122314296L,25036462L,3028025L,15400L,4266367567L,1607778568L,307273681L,44800184L,800800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187244Inst : IEnumerable<long>
{
public static readonly long[] Value=A187244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187244.Bytes);
public long this[int i]=>Value[i];

public static A187244Inst Instance=new A187244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187245
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,17L,78L,463L,3315L,27164L,247975L,2492539L,27422698L,328607417L,4266367567L,59686293284L,895068242601L,14320843215019L,243467476610732L,4382635181281015L,83272415871044649L,1665465961530365026L,BigInteger.Parse("34974843092354081119"),BigInteger.Parse("769445564105823722109") };
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
public class A187245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187245Inst Instance=new A187245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187246
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,7L,42L,267L,1900L,15263L,137494L,1375195L,15127656L,181532895L,2359929682L,33039019643L,495585302836L,7929364861759L,134799202682670L,2426385648353595L,46101327318849376L,922026546377249663L,BigInteger.Parse("19362557473922767210"),BigInteger.Parse("425976264426301927195") };
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
public class A187246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187246Inst Instance=new A187246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187247
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,3L,1L,2L,4L,11L,6L,1L,16L,18L,40L,35L,10L,1L,104L,142L,178L,195L,85L,15L,1L,688L,1236L,1106L,1148L,665L,175L,21L,1L,5116L,10832L,9300L,7728L,5173L,1820L,322L,28L,1L,44224L,98492L,91680L,63284L,42168L,18165L,4284L,546L,36L,1L,438560L,964172L,974924L,627420L,378620L,181797L,53361L,9030L,870L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187247Inst : IEnumerable<long>
{
public static readonly long[] Value=A187247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187247.Bytes);
public long this[int i]=>Value[i];

public static A187247Inst Instance=new A187247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187248
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,2L,16L,104L,688L,5116L,44224L,438560L,4851136L,58603544L,764606016L,10715043104L,160692920256L,2570016145680L,43678554864128L,786135111482112L,14936420654180864L,298733557232591136L,6273502048592506112L,BigInteger.Parse("138018105454095739008"),BigInteger.Parse("3174423293668325353216") };
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
public class A187248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187248Inst Instance=new A187248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187249
{
public static readonly BigInteger[] Value={ 0L,1L,3L,11L,48L,248L,1504L,10560L,84544L,761024L,7610496L,83715968L,1004592640L,13059706368L,182835893248L,2742538406912L,43880614526976L,745970446991360L,13427468045910016L,255121892872421376L,5102437857448689664L,BigInteger.Parse("107151195006423007232"),BigInteger.Parse("2357326290141307207680") };
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
public class A187249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187249Inst Instance=new A187249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187250
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,2L,94L,26L,460L,260L,2532L,2508L,15420L,24760L,140L,102620L,254968L,5292L,739512L,2760432L,128856L,5729192L,31547344L,2640264L,47429896L,381339368L,50186136L,46200L,417429800L,4879612808L,926494712L,3483480L,3888426512L,66107044176L,17025751600L,157068912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187250Inst : IEnumerable<long>
{
public static readonly long[] Value=A187250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187250.Bytes);
public long this[int i]=>Value[i];

public static A187250Inst Instance=new A187250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187251
{
public static readonly ulong[] Value={ 1L,1L,2L,6L,22L,94L,460L,2532L,15420L,102620L,739512L,5729192L,47429896L,417429800L,3888426512L,38192416048L,394239339792L,4264424937488L,48212317486112L,568395755184224L,6973300915138656L,88860103591344864L,1174131206436335296L,16061756166912244800UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187251Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A187251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187251.Bytes);
public ulong this[int i]=>Value[i];

public static A187251Inst Instance=new A187251Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187252
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,2L,26L,260L,2508L,25040L,265552L,3018144L,36827872L,481850240L,6743052672L,100629754112L,1596624594688L,26853667866624L,477435143587840L,8949520012611584L,176443253945217024L,3650510179312910336L,BigInteger.Parse("79093615773747232768"),BigInteger.Parse("1791150489194147512320") };
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
public class A187252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187252Inst Instance=new A187252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187253
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,3L,0L,1L,0L,6L,0L,6L,0L,1L,4L,0L,21L,0L,10L,0L,1L,0L,34L,0L,55L,0L,15L,0L,1L,22L,0L,157L,0L,120L,0L,21L,0L,1L,0L,232L,0L,526L,0L,231L,0L,28L,0L,1L,139L,0L,1317L,0L,1435L,0L,406L,0L,36L,0L,1L,0L,1761L,0L,5355L,0L,3388L,0L,666L,0L,45L,0L,1L,979L,0L,11883L,0L,17500L,0L,7182L,0L,1035L,0L,55L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187253Inst : IEnumerable<long>
{
public static readonly long[] Value=A187253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187253.Bytes);
public long this[int i]=>Value[i];

public static A187253Inst Instance=new A187253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187254
{
public static readonly long[] Value={ 1L,0L,1L,4L,22L,139L,979L,7484L,61018L,523995L,4696277L,43623618L,417729564L,4106089683L,41289287337L,423556384020L,4422308778458L,46904447607369L,504544306691569L,5496706186024364L,60576765646658782L,674624324569952719L,7585425185883023881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187254Inst : IEnumerable<long>
{
public static readonly long[] Value=A187254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187254.Bytes);
public long this[int i]=>Value[i];

public static A187254Inst Instance=new A187254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187255
{
public static readonly long[] Value={ 0L,1L,2L,4L,10L,29L,88L,281L,928L,3170L,11108L,39844L,145700L,542099L,2047390L,7837154L,30359390L,118877686L,470023034L,1874858180L,7538907394L,30538466279L,124544812652L,511112081854L,2109676656860L,8754763717529L,36512355688438L,152987775947396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187255Inst : IEnumerable<long>
{
public static readonly long[] Value=A187255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187255.Bytes);
public long this[int i]=>Value[i];

public static A187255Inst Instance=new A187255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187256
{
public static readonly long[] Value={ 1L,2L,4L,10L,28L,82L,248L,770L,2440L,7858L,25644L,84618L,281844L,946338L,3199728L,10885122L,37230352L,127951714L,441633812L,1530242954L,5320853260L,18560408050L,64932101224L,227767796482L,800928670232L,2822814469394L,9969770245948L,35280714655498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187256Inst : IEnumerable<long>
{
public static readonly long[] Value=A187256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187256.Bytes);
public long this[int i]=>Value[i];

public static A187256Inst Instance=new A187256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187257
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,5L,17L,52L,150L,417L,1135L,3047L,8103L,21409L,56303L,147569L,385808L,1006775L,2623477L,6828941L,17761182L,46165507L,119937807L,311485907L,808731993L,2099358057L,5448906369L,14141429587L,36699034884L,95237147804L,247149109444L,641388458961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187257Inst : IEnumerable<long>
{
public static readonly long[] Value=A187257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187257.Bytes);
public long this[int i]=>Value[i];

public static A187257Inst Instance=new A187257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187258
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,7L,17L,41L,99L,242L,596L,1477L,3681L,9215L,23155L,58368L,147530L,373768L,948882L,2413264L,6147414L,15682008L,40056238L,102434119L,262228051L,671945055L,1723350315L,4423518544L,11362907022L,29208834520L,75131251334L,193370093508L,497969663062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187258Inst : IEnumerable<long>
{
public static readonly long[] Value=A187258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187258.Bytes);
public long this[int i]=>Value[i];

public static A187258Inst Instance=new A187258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187259
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,11L,39L,122L,358L,1008L,2770L,7493L,20049L,53239L,140603L,369837L,969883L,2537685L,6628215L,17288950L,45048932L,117285552L,305159262L,793581817L,2062948149L,5361112383L,13929080271L,36183941553L,93984332531L,244094334682L,633922350198L,1646271999611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187259Inst : IEnumerable<long>
{
public static readonly long[] Value=A187259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187259.Bytes);
public long this[int i]=>Value[i];

public static A187259Inst Instance=new A187259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187388
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,103L,104L,105L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187388Inst : IEnumerable<long>
{
public static readonly long[] Value=A187388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187388.Bytes);
public long this[int i]=>Value[i];

public static A187388Inst Instance=new A187388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187389
{
public static readonly long[] Value={ 6L,12L,18L,24L,30L,36L,42L,48L,54L,60L,67L,73L,79L,85L,91L,97L,103L,109L,115L,121L,128L,134L,140L,146L,152L,158L,164L,170L,176L,182L,188L,195L,201L,207L,213L,219L,225L,231L,237L,243L,249L,256L,262L,268L,274L,280L,286L,292L,298L,304L,310L,316L,323L,329L,335L,341L,347L,353L,359L,365L,371L,377L,384L,390L,396L,402L,408L,414L,420L,426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187389Inst : IEnumerable<long>
{
public static readonly long[] Value=A187389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187389.Bytes);
public long this[int i]=>Value[i];

public static A187389Inst Instance=new A187389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187390
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,92L,93L,94L,95L,96L,98L,99L,100L,101L,102L,104L,105L,106L,107L,108L,110L,111L,112L,113L,114L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187390Inst : IEnumerable<long>
{
public static readonly long[] Value=A187390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187390.Bytes);
public long this[int i]=>Value[i];

public static A187390Inst Instance=new A187390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187391
{
public static readonly long[] Value={ 6L,12L,19L,25L,32L,38L,45L,51L,58L,64L,71L,77L,84L,90L,97L,103L,110L,116L,123L,129L,135L,142L,148L,155L,161L,168L,174L,181L,187L,194L,200L,207L,213L,220L,226L,233L,239L,246L,252L,258L,265L,271L,278L,284L,291L,297L,304L,310L,317L,323L,330L,336L,343L,349L,356L,362L,369L,375L,381L,388L,394L,401L,407L,414L,420L,427L,433L,440L,446L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187391Inst : IEnumerable<long>
{
public static readonly long[] Value=A187391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187391.Bytes);
public long this[int i]=>Value[i];

public static A187391Inst Instance=new A187391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187392
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L,98L,99L,100L,101L,102L,104L,105L,106L,107L,108L,109L,111L,112L,113L,114L,115L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187392Inst : IEnumerable<long>
{
public static readonly long[] Value=A187392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187392.Bytes);
public long this[int i]=>Value[i];

public static A187392Inst Instance=new A187392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187393
{
public static readonly long[] Value={ 6L,13L,20L,27L,34L,40L,47L,54L,61L,68L,75L,81L,88L,95L,102L,109L,116L,122L,129L,136L,143L,150L,157L,163L,170L,177L,184L,191L,198L,204L,211L,218L,225L,232L,238L,245L,252L,259L,266L,273L,279L,286L,293L,300L,307L,314L,320L,327L,334L,341L,348L,355L,361L,368L,375L,382L,389L,396L,402L,409L,416L,423L,430L,437L,443L,450L,457L,464L,471L,477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187393Inst : IEnumerable<long>
{
public static readonly long[] Value=A187393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187393.Bytes);
public long this[int i]=>Value[i];

public static A187393Inst Instance=new A187393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187394
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,87L,89L,90L,91L,92L,93L,94L,96L,97L,98L,99L,100L,101L,103L,104L,105L,106L,107L,108L,110L,111L,112L,113L,114L,115L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187394Inst : IEnumerable<long>
{
public static readonly long[] Value=A187394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187394.Bytes);
public long this[int i]=>Value[i];

public static A187394Inst Instance=new A187394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187395
{
public static readonly long[] Value={ 7L,14L,21L,28L,35L,42L,50L,57L,64L,71L,78L,85L,93L,100L,107L,114L,121L,128L,136L,143L,150L,157L,164L,171L,179L,186L,193L,200L,207L,214L,222L,229L,236L,243L,250L,257L,265L,272L,279L,286L,293L,300L,307L,315L,322L,329L,336L,343L,350L,358L,365L,372L,379L,386L,393L,401L,408L,415L,422L,429L,436L,444L,451L,458L,465L,472L,479L,487L,494L,501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187395Inst : IEnumerable<long>
{
public static readonly long[] Value=A187395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187395.Bytes);
public long this[int i]=>Value[i];

public static A187395Inst Instance=new A187395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187396
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,91L,92L,94L,95L,96L,97L,98L,99L,101L,102L,103L,104L,105L,106L,108L,109L,110L,111L,112L,113L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187396Inst : IEnumerable<long>
{
public static readonly long[] Value=A187396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187396.Bytes);
public long this[int i]=>Value[i];

public static A187396Inst Instance=new A187396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187397
{
public static readonly long[] Value={ 0L,0L,0L,0L,10L,16L,22L,36L,54L,66L,92L,122L,156L,196L,240L,288L,366L,426L,490L,590L,698L,780L,904L,1036L,1176L,1326L,1484L,1650L,1874L,2060L,2254L,2512L,2782L,3006L,3300L,3606L,3924L,4256L,4600L,4956L,5398L,5782L,6178L,6666L,7170L,7608L,8144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187397Inst : IEnumerable<long>
{
public static readonly long[] Value=A187397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187397.Bytes);
public long this[int i]=>Value[i];

public static A187397Inst Instance=new A187397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187398
{
public static readonly long[] Value={ 248L,264L,324L,384L,396L,432L,624L,648L,672L,728L,735L,784L,824L,864L,936L,1236L,1248L,1296L,1326L,1362L,1368L,1395L,1632L,1692L,1764L,1824L,1926L,1935L,1962L,2048L,2064L,2136L,2184L,2196L,2248L,2304L,2316L,2328L,2340L,2346L,2364L,2376L,2384L,2394L,2408L,2436L,2448L,2460L,2480L,2488L,2496L,2540L,2568L,2584L,2604L,2634L,2640L,2648L,2664L,2688L,2730L,2736L,2744L,2784L,2824L,2832L,2840L,2848L,2856L,2864L,2916L,2934L,2964L,2984L,3024L,3048L,3096L,3126L,3162L,3168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187398Inst : IEnumerable<long>
{
public static readonly long[] Value=A187398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187398.Bytes);
public long this[int i]=>Value[i];

public static A187398Inst Instance=new A187398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187399
{
public static readonly long[] Value={ 12429793L,124097L,14239807L,135697L,7561L,15209167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187399Inst : IEnumerable<long>
{
public static readonly long[] Value=A187399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187399.Bytes);
public long this[int i]=>Value[i];

public static A187399Inst Instance=new A187399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187400
{
public static readonly long[] Value={ 15L,35L,51L,65L,77L,91L,115L,123L,141L,161L,185L,187L,201L,209L,219L,221L,235L,259L,267L,301L,305L,321L,339L,341L,355L,365L,377L,381L,403L,413L,427L,437L,451L,453L,481L,485L,497L,501L,537L,545L,589L,649L,667L,681L,689L,699L,717L,721L,723L,737L,745L,749L,763L,789L,835L,843L,849L,893L,901L,905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187400Inst : IEnumerable<long>
{
public static readonly long[] Value=A187400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187400.Bytes);
public long this[int i]=>Value[i];

public static A187400Inst Instance=new A187400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187401
{
public static readonly long[] Value={ 30L,100L,144L,274L,484L,516L,526L,756L,1046L,1250L,1714L,1806L,1834L,2284L,2440L,2610L,2940L,3524L,3824L,4190L,5084L,5746L,6766L,7486L,9746L,9920L,10310L,13024L,13210L,15396L,16916L,17546L,18726L,19256L,20000L,21194L,23214L,24964L,30370L,30394L,31126L,31496L,35180L,36680L,37816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187401Inst : IEnumerable<long>
{
public static readonly long[] Value=A187401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187401.Bytes);
public long this[int i]=>Value[i];

public static A187401Inst Instance=new A187401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187402
{
public static readonly BigInteger[] Value={ 9L,141L,4743L,378999L,77470101L,43182942669L,69704886620367L,343603587128867631L,BigInteger.Parse("5351921330163734358189"),BigInteger.Parse("265547472520415711196418101") };
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
public class A187402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187402Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187402.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187402Inst Instance=new A187402Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187403
{
public static readonly BigInteger[] Value={ 16L,580L,59008L,18555136L,19210448896L,68711440384000L,884085911344119808L,BigInteger.Parse("42474221110291056295936") };
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
public class A187403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187403Inst Instance=new A187403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187740
{
public static readonly BigInteger[] Value={ 1L,6L,85L,1650L,40500L,1200000L,41625000L,1653750000L,74025000000L,3685500000000L,201993750000000L,12084187500000000L,783523125000000000L,BigInteger.Parse("54729675000000000000"),BigInteger.Parse("4097124281250000000000"),BigInteger.Parse("327237848437500000000000"),BigInteger.Parse("27775310062500000000000000"),BigInteger.Parse("2496585341250000000000000000") };
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
public class A187740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187740Inst Instance=new A187740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187741
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,12L,24L,60L,120L,360L,720L,2520L,5040L,20160L,40320L,181440L,362880L,1814400L,3628800L,19958400L,39916800L,239500800L,479001600L,3113510400L,6227020800L,43589145600L,87178291200L,653837184000L,1307674368000L,10461394944000L,20922789888000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187741Inst : IEnumerable<long>
{
public static readonly long[] Value=A187741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187741.Bytes);
public long this[int i]=>Value[i];

public static A187741Inst Instance=new A187741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187742
{
public static readonly BigInteger[] Value={ 1L,1L,4L,14L,66L,384L,2640L,20880L,186480L,1854720L,20321280L,243129600L,3153427200L,44068147200L,660064204800L,10548573235200L,179151388416000L,3222109642752000L,61178237632512000L,1222853377794048000L,BigInteger.Parse("25667116186263552000"),BigInteger.Parse("564433265896980480000"),BigInteger.Parse("12977099311614197760000") };
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
public class A187742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187742Inst Instance=new A187742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187743
{
public static readonly long[] Value={ 1890L,3150L,4410L,5670L,6930L,8190L,9450L,10710L,11970L,12600L,14490L,13860L,15750L,17010L,20160L,19530L,22050L,20790L,23940L,24570L,26460L,28350L,28980L,64680L,27720L,32130L,32760L,38430L,39690L,40320L,34650L,51660L,53550L,56700L,41580L,58590L,48510L,70560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187743Inst : IEnumerable<long>
{
public static readonly long[] Value=A187743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187743.Bytes);
public long this[int i]=>Value[i];

public static A187743Inst Instance=new A187743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187744
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,12L,15L,19L,21L,24L,28L,30L,33L,37L,42L,46L,51L,55L,60L,64L,69L,73L,78L,82L,87L,91L,96L,100L,102L,105L,109L,111L,114L,118L,120L,123L,127L,132L,136L,141L,145L,150L,154L,159L,163L,168L,172L,177L,181L,186L,190L,195L,201L,204L,208L,210L,213L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187744Inst : IEnumerable<long>
{
public static readonly long[] Value=A187744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187744.Bytes);
public long this[int i]=>Value[i];

public static A187744Inst Instance=new A187744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187745
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-1L,-1L,-3617L,-7709321041217L,BigInteger.Parse("-106783830147866529886385444979142647942017") };
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
public class A187745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187745Inst Instance=new A187745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187746
{
public static readonly BigInteger[] Value={ 1L,2L,13L,100L,984L,11712L,163200L,2603520L,46771200L,934133760L,20530298880L,492355584000L,12793813401600L,358063276032000L,10737974299852800L,343513154086502400L,11676590580695040000UL,BigInteger.Parse("420271561157640192000"),BigInteger.Parse("15967576932074127360000") };
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
public class A187746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187746Inst Instance=new A187746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187747
{
public static readonly long[] Value={ 1L,-6L,3L,-7L,3L,1L,1L,-2L,3L,-5L,1L,3L,0L,7L,5L,-2L,0L,0L,3L,1L,0L,2L,4L,-4L,-4L,-1L,1L,2L,-1L,2L,7L,-1L,-6L,0L,4L,-1L,-3L,-6L,4L,0L,-1L,2L,2L,3L,0L,6L,-3L,-2L,-4L,-8L,-5L,-4L,3L,-5L,-4L,0L,1L,-2L,0L,-2L,-3L,-1L,7L,-5L,-4L,-2L,3L,8L,-6L,0L,-2L,-3L,6L,-1L,3L,3L,-3L,-4L,1L,4L,0L,4L,1L,-5L,7L,-3L,-5L,2L,7L,-5L,-3L,-2L,2L,-3L,0L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187747Inst : IEnumerable<long>
{
public static readonly long[] Value=A187747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187747.Bytes);
public long this[int i]=>Value[i];

public static A187747Inst Instance=new A187747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187748
{
public static readonly BigInteger[] Value={ 1L,2L,12L,144L,4320L,233280L,29393280L,7054387200L,3555411148800L,3519857037312000L,7201627498340352000L,BigInteger.Parse("28950542543328215040000"),BigInteger.Parse("237104943429858081177600000"),BigInteger.Parse("3853903750508913251460710400000"),BigInteger.Parse("126138269754156730720309051392000000"),BigInteger.Parse("8234306249551351381421774874869760000000"),BigInteger.Parse("1079270520128695625562952032849179443200000000"),BigInteger.Parse("282311265573183686952254740944556962034483200000000") };
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
public class A187748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187748Inst Instance=new A187748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187749
{
public static readonly long[] Value={ 17L,20L,24L,27L,31L,33L,35L,40L,41L,42L,44L,49L,50L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187749Inst : IEnumerable<long>
{
public static readonly long[] Value=A187749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187749.Bytes);
public long this[int i]=>Value[i];

public static A187749Inst Instance=new A187749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187750
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,10L,11L,18L,20L,32L,50L,110L,153L,507L,727L,900L,982L,1489L,1737L,1974L,3085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187750Inst : IEnumerable<long>
{
public static readonly long[] Value=A187750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187750.Bytes);
public long this[int i]=>Value[i];

public static A187750Inst Instance=new A187750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187751
{
public static readonly BigInteger[] Value={ 0L,0L,0L,81L,225280L,7991790625L,1078848154238976L,BigInteger.Parse("65180706714634067542224001"),BigInteger.Parse("1650157594512930366268925848349310976"),BigInteger.Parse("66807065275536807794426016376688705273224158387201") };
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
public class A187751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A187751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A187751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A187751Inst Instance=new A187751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A187752
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,2L,0L,1L,0L,3L,2L,3L,4L,3L,0L,1L,1L,2L,1L,2L,0L,6L,2L,3L,3L,5L,5L,4L,6L,4L,0L,1L,1L,2L,0L,3L,2L,3L,1L,3L,1L,4L,1L,3L,3L,8L,2L,3L,4L,4L,3L,5L,3L,8L,5L,5L,5L,6L,8L,5L,8L,5L,0L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,4L,1L,5L,3L,4L,1L,3L,2L,5L,2L,4L,2L,6L,1L,4L,3L,6L,2L,6L,4L,10L,2L,3L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A187752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A187752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A187752Inst : IEnumerable<long>
{
public static readonly long[] Value=A187752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A187752.Bytes);
public long this[int i]=>Value[i];

public static A187752Inst Instance=new A187752Inst();

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