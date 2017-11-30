using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A188823
{
public static readonly long[] Value={ 256L,3025L,11664L,28561L,53824L,87616L,129600L,179776L,238144L,304704L,379456L,462400L,553536L,652864L,760384L,876096L,1000000L,1132096L,1272384L,1420864L,1577536L,1742400L,1915456L,2096704L,2286144L,2483776L,2689600L,2903616L,3125824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188823Inst : IEnumerable<long>
{
public static readonly long[] Value=A188823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188823.Bytes);
public long this[int i]=>Value[i];

public static A188823Inst Instance=new A188823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188824
{
public static readonly long[] Value={ 2L,4L,4L,8L,9L,8L,16L,25L,16L,16L,32L,64L,48L,25L,32L,64L,169L,144L,81L,36L,64L,128L,441L,432L,256L,120L,49L,128L,256L,1156L,1296L,841L,400L,169L,64L,256L,512L,3025L,3888L,2704L,1360L,576L,224L,81L,512L,1024L,7921L,11664L,8836L,4624L,2025L,784L,289L,100L,1024L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188824Inst : IEnumerable<long>
{
public static readonly long[] Value=A188824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188824.Bytes);
public long this[int i]=>Value[i];

public static A188824Inst Instance=new A188824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188825
{
public static readonly long[] Value={ 8L,16L,48L,144L,432L,1296L,3888L,11664L,34992L,104976L,314928L,944784L,2834352L,8503056L,25509168L,76527504L,229582512L,688747536L,2066242608L,6198727824L,18596183472L,55788550416L,167365651248L,502096953744L,1506290861232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188825Inst : IEnumerable<long>
{
public static readonly long[] Value=A188825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188825.Bytes);
public long this[int i]=>Value[i];

public static A188825Inst Instance=new A188825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188826
{
public static readonly long[] Value={ 16L,25L,81L,256L,841L,2704L,8836L,28561L,93025L,301401L,980100L,3179089L,10329796L,33524100L,108889225L,353477601L,1147922161L,3726858304L,12101980081L,39292754176L,127587553636L,414263438689L,1345129081209L,4367552437161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188826Inst : IEnumerable<long>
{
public static readonly long[] Value=A188826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188826.Bytes);
public long this[int i]=>Value[i];

public static A188826Inst Instance=new A188826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188827
{
public static readonly long[] Value={ 32L,36L,120L,400L,1360L,4624L,15776L,53824L,183744L,627264L,2141568L,7311616L,24963328L,85229824L,290992640L,993510400L,3392056320L,11581203456L,39540701184L,135000395776L,460920180736L,1573679927296L,5372879347712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188827Inst : IEnumerable<long>
{
public static readonly long[] Value=A188827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188827.Bytes);
public long this[int i]=>Value[i];

public static A188827Inst Instance=new A188827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188876
{
public static readonly long[] Value={ 16L,256L,2032L,21937L,233756L,2368612L,24609576L,255014376L,2634386061L,27264641304L,282086403837L,2918043746684L,30189606384325L,312327215078591L,3231163537843117L,33428102017481312L,345830567133874557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188876Inst : IEnumerable<long>
{
public static readonly long[] Value=A188876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188876.Bytes);
public long this[int i]=>Value[i];

public static A188876Inst Instance=new A188876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188877
{
public static readonly BigInteger[] Value={ 32L,1024L,13045L,252932L,4805140L,84965120L,1558668181L,28472229080L,517776315573L,9442392487092L,172104527985533L,3136183930249272L,57160501361811036L,1041761230924349515L,BigInteger.Parse("18986128724688300231") };
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
public class A188877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188877Inst Instance=new A188877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188878
{
public static readonly BigInteger[] Value={ 64L,4096L,83737L,2915832L,98892196L,3043939392L,98523889293L,3172528318064L,101464669143512L,3258224293964324L,104560302171744053L,3354085571383579972L,BigInteger.Parse("107624415834964708600"),BigInteger.Parse("3453181474717075939696"),BigInteger.Parse("110794646417240343858097") };
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
public class A188878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188878Inst Instance=new A188878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188879
{
public static readonly BigInteger[] Value={ 128L,16384L,537496L,33617513L,2035428944L,109002398784L,6231989402196L,353870576831949L,19905175576044841L,1126107155232462372L,BigInteger.Parse("63649373276613825016"),BigInteger.Parse("3595294680877439593742"),BigInteger.Parse("203177355059869569596960") };
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
public class A188879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188879Inst Instance=new A188879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188880
{
public static readonly BigInteger[] Value={ 256L,65536L,3450100L,387583973L,41894114820L,3903192037184L,394199392835388L,39466951597153578L,3904179563792169392L,BigInteger.Parse("389112055304583124864"),BigInteger.Parse("38733126975093560310741"),BigInteger.Parse("3852354123185134763957569") };
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
public class A188880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188880Inst Instance=new A188880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188881
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,6L,11L,12L,6L,24L,50L,70L,60L,24L,120L,274L,450L,510L,360L,120L,720L,1764L,3248L,4410L,4200L,2520L,720L,5040L,13068L,26264L,40614L,47040L,38640L,20160L,5040L,40320L,109584L,236248L,403704L,538776L,544320L,393120L,181440L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188881Inst : IEnumerable<long>
{
public static readonly long[] Value=A188881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188881.Bytes);
public long this[int i]=>Value[i];

public static A188881Inst Instance=new A188881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188882
{
public static readonly long[] Value={ 3L,6L,1L,0L,3L,1L,7L,2L,9L,8L,2L,8L,1L,7L,6L,6L,8L,2L,3L,6L,2L,4L,7L,1L,7L,6L,2L,5L,8L,4L,8L,5L,2L,7L,6L,9L,2L,1L,7L,3L,7L,9L,9L,4L,4L,4L,9L,6L,1L,9L,9L,0L,6L,5L,1L,4L,8L,3L,3L,3L,5L,5L,8L,1L,6L,2L,2L,6L,0L,3L,3L,5L,3L,9L,9L,8L,9L,0L,4L,2L,0L,9L,2L,2L,1L,7L,4L,6L,7L,7L,5L,4L,8L,4L,3L,4L,5L,1L,3L,2L,8L,5L,2L,2L,6L,3L,2L,0L,7L,3L,5L,8L,4L,5L,1L,6L,3L,7L,1L,1L,7L,2L,7L,1L,2L,9L,1L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188882Inst : IEnumerable<long>
{
public static readonly long[] Value=A188882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188882.Bytes);
public long this[int i]=>Value[i];

public static A188882Inst Instance=new A188882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188883
{
public static readonly long[] Value={ 1L,3L,6L,7L,7L,4L,8L,3L,9L,4L,9L,3L,1L,3L,6L,7L,4L,4L,4L,6L,9L,9L,6L,9L,1L,7L,6L,5L,6L,8L,2L,2L,0L,5L,4L,5L,5L,6L,5L,1L,1L,1L,3L,2L,6L,8L,9L,0L,2L,1L,4L,8L,8L,6L,9L,4L,7L,5L,0L,0L,4L,6L,5L,7L,5L,6L,7L,1L,5L,3L,4L,5L,6L,2L,8L,2L,0L,1L,7L,6L,9L,3L,0L,7L,9L,0L,1L,9L,3L,0L,9L,7L,4L,1L,9L,3L,2L,3L,3L,5L,3L,1L,2L,2L,6L,6L,3L,0L,2L,7L,3L,4L,3L,3L,0L,8L,1L,4L,5L,9L,8L,2L,2L,8L,1L,5L,8L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188883Inst : IEnumerable<long>
{
public static readonly long[] Value=A188883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188883.Bytes);
public long this[int i]=>Value[i];

public static A188883Inst Instance=new A188883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188884
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,1L,3L,1L,1L,5L,1L,7L,1L,1L,23L,2L,2L,4L,3L,1L,11L,158L,1L,1L,1L,1L,4L,2L,1L,6L,2L,19L,75L,1L,1L,1L,28L,1L,29L,6L,8L,1L,5L,1L,4L,2L,1L,8L,1L,1L,19L,1L,1L,9L,2L,2L,3L,1L,2L,11L,1L,1L,3L,1L,1L,4L,169L,1L,1L,2L,1L,3L,1L,1L,10L,2L,1L,3L,8L,2L,4L,8L,5L,1L,8L,1L,7L,1L,1L,1L,1L,4L,38L,1L,5L,1L,43L,1L,1L,1L,1L,2L,1L,8L,1L,20L,1L,1L,1L,2L,13L,51L,2L,21L,1L,2L,5L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188884Inst : IEnumerable<long>
{
public static readonly long[] Value=A188884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188884.Bytes);
public long this[int i]=>Value[i];

public static A188884Inst Instance=new A188884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188885
{
public static readonly long[] Value={ 1L,4L,3L,3L,4L,0L,0L,5L,7L,3L,4L,0L,5L,1L,5L,4L,8L,4L,6L,3L,3L,1L,9L,0L,6L,9L,1L,9L,9L,7L,6L,7L,5L,2L,3L,2L,8L,8L,4L,3L,3L,9L,1L,1L,8L,3L,9L,5L,3L,6L,7L,0L,7L,8L,9L,8L,2L,5L,7L,9L,4L,6L,7L,9L,5L,0L,7L,5L,2L,7L,3L,9L,3L,9L,0L,5L,2L,7L,0L,6L,8L,9L,7L,5L,0L,7L,3L,6L,9L,7L,8L,9L,0L,9L,2L,5L,4L,5L,6L,5L,0L,5L,7L,4L,3L,2L,9L,4L,0L,8L,7L,5L,5L,5L,9L,0L,7L,4L,4L,7L,4L,8L,2L,3L,5L,3L,9L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188885Inst : IEnumerable<long>
{
public static readonly long[] Value=A188885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188885.Bytes);
public long this[int i]=>Value[i];

public static A188885Inst Instance=new A188885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188886
{
public static readonly long[] Value={ 1L,2L,3L,3L,1L,15L,1L,3L,7L,1L,2L,4L,2L,1L,4L,1L,1L,12L,4L,52L,1L,2L,1L,7L,3L,6L,1L,21L,1L,11L,1L,4L,1L,3L,2L,3L,2L,7L,1L,1L,2L,1L,3L,2L,1L,43L,4L,1L,1L,4L,4L,18L,2L,4L,4L,2L,1L,2L,3L,1L,3L,9L,1L,9L,4L,1L,6L,1L,1L,1L,2L,10L,1L,1L,1L,1L,2L,1L,2L,1L,2L,21L,2L,2L,1L,4L,1L,3L,12L,1L,9L,6L,1L,1L,4L,5L,2L,1L,1L,1L,1L,3L,1L,3L,16L,1L,6L,3L,10L,1L,8L,1L,8L,1L,13L,21L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188886Inst : IEnumerable<long>
{
public static readonly long[] Value=A188886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188886.Bytes);
public long this[int i]=>Value[i];

public static A188886Inst Instance=new A188886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188887
{
public static readonly long[] Value={ 1L,9L,3L,1L,8L,5L,1L,6L,5L,2L,5L,7L,8L,1L,3L,6L,5L,7L,3L,4L,9L,9L,4L,8L,6L,3L,9L,9L,4L,5L,7L,7L,9L,4L,7L,3L,5L,2L,6L,7L,8L,0L,9L,6L,7L,8L,0L,1L,6L,8L,0L,9L,1L,0L,0L,8L,0L,4L,6L,8L,6L,1L,5L,2L,6L,2L,0L,8L,4L,6L,4L,2L,7L,9L,5L,9L,7L,1L,1L,0L,3L,2L,6L,9L,5L,1L,2L,3L,4L,8L,3L,7L,1L,6L,1L,4L,0L,9L,0L,3L,7L,7L,6L,8L,0L,4L,2L,2L,3L,7L,2L,8L,7L,6L,3L,2L,4L,3L,0L,7L,4L,8L,9L,1L,8L,5L,0L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188887Inst : IEnumerable<long>
{
public static readonly long[] Value=A188887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188887.Bytes);
public long this[int i]=>Value[i];

public static A188887Inst Instance=new A188887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188888
{
public static readonly long[] Value={ 1L,1L,13L,1L,2L,15L,10L,1L,18L,1L,1L,21L,2L,1L,1L,2L,4L,5L,2L,2L,2L,11L,1L,2L,2L,3L,1L,1L,10L,1L,2L,1L,2L,3L,2L,3L,15L,1L,2L,3L,1L,1L,90L,1L,44L,2L,4L,10L,1L,11L,9L,1L,17L,1L,8L,2L,2L,6L,2L,6L,1L,3L,1L,1L,1L,2L,20L,1L,7L,27L,1L,19L,40L,1L,304L,1L,1L,2L,1L,1L,1L,62L,1L,1L,2L,1L,2L,1L,32L,1L,1L,1L,11L,1L,20L,1L,85L,1L,1L,1L,3L,3L,13L,1L,4L,1L,3L,1L,3L,1L,16L,1L,9L,3L,2L,1L,1L,30L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188888Inst : IEnumerable<long>
{
public static readonly long[] Value=A188888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188888.Bytes);
public long this[int i]=>Value[i];

public static A188888Inst Instance=new A188888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188889
{
public static readonly long[] Value={ 3L,5L,3L,5L,7L,5L,9L,5L,7L,5L,3L,3L,3L,5L,5L,5L,3L,5L,3L,3L,5L,3L,3L,5L,3L,5L,7L,7L,3L,3L,5L,5L,3L,3L,3L,5L,5L,7L,7L,5L,9L,7L,3L,3L,3L,15L,7L,3L,3L,3L,3L,5L,3L,7L,3L,5L,5L,7L,3L,3L,5L,3L,5L,3L,3L,3L,5L,5L,5L,5L,5L,5L,7L,5L,5L,3L,5L,3L,3L,3L,5L,3L,13L,3L,3L,3L,3L,13L,3L,3L,5L,5L,3L,7L,3L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188889Inst : IEnumerable<long>
{
public static readonly long[] Value=A188889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188889.Bytes);
public long this[int i]=>Value[i];

public static A188889Inst Instance=new A188889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188890
{
public static readonly BigInteger[] Value={ 1L,8L,9216L,1763704832L,55786539933761536L,BigInteger.Parse("291139753716719964894789632"),BigInteger.Parse("250571020614762113258116708732764160000"),BigInteger.Parse("35558299325468842404742419202148426327085023232000000"),BigInteger.Parse("831952537599396321581603077837672266625608464198409017861335832068096") };
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
public class A188890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188890Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188890.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188890Inst Instance=new A188890Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188891
{
public static readonly long[] Value={ 3L,36L,210L,6L,55L,21L,325L,10L,0L,105L,36L,1275L,15L,45L,231L,0L,946L,276L,21L,11935L,66L,136L,351L,1596L,78L,28L,1225L,595L,820L,58653L,190L,325L,1335795L,36L,6670L,0L,561L,4005L,120L,1128L,1485L,203841L,45L,666L,6903L,465L,4950L,20910L,741L,153L,10731L,8911L,55L,1953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188891Inst : IEnumerable<long>
{
public static readonly long[] Value=A188891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188891.Bytes);
public long this[int i]=>Value[i];

public static A188891Inst Instance=new A188891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188940
{
public static readonly long[] Value={ 2L,3L,4L,4L,3L,5L,5L,6L,2L,9L,2L,5L,3L,6L,2L,5L,8L,6L,9L,0L,8L,3L,4L,6L,6L,9L,2L,4L,2L,4L,0L,5L,7L,2L,1L,7L,2L,1L,6L,4L,0L,0L,9L,2L,3L,5L,9L,7L,8L,5L,6L,6L,5L,3L,0L,1L,5L,8L,5L,1L,9L,0L,2L,6L,8L,4L,0L,3L,1L,2L,6L,2L,2L,4L,3L,5L,7L,7L,9L,4L,9L,2L,5L,9L,9L,6L,1L,4L,3L,3L,3L,2L,0L,6L,9L,2L,3L,3L,9L,0L,9L,0L,6L,3L,9L,3L,8L,3L,4L,6L,5L,0L,1L,3L,5L,2L,1L,9L,4L,6L,5L,6L,2L,8L,3L,6L,9L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188940Inst : IEnumerable<long>
{
public static readonly long[] Value=A188940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188940.Bytes);
public long this[int i]=>Value[i];

public static A188940Inst Instance=new A188940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188941
{
public static readonly long[] Value={ 4L,2L,6L,5L,5L,6L,4L,4L,3L,7L,0L,7L,4L,6L,3L,7L,4L,1L,3L,0L,9L,1L,6L,5L,3L,3L,0L,7L,5L,7L,5L,9L,4L,2L,7L,8L,2L,7L,8L,3L,5L,9L,9L,0L,7L,6L,4L,0L,2L,1L,4L,3L,3L,4L,6L,9L,8L,4L,1L,4L,8L,0L,9L,7L,3L,1L,5L,9L,6L,8L,7L,3L,7L,7L,5L,6L,4L,2L,2L,0L,5L,0L,7L,4L,0L,0L,3L,8L,5L,6L,6L,6L,7L,9L,3L,0L,7L,6L,6L,0L,9L,0L,9L,3L,6L,0L,6L,1L,6L,5L,3L,4L,9L,8L,6L,4L,7L,8L,0L,5L,3L,4L,3L,7L,1L,6L,3L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188941Inst : IEnumerable<long>
{
public static readonly long[] Value=A188941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188941.Bytes);
public long this[int i]=>Value[i];

public static A188941Inst Instance=new A188941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188942
{
public static readonly long[] Value={ 5L,6L,5L,7L,4L,1L,4L,5L,4L,0L,8L,9L,3L,3L,5L,1L,1L,7L,8L,1L,3L,4L,6L,3L,1L,2L,2L,0L,8L,8L,2L,5L,0L,6L,7L,5L,6L,2L,4L,7L,8L,3L,9L,0L,4L,3L,5L,9L,1L,2L,5L,6L,3L,1L,2L,1L,4L,9L,2L,4L,4L,9L,0L,6L,2L,8L,8L,0L,5L,5L,0L,8L,6L,1L,7L,8L,3L,1L,5L,9L,2L,4L,6L,5L,8L,9L,6L,8L,1L,9L,6L,6L,3L,5L,8L,4L,8L,8L,0L,3L,8L,7L,7L,4L,7L,6L,3L,6L,3L,2L,9L,3L,2L,2L,7L,4L,3L,2L,7L,0L,6L,6L,1L,5L,5L,3L,6L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188942Inst : IEnumerable<long>
{
public static readonly long[] Value=A188942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188942.Bytes);
public long this[int i]=>Value[i];

public static A188942Inst Instance=new A188942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188943
{
public static readonly long[] Value={ 1L,7L,6L,7L,5L,9L,1L,8L,7L,9L,2L,4L,3L,9L,9L,8L,2L,1L,5L,5L,1L,9L,8L,7L,0L,2L,1L,1L,2L,4L,5L,0L,8L,2L,6L,5L,7L,7L,0L,8L,5L,4L,9L,4L,2L,8L,9L,7L,4L,2L,0L,7L,7L,0L,2L,1L,1L,8L,4L,0L,8L,8L,4L,2L,7L,0L,4L,5L,2L,7L,8L,2L,4L,7L,1L,5L,5L,0L,1L,7L,4L,0L,8L,6L,7L,4L,3L,6L,5L,1L,3L,6L,6L,9L,7L,4L,8L,4L,5L,2L,9L,4L,5L,5L,8L,5L,6L,9L,7L,0L,0L,4L,0L,1L,0L,5L,9L,0L,0L,6L,2L,6L,7L,1L,7L,7L,9L,7L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188943Inst : IEnumerable<long>
{
public static readonly long[] Value=A188943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188943.Bytes);
public long this[int i]=>Value[i];

public static A188943Inst Instance=new A188943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188944
{
public static readonly long[] Value={ 4L,5L,1L,4L,1L,6L,2L,2L,9L,6L,4L,5L,1L,3L,6L,4L,6L,9L,8L,3L,2L,7L,9L,4L,7L,4L,8L,7L,8L,6L,9L,1L,3L,1L,9L,1L,4L,2L,9L,9L,1L,3L,6L,0L,5L,6L,3L,9L,1L,8L,3L,2L,7L,3L,2L,1L,0L,5L,5L,5L,1L,8L,0L,2L,6L,6L,3L,1L,0L,3L,9L,2L,2L,5L,6L,5L,7L,2L,1L,2L,4L,0L,7L,9L,8L,6L,9L,0L,3L,7L,8L,4L,1L,8L,1L,8L,7L,9L,6L,4L,6L,1L,6L,4L,5L,1L,4L,0L,5L,5L,3L,8L,3L,4L,1L,7L,8L,9L,6L,8L,0L,8L,5L,4L,9L,0L,0L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188944Inst : IEnumerable<long>
{
public static readonly long[] Value=A188944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188944.Bytes);
public long this[int i]=>Value[i];

public static A188944Inst Instance=new A188944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188945
{
public static readonly long[] Value={ 2L,2L,1L,5L,2L,5L,0L,4L,3L,7L,0L,2L,1L,5L,3L,0L,1L,9L,6L,8L,3L,3L,8L,7L,1L,9L,1L,7L,8L,7L,9L,7L,5L,3L,4L,7L,5L,2L,3L,6L,7L,5L,3L,0L,6L,1L,0L,2L,7L,4L,8L,3L,3L,9L,3L,4L,5L,6L,1L,1L,1L,4L,8L,6L,4L,0L,0L,3L,5L,6L,2L,7L,4L,4L,1L,0L,0L,9L,4L,5L,4L,2L,5L,8L,6L,7L,9L,7L,6L,2L,8L,8L,2L,4L,8L,4L,7L,8L,7L,0L,2L,0L,5L,0L,2L,1L,5L,2L,6L,1L,1L,2L,8L,3L,2L,4L,8L,7L,6L,9L,8L,5L,8L,1L,1L,7L,6L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188945Inst : IEnumerable<long>
{
public static readonly long[] Value=A188945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188945.Bytes);
public long this[int i]=>Value[i];

public static A188945Inst Instance=new A188945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188946
{
public static readonly BigInteger[] Value={ 1L,7L,103L,1969L,41935L,947737L,22248409L,536310271L,13183283743L,328970388985L,8307368234473L,211822788505951L,5444571611722369L,140892128574440887L,3667015053678269095L,BigInteger.Parse("95918056089104563489"),BigInteger.Parse("2519845343307697266943") };
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
public class A188946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188946Inst Instance=new A188946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188947
{
public static readonly long[] Value={ 2L,5L,16L,41L,86L,157L,260L,401L,586L,821L,1112L,1465L,1886L,2381L,2956L,3617L,4370L,5221L,6176L,7241L,8422L,9725L,11156L,12721L,14426L,16277L,18280L,20441L,22766L,25261L,27932L,30785L,33826L,37061L,40496L,44137L,47990L,52061L,56356L,60881L,65642L,70645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188947Inst : IEnumerable<long>
{
public static readonly long[] Value=A188947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188947.Bytes);
public long this[int i]=>Value[i];

public static A188947Inst Instance=new A188947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188948
{
public static readonly long[] Value={ 0L,2L,5L,9L,119L,122L,828L,4449L,239L,56403L,145668L,246046L,3369960L,3627003L,23161315L,128629846L,13651680L,1590277918L,4241902555L,6712571031L,95420159401L,107655263398L,647549275812L,3718150825791L,584824319281L,44827014819597L,123471611274972L,182714776311554L,2701419604443960L,3190610873034597L,18094618450123325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188948Inst : IEnumerable<long>
{
public static readonly long[] Value=A188948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188948.Bytes);
public long this[int i]=>Value[i];

public static A188948Inst Instance=new A188948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188949
{
public static readonly long[] Value={ 1L,3L,12L,46L,120L,597L,2035L,6554L,28560L,86158L,341525L,1315911L,3455641L,17021162L,58317492L,186118929L,815616479L,2474152797L,9719139348L,37641223154L,99498527400L,485257533003L,1671083125805L,5284814079046L,23290743888720L,71041880304722L,276564805068235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188949Inst : IEnumerable<long>
{
public static readonly long[] Value=A188949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188949.Bytes);
public long this[int i]=>Value[i];

public static A188949Inst Instance=new A188949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188950
{
public static readonly long[] Value={ 3L,11L,4L,10L,6L,11L,5L,14L,3L,18L,4L,20L,6L,18L,7L,22L,11L,18L,10L,20L,6L,27L,5L,29L,8L,26L,11L,27L,9L,30L,3L,38L,14L,29L,6L,38L,10L,34L,18L,27L,11L,38L,7L,47L,12L,42L,20L,34L,5L,50L,4L,52L,18L,38L,6L,51L,13L,46L,11L,51L,8L,56L,14L,50L,27L,38L,15L,54L,22L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188950Inst : IEnumerable<long>
{
public static readonly long[] Value=A188950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188950.Bytes);
public long this[int i]=>Value[i];

public static A188950Inst Instance=new A188950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188951
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,10L,15L,22L,30L,41L,57L,81L,113L,155L,216L,298L,416L,582L,813L,1135L,1588L,2223L,3115L,4368L,6135L,8622L,12127L,17063L,24022L,33838L,47688L,67226L,94804L,133737L,188709L,266350L,376018L,530940L,749819L,1059096L,1496143L,2113801L,2986769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188951Inst : IEnumerable<long>
{
public static readonly long[] Value=A188951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188951.Bytes);
public long this[int i]=>Value[i];

public static A188951Inst Instance=new A188951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188952
{
public static readonly long[] Value={ 1L,24L,29172L,504690017L,229188213745576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188952Inst : IEnumerable<long>
{
public static readonly long[] Value=A188952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188952.Bytes);
public long this[int i]=>Value[i];

public static A188952Inst Instance=new A188952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188953
{
public static readonly long[] Value={ 2L,24L,362L,3969L,45288L,532224L,6187928L,71851073L,835579642L,9715691800L,112952196626L,1313218423169L,15268015911568L,177510903321088L,2063800528041456L,23994446285179649L,278967524405993266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188953Inst : IEnumerable<long>
{
public static readonly long[] Value=A188953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188953.Bytes);
public long this[int i]=>Value[i];

public static A188953Inst Instance=new A188953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188954
{
public static readonly BigInteger[] Value={ 6L,362L,29172L,1722256L,104735558L,6513224285L,402549615544L,24857280209008L,1535940257170788L,94903086891894000L,5863618342142622360L,BigInteger.Parse("362289547465186312038"),BigInteger.Parse("22384463811480689586560"),BigInteger.Parse("1383047351386729941046442") };
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
public class A188954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188954Inst Instance=new A188954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188955
{
public static readonly BigInteger[] Value={ 14L,3969L,1722256L,504690017L,151700751624L,47085945014364L,14529766291673016L,4473345039125385924L,BigInteger.Parse("1378237965469881319638"),BigInteger.Parse("424709806495811992908136"),BigInteger.Parse("130865875276447905156349870"),BigInteger.Parse("40323080903656724639859869876") };
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
public class A188955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188955Inst Instance=new A188955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189020
{
public static readonly long[] Value={ 1L,89L,3575L,93237L,1951526L,35270969L,578262093L,8840109380L,128217432396L,1784942188189L,24045237260214L,315312623543840L,4042957241191810L,50862246063060180L,629513636928477232L,7681900592647818929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189020Inst : IEnumerable<long>
{
public static readonly long[] Value=A189020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189020.Bytes);
public long this[int i]=>Value[i];

public static A189020Inst Instance=new A189020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189021
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,1L,1L,0L,-1L,1L,1L,-1L,1L,1L,1L,0L,1L,-1L,1L,-1L,1L,1L,1L,0L,-1L,1L,0L,-1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,-1L,-1L,1L,1L,0L,-1L,-1L,1L,-1L,1L,0L,1L,0L,1L,1L,1L,-1L,1L,1L,-1L,0L,1L,1L,1L,-1L,1L,1L,1L,0L,1L,1L,-1L,-1L,1L,1L,1L,0L,0L,1L,1L,-1L,1L,1L,1L,0L,1L,-1L,1L,-1L,1L,1L,1L,0L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189021Inst : IEnumerable<long>
{
public static readonly long[] Value=A189021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189021.Bytes);
public long this[int i]=>Value[i];

public static A189021Inst Instance=new A189021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189022
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189022Inst : IEnumerable<long>
{
public static readonly long[] Value=A189022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189022.Bytes);
public long this[int i]=>Value[i];

public static A189022Inst Instance=new A189022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189023
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189023Inst : IEnumerable<long>
{
public static readonly long[] Value=A189023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189023.Bytes);
public long this[int i]=>Value[i];

public static A189023Inst Instance=new A189023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189024
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,1L,2L,2L,3L,3L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,3L,3L,3L,4L,3L,4L,4L,4L,3L,4L,3L,3L,3L,3L,2L,2L,1L,1L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189024Inst : IEnumerable<long>
{
public static readonly long[] Value=A189024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189024.Bytes);
public long this[int i]=>Value[i];

public static A189024Inst Instance=new A189024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189025
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,2L,2L,3L,2L,3L,3L,2L,2L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,2L,2L,3L,3L,3L,3L,4L,3L,4L,4L,3L,3L,4L,4L,4L,4L,4L,3L,4L,4L,4L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,4L,4L,4L,3L,4L,4L,5L,5L,5L,5L,4L,4L,4L,4L,4L,4L,5L,5L,5L,4L,4L,4L,5L,4L,4L,4L,3L,3L,3L,3L,4L,4L,3L,3L,4L,4L,5L,4L,4L,4L,5L,5L,6L,5L,5L,5L,6L,6L,6L,6L,6L,6L,5L,5L,5L,5L,5L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189025Inst : IEnumerable<long>
{
public static readonly long[] Value=A189025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189025.Bytes);
public long this[int i]=>Value[i];

public static A189025Inst Instance=new A189025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189026
{
public static readonly long[] Value={ 127L,1367L,2531L,2539L,6007L,7457L,10061L,10847L,23531L,35797L,35801L,38557L,44497L,47111L,69767L,69809L,88321L,107687L,110419L,110431L,113723L,127217L,250673L,250681L,250687L,250703L,268487L,268493L,286381L,286393L,302563L,302567L,360947L,369821L,405199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189026Inst : IEnumerable<long>
{
public static readonly long[] Value=A189026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189026.Bytes);
public long this[int i]=>Value[i];

public static A189026Inst Instance=new A189026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189027
{
public static readonly long[] Value={ 2L,3L,37L,139L,331L,1409L,1423L,1427L,2239L,3163L,3181L,3511L,6547L,7433L,7457L,7487L,10061L,11777L,11779L,14401L,18899L,19081L,19373L,23537L,24763L,27617L,27673L,32027L,32051L,38113L,43573L,43579L,47269L,47279L,50839L,61463L,88643L,88651L,88657L,88729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189027Inst : IEnumerable<long>
{
public static readonly long[] Value=A189027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189027.Bytes);
public long this[int i]=>Value[i];

public static A189027Inst Instance=new A189027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189028
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189028Inst : IEnumerable<long>
{
public static readonly long[] Value=A189028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189028.Bytes);
public long this[int i]=>Value[i];

public static A189028Inst Instance=new A189028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189029
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,11L,13L,15L,18L,20L,21L,22L,24L,29L,32L,33L,34L,35L,36L,38L,39L,41L,47L,50L,51L,53L,54L,55L,57L,58L,60L,61L,62L,65L,70L,71L,74L,79L,80L,83L,84L,85L,86L,87L,90L,92L,94L,95L,96L,97L,98L,101L,102L,103L,106L,110L,112L,114L,116L,117L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189029Inst : IEnumerable<long>
{
public static readonly long[] Value=A189029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189029.Bytes);
public long this[int i]=>Value[i];

public static A189029Inst Instance=new A189029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189030
{
public static readonly long[] Value={ 2L,4L,6L,7L,10L,12L,14L,16L,17L,19L,23L,25L,26L,27L,28L,30L,31L,37L,40L,42L,43L,44L,45L,46L,48L,49L,52L,56L,59L,63L,64L,66L,67L,68L,69L,72L,73L,75L,76L,77L,78L,81L,82L,88L,89L,91L,93L,99L,100L,104L,105L,107L,108L,109L,111L,113L,115L,118L,119L,120L,121L,122L,123L,126L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189030Inst : IEnumerable<long>
{
public static readonly long[] Value=A189030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189030.Bytes);
public long this[int i]=>Value[i];

public static A189030Inst Instance=new A189030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189031
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189031Inst : IEnumerable<long>
{
public static readonly long[] Value=A189031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189031.Bytes);
public long this[int i]=>Value[i];

public static A189031Inst Instance=new A189031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189032
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,12L,13L,14L,18L,20L,21L,23L,25L,27L,29L,32L,34L,36L,38L,40L,42L,43L,45L,47L,49L,50L,53L,56L,58L,62L,63L,65L,66L,67L,69L,71L,72L,73L,74L,77L,79L,82L,84L,90L,92L,94L,96L,98L,100L,102L,103L,104L,105L,106L,107L,110L,112L,114L,115L,117L,119L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189032Inst : IEnumerable<long>
{
public static readonly long[] Value=A189032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189032.Bytes);
public long this[int i]=>Value[i];

public static A189032Inst Instance=new A189032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189033
{
public static readonly long[] Value={ 2L,4L,6L,7L,10L,11L,15L,16L,17L,19L,22L,24L,26L,28L,30L,31L,33L,35L,37L,39L,41L,44L,46L,48L,51L,52L,54L,55L,57L,59L,60L,61L,64L,68L,70L,75L,76L,78L,80L,81L,83L,85L,86L,87L,88L,89L,91L,93L,95L,97L,99L,101L,108L,109L,111L,113L,116L,118L,120L,123L,124L,125L,126L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189033Inst : IEnumerable<long>
{
public static readonly long[] Value=A189033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189033.Bytes);
public long this[int i]=>Value[i];

public static A189033Inst Instance=new A189033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189034
{
public static readonly long[] Value={ 1L,5L,7L,8L,10L,11L,12L,15L,16L,17L,19L,23L,24L,25L,27L,30L,34L,36L,37L,38L,40L,43L,47L,48L,52L,54L,55L,57L,58L,59L,61L,64L,68L,69L,73L,75L,76L,77L,81L,83L,84L,86L,87L,88L,91L,92L,93L,95L,98L,102L,103L,107L,109L,110L,111L,115L,117L,118L,120L,121L,122L,124L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189034Inst : IEnumerable<long>
{
public static readonly long[] Value=A189034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189034.Bytes);
public long this[int i]=>Value[i];

public static A189034Inst Instance=new A189034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189035
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,13L,14L,18L,20L,21L,22L,26L,28L,29L,31L,32L,33L,35L,39L,41L,42L,44L,45L,46L,49L,50L,51L,53L,56L,60L,62L,63L,65L,66L,67L,70L,71L,72L,74L,78L,79L,80L,82L,85L,89L,90L,94L,96L,97L,99L,100L,101L,104L,105L,106L,108L,112L,113L,114L,116L,119L,123L,125L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189035Inst : IEnumerable<long>
{
public static readonly long[] Value=A189035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189035.Bytes);
public long this[int i]=>Value[i];

public static A189035Inst Instance=new A189035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189116
{
public static readonly BigInteger[] Value={ 256L,65536L,3400336L,133079296L,6517280000L,332070977536L,17473826493152L,924914073760000L,49276690205414880L,2624759937460543744L,BigInteger.Parse("139853913235736220352"),BigInteger.Parse("7451253901687535139600"),BigInteger.Parse("397104423727338960018560") };
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
public class A189116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189116Inst Instance=new A189116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189117
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,0L,2L,1L,3L,1L,2L,1L,3L,0L,2L,1L,5L,2L,3L,1L,1L,0L,1L,2L,1L,2L,1L,3L,0L,1L,0L,1L,1L,0L,2L,1L,1L,1L,3L,1L,1L,0L,1L,0L,1L,0L,3L,1L,2L,0L,1L,0L,2L,0L,2L,1L,1L,0L,1L,2L,1L,0L,1L,0L,3L,0L,2L,2L,1L,0L,2L,0L,2L,1L,1L,1L,1L,0L,3L,1L,1L,0L,1L,0L,1L,0L,1L,0L,3L,0L,0L,1L,1L,1L,2L,0L,2L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189117Inst : IEnumerable<long>
{
public static readonly long[] Value=A189117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189117.Bytes);
public long this[int i]=>Value[i];

public static A189117Inst Instance=new A189117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189118
{
public static readonly long[] Value={ 9L,25L,91L,119L,201L,295L,527L,891L,1133L,1341L,1671L,2479L,2973L,4299L,5593L,8469L,9553L,15691L,16145L,19621L,25481L,28233L,31423L,31909L,34073L,35619L,43337L,44295L,89695L,107381L,134519L,155943L,173363L,175143L,188037L,212705L,265629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189118Inst : IEnumerable<long>
{
public static readonly long[] Value=A189118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189118.Bytes);
public long this[int i]=>Value[i];

public static A189118Inst Instance=new A189118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189119
{
public static readonly long[] Value={ 621L,867L,891L,897L,1023L,1239L,1413L,1587L,1881L,2091L,2115L,2145L,2169L,2403L,2451L,2505L,2601L,2769L,2871L,2889L,3003L,3129L,3171L,3231L,3237L,3243L,3399L,3417L,3423L,3435L,3441L,3471L,3477L,3501L,3807L,3813L,3933L,3993L,4029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189119Inst : IEnumerable<long>
{
public static readonly long[] Value=A189119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189119.Bytes);
public long this[int i]=>Value[i];

public static A189119Inst Instance=new A189119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189120
{
public static readonly long[] Value={ 1L,1L,1L,17L,1L,37L,1L,81L,82L,101L,1L,197L,1L,197L,226L,337L,1L,442L,1L,517L,442L,485L,1L,837L,626L,677L,811L,997L,1L,1262L,1L,1361L,1090L,1157L,1226L,1898L,1L,1445L,1522L,2181L,1L,2438L,1L,2437L,2332L,2117L,1L,3397L,2402L,3226L,2602L,3397L,1L,4087L,3026L,4197L,3250L,3365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189120Inst : IEnumerable<long>
{
public static readonly long[] Value=A189120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189120.Bytes);
public long this[int i]=>Value[i];

public static A189120Inst Instance=new A189120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189121
{
public static readonly long[] Value={ 822L,14560L,12170L,14280L,64288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189121Inst : IEnumerable<long>
{
public static readonly long[] Value=A189121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189121.Bytes);
public long this[int i]=>Value[i];

public static A189121Inst Instance=new A189121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189122
{
public static readonly BigInteger[] Value={ 1L,5L,45L,526L,7585L,130371L,2602285L,59142588L,1507308129L,42563286145L,1318792866941L,44477806954890L,1621859437812289L,63576780042697663L,2665971232476845805L,BigInteger.Parse("119073945060707737336"),BigInteger.Parse("5643402849491554535745") };
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
public class A189122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189122Inst Instance=new A189122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189123
{
public static readonly long[] Value={ 21080618L,63241604L,67139098L,116385658L,117448688L,126483083L,152523860L,189724562L,212400458L,229762259L,318689258L,348330652L,353942783L,366873514L,373603732L,379448999L,385159320L,404764540L,409108300L,460759642L,465722100L,477258719L,498197068L,511069678L,516743639L,519835084L,538858312L,545438698L,545790940L,546853138L,574842670L,575550972L,581106238L,590785918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189123Inst : IEnumerable<long>
{
public static readonly long[] Value=A189123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189123.Bytes);
public long this[int i]=>Value[i];

public static A189123Inst Instance=new A189123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189124
{
public static readonly long[] Value={ 353942783L,516743639L,1163385647L,1542243239L,1932319583L,2336924879L,3113713259L,3444631199L,3878989487L,4103787551L,4166809919L,4937621453L,5123340683L,5170931639L,5184740299L,5200683263L,5390865059L,5455982879L,5467766947L,5570566315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189124Inst : IEnumerable<long>
{
public static readonly long[] Value=A189124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189124.Bytes);
public long this[int i]=>Value[i];

public static A189124Inst Instance=new A189124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189125
{
public static readonly long[] Value={ 353942783L,1163385647L,1932319583L,2336924879L,4166809919L,4937621453L,5123340683L,5184740299L,5390865059L,5455982879L,5467766947L,6432033887L,6459553799L,6545574839L,6714582263L,6988649399L,7378517519L,7515851039L,7657182539L,7756383347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189125Inst : IEnumerable<long>
{
public static readonly long[] Value=A189125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189125.Bytes);
public long this[int i]=>Value[i];

public static A189125Inst Instance=new A189125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189126
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189126Inst : IEnumerable<long>
{
public static readonly long[] Value=A189126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189126.Bytes);
public long this[int i]=>Value[i];

public static A189126Inst Instance=new A189126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189127
{
public static readonly long[] Value={ 3L,5L,8L,9L,10L,15L,16L,17L,18L,19L,27L,28L,29L,30L,31L,32L,33L,34L,35L,38L,48L,49L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,66L,67L,68L,70L,72L,74L,85L,87L,92L,95L,97L,100L,101L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,114L,115L,117L,118L,119L,120L,121L,122L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189127Inst : IEnumerable<long>
{
public static readonly long[] Value=A189127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189127.Bytes);
public long this[int i]=>Value[i];

public static A189127Inst Instance=new A189127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189128
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,11L,12L,13L,14L,20L,21L,22L,23L,24L,25L,26L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,54L,64L,65L,69L,71L,73L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,86L,88L,89L,90L,91L,93L,94L,96L,98L,99L,102L,113L,116L,123L,127L,129L,133L,135L,137L,139L,140L,141L,142L,143L,144L,145L,146L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189128Inst : IEnumerable<long>
{
public static readonly long[] Value=A189128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189128.Bytes);
public long this[int i]=>Value[i];

public static A189128Inst Instance=new A189128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189129
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189129Inst : IEnumerable<long>
{
public static readonly long[] Value=A189129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189129.Bytes);
public long this[int i]=>Value[i];

public static A189129Inst Instance=new A189129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189130
{
public static readonly long[] Value={ 3L,5L,8L,9L,12L,13L,14L,19L,20L,21L,22L,23L,30L,31L,33L,34L,35L,36L,37L,40L,42L,48L,49L,51L,54L,55L,56L,57L,58L,59L,62L,63L,65L,66L,67L,75L,76L,80L,85L,86L,88L,89L,90L,91L,92L,93L,96L,97L,98L,99L,101L,102L,103L,104L,105L,107L,109L,112L,118L,119L,125L,133L,135L,138L,139L,141L,143L,144L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189130Inst : IEnumerable<long>
{
public static readonly long[] Value=A189130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189130.Bytes);
public long this[int i]=>Value[i];

public static A189130Inst Instance=new A189130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189131
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,10L,11L,15L,16L,17L,18L,24L,25L,26L,27L,28L,29L,32L,38L,39L,41L,43L,44L,45L,46L,47L,50L,52L,53L,60L,61L,64L,68L,69L,70L,71L,72L,73L,74L,77L,78L,79L,81L,82L,83L,84L,87L,94L,95L,100L,106L,108L,110L,111L,113L,114L,115L,116L,117L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189131Inst : IEnumerable<long>
{
public static readonly long[] Value=A189131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189131.Bytes);
public long this[int i]=>Value[i];

public static A189131Inst Instance=new A189131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189180
{
public static readonly long[] Value={ 0L,33L,192L,4081L,47936L,733465L,9925824L,142150545L,1982789568L,27997733409L,393091648000L,5533702536417L,77804055183232L,1094555504869945L,15394211168981632L,216536449010819041L,3045646510935265408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189180Inst : IEnumerable<long>
{
public static readonly long[] Value=A189180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189180.Bytes);
public long this[int i]=>Value[i];

public static A189180Inst Instance=new A189180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189181
{
public static readonly BigInteger[] Value={ 1L,185L,4081L,251720L,10599449L,524539713L,24377674329L,1162453545201L,54868164490816L,2600517767888745L,123049732810644217L,5826272557390770993L,BigInteger.Parse("275793998574143720745"),BigInteger.Parse("13056461887253840005544"),BigInteger.Parse("618083925262185774246993") };
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
public class A189181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189181Inst Instance=new A189181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189182
{
public static readonly BigInteger[] Value={ 0L,913L,47936L,10599449L,1339732352L,212852911361L,30863909708032L,4646631858824169L,689003645197185280L,BigInteger.Parse("102804050401764094481"),BigInteger.Parse("15300259132449601539840"),BigInteger.Parse("2279486758722355781575289") };
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
public class A189182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189182Inst Instance=new A189182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189183
{
public static readonly BigInteger[] Value={ 1L,4777L,733465L,524539713L,212852911361L,108943637068673L,51019657551661825L,BigInteger.Parse("24772194881412281568"),BigInteger.Parse("11859612477133400173321"),BigInteger.Parse("5710233425140480749753825"),BigInteger.Parse("2743236264948075503280904473"),BigInteger.Parse("1319063462694864224288387507313") };
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
public class A189183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189183Inst Instance=new A189183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189184
{
public static readonly BigInteger[] Value={ 0L,24577L,9925824L,24377674329L,30863909708032L,51019657551661825L,BigInteger.Parse("76260881288534294528"),BigInteger.Parse("118756821701162151227761"),BigInteger.Parse("182058599536052537764772096"),BigInteger.Parse("280897765265782382194137678153") };
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
public class A189184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189184Inst Instance=new A189184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189185
{
public static readonly BigInteger[] Value={ 1L,127385L,142150545L,1162453545201L,4646631858824169L,BigInteger.Parse("24772194881412281568"),BigInteger.Parse("118756821701162151227761"),BigInteger.Parse("594579828469677562655346609"),BigInteger.Parse("2929346624538378869533780899145"),BigInteger.Parse("14529411775016363663957822341921161") };
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
public class A189185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189185Inst Instance=new A189185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189186
{
public static readonly long[] Value={ 0L,1L,1L,0L,9L,0L,1L,33L,33L,1L,0L,185L,192L,185L,0L,1L,913L,4081L,4081L,913L,1L,0L,4777L,47936L,251720L,47936L,4777L,0L,1L,24577L,733465L,10599449L,10599449L,733465L,24577L,1L,0L,127385L,9925824L,524539713L,1339732352L,524539713L,9925824L,127385L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189186Inst : IEnumerable<long>
{
public static readonly long[] Value=A189186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189186.Bytes);
public long this[int i]=>Value[i];

public static A189186Inst Instance=new A189186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189187
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,4L,7L,5L,1L,7L,17L,16L,7L,1L,13L,38L,46L,29L,9L,1L,24L,82L,12L,99L,46L,11L,1L,44L,174L,304L,303L,184L,67L,13L,1L,81L,362L,728L,857L,64L,309L,92L,15L,1L,149L,743L,1690L,2291L,2031L,1212L,482L,121L,17L,1L,274L,1509L,3827L,5869L,6004L,4260L,2108L,711L,154L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189187Inst : IEnumerable<long>
{
public static readonly long[] Value=A189187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189187.Bytes);
public long this[int i]=>Value[i];

public static A189187Inst Instance=new A189187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189188
{
public static readonly long[] Value={ 2016L,2244L,2336L,2570L,2762L,4106L,4362L,4464L,4566L,4670L,4776L,4934L,5952L,6870L,7036L,7146L,7588L,7644L,7700L,8824L,9756L,9930L,9988L,10394L,10454L,10514L,10690L,10868L,10928L,11560L,12620L,12682L,14986L,15424L,15808L,16000L,16510L,18668L,20434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189188Inst : IEnumerable<long>
{
public static readonly long[] Value=A189188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189188.Bytes);
public long this[int i]=>Value[i];

public static A189188Inst Instance=new A189188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189189
{
public static readonly BigInteger[] Value={ 2L,16L,316L,15326L,1579664L,367115337L,184841938568L,209311662962608L,525679279319545840L,BigInteger.Parse("2979655033608039508606"),BigInteger.Parse("37875187935027408625277140"),BigInteger.Parse("1087648851912447148168100296827"),BigInteger.Parse("70353152136567154798416885107484140") };
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
public class A189189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189189Inst Instance=new A189189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189190
{
public static readonly long[] Value={ 8L,64L,316L,1494L,6446L,27170L,111778L,455376L,1841116L,7415070L,29785050L,119460218L,478648930L,1916674924L,7672027140L,30701884934L,122843150982L,491465083490L,1966100647058L,7865028551176L,31461745847388L,125851241881374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189190Inst : IEnumerable<long>
{
public static readonly long[] Value=A189190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189190.Bytes);
public long this[int i]=>Value[i];

public static A189190Inst Instance=new A189190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189191
{
public static readonly long[] Value={ 16L,256L,2032L,15326L,101628L,657028L,4109278L,25421672L,155713446L,949556490L,5771152218L,35012940148L,212158079476L,1284620610228L,7774639010740L,47038657576938L,284540271729956L,1720987141305056L,10408196505797294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189191Inst : IEnumerable<long>
{
public static readonly long[] Value=A189191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189191.Bytes);
public long this[int i]=>Value[i];

public static A189191Inst Instance=new A189191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189192
{
public static readonly long[] Value={ 32L,1024L,13045L,156564L,1579664L,15564047L,146936454L,1372985912L,12673978495L,116484051544L,1066397329392L,9744883834389L,88925544182556L,810852982213004L,7389628274064849L,67322696225968620L,613203444821642088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189192Inst : IEnumerable<long>
{
public static readonly long[] Value=A189192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189192.Bytes);
public long this[int i]=>Value[i];

public static A189192Inst Instance=new A189192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189193
{
public static readonly long[] Value={ 64L,4096L,83737L,1598444L,24496092L,367115337L,5218915180L,73539558380L,1021199649839L,14125557202206L,194506779840320L,2673686180231803L,36695207349332618L,503243079829310096L,6897499795974119793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189193Inst : IEnumerable<long>
{
public static readonly long[] Value=A189193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189193.Bytes);
public long this[int i]=>Value[i];

public static A189193Inst Instance=new A189193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189194
{
public static readonly BigInteger[] Value={ 128L,16384L,537496L,16316636L,379515360L,8646366042L,184841938568L,3925306136096L,81929775932500L,1704770564043390L,35287851485832028L,729339086587874460L,15048014087794649376UL,BigInteger.Parse("310256937493956570170") };
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
public class A189194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189194Inst Instance=new A189194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189195
{
public static readonly BigInteger[] Value={ 256L,65536L,3450100L,166552852L,5878642448L,203562575017L,6541724250668L,209311662962608L,6564303642825447L,205436602739842458L,6391004867571530548L,BigInteger.Parse("198584429070400680915"),BigInteger.Parse("6158498206342385810146"),BigInteger.Parse("190869078020765592228428") };
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
public class A189195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189195Inst Instance=new A189195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189324
{
public static readonly long[] Value={ 11L,17L,31L,51L,91L,157L,253L,374L,509L,649L,789L,929L,1069L,1209L,1349L,1489L,1629L,1769L,1909L,2049L,2189L,2329L,2469L,2609L,2749L,2889L,3029L,3169L,3309L,3449L,3589L,3729L,3869L,4009L,4149L,4289L,4429L,4569L,4709L,4849L,4989L,5129L,5269L,5409L,5549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189324Inst : IEnumerable<long>
{
public static readonly long[] Value=A189324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189324.Bytes);
public long this[int i]=>Value[i];

public static A189324Inst Instance=new A189324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189325
{
public static readonly long[] Value={ 13L,24L,49L,95L,179L,321L,548L,866L,1267L,1733L,2248L,2806L,3408L,4056L,4752L,5498L,6296L,7148L,8056L,9022L,10048L,11136L,12288L,13506L,14792L,16148L,17576L,19078L,20656L,22312L,24048L,25866L,27768L,29756L,31832L,33998L,36256L,38608L,41056L,43602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189325Inst : IEnumerable<long>
{
public static readonly long[] Value=A189325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189325.Bytes);
public long this[int i]=>Value[i];

public static A189325Inst Instance=new A189325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189326
{
public static readonly long[] Value={ 2L,4L,2L,5L,6L,2L,7L,7L,8L,2L,8L,12L,11L,10L,2L,10L,12L,20L,16L,12L,2L,11L,18L,21L,32L,22L,14L,2L,13L,17L,36L,33L,49L,28L,16L,2L,14L,24L,31L,64L,54L,70L,34L,18L,2L,16L,22L,49L,51L,110L,84L,94L,40L,20L,2L,17L,30L,42L,95L,91L,179L,119L,120L,46L,22L,2L,19L,27L,63L,76L,179L,157L,275L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189326Inst : IEnumerable<long>
{
public static readonly long[] Value=A189326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189326.Bytes);
public long this[int i]=>Value[i];

public static A189326Inst Instance=new A189326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189327
{
public static readonly long[] Value={ 2L,6L,7L,12L,12L,18L,17L,24L,22L,30L,27L,36L,32L,42L,37L,48L,42L,54L,47L,60L,52L,66L,57L,72L,62L,78L,67L,84L,72L,90L,77L,96L,82L,102L,87L,108L,92L,114L,97L,120L,102L,126L,107L,132L,112L,138L,117L,144L,122L,150L,127L,156L,132L,162L,137L,168L,142L,174L,147L,180L,152L,186L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189327Inst : IEnumerable<long>
{
public static readonly long[] Value=A189327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189327.Bytes);
public long this[int i]=>Value[i];

public static A189327Inst Instance=new A189327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189328
{
public static readonly long[] Value={ 2L,8L,11L,20L,21L,36L,31L,49L,42L,63L,51L,79L,60L,93L,72L,105L,80L,125L,89L,133L,104L,149L,109L,168L,117L,178L,135L,190L,138L,213L,147L,219L,166L,234L,166L,257L,176L,263L,197L,274L,196L,303L,205L,304L,227L,319L,225L,346L,234L,347L,259L,360L,254L,392L,262L,389L,290L,404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189328Inst : IEnumerable<long>
{
public static readonly long[] Value=A189328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189328.Bytes);
public long this[int i]=>Value[i];

public static A189328Inst Instance=new A189328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189329
{
public static readonly long[] Value={ 2L,10L,16L,32L,33L,64L,51L,95L,76L,122L,91L,166L,102L,185L,141L,214L,137L,272L,155L,277L,201L,304L,191L,380L,199L,366L,272L,396L,237L,480L,253L,462L,335L,483L,286L,593L,299L,545L,403L,584L,335L,684L,353L,648L,465L,660L,388L,808L,395L,726L,531L,767L,435L,896L,456L,826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189329Inst : IEnumerable<long>
{
public static readonly long[] Value=A189329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189329.Bytes);
public long this[int i]=>Value[i];

public static A189329Inst Instance=new A189329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189330
{
public static readonly long[] Value={ 2L,12L,22L,49L,54L,110L,91L,179L,154L,238L,190L,360L,215L,376L,333L,453L,290L,604L,334L,607L,478L,634L,411L,904L,428L,771L,658L,882L,504L,1132L,537L,1023L,832L,1023L,627L,1453L,625L,1158L,1007L,1336L,710L,1614L,753L,1459L,1191L,1398L,825L,2016L,831L,1574L,1337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189330Inst : IEnumerable<long>
{
public static readonly long[] Value=A189330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189330.Bytes);
public long this[int i]=>Value[i];

public static A189330Inst Instance=new A189330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189331
{
public static readonly long[] Value={ 2L,14L,28L,70L,84L,179L,157L,321L,283L,461L,390L,720L,482L,784L,747L,988L,684L,1299L,796L,1371L,1121L,1395L,973L,2066L,1061L,1707L,1531L,2058L,1207L,2624L,1282L,2386L,1968L,2303L,1599L,3439L,1482L,2615L,2372L,3304L,1705L,3744L,1798L,3430L,2993L,3157L,1975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189331Inst : IEnumerable<long>
{
public static readonly long[] Value=A189331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189331.Bytes);
public long this[int i]=>Value[i];

public static A189331Inst Instance=new A189331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189332
{
public static readonly long[] Value={ 2L,16L,34L,94L,119L,275L,253L,548L,477L,845L,725L,1375L,951L,1608L,1522L,2126L,1511L,2758L,1809L,3130L,2557L,3125L,2312L,4710L,2551L,3930L,3502L,4942L,2922L,6053L,3105L,5798L,4483L,5381L,4049L,8173L,3634L,6207L,5339L,8368L,4204L,8795L,4353L,8395L,7148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189332Inst : IEnumerable<long>
{
public static readonly long[] Value=A189332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189332.Bytes);
public long this[int i]=>Value[i];

public static A189332Inst Instance=new A189332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189333
{
public static readonly long[] Value={ 2L,18L,40L,120L,157L,393L,374L,866L,775L,1426L,1261L,2448L,1761L,3006L,2890L,4232L,3063L,5605L,3802L,6615L,5533L,6899L,5188L,10472L,5864L,8986L,7964L,11411L,7088L,13830L,7645L,13841L,10360L,12801L,9755L,19139L,9300L,15031L,12334L,20347L,10558L,20918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189333Inst : IEnumerable<long>
{
public static readonly long[] Value=A189333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189333.Bytes);
public long this[int i]=>Value[i];

public static A189333Inst Instance=new A189333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189334
{
public static readonly long[] Value={ 1L,4L,36L,340L,3220L,30500L,288900L,2736500L,25920500L,245522500L,2325622500L,22028612500L,208658012500L,1976437062500L,18721080562500L,177328620312500L,1679680800312500L,15910164901562500L,150703245014062500L,1427481625632812500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189334Inst : IEnumerable<long>
{
public static readonly long[] Value=A189334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189334.Bytes);
public long this[int i]=>Value[i];

public static A189334Inst Instance=new A189334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189335
{
public static readonly long[] Value={ 2L,16L,512L,36626L,6814820L,2650369322L,2739456017053L,6190300153637745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189335Inst : IEnumerable<long>
{
public static readonly long[] Value=A189335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189335.Bytes);
public long this[int i]=>Value[i];

public static A189335Inst Instance=new A189335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189336
{
public static readonly long[] Value={ 4L,16L,64L,225L,784L,2704L,9409L,32761L,114244L,398161L,1387684L,4835601L,16851025L,58721569L,204633025L,713103616L,2485022500L,8659791364L,30177596089L,105162706944L,366470415424L,1277074025929L,4450340433889L,15508521343396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189336Inst : IEnumerable<long>
{
public static readonly long[] Value=A189336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189336.Bytes);
public long this[int i]=>Value[i];

public static A189336Inst Instance=new A189336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189337
{
public static readonly long[] Value={ 8L,64L,512L,3375L,21952L,140608L,912673L,5929741L,38614472L,251239591L,1634691752L,10633486599L,69173457625L,449983383247L,2927275422625L,19042718961664L,123878371625000L,805862864751112L,5242361459792813L,34103003909455872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189337Inst : IEnumerable<long>
{
public static readonly long[] Value=A189337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189337.Bytes);
public long this[int i]=>Value[i];

public static A189337Inst Instance=new A189337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189338
{
public static readonly long[] Value={ 15L,225L,3375L,36626L,390721L,3988168L,42069350L,442969881L,4709354541L,49857094654L,528436125424L,5591212296038L,59196669906872L,626540356943069L,6633322246811551L,70220475509151710L,743409267344795743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189338Inst : IEnumerable<long>
{
public static readonly long[] Value=A189338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189338.Bytes);
public long this[int i]=>Value[i];

public static A189338Inst Instance=new A189338Inst();

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