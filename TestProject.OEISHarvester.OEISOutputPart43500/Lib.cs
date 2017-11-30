using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A051045
{
public static readonly long[] Value={ 1L,2L,8L,44L,298L,2350L,22774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051045Inst : IEnumerable<long>
{
public static readonly long[] Value=A051045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051045.Bytes);
public long this[int i]=>Value[i];

public static A051045Inst Instance=new A051045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051046
{
public static readonly long[] Value={ 1L,109L,113L,114L,199L,200L,201L,241L,242L,271L,277L,281L,282L,283L,284L,285L,286L,287L,288L,289L,293L,294L,295L,313L,317L,318L,319L,443L,444L,445L,449L,450L,451L,457L,458L,461L,462L,463L,464L,465L,466L,467L,468L,469L,470L,471L,472L,473L,474L,475L,476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051046Inst : IEnumerable<long>
{
public static readonly long[] Value=A051046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051046.Bytes);
public long this[int i]=>Value[i];

public static A051046Inst Instance=new A051046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051047
{
public static readonly BigInteger[] Value={ 1L,3L,8L,120L,1680L,23408L,326040L,4541160L,63250208L,880961760L,12270214440L,170902040408L,2380358351280L,33154114877520L,461777249934008L,6431727384198600L,89582406128846400L,1247721958419651008L,17378525011746267720UL,BigInteger.Parse("242051628206028097080") };
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
public class A051047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051047Inst Instance=new A051047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051048
{
public static readonly long[] Value={ 2L,5L,31L,449L,6271L,87361L,1216799L,16947841L,236052991L,3287794049L,45793063711L,637815097921L,8883618307199L,123732841202881L,1723376158533151L,24003533378261249L,334326091137124351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051048Inst : IEnumerable<long>
{
public static readonly long[] Value=A051048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051048.Bytes);
public long this[int i]=>Value[i];

public static A051048Inst Instance=new A051048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051049
{
public static readonly long[] Value={ 1L,1L,4L,7L,16L,31L,64L,127L,256L,511L,1024L,2047L,4096L,8191L,16384L,32767L,65536L,131071L,262144L,524287L,1048576L,2097151L,4194304L,8388607L,16777216L,33554431L,67108864L,134217727L,268435456L,536870911L,1073741824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051049Inst : IEnumerable<long>
{
public static readonly long[] Value=A051049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051049.Bytes);
public long this[int i]=>Value[i];

public static A051049Inst Instance=new A051049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051050
{
public static readonly BigInteger[] Value={ 1L,35L,9L,676039L,20000L,322476036831L,45956640625L,BigInteger.Parse("109701233401363445369"),3112866107675783424L,BigInteger.Parse("95848123849566788297513035239457"),BigInteger.Parse("43415602393213717594147325952") };
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
public class A051050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051050.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051050Inst Instance=new A051050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051051
{
public static readonly BigInteger[] Value={ 1L,12L,143L,648000L,12964479L,1721036800000L,2077805148460987L,BigInteger.Parse("5041895218133760000000"),BigInteger.Parse("14154229032767142723739127"),BigInteger.Parse("51951524164830314976613655528865792") };
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
public class A051051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051051.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051051Inst Instance=new A051051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051052
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,6L,7L,8L,9L,45L,55L,66L,78L,91L,455L,560L,680L,816L,969L,4845L,5985L,7315L,8855L,10626L,53130L,65780L,80730L,98280L,118755L,593775L,736281L,906192L,1107568L,1344904L,6724520L,8347680L,10295472L,12620256L,15380937L,76904685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051052Inst : IEnumerable<long>
{
public static readonly long[] Value=A051052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051052.Bytes);
public long this[int i]=>Value[i];

public static A051052Inst Instance=new A051052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051053
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,6L,7L,8L,9L,10L,11L,66L,78L,91L,105L,120L,136L,816L,969L,1140L,1330L,1540L,1771L,10626L,12650L,14950L,17550L,20475L,23751L,142506L,169911L,201376L,237336L,278256L,324632L,1947792L,2324784L,2760681L,3262623L,3838380L,4496388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051053Inst : IEnumerable<long>
{
public static readonly long[] Value=A051053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051053.Bytes);
public long this[int i]=>Value[i];

public static A051053Inst Instance=new A051053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051054
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,26L,54L,85L,159L,292L,513L,804L,1844L,2965L,5169L,10679L,20107L,34120L,72498L,126028L,245966L,498852L,913872L,1644570L,3600916L,6530881L,12280999L,25149973L,48355605L,89310576L,187976827L,348475899L,677303827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051054Inst : IEnumerable<long>
{
public static readonly long[] Value=A051054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051054.Bytes);
public long this[int i]=>Value[i];

public static A051054Inst Instance=new A051054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051055
{
public static readonly BigInteger[] Value={ 0L,1L,0L,1L,2L,59L,1092L,51412L,3420384L,382912420L,68021283668L,19474443244283L,9025228384142396L,6825775070789988992L,BigInteger.Parse("8486240219059861120000"),BigInteger.Parse("17454179683586670023001218"),BigInteger.Parse("59698062960218238908531091872") };
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
public class A051055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051055Inst Instance=new A051055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051056
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,5L,7L,11L,14L,20L,27L,37L,48L,65L,83L,109L,139L,179L,226L,288L,361L,456L,569L,712L,885L,1105L,1371L,1708L,2125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051056Inst : IEnumerable<long>
{
public static readonly long[] Value=A051056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051056.Bytes);
public long this[int i]=>Value[i];

public static A051056Inst Instance=new A051056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051057
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,6L,9L,16L,23L,36L,52L,78L,111L,163L,227L,322L,444L,618L,841L,1151L,1550L,2094L,2793L,3730L,4931L,6522L,8555L,11216L,14608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051057Inst : IEnumerable<long>
{
public static readonly long[] Value=A051057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051057.Bytes);
public long this[int i]=>Value[i];

public static A051057Inst Instance=new A051057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051058
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,4L,7L,13L,21L,36L,56L,89L,135L,207L,305L,453L,656L,950L,1351L,1922L,2694L,3772L,5224L,7218L,9885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051058Inst : IEnumerable<long>
{
public static readonly long[] Value=A051058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051058.Bytes);
public long this[int i]=>Value[i];

public static A051058Inst Instance=new A051058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051059
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,5L,6L,6L,8L,10L,10L,12L,14L,15L,18L,20L,22L,26L,30L,33L,37L,42L,47L,54L,62L,68L,81L,93L,104L,122L,142L,163L,192L,225L,264L,311L,371L,437L,523L,623L,739L,885L,1063L,1266L,1518L,1817L,2175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051059Inst : IEnumerable<long>
{
public static readonly long[] Value=A051059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051059.Bytes);
public long this[int i]=>Value[i];

public static A051059Inst Instance=new A051059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051060
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,4L,5L,7L,9L,11L,15L,20L,25L,33L,40L,48L,60L,74L,89L,108L,130L,157L,187L,222L,262L,311L,365L,427L,500L,585L,680L,792L,915L,1059L,1222L,1407L,1615L,1857L,2123L,2425L,2770L,3162L,3592L,4086L,4633L,5254L,5946L,6723L,7586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051060Inst : IEnumerable<long>
{
public static readonly long[] Value=A051060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051060.Bytes);
public long this[int i]=>Value[i];

public static A051060Inst Instance=new A051060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051061
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,3L,4L,7L,9L,12L,17L,23L,30L,40L,51L,66L,85L,108L,136L,173L,215L,268L,331L,406L,498L,612L,742L,900L,1088L,1311L,1573L,1889L,2252L,2682L,3187L,3779L,4467L,5277L,6206L,7294L,8554L,10015L,11695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051061Inst : IEnumerable<long>
{
public static readonly long[] Value=A051061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051061.Bytes);
public long this[int i]=>Value[i];

public static A051061Inst Instance=new A051061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051062
{
public static readonly long[] Value={ 8L,24L,40L,56L,72L,88L,104L,120L,136L,152L,168L,184L,200L,216L,232L,248L,264L,280L,296L,312L,328L,344L,360L,376L,392L,408L,424L,440L,456L,472L,488L,504L,520L,536L,552L,568L,584L,600L,616L,632L,648L,664L,680L,696L,712L,728L,744L,760L,776L,792L,808L,824L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051062Inst : IEnumerable<long>
{
public static readonly long[] Value=A051062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051062.Bytes);
public long this[int i]=>Value[i];

public static A051062Inst Instance=new A051062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051063
{
public static readonly long[] Value={ 9L,18L,36L,45L,63L,72L,90L,99L,117L,126L,144L,153L,171L,180L,198L,207L,225L,234L,252L,261L,279L,288L,306L,315L,333L,342L,360L,369L,387L,396L,414L,423L,441L,450L,468L,477L,495L,504L,522L,531L,549L,558L,576L,585L,603L,612L,630L,639L,657L,666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051063Inst : IEnumerable<long>
{
public static readonly long[] Value=A051063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051063.Bytes);
public long this[int i]=>Value[i];

public static A051063Inst Instance=new A051063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051064
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,5L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051064Inst : IEnumerable<long>
{
public static readonly long[] Value=A051064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051064.Bytes);
public long this[int i]=>Value[i];

public static A051064Inst Instance=new A051064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051065
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051065Inst : IEnumerable<long>
{
public static readonly long[] Value=A051065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051065.Bytes);
public long this[int i]=>Value[i];

public static A051065Inst Instance=new A051065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051066
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,33L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051066Inst : IEnumerable<long>
{
public static readonly long[] Value=A051066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051066.Bytes);
public long this[int i]=>Value[i];

public static A051066Inst Instance=new A051066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051067
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051067Inst : IEnumerable<long>
{
public static readonly long[] Value=A051067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051067.Bytes);
public long this[int i]=>Value[i];

public static A051067Inst Instance=new A051067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051068
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,22L,22L,23L,24L,24L,25L,26L,27L,28L,29L,29L,30L,31L,31L,32L,33L,34L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L,46L,47L,48L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051068Inst : IEnumerable<long>
{
public static readonly long[] Value=A051068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051068.Bytes);
public long this[int i]=>Value[i];

public static A051068Inst Instance=new A051068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051069
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051069Inst : IEnumerable<long>
{
public static readonly long[] Value=A051069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051069.Bytes);
public long this[int i]=>Value[i];

public static A051069Inst Instance=new A051069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051070
{
public static readonly BigInteger[] Value={ 1L,2L,1L,0L,2L,3L,0L,7L,8L,4L,63L,1L,316L,78L,16L,2048L,7652L,26627L,8L,24000L,232919L,1145406L,BigInteger.Parse("3498690007594650042368"),2058537L,58L,26L,27L,59L,9272780L,3L,69273668L,4870847L,BigInteger.Parse("2387010102192469724605148123694256128"),1L,1L,-53L,43L,0L,-4696L,173L,44583L,BigInteger.Parse("111111111111111111111111111111111111111111"),30402457L,668803781L,1134903170L,382443020332L };
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
public class A051070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051070Inst Instance=new A051070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051071
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,59L,67L,73L,83L,89L,107L,113L,131L,139L,163L,179L,211L,227L,233L,251L,257L,281L,283L,307L,331L,337L,347L,353L,379L,419L,443L,467L,491L,499L,523L,547L,563L,571L,577L,587L,593L,601L,617L,619L,643L,659L,683L,691L,739L,787L,811L,827L,859L,881L,883L,907L,937L,947L,971L,1019L,1033L,1049L,1051L,1091L,1097L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051071Inst : IEnumerable<long>
{
public static readonly long[] Value=A051071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051071.Bytes);
public long this[int i]=>Value[i];

public static A051071Inst Instance=new A051071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051072
{
public static readonly long[] Value={ 2L,3L,11L,17L,41L,43L,59L,83L,89L,107L,113L,131L,137L,179L,227L,233L,251L,257L,281L,283L,307L,347L,353L,401L,419L,433L,443L,449L,457L,467L,491L,499L,521L,563L,569L,587L,593L,601L,617L,641L,643L,659L,683L,691L,739L,761L,809L,811L,827L,857L,881L,929L,947L,953L,971L,977L,1019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051072Inst : IEnumerable<long>
{
public static readonly long[] Value=A051072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051072.Bytes);
public long this[int i]=>Value[i];

public static A051072Inst Instance=new A051072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051073
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,59L,67L,83L,107L,131L,139L,163L,179L,211L,227L,251L,257L,281L,283L,307L,331L,337L,347L,379L,419L,443L,467L,491L,499L,523L,547L,563L,571L,587L,617L,619L,643L,659L,683L,691L,739L,787L,811L,827L,859L,881L,883L,907L,947L,971L,1019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051073Inst : IEnumerable<long>
{
public static readonly long[] Value=A051073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051073.Bytes);
public long this[int i]=>Value[i];

public static A051073Inst Instance=new A051073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051074
{
public static readonly long[] Value={ 2L,3L,17L,19L,43L,59L,67L,73L,83L,89L,97L,107L,113L,137L,139L,163L,179L,193L,227L,233L,241L,251L,257L,283L,307L,313L,337L,347L,353L,379L,409L,419L,433L,443L,449L,457L,467L,499L,523L,547L,563L,569L,571L,577L,587L,593L,617L,619L,641L,643L,659L,673L,683L,739L,769L,787L,809L,827L,857L,859L,883L,907L,929L,937L,947L,953L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051074Inst : IEnumerable<long>
{
public static readonly long[] Value=A051074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051074.Bytes);
public long this[int i]=>Value[i];

public static A051074Inst Instance=new A051074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051075
{
public static readonly long[] Value={ 2L,3L,11L,43L,59L,83L,89L,107L,113L,131L,179L,227L,233L,251L,257L,281L,283L,307L,347L,353L,419L,443L,467L,491L,499L,563L,587L,593L,601L,617L,643L,659L,683L,691L,739L,811L,827L,881L,947L,971L,1019L,1049L,1051L,1091L,1097L,1163L,1187L,1193L,1217L,1259L,1283L,1289L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051075Inst : IEnumerable<long>
{
public static readonly long[] Value=A051075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051075.Bytes);
public long this[int i]=>Value[i];

public static A051075Inst Instance=new A051075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051076
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,59L,67L,73L,83L,89L,97L,107L,131L,137L,139L,163L,179L,193L,227L,233L,241L,251L,257L,283L,307L,313L,331L,347L,353L,401L,409L,419L,433L,443L,457L,467L,499L,521L,523L,563L,569L,571L,577L,587L,593L,601L,619L,641L,643L,673L,683L,691L,739L,761L,769L,787L,809L,811L,857L,859L,881L,907L,929L,937L,947L,953L,971L,977L,1019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051076Inst : IEnumerable<long>
{
public static readonly long[] Value=A051076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051076.Bytes);
public long this[int i]=>Value[i];

public static A051076Inst Instance=new A051076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051077
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,59L,67L,83L,107L,131L,139L,163L,179L,211L,227L,251L,257L,281L,283L,307L,331L,347L,379L,419L,443L,467L,491L,499L,523L,547L,563L,571L,587L,617L,619L,643L,659L,683L,691L,739L,787L,811L,827L,859L,883L,907L,947L,971L,1019L,1033L,1049L,1051L,1091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051077Inst : IEnumerable<long>
{
public static readonly long[] Value=A051077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051077.Bytes);
public long this[int i]=>Value[i];

public static A051077Inst Instance=new A051077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051078
{
public static readonly long[] Value={ 2L,3L,11L,17L,41L,43L,59L,83L,89L,107L,113L,131L,137L,179L,227L,233L,251L,257L,281L,283L,347L,353L,401L,419L,443L,449L,457L,467L,491L,499L,521L,563L,569L,587L,593L,601L,617L,641L,643L,659L,683L,691L,761L,809L,827L,857L,881L,929L,947L,953L,971L,977L,1019L,1049L,1051L,1091L,1097L,1163L,1187L,1193L,1217L,1259L,1283L,1289L,1307L,1361L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051078Inst : IEnumerable<long>
{
public static readonly long[] Value=A051078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051078.Bytes);
public long this[int i]=>Value[i];

public static A051078Inst Instance=new A051078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051079
{
public static readonly long[] Value={ 2L,3L,19L,43L,59L,67L,73L,83L,89L,107L,113L,139L,163L,179L,227L,233L,251L,257L,283L,307L,337L,347L,353L,379L,419L,443L,467L,499L,523L,547L,563L,571L,577L,587L,593L,617L,619L,643L,659L,683L,739L,787L,827L,859L,883L,907L,937L,947L,971L,1019L,1033L,1049L,1097L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051079Inst : IEnumerable<long>
{
public static readonly long[] Value=A051079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051079.Bytes);
public long this[int i]=>Value[i];

public static A051079Inst Instance=new A051079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051080
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,43L,59L,73L,83L,97L,107L,113L,131L,137L,139L,163L,179L,193L,211L,227L,233L,241L,251L,257L,281L,283L,307L,313L,331L,337L,347L,379L,401L,409L,433L,443L,449L,457L,467L,491L,499L,521L,523L,547L,563L,569L,571L,577L,587L,593L,601L,619L,641L,643L,659L,673L,691L,739L,761L,769L,787L,809L,811L,827L,857L,883L,907L,929L,937L,953L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051080Inst : IEnumerable<long>
{
public static readonly long[] Value=A051080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051080.Bytes);
public long this[int i]=>Value[i];

public static A051080Inst Instance=new A051080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051081
{
public static readonly long[] Value={ 2L,3L,11L,43L,59L,83L,107L,131L,179L,227L,251L,257L,281L,283L,307L,347L,419L,443L,467L,491L,499L,563L,587L,617L,643L,659L,683L,691L,739L,811L,827L,881L,947L,971L,1019L,1049L,1051L,1091L,1097L,1163L,1187L,1193L,1217L,1259L,1283L,1307L,1427L,1451L,1459L,1481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051081Inst : IEnumerable<long>
{
public static readonly long[] Value=A051081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051081.Bytes);
public long this[int i]=>Value[i];

public static A051081Inst Instance=new A051081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051082
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,43L,59L,67L,73L,83L,89L,97L,107L,113L,137L,139L,163L,179L,193L,211L,227L,233L,241L,251L,257L,281L,283L,307L,331L,337L,347L,353L,379L,401L,409L,419L,433L,449L,457L,467L,491L,499L,523L,563L,569L,571L,577L,587L,593L,601L,617L,619L,641L,643L,659L,673L,683L,691L,739L,761L,769L,787L,809L,811L,827L,857L,881L,883L,907L,929L,947L,953L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051082Inst : IEnumerable<long>
{
public static readonly long[] Value=A051082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051082.Bytes);
public long this[int i]=>Value[i];

public static A051082Inst Instance=new A051082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051083
{
public static readonly long[] Value={ 2L,3L,11L,19L,59L,67L,73L,83L,89L,107L,131L,139L,163L,179L,227L,233L,251L,257L,283L,307L,331L,347L,353L,419L,443L,467L,499L,523L,563L,571L,577L,587L,593L,601L,619L,643L,683L,691L,739L,787L,811L,859L,881L,907L,937L,947L,971L,1019L,1033L,1049L,1091L,1097L,1123L,1153L,1163L,1171L,1187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051083Inst : IEnumerable<long>
{
public static readonly long[] Value=A051083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051083.Bytes);
public long this[int i]=>Value[i];

public static A051083Inst Instance=new A051083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051084
{
public static readonly long[] Value={ 2L,3L,17L,43L,59L,83L,89L,107L,113L,137L,179L,227L,233L,251L,257L,283L,307L,347L,353L,419L,433L,443L,449L,457L,467L,499L,563L,569L,587L,593L,617L,641L,643L,659L,683L,739L,809L,827L,857L,929L,947L,953L,971L,977L,1019L,1049L,1097L,1163L,1187L,1193L,1217L,1259L,1283L,1289L,1307L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051084Inst : IEnumerable<long>
{
public static readonly long[] Value=A051084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051084.Bytes);
public long this[int i]=>Value[i];

public static A051084Inst Instance=new A051084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051085
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,59L,67L,83L,107L,131L,139L,163L,179L,211L,227L,251L,281L,283L,307L,331L,347L,379L,419L,443L,467L,491L,499L,523L,547L,563L,571L,587L,617L,619L,643L,659L,683L,691L,739L,787L,811L,827L,859L,883L,907L,947L,971L,1019L,1033L,1049L,1051L,1091L,1097L,1123L,1163L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051085Inst : IEnumerable<long>
{
public static readonly long[] Value=A051085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051085.Bytes);
public long this[int i]=>Value[i];

public static A051085Inst Instance=new A051085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051086
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,43L,59L,67L,73L,83L,89L,97L,107L,113L,131L,139L,163L,179L,193L,211L,227L,233L,241L,251L,257L,281L,283L,313L,331L,337L,347L,353L,379L,401L,419L,433L,449L,457L,467L,491L,499L,521L,523L,547L,563L,569L,571L,577L,587L,593L,601L,617L,619L,641L,643L,659L,673L,683L,691L,739L,761L,769L,787L,809L,811L,827L,857L,859L,881L,883L,907L,929L,937L,947L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051086Inst : IEnumerable<long>
{
public static readonly long[] Value=A051086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051086.Bytes);
public long this[int i]=>Value[i];

public static A051086Inst Instance=new A051086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051087
{
public static readonly long[] Value={ 2L,3L,11L,43L,59L,83L,89L,107L,113L,131L,179L,227L,233L,251L,257L,281L,283L,347L,353L,419L,443L,467L,491L,499L,563L,587L,593L,601L,617L,643L,659L,683L,691L,827L,881L,947L,971L,1019L,1049L,1051L,1091L,1097L,1163L,1187L,1193L,1217L,1259L,1283L,1289L,1307L,1427L,1433L,1451L,1481L,1499L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051087Inst : IEnumerable<long>
{
public static readonly long[] Value=A051087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051087.Bytes);
public long this[int i]=>Value[i];

public static A051087Inst Instance=new A051087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051088
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,43L,59L,67L,73L,83L,89L,97L,107L,113L,131L,137L,139L,163L,179L,193L,211L,227L,233L,241L,251L,257L,281L,283L,307L,313L,331L,337L,347L,353L,379L,401L,409L,433L,443L,449L,467L,491L,499L,521L,523L,547L,563L,569L,577L,587L,593L,601L,617L,619L,641L,643L,659L,673L,683L,691L,739L,769L,787L,809L,811L,827L,857L,859L,881L,883L,907L,929L,937L,947L,953L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051088Inst : IEnumerable<long>
{
public static readonly long[] Value=A051088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051088.Bytes);
public long this[int i]=>Value[i];

public static A051088Inst Instance=new A051088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051089
{
public static readonly long[] Value={ 2L,3L,19L,43L,59L,67L,83L,107L,139L,163L,179L,227L,251L,257L,283L,307L,337L,347L,379L,419L,443L,467L,499L,523L,547L,563L,571L,587L,617L,619L,643L,659L,683L,739L,787L,827L,859L,883L,907L,947L,971L,1019L,1033L,1049L,1097L,1123L,1163L,1187L,1193L,1217L,1249L,1259L,1283L,1307L,1427L,1459L,1483L,1499L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051089Inst : IEnumerable<long>
{
public static readonly long[] Value=A051089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051089.Bytes);
public long this[int i]=>Value[i];

public static A051089Inst Instance=new A051089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051090
{
public static readonly long[] Value={ 2L,3L,11L,17L,41L,59L,83L,89L,107L,131L,137L,179L,227L,233L,251L,257L,283L,307L,347L,353L,401L,419L,433L,443L,457L,467L,499L,521L,563L,569L,587L,593L,601L,641L,643L,683L,691L,739L,761L,809L,811L,857L,881L,929L,947L,953L,971L,977L,1019L,1049L,1091L,1097L,1163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051090Inst : IEnumerable<long>
{
public static readonly long[] Value=A051090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051090.Bytes);
public long this[int i]=>Value[i];

public static A051090Inst Instance=new A051090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051091
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,59L,73L,83L,107L,113L,131L,139L,163L,179L,211L,227L,233L,251L,257L,281L,283L,307L,331L,337L,347L,379L,443L,467L,491L,499L,523L,547L,563L,571L,577L,587L,593L,601L,619L,643L,659L,691L,739L,787L,811L,827L,883L,907L,937L,971L,1019L,1033L,1049L,1051L,1091L,1097L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051091Inst : IEnumerable<long>
{
public static readonly long[] Value=A051091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051091.Bytes);
public long this[int i]=>Value[i];

public static A051091Inst Instance=new A051091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051092
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,43L,59L,67L,73L,83L,89L,97L,107L,113L,131L,137L,163L,179L,193L,211L,227L,233L,241L,251L,257L,281L,283L,307L,313L,331L,337L,347L,353L,379L,401L,409L,419L,433L,443L,449L,457L,467L,491L,499L,521L,523L,547L,563L,569L,571L,577L,587L,593L,601L,617L,619L,641L,643L,659L,673L,683L,739L,761L,769L,787L,809L,811L,827L,857L,859L,881L,883L,907L,929L,937L,947L,953L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051092Inst : IEnumerable<long>
{
public static readonly long[] Value=A051092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051092.Bytes);
public long this[int i]=>Value[i];

public static A051092Inst Instance=new A051092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051093
{
public static readonly long[] Value={ 2L,3L,11L,43L,59L,83L,107L,131L,179L,227L,251L,257L,281L,283L,307L,347L,419L,443L,467L,491L,499L,563L,587L,617L,643L,659L,683L,691L,739L,811L,827L,947L,971L,1019L,1049L,1051L,1091L,1097L,1163L,1187L,1193L,1259L,1283L,1307L,1427L,1451L,1459L,1481L,1499L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051093Inst : IEnumerable<long>
{
public static readonly long[] Value=A051093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051093.Bytes);
public long this[int i]=>Value[i];

public static A051093Inst Instance=new A051093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051094
{
public static readonly long[] Value={ 2L,3L,17L,19L,43L,59L,67L,73L,83L,89L,97L,107L,113L,137L,139L,163L,179L,193L,227L,233L,241L,257L,283L,307L,313L,337L,347L,353L,379L,409L,419L,433L,443L,449L,457L,467L,499L,523L,547L,563L,569L,571L,577L,587L,593L,617L,619L,641L,643L,659L,673L,683L,739L,769L,787L,809L,827L,857L,859L,883L,907L,929L,937L,947L,953L,971L,977L,1009L,1019L,1033L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051094Inst : IEnumerable<long>
{
public static readonly long[] Value=A051094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051094.Bytes);
public long this[int i]=>Value[i];

public static A051094Inst Instance=new A051094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051095
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,59L,67L,73L,83L,89L,107L,113L,139L,163L,179L,211L,227L,233L,251L,257L,281L,283L,307L,331L,337L,347L,353L,379L,419L,467L,491L,499L,523L,563L,571L,577L,587L,593L,601L,617L,619L,643L,659L,683L,691L,739L,787L,811L,827L,881L,883L,907L,947L,971L,1019L,1033L,1049L,1051L,1091L,1097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051095Inst : IEnumerable<long>
{
public static readonly long[] Value=A051095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051095.Bytes);
public long this[int i]=>Value[i];

public static A051095Inst Instance=new A051095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051096
{
public static readonly long[] Value={ 2L,3L,11L,17L,41L,43L,59L,83L,89L,107L,113L,131L,137L,179L,227L,233L,251L,257L,281L,283L,347L,353L,401L,419L,443L,449L,457L,467L,491L,499L,521L,563L,569L,587L,593L,601L,617L,641L,643L,659L,683L,691L,761L,809L,827L,857L,881L,929L,947L,953L,971L,977L,1019L,1049L,1051L,1091L,1097L,1163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051096Inst : IEnumerable<long>
{
public static readonly long[] Value=A051096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051096.Bytes);
public long this[int i]=>Value[i];

public static A051096Inst Instance=new A051096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051097
{
public static readonly long[] Value={ 2L,3L,11L,19L,59L,67L,83L,107L,131L,139L,163L,179L,227L,251L,257L,283L,307L,331L,347L,419L,443L,467L,499L,523L,563L,571L,587L,619L,643L,683L,691L,739L,787L,811L,859L,881L,907L,947L,971L,1019L,1033L,1049L,1091L,1097L,1123L,1163L,1171L,1187L,1193L,1217L,1249L,1259L,1283L,1291L,1307L,1427L,1451L,1459L,1481L,1483L,1523L,1531L,1553L,1571L,1579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051097Inst : IEnumerable<long>
{
public static readonly long[] Value=A051097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051097.Bytes);
public long this[int i]=>Value[i];

public static A051097Inst Instance=new A051097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051098
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,43L,67L,73L,83L,89L,97L,107L,113L,131L,137L,139L,163L,179L,193L,211L,227L,241L,251L,257L,281L,283L,307L,313L,331L,337L,347L,353L,379L,401L,409L,419L,433L,443L,449L,457L,467L,491L,499L,521L,547L,563L,569L,571L,577L,587L,593L,601L,617L,619L,641L,643L,659L,673L,683L,691L,739L,761L,769L,787L,809L,811L,827L,857L,859L,881L,883L,907L,937L,947L,953L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051098Inst : IEnumerable<long>
{
public static readonly long[] Value=A051098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051098.Bytes);
public long this[int i]=>Value[i];

public static A051098Inst Instance=new A051098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051099
{
public static readonly long[] Value={ 2L,3L,43L,59L,83L,89L,107L,113L,179L,227L,233L,251L,257L,283L,307L,347L,353L,419L,443L,467L,499L,563L,587L,593L,617L,643L,659L,683L,739L,827L,947L,971L,1019L,1049L,1097L,1163L,1187L,1193L,1217L,1259L,1283L,1289L,1307L,1427L,1433L,1459L,1499L,1523L,1553L,1579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051099Inst : IEnumerable<long>
{
public static readonly long[] Value=A051099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051099.Bytes);
public long this[int i]=>Value[i];

public static A051099Inst Instance=new A051099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051100
{
public static readonly long[] Value={ 2L,3L,11L,17L,19L,41L,43L,59L,67L,73L,83L,89L,97L,107L,113L,131L,137L,139L,163L,179L,193L,211L,227L,233L,241L,251L,257L,281L,283L,307L,313L,331L,337L,347L,353L,379L,401L,409L,419L,433L,443L,449L,457L,467L,491L,499L,521L,523L,547L,563L,569L,571L,577L,587L,593L,601L,617L,619L,641L,643L,659L,673L,683L,691L,739L,761L,769L,787L,809L,811L,827L,857L,859L,881L,883L,907L,929L,937L,947L,953L,971L,977L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051100Inst : IEnumerable<long>
{
public static readonly long[] Value=A051100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051100.Bytes);
public long this[int i]=>Value[i];

public static A051100Inst Instance=new A051100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051101
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,59L,67L,83L,107L,131L,139L,163L,179L,211L,227L,251L,281L,283L,307L,331L,347L,379L,419L,443L,467L,491L,499L,523L,547L,563L,571L,587L,617L,619L,643L,659L,683L,691L,739L,787L,811L,827L,859L,883L,907L,947L,971L,1019L,1033L,1049L,1051L,1091L,1097L,1123L,1163L,1171L,1187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051101Inst : IEnumerable<long>
{
public static readonly long[] Value=A051101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051101.Bytes);
public long this[int i]=>Value[i];

public static A051101Inst Instance=new A051101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051102
{
public static readonly BigInteger[] Value={ 7L,20L,148L,1096L,59874L,442413L,24154952L,178482300L,9744803446L,3931334297144L,29048849665247L,11719142372802611L,639843493530054949L,4727839468229346561L,BigInteger.Parse("258131288619006739623"),BigInteger.Parse("104137594330290877971834") };
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
public class A051102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051102Inst Instance=new A051102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051103
{
public static readonly long[] Value={ 1L,2L,2243L,1954L,8798L,32865944L,131921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051103Inst : IEnumerable<long>
{
public static readonly long[] Value=A051103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051103.Bytes);
public long this[int i]=>Value[i];

public static A051103Inst Instance=new A051103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051104
{
public static readonly long[] Value={ 12L,75L,1029000L,165375L,800415L,2840672835L,9909900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051104Inst : IEnumerable<long>
{
public static readonly long[] Value=A051104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051104.Bytes);
public long this[int i]=>Value[i];

public static A051104Inst Instance=new A051104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051105
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051105Inst : IEnumerable<long>
{
public static readonly long[] Value=A051105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051105.Bytes);
public long this[int i]=>Value[i];

public static A051105Inst Instance=new A051105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051106
{
public static readonly BigInteger[] Value={ 1L,3L,14L,105L,1287L,26026L,873392L,48825972L,4559177300L,712438499850L,186574469114250L,81973527087903750L,BigInteger.Parse("60475684628083567500"),BigInteger.Parse("74966560165861256115000"),BigInteger.Parse("156232609877290216839177600") };
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
public class A051106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051106.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051106Inst Instance=new A051106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051107
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,30L,40L,50L,60L,70L,80L,90L,100L,1000L,1000000L,1000000000L,1000000000000L,1000000000000000000L,BigInteger.Parse("1000000000000000000000000") };
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
public class A051107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051107Inst Instance=new A051107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051108
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,30L,40L,50L,60L,70L,80L,90L,100L,1000L,1000000L,1000000000L,1000000000000L,1000000000000000L,1000000000000000000L,BigInteger.Parse("1000000000000000000000") };
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
public class A051108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051108Inst Instance=new A051108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051109
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,50L,100L,200L,500L,1000L,2000L,5000L,10000L,20000L,50000L,100000L,200000L,500000L,1000000L,2000000L,5000000L,10000000L,20000000L,50000000L,100000000L,200000000L,500000000L,1000000000L,2000000000L,5000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051109Inst : IEnumerable<long>
{
public static readonly long[] Value=A051109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051109.Bytes);
public long this[int i]=>Value[i];

public static A051109Inst Instance=new A051109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051110
{
public static readonly long[] Value={ 113L,293L,317L,523L,773L,839L,863L,887L,953L,1069L,1129L,1259L,1327L,1381L,1409L,1583L,1637L,1669L,1759L,1831L,1847L,1913L,1933L,1951L,2039L,2113L,2161L,2179L,2221L,2251L,2311L,2357L,2423L,2477L,2503L,2557L,2593L,2633L,2753L,2803L,2819L,2861L,2939L,2971L,3023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051110Inst : IEnumerable<long>
{
public static readonly long[] Value=A051110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051110.Bytes);
public long this[int i]=>Value[i];

public static A051110Inst Instance=new A051110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051111
{
public static readonly long[] Value={ 1L,2L,0L,-5L,-5L,8L,21L,0L,-55L,-55L,89L,233L,0L,-610L,-610L,987L,2584L,0L,-6765L,-6765L,10946L,28657L,0L,-75025L,-75025L,121393L,317811L,0L,-832040L,-832040L,1346269L,3524578L,0L,-9227465L,-9227465L,14930352L,39088169L,0L,-102334155L,-102334155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051111Inst : IEnumerable<long>
{
public static readonly long[] Value=A051111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051111.Bytes);
public long this[int i]=>Value[i];

public static A051111Inst Instance=new A051111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051112
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,25L,2020L,82115L,2401910L,58089465L,1245331920L,24625121455L,460316430970L,8266174350005L,144171200793620L,2461016066613195L,41343340015862430L,686274244801356145L,11289648429330100120UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051112Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A051112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051112.Bytes);
public ulong this[int i]=>Value[i];

public static A051112Inst Instance=new A051112Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051113
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,6L,2146L,304752L,25400564L,1557306954L,78817977462L,3513106214484L,143429796694888L,5501383287745422L,201652447559180618L,7148287976359243896L,BigInteger.Parse("247151326758617289372"),BigInteger.Parse("8386495692534098616210"),BigInteger.Parse("280574309728711561269214"),BigInteger.Parse("9286566498536162168164188") };
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
public class A051113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051113Inst Instance=new A051113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051114
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,1380L,759457L,192504214L,31169837405L,3827970163920L,392135190780649L,35468973527445018L,2937270598777421269L,BigInteger.Parse("228156280366446932500"),BigInteger.Parse("16904255174464832812001"),BigInteger.Parse("1208995011493806361868862"),BigInteger.Parse("84197134590686932418878093"),BigInteger.Parse("5746616155270206518199693720") };
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
public class A051114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051114Inst Instance=new A051114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051115
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,490L,1308270L,1085660748L,483349680164L,147791677696350L,35419166732721930L,7189973830216081696L,BigInteger.Parse("1298090729995668204288"),BigInteger.Parse("215276329320562758744210"),BigInteger.Parse("33531967207612008887673350") };
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
public class A051115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051115Inst Instance=new A051115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051116
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,115L,1613250L,4693213105L,5971431466764L,4657267944250425L,2654563364004395160L,BigInteger.Parse("1223795727111874798255"),BigInteger.Parse("485987045749653063943998"),BigInteger.Parse("173253367143529540187635315"),BigInteger.Parse("57037488183550191520963561230") };
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
public class A051116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051116Inst Instance=new A051116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051117
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,20L,1484230L,15946757960L,60089234465176L,122281201867047920L,BigInteger.Parse("168329227672583040430"),BigInteger.Parse("178185327268349957044060"),BigInteger.Parse("156921594738520322214197672"),BigInteger.Parse("121014019160263331691800711500") };
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
public class A051117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051117Inst Instance=new A051117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051118
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,2L,1067771L,43506231489L,501425871595264L,2719674203584968630L,BigInteger.Parse("9172837864705015158979"),BigInteger.Parse("22524989249381408262409893"),BigInteger.Parse("44328073635887914351462953684"),BigInteger.Parse("74381256243136645820404637874910") };
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
public class A051118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051118Inst Instance=new A051118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051119
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,4L,1L,2L,3L,1L,1L,2L,1L,4L,3L,2L,1L,8L,1L,2L,1L,4L,1L,6L,1L,1L,3L,2L,5L,4L,1L,2L,3L,8L,1L,6L,1L,4L,9L,2L,1L,16L,1L,2L,3L,4L,1L,2L,5L,8L,3L,2L,1L,12L,1L,2L,9L,1L,5L,6L,1L,4L,3L,10L,1L,8L,1L,2L,3L,4L,7L,6L,1L,16L,1L,2L,1L,12L,5L,2L,3L,8L,1L,18L,7L,4L,3L,2L,5L,32L,1L,2L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051119Inst : IEnumerable<long>
{
public static readonly long[] Value=A051119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051119.Bytes);
public long this[int i]=>Value[i];

public static A051119Inst Instance=new A051119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051120
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,4L,1L,1L,4L,2L,3L,6L,1L,1L,6L,2L,4L,3L,3L,1L,2L,8L,1L,1L,8L,2L,6L,3L,4L,5L,3L,3L,2L,11L,1L,1L,11L,2L,8L,3L,6L,1L,5L,4L,4L,8L,3L,5L,2L,13L,1L,1L,13L,2L,11L,4L,8L,4L,6L,3L,5L,6L,4L,10L,3L,7L,2L,16L,1L,1L,16L,2L,13L,3L,11L,1L,10L,5L,8L,1L,7L,6L,6L,4L,5L,9L,4L,12L,3L,9L,2L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051120Inst : IEnumerable<long>
{
public static readonly long[] Value=A051120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051120.Bytes);
public long this[int i]=>Value[i];

public static A051120Inst Instance=new A051120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051121
{
public static readonly long[] Value={ 1L,15L,29L,12L,26L,11L,25L,8L,22L,6L,20L,3L,17L,1L,15L,29L,12L,26L,9L,23L,7L,21L,4L,18L,2L,16L,30L,13L,27L,10L,24L,10L,24L,7L,21L,5L,19L,2L,16L,30L,14L,28L,11L,25L,8L,22L,6L,20L,3L,17L,1L,15L,29L,12L,26L,9L,23L,9L,23L,6L,20L,4L,18L,1L,15L,29L,13L,27L,10L,24L,7L,21L,5L,19L,2L,16L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051121Inst : IEnumerable<long>
{
public static readonly long[] Value=A051121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051121.Bytes);
public long this[int i]=>Value[i];

public static A051121Inst Instance=new A051121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051122
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,8L,5L,0L,34L,17L,16L,128L,105L,96L,578L,537L,536L,16L,4165L,2624L,2L,17697L,9504L,9472L,65553L,55808L,55618L,317489L,299040L,295432L,2053L,2163968L,1377506L,263361L,8437888L,6328368L,5247017L,38010912L,33623682L,1576009L,165153832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051122Inst : IEnumerable<long>
{
public static readonly long[] Value=A051122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051122.Bytes);
public long this[int i]=>Value[i];

public static A051122Inst Instance=new A051122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051123
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,13L,13L,29L,55L,55L,127L,217L,249L,505L,891L,1019L,2047L,3645L,6749L,6781L,15087L,28655L,28671L,65521L,111921L,130865L,262003L,458611L,514551L,1047229L,1882877L,3522525L,3538919L,7849959L,14666991L,15719929L,32759801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051123Inst : IEnumerable<long>
{
public static readonly long[] Value=A051123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051123.Bytes);
public long this[int i]=>Value[i];

public static A051123Inst Instance=new A051123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051124
{
public static readonly long[] Value={ 1L,0L,3L,1L,6L,13L,5L,24L,55L,21L,110L,201L,121L,400L,795L,441L,1510L,3109L,6733L,2616L,12463L,28653L,10974L,56017L,102449L,65312L,206195L,402993L,197062L,748189L,1587445L,3520472L,1374951L,6472453L,14403630L,7282041L,26431433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051124Inst : IEnumerable<long>
{
public static readonly long[] Value=A051124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051124.Bytes);
public long this[int i]=>Value[i];

public static A051124Inst Instance=new A051124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051125
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,4L,3L,3L,4L,5L,4L,3L,4L,5L,6L,5L,4L,4L,5L,6L,7L,6L,5L,4L,5L,6L,7L,8L,7L,6L,5L,5L,6L,7L,8L,9L,8L,7L,6L,5L,6L,7L,8L,9L,10L,9L,8L,7L,6L,6L,7L,8L,9L,10L,11L,10L,9L,8L,7L,6L,7L,8L,9L,10L,11L,12L,11L,10L,9L,8L,7L,7L,8L,9L,10L,11L,12L,13L,12L,11L,10L,9L,8L,7L,8L,9L,10L,11L,12L,13L,14L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051125Inst : IEnumerable<long>
{
public static readonly long[] Value=A051125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051125.Bytes);
public long this[int i]=>Value[i];

public static A051125Inst Instance=new A051125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051126
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,2L,1L,0L,1L,2L,0L,0L,0L,1L,2L,3L,1L,1L,0L,1L,2L,3L,0L,2L,0L,0L,1L,2L,3L,4L,1L,0L,1L,0L,1L,2L,3L,4L,0L,2L,1L,0L,0L,1L,2L,3L,4L,5L,1L,3L,2L,1L,0L,1L,2L,3L,4L,5L,0L,2L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,1L,3L,1L,1L,1L,0L,1L,2L,3L,4L,5L,6L,0L,2L,4L,2L,2L,0L,0L,1L,2L,3L,4L,5L,6L,7L,1L,3L,0L,3L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051126Inst : IEnumerable<long>
{
public static readonly long[] Value=A051126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051126.Bytes);
public long this[int i]=>Value[i];

public static A051126Inst Instance=new A051126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051127
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,2L,1L,0L,0L,0L,2L,1L,0L,1L,1L,3L,2L,1L,0L,0L,2L,0L,3L,2L,1L,0L,1L,0L,1L,4L,3L,2L,1L,0L,0L,1L,2L,0L,4L,3L,2L,1L,0L,1L,2L,3L,1L,5L,4L,3L,2L,1L,0L,0L,0L,0L,2L,0L,5L,4L,3L,2L,1L,0L,1L,1L,1L,3L,1L,6L,5L,4L,3L,2L,1L,0L,0L,2L,2L,4L,2L,0L,6L,5L,4L,3L,2L,1L,0L,1L,0L,3L,0L,3L,1L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051127Inst : IEnumerable<long>
{
public static readonly long[] Value=A051127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051127.Bytes);
public long this[int i]=>Value[i];

public static A051127Inst Instance=new A051127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051128
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,9L,8L,1L,5L,16L,27L,16L,1L,6L,25L,64L,81L,32L,1L,7L,36L,125L,256L,243L,64L,1L,8L,49L,216L,625L,1024L,729L,128L,1L,9L,64L,343L,1296L,3125L,4096L,2187L,256L,1L,10L,81L,512L,2401L,7776L,15625L,16384L,6561L,512L,1L,11L,100L,729L,4096L,16807L,46656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051128Inst : IEnumerable<long>
{
public static readonly long[] Value=A051128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051128.Bytes);
public long this[int i]=>Value[i];

public static A051128Inst Instance=new A051128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051129
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,1L,8L,9L,4L,1L,16L,27L,16L,5L,1L,32L,81L,64L,25L,6L,1L,64L,243L,256L,125L,36L,7L,1L,128L,729L,1024L,625L,216L,49L,8L,1L,256L,2187L,4096L,3125L,1296L,343L,64L,9L,1L,512L,6561L,16384L,15625L,7776L,2401L,512L,81L,10L,1L,1024L,19683L,65536L,78125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051129Inst : IEnumerable<long>
{
public static readonly long[] Value=A051129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051129.Bytes);
public long this[int i]=>Value[i];

public static A051129Inst Instance=new A051129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051130
{
public static readonly long[] Value={ 2L,3L,7L,13L,42L,55L,2841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051130Inst : IEnumerable<long>
{
public static readonly long[] Value=A051130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051130.Bytes);
public long this[int i]=>Value[i];

public static A051130Inst Instance=new A051130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051131
{
public static readonly BigInteger[] Value={ 2L,5L,877L,27644437L,BigInteger.Parse("35742549198872617291353508656626642567"),BigInteger.Parse("359334085968622831041960188598043661065388726959079837") };
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
public class A051131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A051131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A051131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A051131Inst Instance=new A051131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051132
{
public static readonly long[] Value={ 0L,1L,9L,25L,45L,69L,109L,145L,193L,249L,305L,373L,437L,517L,609L,697L,793L,889L,1005L,1125L,1245L,1369L,1513L,1649L,1789L,1941L,2109L,2285L,2449L,2617L,2809L,2997L,3205L,3405L,3613L,3841L,4049L,4281L,4509L,4765L,5013L,5249L,5521L,5785L,6073L,6349L,6621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051132Inst : IEnumerable<long>
{
public static readonly long[] Value=A051132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051132.Bytes);
public long this[int i]=>Value[i];

public static A051132Inst Instance=new A051132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051133
{
public static readonly long[] Value={ 0L,3L,30L,210L,1260L,6930L,36036L,180180L,875160L,4157010L,19399380L,89237148L,405623400L,1825305300L,8143669800L,36064823400L,158685222960L,694247850450L,3022020054900L,13095420237900L,56517076816200L,243023430309660L,1041528987041400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051133Inst : IEnumerable<long>
{
public static readonly long[] Value=A051133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051133.Bytes);
public long this[int i]=>Value[i];

public static A051133Inst Instance=new A051133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051134
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,5L,5L,6L,7L,8L,8L,8L,8L,9L,9L,10L,11L,12L,12L,13L,13L,13L,14L,15L,16L,17L,18L,18L,19L,19L,20L,20L,21L,22L,23L,23L,24L,25L,26L,27L,27L,27L,28L,29L,30L,30L,31L,31L,32L,33L,34L,34L,35L,35L,35L,36L,36L,36L,36L,37L,38L,39L,40L,41L,41L,42L,43L,43L,43L,43L,44L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051134Inst : IEnumerable<long>
{
public static readonly long[] Value=A051134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051134.Bytes);
public long this[int i]=>Value[i];

public static A051134Inst Instance=new A051134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051135
{
public static readonly long[] Value={ 2L,2L,1L,3L,1L,1L,2L,4L,1L,1L,1L,2L,1L,2L,3L,5L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,6L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,7L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051135Inst : IEnumerable<long>
{
public static readonly long[] Value=A051135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051135.Bytes);
public long this[int i]=>Value[i];

public static A051135Inst Instance=new A051135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051136
{
public static readonly long[] Value={ 1L,4L,9L,20L,42L,80L,147L,260L,445L,744L,1215L,1944L,3059L,4740L,7239L,10920L,16286L,24028L,35110L,50844L,73010L,104028L,147144L,206700L,288501L,400232L,552037L,757288L,1033495L,1403508L,1897088L,2552812L,3420527L,4564500L,6067265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051136Inst : IEnumerable<long>
{
public static readonly long[] Value=A051136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051136.Bytes);
public long this[int i]=>Value[i];

public static A051136Inst Instance=new A051136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051137
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,6L,10L,10L,5L,1L,1L,8L,21L,20L,15L,6L,1L,1L,13L,39L,55L,35L,21L,7L,1L,1L,18L,92L,136L,120L,56L,28L,8L,1L,1L,30L,198L,430L,377L,231L,84L,36L,9L,1L,1L,46L,498L,1300L,1505L,888L,406L,120L,45L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051137Inst : IEnumerable<long>
{
public static readonly long[] Value=A051137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051137.Bytes);
public long this[int i]=>Value[i];

public static A051137Inst Instance=new A051137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051138
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-5L,-4L,29L,129L,-65L,-3689L,-16264L,113689L,2382785L,7001471L,-398035821L,-7911171596L,43244638645L,6480598259201L,124106986093951L,-5987117709349201L,-541051130050800400L,-4830209396684261199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051138Inst : IEnumerable<long>
{
public static readonly long[] Value=A051138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051138.Bytes);
public long this[int i]=>Value[i];

public static A051138Inst Instance=new A051138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051139
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,7L,19L,64L,236L,893L,3489L,14347L,62429L,285580L,1362372L,6749337L,34683211L,184774851L,1019351071L,5813020060L,34206071992L,207391313189L,1294092695729L,8302365433863L,54713262186745L,370027343460584L,2565874205681368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051139Inst : IEnumerable<long>
{
public static readonly long[] Value=A051139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051139.Bytes);
public long this[int i]=>Value[i];

public static A051139Inst Instance=new A051139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051140
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,8L,47L,259L,1437L,8208L,48659L,300553L,1937958L,13052028L,91784452L,673328720L,5146726651L,40934788112L,338292605257L,2900716040495L,25769979503573L,236876549095324L,2249873611378525L,22053647698650293L,222832106687369092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051140Inst : IEnumerable<long>
{
public static readonly long[] Value=A051140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051140.Bytes);
public long this[int i]=>Value[i];

public static A051140Inst Instance=new A051140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051141
{
public static readonly long[] Value={ 1L,-3L,1L,18L,-9L,1L,-162L,99L,-18L,1L,1944L,-1350L,315L,-30L,1L,-29160L,22194L,-6075L,765L,-45L,1L,524880L,-428652L,131544L,-19845L,1575L,-63L,1L,-11022480L,9526572L,-3191076L,548289L,-52920L,2898L,-84L,1L,264539520L,-239660208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051141Inst : IEnumerable<long>
{
public static readonly long[] Value=A051141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051141.Bytes);
public long this[int i]=>Value[i];

public static A051141Inst Instance=new A051141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051142
{
public static readonly long[] Value={ 1L,-4L,1L,32L,-12L,1L,-384L,176L,-24L,1L,6144L,-3200L,560L,-40L,1L,-122880L,70144L,-14400L,1360L,-60L,1L,2949120L,-1806336L,415744L,-47040L,2800L,-84L,1L,-82575360L,53526528L,-13447168L,1732864L,-125440L,5152L,-112L,1L,2642411520L,-1795424256L,483835904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051142Inst : IEnumerable<long>
{
public static readonly long[] Value=A051142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051142.Bytes);
public long this[int i]=>Value[i];

public static A051142Inst Instance=new A051142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051143
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,26L,2061L,702993L,307058572L,3350187739L,9088200428L,43794115173L,51932790219L,378210209388L,521301342188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051143Inst : IEnumerable<long>
{
public static readonly long[] Value=A051143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051143.Bytes);
public long this[int i]=>Value[i];

public static A051143Inst Instance=new A051143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A051144
{
public static readonly long[] Value={ 8L,12L,18L,20L,24L,27L,28L,32L,40L,44L,45L,48L,50L,52L,54L,56L,60L,63L,68L,72L,75L,76L,80L,84L,88L,90L,92L,96L,98L,99L,104L,108L,112L,116L,117L,120L,124L,125L,126L,128L,132L,135L,136L,140L,147L,148L,150L,152L,153L,156L,160L,162L,164L,168L,171L,172L,175L,176L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A051144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A051144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A051144Inst : IEnumerable<long>
{
public static readonly long[] Value=A051144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A051144.Bytes);
public long this[int i]=>Value[i];

public static A051144Inst Instance=new A051144Inst();

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