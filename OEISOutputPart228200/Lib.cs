using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278862
{
public static readonly long[] Value={ 157441L,177617L,178637L,226891L,374359L,900745L,1456223L,1526983L,1545227L,1817999L,2232815L,2274595L,2320643L,2336935L,2363383L,2404487L,2461559L,2536595L,2812451L,2877463L,2893769L,2910811L,2912446L,3046915L,3053999L,3090575L,3105319L,3382141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278862Inst : IEnumerable<long>
{
public static readonly long[] Value=A278862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278862.Bytes);
public long this[int i]=>Value[i];

public static A278862Inst Instance=new A278862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278863
{
public static readonly long[] Value={ 1L,0L,6L,1L,16L,7L,120L,71L,32L,991L,512L,255L,7552L,767L,31872L,11647L,119296L,48639L,475136L,190463L,1931264L,526335L,8241152L,2269183L,31285248L,2662399L,105283584L,99385343L,22249472L,1010302975L,319717376L,4095574015L,1278738432L,17054040063L,7262961664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278863Inst : IEnumerable<long>
{
public static readonly long[] Value=A278863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278863.Bytes);
public long this[int i]=>Value[i];

public static A278863Inst Instance=new A278863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278864
{
public static readonly BigInteger[] Value={ 1L,0L,11L,1000L,1L,111000L,11L,11111000L,1L,1111101100L,11L,111111001000L,11L,11111110001000L,1000001L,1111111111011100L,110001011L,111111110000101000L,11000111L,11111111111000000010UL,111111000L,BigInteger.Parse("1111111111110011010111"),1000010010L,BigInteger.Parse("111111111111010011000000") };
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
public class A278864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278864Inst Instance=new A278864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278865
{
public static readonly long[] Value={ 1L,0L,110L,1L,10000L,111L,1100000L,11111L,100000000L,11011111L,11000000000L,100111111L,1100000000000L,10001111111L,100000100000000L,11101111111111L,11010001100000000L,101000011111111L,1110001100000000000L,1000000011111111111L,111111000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278865Inst : IEnumerable<long>
{
public static readonly long[] Value=A278865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278865.Bytes);
public long this[int i]=>Value[i];

public static A278865Inst Instance=new A278865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278866
{
public static readonly long[] Value={ 1L,0L,3L,8L,1L,56L,3L,248L,1L,1004L,3L,4040L,3L,16264L,65L,65500L,395L,261160L,199L,1048066L,504L,4193495L,530L,16774336L,1331L,67100932L,3377L,268423174L,7568L,1073711175L,12048L,4294918753L,5658L,17179754562L,79930L,68719366802L,262154L,274877208450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278866Inst : IEnumerable<long>
{
public static readonly long[] Value=A278866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278866.Bytes);
public long this[int i]=>Value[i];

public static A278866Inst Instance=new A278866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278867
{
public static readonly long[] Value={ 1L,0L,6L,1L,16L,7L,96L,31L,256L,223L,1536L,319L,6144L,1151L,16640L,15359L,107264L,20735L,464896L,264191L,258048L,3854335L,2367488L,208895L,26820608L,8527871L,73760768L,100712447L,20381696L,948207615L,75104256L,2252537855L,2966421504L,4429840383L,12362973184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278867Inst : IEnumerable<long>
{
public static readonly long[] Value=A278867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278867.Bytes);
public long this[int i]=>Value[i];

public static A278867Inst Instance=new A278867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278868
{
public static readonly BigInteger[] Value={ 1L,1L,6183L,5772211367657472L,BigInteger.Parse("76148812142946816440318638031477145600000"),BigInteger.Parse("3940613226283843476344831941863494501303228636304800836707599745608602091520000000000") };
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
public class A278868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278868Inst Instance=new A278868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278869
{
public static readonly long[] Value={ 11L,23L,53L,173L,233L,593L,653L,1103L,1223L,2693L,2903L,2963L,4793L,5303L,6263L,6323L,7823L,9473L,10253L,11783L,12653L,13463L,15803L,20753L,25673L,27743L,27773L,29873L,31253L,33623L,38183L,38453L,39233L,40283L,41603L,44273L,44543L,54443L,54773L,59393L,60083L,62213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278869Inst : IEnumerable<long>
{
public static readonly long[] Value=A278869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278869.Bytes);
public long this[int i]=>Value[i];

public static A278869Inst Instance=new A278869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278870
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1111L,100L,110111L,0L,11110111L,0L,1111111101L,10001L,111111111111L,1010000L,11111101010111L,1010000L,1111111111011111L,100000100L,111111110101111111L,100010100L,11111111110101010111UL,101010000L,BigInteger.Parse("1111111111110101010101"),101010101L };
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
public class A278870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278870Inst Instance=new A278870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278871
{
public static readonly ulong[] Value={ 1L,10L,100L,1111L,100L,111011L,0L,11101111L,0L,1011111111L,10001000000L,111111111111L,101000000L,11101010111111L,10100000000L,1111101111111111L,100000100000000L,111111101011111111L,10100010000000000L,11101010101111111111UL,10101000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278871Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278871.Bytes);
public ulong this[int i]=>Value[i];

public static A278871Inst Instance=new A278871Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278872
{
public static readonly long[] Value={ 1L,1L,1L,15L,4L,55L,0L,247L,0L,1021L,17L,4095L,80L,16215L,80L,65503L,260L,261503L,276L,1047895L,336L,4193621L,341L,16774485L,1365L,67108181L,4437L,268432725L,17749L,1073700181L,16725L,4294964565L,66901L,17179737429L,20821L,68719301973L,87381L,274877863253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278872Inst : IEnumerable<long>
{
public static readonly long[] Value=A278872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278872.Bytes);
public long this[int i]=>Value[i];

public static A278872Inst Instance=new A278872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278873
{
public static readonly long[] Value={ 1L,2L,4L,15L,4L,59L,0L,239L,0L,767L,1088L,4095L,320L,15039L,1280L,64511L,16640L,260863L,82944L,961535L,86016L,2797567L,5586944L,11186175L,22364160L,44761087L,89407488L,178978815L,357842944L,716095487L,1430323200L,2863661055L,5725290496L,11458772991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278873Inst : IEnumerable<long>
{
public static readonly long[] Value=A278873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278873.Bytes);
public long this[int i]=>Value[i];

public static A278873Inst Instance=new A278873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278874
{
public static readonly long[] Value={ 1L,1L,1L,7L,25L,50L,155L,508L,1343L,3800L,11438L,32525L,92333L,268766L,774302L,2216976L,6392865L,18425916L,52958070L,152425812L,438973764L,1263109849L,3634965137L,10463959311L,30116734921L,86675829307L,249478723992L,718056248229L,2066658063664L,5948257601097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278874Inst : IEnumerable<long>
{
public static readonly long[] Value=A278874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278874.Bytes);
public long this[int i]=>Value[i];

public static A278874Inst Instance=new A278874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278875
{
public static readonly long[] Value={ 1L,1L,7L,50L,311L,1954L,11914L,76003L,467221L,2943211L,18261840L,114360149L,712196192L,4449548684L,27749537725L,173227638835L,1080825788517L,6745415139188L,42092502492537L,262680587755837L,1639226363457986L,10229514197548963L,63836523795617745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278875Inst : IEnumerable<long>
{
public static readonly long[] Value=A278875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278875.Bytes);
public long this[int i]=>Value[i];

public static A278875Inst Instance=new A278875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278876
{
public static readonly BigInteger[] Value={ 1L,1L,25L,311L,4101L,56864L,728857L,9616962L,127040707L,1669454156L,22011707486L,289906000417L,3817261693883L,50281947199556L,662232832054368L,8721984517729672L,114875834939622917L,1512983475914685706L,BigInteger.Parse("19927016855891011234"),BigInteger.Parse("262452496836729312910") };
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
public class A278876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278876Inst Instance=new A278876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278877
{
public static readonly BigInteger[] Value={ 1L,3L,155L,11914L,728857L,42238426L,2492016728L,147382229321L,8704392890599L,514207059584879L,30367424047335204L,1793195869965086337L,BigInteger.Parse("105893252956708204722"),BigInteger.Parse("6253339527216096201144"),BigInteger.Parse("369279138864066223011929"),BigInteger.Parse("21807048314051213226593407") };
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
public class A278877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278877Inst Instance=new A278877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278878
{
public static readonly BigInteger[] Value={ 1L,4L,508L,76003L,9616962L,1178422563L,147382229321L,18446349150367L,2306845502243104L,288660593026069762L,BigInteger.Parse("36110872742261362007"),BigInteger.Parse("4516714276347536995415"),BigInteger.Parse("564976767651757484324113"),BigInteger.Parse("70671912291059592748455901"),BigInteger.Parse("8840222401663200361818980813") };
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
public class A278878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278878Inst Instance=new A278878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278879
{
public static readonly BigInteger[] Value={ 1L,1L,5L,52L,931L,25516L,992799L,52032702L,3533592843L,301810098928L,31663565386063L,4002675000842794L,600053009189628075L,BigInteger.Parse("105257275528784647932"),BigInteger.Parse("21358127184625653306447"),BigInteger.Parse("4963922750189468652517318"),BigInteger.Parse("1310048479903507430878396651"),BigInteger.Parse("389626915538187147603694911208"),BigInteger.Parse("129712358816242576287065101448751"),BigInteger.Parse("48047325215595869387366562525477954") };
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
public class A278879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278879Inst Instance=new A278879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278880
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,14L,14L,1L,1L,30L,81L,30L,1L,1L,55L,308L,308L,55L,1L,1L,91L,910L,1872L,910L,91L,1L,1L,140L,2268L,8250L,8250L,2268L,140L,1L,1L,204L,4998L,29172L,51425L,29172L,4998L,204L,1L,1L,285L,10032L,87780L,247247L,247247L,87780L,10032L,285L,1L,1L,385L,18711L,233376L,980980L,1565109L,980980L,233376L,18711L,385L,1L,1L,506L,32890L,562419L,3354780L,7970144L,7970144L,3354780L,562419L,32890L,506L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278880Inst : IEnumerable<long>
{
public static readonly long[] Value=A278880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278880.Bytes);
public long this[int i]=>Value[i];

public static A278880Inst Instance=new A278880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278881
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,8L,3L,0L,1L,20L,30L,4L,0L,1L,40L,147L,80L,5L,0L,1L,70L,504L,672L,175L,6L,0L,1L,112L,1386L,3600L,2310L,336L,7L,0L,1L,168L,3276L,14520L,18150L,6552L,588L,8L,0L,1L,240L,6930L,48048L,102245L,72072L,16170L,960L,9L,0L,1L,330L,13464L,137280L,455455L,546546L,240240L,35904L,1485L,10L,0L,1L,440L,24453L,350064L,1701700L,3179904L,2382380L,700128L,73359L,2200L,11L,0L,1L,572L,42042L,815100L,5542680L,15148224L,17672928L,8868288L,1833975L,140140L,3146L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278881Inst : IEnumerable<long>
{
public static readonly long[] Value=A278881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278881.Bytes);
public long this[int i]=>Value[i];

public static A278881Inst Instance=new A278881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278882
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,3L,8L,1L,0L,4L,30L,20L,1L,0L,5L,80L,147L,40L,1L,0L,6L,175L,672L,504L,70L,1L,0L,7L,336L,2310L,3600L,1386L,112L,1L,0L,8L,588L,6552L,18150L,14520L,3276L,168L,1L,0L,9L,960L,16170L,72072L,102245L,48048L,6930L,240L,1L,0L,10L,1485L,35904L,240240L,546546L,455455L,137280L,13464L,330L,1L,0L,11L,2200L,73359L,700128L,2382380L,3179904L,1701700L,350064L,24453L,440L,1L,0L,12L,3146L,140140L,1833975L,8868288L,17672928L,15148224L,5542680L,815100L,42042L,572L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278882Inst : IEnumerable<long>
{
public static readonly long[] Value=A278882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278882.Bytes);
public long this[int i]=>Value[i];

public static A278882Inst Instance=new A278882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278883
{
public static readonly BigInteger[] Value={ 1L,5L,81L,1872L,51425L,1565109L,50979600L,1742711616L,61765676577L,2251396558125L,83924761860225L,3186277484832000L,122829049870699536L,4796448751641900752L,BigInteger.Parse("189381233826675892800"),BigInteger.Parse("7549371503605704934656"),BigInteger.Parse("303473219026059360959265"),BigInteger.Parse("12289574902507266828093525"),BigInteger.Parse("500960076377670398672062425"),BigInteger.Parse("20540854991655352005504930000"),BigInteger.Parse("846696245823312839372671355025"),BigInteger.Parse("35068049224094584278339245227125"),BigInteger.Parse("1458752047374053912228252043321600") };
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
public class A278883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278883Inst Instance=new A278883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278884
{
public static readonly BigInteger[] Value={ 1L,2L,30L,672L,18150L,546546L,17672928L,600935040L,21212454582L,770748371250L,28657235757150L,1085694550387200L,41778588391394400L,1628982594897249312L,BigInteger.Parse("64234570537702934400"),BigInteger.Parse("2557710564063135005184"),BigInteger.Parse("102714012593435476016982"),BigInteger.Parse("4155894894567674772785250"),BigInteger.Parse("169274181059121504574121550"),BigInteger.Parse("6935873114065443534326340000"),BigInteger.Parse("285716428631735196825345889350"),BigInteger.Parse("11826871503027977442890882704050"),BigInteger.Parse("491714173272153004121882711232000") };
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
public class A278884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278884Inst Instance=new A278884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278885
{
public static readonly long[] Value={ -1L,1L,0L,0L,0L,0L,1L,-3L,2L,-2L,3L,-1L,0L,2L,-8L,6L,6L,-8L,2L,0L,-1L,11L,-20L,44L,-104L,104L,-44L,20L,-11L,1L,0L,-10L,100L,-150L,-70L,130L,130L,-70L,-150L,100L,-10L,0L,1L,-43L,142L,-466L,2245L,-5423L,7480L,-7480L,5423L,-2245L,466L,-142L,43L,-1L,0L,42L,-1008L,2646L,-462L,4704L,-23730L,17808L,17808L,-23730L,4704L,-462L,2646L,-1008L,42L,0L,-1L,171L,-1040L,3888L,-45138L,215718L,-501504L,720816L,-790524L,790524L,-720816L,501504L,-215718L,45138L,-3888L,1040L,-171L,1L,0L,-170L,9500L,-42150L,38990L,-422070L,2104870L,-3396830L,1821030L,-113170L,-113170L,1821030L,-3396830L,2104870L,-422070L,38990L,-42150L,9500L,-170L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278885Inst : IEnumerable<long>
{
public static readonly long[] Value=A278885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278885.Bytes);
public long this[int i]=>Value[i];

public static A278885Inst Instance=new A278885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278886
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,2L,-4L,2L,0L,0L,0L,0L,-7L,15L,-8L,2L,-3L,1L,0L,0L,0L,-20L,50L,-20L,-10L,-30L,40L,-10L,0L,0L,0L,0L,61L,-281L,520L,-634L,594L,-304L,34L,0L,11L,-1L,0L,0L,0L,182L,-504L,-378L,952L,2436L,-4956L,2296L,-168L,462L,-364L,42L,0L,0L,0L,0L,-547L,4915L,-16368L,29530L,-36853L,42411L,-50908L,49144L,-27669L,5857L,668L,-138L,-43L,1L,0L,0L,0L,-1640L,4750L,28120L,-84310L,-19450L,223880L,-233510L,255040L,-430280L,369410L,-115840L,6830L,-6110L,3280L,-170L,0L,0L,0L,0L,4921L,-82461L,428240L,-1018098L,1757028L,-4061298L,8799414L,-11619696L,8677464L,-4315854L,2941956L,-2402754L,1032888L,-121338L,-22482L,1900L,171L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278886Inst : IEnumerable<long>
{
public static readonly long[] Value=A278886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278886.Bytes);
public long this[int i]=>Value[i];

public static A278886Inst Instance=new A278886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278887
{
public static readonly long[] Value={ 1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,-2L,4L,-2L,0L,0L,0L,1L,-3L,2L,-8L,15L,-7L,0L,0L,0L,0L,10L,-40L,30L,10L,20L,-50L,20L,0L,0L,0L,-1L,11L,0L,34L,-304L,594L,-634L,520L,-281L,61L,0L,0L,0L,0L,-42L,364L,-462L,168L,-2296L,4956L,-2436L,-952L,378L,504L,-182L,0L,0L,0L,1L,-43L,-138L,668L,5857L,-27669L,49144L,-50908L,42411L,-36853L,29530L,-16368L,4915L,-547L,0L,0L,0L,0L,170L,-3280L,6110L,-6830L,115840L,-369410L,430280L,-255040L,233510L,-223880L,19450L,84310L,-28120L,-4750L,1640L,0L,0L,0L,-1L,171L,1900L,-22482L,-121338L,1032888L,-2402754L,2941956L,-4315854L,8677464L,-11619696L,8799414L,-4061298L,1757028L,-1018098L,428240L,-82461L,4921L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278887Inst : IEnumerable<long>
{
public static readonly long[] Value=A278887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278887.Bytes);
public long this[int i]=>Value[i];

public static A278887Inst Instance=new A278887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278888
{
public static readonly BigInteger[] Value={ 1L,0L,-2L,6L,104L,130L,-7480L,17808L,790524L,-113170L,-206401200L,259762932L,53140218296L,-111175815660L,-24172057073456L,25301079682096L,12946893572092052L,-32517981767052650L,-8943735216460534192L,16410991703475470220UL,BigInteger.Parse("7930971475493259708440"),BigInteger.Parse("-19662403949243519946900"),BigInteger.Parse("-8179625437444893103218320"),BigInteger.Parse("21740998917740950059114560"),BigInteger.Parse("10426747097560071845593768504"),BigInteger.Parse("-28225693942184808133067863860"),BigInteger.Parse("-15345614872626105712148352012640") };
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
public class A278888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278888Inst Instance=new A278888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278889
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2L,15L,-20L,-634L,2436L,42411L,-233510L,-11619696L,49163400L,2036481646L,-16025646000L,-918152531964L,5815779836440L,409507398512787L,-3500207461700030L,-252977369776337212L,2287457363619598128L,BigInteger.Parse("206314648049383192746"),BigInteger.Parse("-2015385286805661512720"),BigInteger.Parse("-189234286870610655433500"),BigInteger.Parse("2114103576405833262908120"),BigInteger.Parse("225453932801460863956791550"),BigInteger.Parse("-2618254080140270392494246300"),BigInteger.Parse("-303684082923060566479507972944") };
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
public class A278889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278889Inst Instance=new A278889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278890
{
public static readonly long[] Value={ 0L,0L,161L,12392L,389640L,7709668L,112188011L,1300739542L,12621192562L,105953411156L,788164855062L,5289150309598L,32465951875890L,184286234335846L,975907732553934L,4856388450986535L,22846263739979319L,102119704122961051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278890Inst : IEnumerable<long>
{
public static readonly long[] Value=A278890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278890.Bytes);
public long this[int i]=>Value[i];

public static A278890Inst Instance=new A278890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278891
{
public static readonly BigInteger[] Value={ 0L,161L,52424L,6888340L,518626568L,27351484380L,1123462079180L,38208069702548L,1117773552649752L,28854012889071265L,669117722718849452L,14125545954412619268UL,BigInteger.Parse("274254133053070192532"),BigInteger.Parse("4937202122626940281323") };
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
public class A278891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278891Inst Instance=new A278891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278892
{
public static readonly BigInteger[] Value={ 1L,12392L,6888340L,2058210408L,430110958155L,69420349158080L,9164480794983836L,1029371666008338780L,BigInteger.Parse("101224646155024674325"),BigInteger.Parse("8900210716755685218198"),BigInteger.Parse("710786174826504133948822"),BigInteger.Parse("52173165758812211838931296") };
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
public class A278892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278892Inst Instance=new A278892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278893
{
public static readonly BigInteger[] Value={ 56L,389640L,518626568L,430110958155L,273949132717772L,143827898685401892L,BigInteger.Parse("64434873104394812016"),BigInteger.Parse("25210227731914720632036"),BigInteger.Parse("8773051977547229666591720"),BigInteger.Parse("2756820326309288648206048280"),BigInteger.Parse("792154472658215852314325527168") };
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
public class A278893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278893Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278893.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278893Inst Instance=new A278893Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278894
{
public static readonly BigInteger[] Value={ 728L,7709668L,27351484380L,69420349158080L,143827898685401892L,BigInteger.Parse("255381654976413401664"),BigInteger.Parse("398752554782396916414790"),BigInteger.Parse("556345120757052440184428640"),BigInteger.Parse("701731665791093785660064537242") };
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
public class A278894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278894Inst Instance=new A278894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278895
{
public static readonly BigInteger[] Value={ 5328L,112188011L,1123462079180L,9164480794983836L,BigInteger.Parse("64434873104394812016"),BigInteger.Parse("398752554782396916414790"),BigInteger.Parse("2211397160341361569598762016"),BigInteger.Parse("11141678773570596201916524869758") };
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
public class A278895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278895Inst Instance=new A278895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278896
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,161L,161L,1L,56L,12392L,52424L,12392L,56L,728L,389640L,6888340L,6888340L,389640L,728L,5328L,7709668L,518626568L,2058210408L,518626568L,7709668L,5328L,27876L,112188011L,27351484380L,430110958155L,430110958155L,27351484380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278896Inst : IEnumerable<long>
{
public static readonly long[] Value=A278896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278896.Bytes);
public long this[int i]=>Value[i];

public static A278896Inst Instance=new A278896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278897
{
public static readonly BigInteger[] Value={ 1L,1L,14L,146275425484L,BigInteger.Parse("558429168112511379835233509679413804180016") };
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
public class A278897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278897Inst Instance=new A278897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278898
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1111L,100L,110111L,0L,11110111L,10100L,1111010111L,10100L,111111110111L,1010100L,11111101010111L,1010100L,1111111111010111L,101010100L,111111110101010111L,101010100L,11111111111101010111UL,10101010100L,BigInteger.Parse("1111111111010101010111"),10101010100L };
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
public class A278898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278898Inst Instance=new A278898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278899
{
public static readonly ulong[] Value={ 1L,10L,100L,1111L,100L,111011L,0L,11101111L,1010000L,1110101111L,101000000L,111011111111L,10101000000L,11101010111111L,1010100000000L,1110101111111111L,101010100000000L,111010101011111111L,10101010000000000L,11101010111111111111UL,1010101010000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278899Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278899.Bytes);
public ulong this[int i]=>Value[i];

public static A278899Inst Instance=new A278899Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278900
{
public static readonly long[] Value={ 1L,1L,1L,15L,4L,55L,0L,247L,20L,983L,20L,4087L,84L,16215L,84L,65495L,340L,261463L,340L,1048407L,1364L,4191575L,1364L,16776535L,5460L,67097943L,5460L,268432727L,21844L,1073698135L,21844L,4294956375L,87380L,17179694423L,87380L,68719433047L,349524L,274877207895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278900Inst : IEnumerable<long>
{
public static readonly long[] Value=A278900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278900.Bytes);
public long this[int i]=>Value[i];

public static A278900Inst Instance=new A278900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278901
{
public static readonly long[] Value={ 1L,2L,4L,15L,4L,59L,0L,239L,80L,943L,320L,3839L,1344L,15039L,5376L,60415L,21760L,240383L,87040L,962559L,349184L,3845119L,1396736L,15384575L,5591040L,61517823L,22364160L,246087679L,89473024L,984268799L,357892096L,3937140735L,1431633920L,15748235263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278901Inst : IEnumerable<long>
{
public static readonly long[] Value=A278901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278901.Bytes);
public long this[int i]=>Value[i];

public static A278901Inst Instance=new A278901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278902
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,8L,12L,24L,28L,40L,48L,68L,72L,100L,120L,132L,144L,188L,208L,252L,280L,304L,336L,396L,416L,464L,512L,556L,592L,668L,704L,776L,844L,900L,960L,1020L,1056L,1148L,1240L,1308L,1348L,1456L,1524L,1628L,1728L,1792L,1872L,2004L,2080L,2188L,2292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278902Inst : IEnumerable<long>
{
public static readonly long[] Value=A278902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278902.Bytes);
public long this[int i]=>Value[i];

public static A278902Inst Instance=new A278902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278903
{
public static readonly BigInteger[] Value={ 1L,1L,20922L,BigInteger.Parse("96938760190744854628604"),BigInteger.Parse("1039473181175725249030299777705981025900981837012416973957739853576960") };
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
public class A278903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278903Inst Instance=new A278903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278904
{
public static readonly BigInteger[] Value={ 1L,0L,11L,1000L,11L,111100L,1001L,11101110L,10000L,1111001111L,110100L,111110000111L,111000L,11111111000111L,10011000L,1111111010100011L,100111100L,111111110110011001L,1000000010L,11111111100111111100UL,11001000001L,BigInteger.Parse("1111111111000110011110"),10001001000L };
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
public class A278904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278904Inst Instance=new A278904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278905
{
public static readonly BigInteger[] Value={ 1L,0L,110L,1L,11000L,1111L,1001000L,1110111L,10000L,1111001111L,101100000L,111000011111L,1110000000L,11100011111111L,110010000000L,1100010101111111L,111100100000000L,100110011011111111L,100000001000000000L,111111100111111111L,BigInteger.Parse("100000100110000000000") };
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
public class A278905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278905Inst Instance=new A278905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278906
{
public static readonly long[] Value={ 1L,0L,6L,1L,24L,15L,72L,119L,16L,975L,352L,3615L,896L,14591L,3200L,50559L,30976L,157439L,131584L,260607L,1068032L,1991679L,593920L,16687103L,6868992L,51654655L,9641984L,226598911L,16302080L,1013858303L,100859904L,4092723199L,429719552L,15166799871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278906Inst : IEnumerable<long>
{
public static readonly long[] Value=A278906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278906.Bytes);
public long this[int i]=>Value[i];

public static A278906Inst Instance=new A278906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278907
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278907Inst : IEnumerable<long>
{
public static readonly long[] Value=A278907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278907.Bytes);
public long this[int i]=>Value[i];

public static A278907Inst Instance=new A278907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278908
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278908Inst : IEnumerable<long>
{
public static readonly long[] Value=A278908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278908.Bytes);
public long this[int i]=>Value[i];

public static A278908Inst Instance=new A278908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278909
{
public static readonly long[] Value={ 15L,51L,55L,85L,125L,159L,185L,190L,205L,215L,222L,238L,246L,249L,253L,287L,303L,319L,374L,407L,438L,442L,469L,471L,475L,489L,494L,501L,507L,591L,623L,639L,670L,679L,687L,699L,730L,745L,755L,763L,765L,771L,799L,807L,822L,830L,843L,867L,890L,893L,917L,923L,925L,935L,939L,951L,970L,973L,979L,986L,989L,995L,1010L,1015L,1017L,1020L,1023L,1135L,1167L,1203L,1243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278909Inst : IEnumerable<long>
{
public static readonly long[] Value=A278909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278909.Bytes);
public long this[int i]=>Value[i];

public static A278909Inst Instance=new A278909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278910
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,2L,3L,5L,9L,3L,4L,7L,20L,25L,4L,5L,9L,35L,83L,65L,5L,6L,11L,54L,195L,326L,161L,6L,7L,13L,77L,379L,1027L,1217L,385L,7L,8L,15L,104L,653L,2504L,5123L,4376L,897L,8L,9L,17L,135L,1035L,5189L,15629L,24579L,15311L,2049L,9L,10L,19L,170L,1543L,9610L,38885L,93754L,114691L,52490L,4609L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278910Inst : IEnumerable<long>
{
public static readonly long[] Value=A278910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278910.Bytes);
public long this[int i]=>Value[i];

public static A278910Inst Instance=new A278910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278911
{
public static readonly long[] Value={ 9L,25L,289L,729L,1681L,2401L,3481L,5041L,7921L,10201L,15625L,17161L,27889L,28561L,29929L,83521L,85849L,146689L,279841L,458329L,491401L,531441L,552049L,579121L,597529L,683929L,703921L,707281L,734449L,829921L,1190281L,1203409L,1352569L,1394761L,1423249L,1481089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278911Inst : IEnumerable<long>
{
public static readonly long[] Value=A278911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278911.Bytes);
public long this[int i]=>Value[i];

public static A278911Inst Instance=new A278911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278912
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,2L,4L,3L,4L,4L,3L,5L,5L,5L,6L,5L,6L,8L,7L,8L,9L,8L,10L,11L,10L,12L,12L,13L,15L,14L,16L,17L,17L,19L,20L,20L,22L,24L,24L,26L,27L,28L,31L,31L,33L,36L,35L,39L,42L,41L,45L,47L,48L,53L,54L,55L,60L,61L,65L,69L,69L,74L,78L,80L,85L,88L,90L,96L,101L,104L,109L,113L,117L,124L,128L,133L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278912Inst : IEnumerable<long>
{
public static readonly long[] Value=A278912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278912.Bytes);
public long this[int i]=>Value[i];

public static A278912Inst Instance=new A278912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278913
{
public static readonly BigInteger[] Value={ 2L,4L,16L,64L,9765625L,4096L,65536L,262144L,BigInteger.Parse("1471383076677527699142172838322885948765175969"),BigInteger.Parse("10264895304762966931257013446474591264089923314972889033759201"),1073741824L,BigInteger.Parse("18701397461209715023927088008788055619800417991632621566284510161") };
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
public class A278913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278913Inst Instance=new A278913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278914
{
public static readonly BigInteger[] Value={ 9L,2401L,729L,9765625L,531441L,45949729863572161L,5559917313492231481L,BigInteger.Parse("1471383076677527699142172838322885948765175969"),BigInteger.Parse("10264895304762966931257013446474591264089923314972889033759201"),BigInteger.Parse("230466617897195215045509519405933293401") };
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
public class A278914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278914Inst Instance=new A278914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278915
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1111L,100L,110111L,0L,11111111L,10000L,1111010111L,10000L,111111110111L,1000000L,11111101011111L,1000000L,1111111111111111L,101010000L,111111110101010111L,101010000L,11111111111111010111UL,10000010000L,BigInteger.Parse("1111111111010111110111"),10001000000L,BigInteger.Parse("111111111111111101111111"),1010000010000L };
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
public class A278915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278915Inst Instance=new A278915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278916
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1111L,100L,111011L,0L,11111111L,10000L,1110101111L,1000000L,111011111111L,1000000L,11111010111111L,100000000L,1111111111111111L,1010100000000L,111010101011111111L,101010000000000L,11101011111111111111UL,10000010000000000L,BigInteger.Parse("1110111110101111111111"),BigInteger.Parse("100000101000000000000") };
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
public class A278916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278916Inst Instance=new A278916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278917
{
public static readonly long[] Value={ 1L,1L,1L,15L,4L,55L,0L,255L,16L,983L,16L,4087L,64L,16223L,64L,65535L,336L,261463L,336L,1048535L,1040L,4191735L,1088L,16777087L,5136L,67098583L,4368L,268433279L,16404L,1073700855L,16448L,4294967167L,86016L,17179695103L,86016L,68719474687L,278868L,274877243223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278917Inst : IEnumerable<long>
{
public static readonly long[] Value=A278917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278917.Bytes);
public long this[int i]=>Value[i];

public static A278917Inst Instance=new A278917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278918
{
public static readonly long[] Value={ 1L,2L,4L,15L,4L,59L,0L,255L,16L,943L,64L,3839L,64L,16063L,256L,65535L,5376L,240383L,21504L,966655L,66560L,3927039L,69632L,16711679L,1069056L,61845503L,4472832L,267321343L,83902464L,1006551039L,16842752L,4278190079L,1376256L,17174298623L,5505024L,68702699519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278918Inst : IEnumerable<long>
{
public static readonly long[] Value=A278918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278918.Bytes);
public long this[int i]=>Value[i];

public static A278918Inst Instance=new A278918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278919
{
public static readonly long[] Value={ 3L,4L,5L,17L,26L,257L,65537L,4294967297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278919Inst : IEnumerable<long>
{
public static readonly long[] Value=A278919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278919.Bytes);
public long this[int i]=>Value[i];

public static A278919Inst Instance=new A278919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278920
{
public static readonly long[] Value={ 1L,7L,17L,33L,6359L,6363L,6371L,6385L,6443L,6445L,6451L,6465L,6525L,6527L,6563L,6565L,6569L,6571L,6573L,6693L,6917L,6923L,6925L,6965L,6967L,7003L,7011L,7337L,7365L,7367L,7369L,7383L,7403L,7705L,7711L,7763L,7769L,7773L,7775L,7789L,7799L,7801L,7809L,7811L,7821L,7823L,7827L,7829L,7855L,7895L,7899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278920Inst : IEnumerable<long>
{
public static readonly long[] Value=A278920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278920.Bytes);
public long this[int i]=>Value[i];

public static A278920Inst Instance=new A278920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278921
{
public static readonly long[] Value={ 10L,15L,65L,221L,493L,671L,1147L,1219L,3439L,5069L,12209L,14893L,20737L,24503L,30083L,49813L,61937L,77507L,91277L,97297L,100337L,102719L,109283L,109783L,113521L,132427L,144301L,178991L,204851L,244523L,245041L,246559L,257149L,258749L,312167L,339497L,397219L,433091L,434617L,461893L,465763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278921Inst : IEnumerable<long>
{
public static readonly long[] Value=A278921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278921.Bytes);
public long this[int i]=>Value[i];

public static A278921Inst Instance=new A278921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278922
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,2L,3L,2L,0L,2L,3L,2L,3L,2L,5L,2L,5L,2L,3L,2L,5L,2L,7L,2L,5L,2L,7L,2L,7L,2L,7L,2L,11L,2L,11L,2L,5L,2L,11L,2L,13L,2L,11L,2L,13L,2L,13L,2L,11L,2L,17L,2L,13L,2L,13L,2L,17L,2L,17L,2L,17L,2L,19L,2L,19L,2L,13L,2L,17L,2L,19L,2L,17L,2L,23L,2L,19L,2L,19L,2L,23L,2L,23L,2L,23L,2L,23L,2L,29L,2L,23L,2L,29L,2L,29L,2L,23L,2L,29L,2L,31L,2L,31L,2L,29L,2L,31L,2L,29L,2L,31L,2L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278922Inst : IEnumerable<long>
{
public static readonly long[] Value=A278922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278922.Bytes);
public long this[int i]=>Value[i];

public static A278922Inst Instance=new A278922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278923
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,0L,3L,3L,5L,5L,3L,5L,7L,5L,7L,7L,7L,11L,11L,5L,11L,13L,11L,13L,13L,11L,17L,13L,13L,17L,17L,17L,19L,19L,13L,17L,19L,17L,23L,19L,19L,23L,23L,23L,23L,29L,23L,29L,29L,23L,29L,31L,31L,29L,31L,29L,31L,37L,29L,37L,37L,31L,41L,37L,31L,41L,37L,41L,43L,41L,41L,43L,43L,41L,43L,43L,47L,47L,43L,41L,47L,43L,47L,53L,47L,47L,53L,53L,53L,53L,59L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278923Inst : IEnumerable<long>
{
public static readonly long[] Value=A278923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278923.Bytes);
public long this[int i]=>Value[i];

public static A278923Inst Instance=new A278923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278924
{
public static readonly BigInteger[] Value={ 4L,296L,36772L,1288688L,96641548L,26576092808L,8637277012172L,1079658805128928L,91770997994914276L,BigInteger.Parse("43591225139846360008") };
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
public class A278924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278924.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278924Inst Instance=new A278924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278925
{
public static readonly BigInteger[] Value={ 1L,2L,113L,38736L,46311652L,143820883800L,966462062838180L,12412328008727861760UL,BigInteger.Parse("278484670746890475310656"),BigInteger.Parse("10197331743850942940587152000"),BigInteger.Parse("577793817845799602600135280168000"),BigInteger.Parse("48534819511412868687827815575204633600"),BigInteger.Parse("5834998526939444017550860154062183732711680") };
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
public class A278925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278925Inst Instance=new A278925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278926
{
public static readonly BigInteger[] Value={ 1L,2L,353L,561608L,4341274884L,111107400842568L,7493918659070379300L,BigInteger.Parse("1139021252689549522419840"),BigInteger.Parse("348457223545199873458486125120"),BigInteger.Parse("196982631587037086047232203674775680"),BigInteger.Parse("192443334239172066295878807351087122210880"),BigInteger.Parse("307899710379447999264505625949360598523097530880") };
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
public class A278926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278926Inst Instance=new A278926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278927
{
public static readonly BigInteger[] Value={ 1L,3L,38L,1116L,59392L,5004720L,613252320L,103050420480L,22752244279296L,6388491978086400L,2223423557203968000L,BigInteger.Parse("939489529945565491200"),BigInteger.Parse("473789563269835667374080"),BigInteger.Parse("281112352557447776249364480"),BigInteger.Parse("193857685859605294233907200000"),BigInteger.Parse("153758529080702011472247521280000") };
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
public class A278927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278927Inst Instance=new A278927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278928
{
public static readonly long[] Value={ 1L,5L,5L,3L,7L,7L,3L,9L,7L,4L,0L,3L,0L,0L,3L,7L,3L,0L,7L,3L,4L,4L,1L,5L,8L,9L,5L,3L,0L,6L,3L,1L,4L,6L,9L,4L,8L,1L,6L,4L,5L,8L,3L,4L,9L,9L,4L,1L,0L,3L,0L,7L,8L,3L,6L,3L,3L,2L,6L,7L,1L,1L,4L,8L,3L,3L,3L,6L,7L,5L,2L,5L,6L,7L,8L,8L,7L,3L,3L,1L,0L,2L,7L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278928Inst : IEnumerable<long>
{
public static readonly long[] Value=A278928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278928.Bytes);
public long this[int i]=>Value[i];

public static A278928Inst Instance=new A278928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278929
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,3L,0L,0L,0L,0L,1L,0L,0L,4L,0L,0L,1L,0L,1L,0L,0L,5L,0L,0L,3L,0L,1L,0L,0L,6L,0L,0L,6L,0L,1L,0L,0L,7L,0L,0L,10L,0L,1L,1L,0L,8L,0L,0L,15L,0L,1L,4L,0L,9L,0L,0L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278929Inst : IEnumerable<long>
{
public static readonly long[] Value=A278929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278929.Bytes);
public long this[int i]=>Value[i];

public static A278929Inst Instance=new A278929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278930
{
public static readonly long[] Value={ 2L,36L,100L,2081L,8257L,32897L,131329L,524801L,2098177L,8390657L,33558529L,134225921L,536887297L,2147516417L,8590000129L,34359869441L,137439215617L,549756338177L,2199024304129L,8796095119361L,35184376283137L,140737496743937L,562949970198529L,2251799847239681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278930Inst : IEnumerable<long>
{
public static readonly long[] Value=A278930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278930.Bytes);
public long this[int i]=>Value[i];

public static A278930Inst Instance=new A278930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278931
{
public static readonly long[] Value={ 25L,49L,65L,82L,106L,115L,118L,121L,142L,143L,155L,187L,209L,235L,254L,259L,262L,265L,274L,289L,299L,314L,319L,326L,334L,335L,341L,355L,361L,382L,398L,415L,445L,451L,454L,458L,469L,493L,511L,515L,538L,551L,562L,566L,583L,586L,589L,614L,622L,634L,649L,667L,679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278931Inst : IEnumerable<long>
{
public static readonly long[] Value=A278931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278931.Bytes);
public long this[int i]=>Value[i];

public static A278931Inst Instance=new A278931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278932
{
public static readonly long[] Value={ 1122659L,2164229L,2329469L,10257809L,10309889L,12314699L,14030309L,14145539L,19099919L,23103659L,24176129L,28843649L,37088729L,38199839L,42389519L,49160099L,50785439L,52554569L,62800169L,68718059L,85864769L,88174049L,95831189L,105109139L,105388169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278932Inst : IEnumerable<long>
{
public static readonly long[] Value=A278932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278932.Bytes);
public long this[int i]=>Value[i];

public static A278932Inst Instance=new A278932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278933
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,4L,8L,8L,12L,12L,20L,20L,24L,28L,32L,32L,40L,40L,48L,52L,56L,56L,68L,68L,72L,76L,84L,84L,96L,96L,104L,108L,112L,116L,128L,128L,132L,136L,148L,148L,160L,160L,168L,176L,180L,180L,196L,196L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278933Inst : IEnumerable<long>
{
public static readonly long[] Value=A278933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278933.Bytes);
public long this[int i]=>Value[i];

public static A278933Inst Instance=new A278933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278934
{
public static readonly BigInteger[] Value={ 1L,3L,29L,303L,3501L,42663L,538769L,6977547L,92078989L,1232902023L,16700233689L,228356672547L,3147087003201L,43659275921667L,609117615688149L,8539863624592023L,120242239301247309L,1699411957967345127L,BigInteger.Parse("24098616839012623769"),BigInteger.Parse("342754384909199620803") };
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
public class A278934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278934Inst Instance=new A278934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278935
{
public static readonly long[] Value={ 126L,84L,63L,3231L,42L,4154L,2143L,1143L,4105263158L,6440909347642L,21L,11L,2077L,1077L,18063L,1206L,16056L,105882353L,2052631579L,43304763L,3220454673821L,8044L,12042L,30411L,6039L,5037593985L,321603571507896L,5035L,14033492823L,3033L,17403126122889L,20713030303119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278935Inst : IEnumerable<long>
{
public static readonly long[] Value=A278935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278935.Bytes);
public long this[int i]=>Value[i];

public static A278935Inst Instance=new A278935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278936
{
public static readonly long[] Value={ 1331L,1030301L,1331000L,1003003001L,1030301000L,1331000000L,1000300030001L,1003003001000L,1030301000000L,1331000000000L,1000030000300001L,1000300030001000L,1003003001000000L,1030301000000000L,1331000000000000L,321302302131323213L,1000003000003000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278936Inst : IEnumerable<long>
{
public static readonly long[] Value=A278936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278936.Bytes);
public long this[int i]=>Value[i];

public static A278936Inst Instance=new A278936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278937
{
public static readonly long[] Value={ 11L,101L,110L,1001L,1010L,1100L,10001L,10010L,10100L,11000L,100001L,100010L,100100L,101000L,110000L,684917L,1000001L,1000010L,1000100L,1001000L,1010000L,1100000L,6849170L,10000001L,10000010L,10000100L,10001000L,10010000L,10100000L,11000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278937Inst : IEnumerable<long>
{
public static readonly long[] Value=A278937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278937.Bytes);
public long this[int i]=>Value[i];

public static A278937Inst Instance=new A278937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278938
{
public static readonly long[] Value={ 0L,1L,2L,20L,21L,3L,23L,4L,5L,24L,6L,7L,8L,25L,9L,10L,12L,11L,13L,14L,26L,15L,16L,17L,27L,18L,19L,30L,32L,31L,33L,34L,35L,42L,36L,37L,38L,39L,40L,28L,41L,43L,44L,45L,46L,29L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,62L,59L,60L,61L,63L,64L,65L,66L,200L,67L,68L,69L,70L,71L,73L,72L,74L,75L,76L,77L,78L,79L,80L,81L,201L,83L,84L,85L,86L,87L,88L,89L,82L,90L,91L,93L,94L,95L,96L,97L,98L,99L,203L,100L,101L,103L,104L,105L,102L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278938Inst : IEnumerable<long>
{
public static readonly long[] Value=A278938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278938.Bytes);
public long this[int i]=>Value[i];

public static A278938Inst Instance=new A278938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278939
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,40L,41L,5L,42L,6L,7L,43L,8L,9L,14L,10L,11L,24L,12L,13L,15L,45L,16L,17L,18L,46L,19L,20L,21L,34L,22L,23L,25L,26L,54L,27L,28L,29L,30L,31L,47L,32L,33L,35L,36L,37L,48L,38L,39L,50L,51L,52L,64L,53L,55L,56L,57L,58L,59L,74L,60L,61L,62L,63L,65L,66L,67L,49L,68L,69L,70L,71L,72L,73L,75L,400L,76L,77L,78L,79L,80L,81L,82L,401L,83L,85L,86L,87L,88L,89L,90L,84L,91L,92L,93L,95L,96L,97L,98L,99L,104L,100L,101L,102L,103L,105L,106L,94L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278939Inst : IEnumerable<long>
{
public static readonly long[] Value=A278939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278939.Bytes);
public long this[int i]=>Value[i];

public static A278939Inst Instance=new A278939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278940
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,50L,51L,6L,52L,7L,8L,53L,9L,10L,54L,11L,12L,56L,13L,14L,15L,16L,17L,18L,25L,19L,20L,21L,22L,57L,23L,24L,26L,27L,58L,28L,29L,30L,31L,35L,32L,33L,34L,36L,37L,45L,38L,39L,40L,41L,42L,43L,59L,44L,46L,47L,48L,49L,60L,500L,61L,62L,63L,64L,66L,67L,501L,68L,69L,70L,71L,72L,73L,65L,74L,76L,77L,78L,79L,80L,81L,82L,502L,83L,84L,86L,87L,88L,89L,90L,75L,91L,92L,93L,94L,96L,97L,98L,99L,105L,100L,101L,102L,103L,104L,106L,85L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278940Inst : IEnumerable<long>
{
public static readonly long[] Value=A278940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278940.Bytes);
public long this[int i]=>Value[i];

public static A278940Inst Instance=new A278940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278941
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,60L,61L,7L,62L,8L,9L,63L,10L,16L,11L,12L,26L,13L,14L,15L,64L,17L,18L,19L,65L,20L,21L,22L,36L,23L,24L,25L,27L,46L,28L,29L,30L,31L,32L,67L,33L,34L,35L,37L,38L,68L,39L,40L,41L,42L,43L,56L,44L,45L,47L,48L,49L,50L,76L,51L,52L,53L,54L,55L,57L,58L,69L,59L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278941Inst : IEnumerable<long>
{
public static readonly long[] Value=A278941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278941.Bytes);
public long this[int i]=>Value[i];

public static A278941Inst Instance=new A278941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278942
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,70L,71L,8L,72L,9L,17L,10L,11L,73L,12L,13L,74L,14L,15L,27L,16L,18L,19L,37L,20L,21L,22L,23L,75L,24L,25L,26L,28L,76L,29L,30L,31L,32L,47L,33L,34L,35L,36L,38L,57L,39L,40L,41L,42L,43L,44L,78L,45L,46L,48L,49L,50L,51L,79L,52L,53L,54L,55L,56L,58L,67L,59L,60L,61L,62L,63L,64L,65L,87L,66L,68L,69L,80L,81L,82L,83L,84L,700L,85L,86L,88L,89L,90L,91L,92L,97L,93L,94L,95L,96L,98L,99L,100L,101L,701L,102L,103L,104L,105L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278942Inst : IEnumerable<long>
{
public static readonly long[] Value=A278942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278942.Bytes);
public long this[int i]=>Value[i];

public static A278942Inst Instance=new A278942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278943
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,80L,81L,9L,82L,10L,83L,11L,18L,12L,13L,28L,14L,15L,16L,84L,17L,19L,20L,85L,21L,22L,23L,38L,24L,25L,26L,27L,48L,29L,30L,31L,32L,33L,86L,34L,35L,36L,37L,39L,87L,40L,41L,42L,43L,44L,58L,45L,46L,47L,49L,50L,51L,68L,52L,53L,54L,55L,56L,57L,59L,89L,60L,61L,62L,63L,64L,65L,66L,800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278943Inst : IEnumerable<long>
{
public static readonly long[] Value=A278943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278943.Bytes);
public long this[int i]=>Value[i];

public static A278943Inst Instance=new A278943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278944
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,90L,91L,19L,10L,29L,11L,12L,92L,13L,14L,93L,15L,16L,39L,17L,18L,20L,49L,21L,22L,23L,24L,94L,25L,26L,27L,28L,95L,30L,31L,32L,33L,59L,34L,35L,36L,37L,38L,69L,40L,41L,42L,43L,44L,45L,96L,46L,47L,48L,50L,51L,52L,97L,53L,54L,55L,56L,57L,58L,79L,60L,61L,62L,63L,64L,65L,66L,89L,67L,68L,70L,71L,72L,73L,74L,75L,98L,76L,77L,78L,80L,81L,82L,83L,84L,900L,85L,86L,87L,88L,100L,101L,109L,102L,103L,104L,105L,106L,107L,190L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278944Inst : IEnumerable<long>
{
public static readonly long[] Value=A278944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278944.Bytes);
public long this[int i]=>Value[i];

public static A278944Inst Instance=new A278944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278945
{
public static readonly long[] Value={ 0L,1L,7L,16L,35L,46L,88L,92L,155L,169L,242L,232L,392L,326L,476L,496L,651L,562L,871L,704L,1050L,968L,1184L,1036L,1640L,1271L,1658L,1600L,2044L,1654L,2528L,1892L,2667L,2392L,2846L,2552L,3731L,2702L,3560L,3344L,4330L,3322L,4904L,3656L,5040L,4654L,5228L,4372L,6696L,4845L,6417L,5728L,7042L,5566L,8080L,6272L,8380L,7160L,8330L,6904L,10752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278945Inst : IEnumerable<long>
{
public static readonly long[] Value=A278945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278945.Bytes);
public long this[int i]=>Value[i];

public static A278945Inst Instance=new A278945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278946
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,20L,110L,11L,30L,12L,120L,13L,14L,40L,15L,16L,130L,17L,18L,19L,50L,21L,22L,23L,140L,24L,25L,26L,27L,60L,28L,29L,31L,32L,150L,33L,34L,35L,36L,37L,70L,38L,39L,41L,42L,43L,160L,44L,45L,46L,47L,48L,49L,80L,51L,52L,53L,54L,55L,56L,170L,57L,58L,59L,61L,62L,63L,64L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278946Inst : IEnumerable<long>
{
public static readonly long[] Value=A278946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278946.Bytes);
public long this[int i]=>Value[i];

public static A278946Inst Instance=new A278946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278947
{
public static readonly long[] Value={ 0L,1L,8L,19L,42L,56L,107L,113L,190L,208L,298L,287L,483L,404L,589L,614L,806L,698L,1079L,875L,1302L,1202L,1471L,1289L,2035L,1581L,2062L,1990L,2541L,2060L,3142L,2357L,3318L,2978L,3544L,3178L,4641L,3368L,4435L,4166L,5390L,4142L,6106L,4559L,6279L,5798L,6517L,5453L,8339L,6042L,7998L,7142L,8778L,6944L,10070L,7822L,10445L,8930L,10390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278947Inst : IEnumerable<long>
{
public static readonly long[] Value=A278947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278947.Bytes);
public long this[int i]=>Value[i];

public static A278947Inst Instance=new A278947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278948
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,15L,21L,25L,49L,1261L,2449L,2701L,2881L,3006L,7486L,9265L,21583L,21809L,22663L,22987L,23707L,23711L,24257L,24613L,24797L,25021L,25217L,25283L,25807L,26123L,26167L,27331L,28199L,28417L,28841L,29143L,29503L,29747L,29987L,30227L,31133L,31313L,31459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278948Inst : IEnumerable<long>
{
public static readonly long[] Value=A278948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278948.Bytes);
public long this[int i]=>Value[i];

public static A278948Inst Instance=new A278948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278949
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,9L,9L,11L,11L,11L,12L,13L,13L,15L,15L,15L,16L,17L,17L,19L,20L,20L,23L,24L,24L,26L,27L,27L,30L,31L,31L,33L,34L,35L,38L,40L,40L,44L,45L,46L,49L,51L,51L,56L,57L,58L,61L,63L,64L,69L,72L,73L,78L,80L,81L,86L,89L,90L,96L,98L,99L,105L,108L,110L,116L,120L,121L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278949Inst : IEnumerable<long>
{
public static readonly long[] Value=A278949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278949.Bytes);
public long this[int i]=>Value[i];

public static A278949Inst Instance=new A278949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278950
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,3L,3L,5L,5L,5L,5L,6L,5L,6L,6L,6L,6L,6L,6L,7L,6L,6L,5L,7L,8L,8L,7L,7L,7L,6L,7L,8L,8L,8L,7L,8L,7L,7L,8L,9L,9L,9L,8L,10L,10L,11L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,13L,12L,12L,12L,12L,12L,12L,11L,11L,12L,13L,12L,13L,12L,13L,13L,13L,15L,15L,16L,16L,16L,15L,15L,16L,16L,16L,15L,15L,15L,15L,14L,15L,16L,15L,15L,15L,15L,14L,15L,15L,15L,16L,16L,16L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278950Inst : IEnumerable<long>
{
public static readonly long[] Value=A278950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278950.Bytes);
public long this[int i]=>Value[i];

public static A278950Inst Instance=new A278950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278951
{
public static readonly ulong[] Value={ 1L,11L,100L,1110L,10000L,111100L,1001010L,11111110L,100000000L,1111000000L,10010100000L,111111110000L,1000000001000L,11110000011100L,100101000100010L,1111111101110110L,10000000000000000L,111100000000000000L,1001010001010000000L,11111111011011000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278951Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278951.Bytes);
public ulong this[int i]=>Value[i];

public static A278951Inst Instance=new A278951Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278952
{
public static readonly BigInteger[] Value={ 1L,11L,1L,111L,1L,1111L,101001L,1111111L,1L,1111L,101001L,11111111L,1000000001L,111000001111L,10001000101001L,110111011111111L,1L,1111L,101000101001L,11011011111111L,1000000000000001L,111000000000001111L,10001000000000101001UL,BigInteger.Parse("1110111000000011111111") };
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
public class A278952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278952Inst Instance=new A278952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278953
{
public static readonly long[] Value={ 1L,3L,4L,14L,16L,60L,74L,254L,256L,960L,1184L,4080L,4104L,15388L,18978L,65398L,65536L,245760L,303744L,1046208L,1048608L,3932272L,4849800L,16712156L,16810658L,63030966L,77769160L,267890364L,268465546L,1007191646L,1243466176L,4280827440L,4310587848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278953Inst : IEnumerable<long>
{
public static readonly long[] Value=A278953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278953.Bytes);
public long this[int i]=>Value[i];

public static A278953Inst Instance=new A278953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278954
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,15L,41L,127L,1L,15L,41L,255L,513L,3599L,8745L,28415L,1L,15L,2601L,14079L,32769L,229391L,557097L,3899647L,9077249L,28675599L,10267177L,64446207L,171294721L,513295375L,30006313L,209458431L,657780225L,4052658703L,9070269993L,26967728895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278954Inst : IEnumerable<long>
{
public static readonly long[] Value=A278954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278954.Bytes);
public long this[int i]=>Value[i];

public static A278954Inst Instance=new A278954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278955
{
public static readonly BigInteger[] Value={ 1L,0L,11L,1000L,11L,111110L,1010L,11101000L,10111L,1111000100L,110011L,111110101110L,101010L,11111111000000L,10011111L,1111111011100000L,110001111L,111111110100101100L,111100011L,11111111111111111000UL,10010000011L,BigInteger.Parse("1111111111010110111110"),110000110010L };
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
public class A278955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278955Inst Instance=new A278955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278956
{
public static readonly BigInteger[] Value={ 1L,0L,110L,1L,11000L,11111L,101000L,10111L,111010000L,10001111L,11001100000L,11101011111L,101010000000L,11111111L,111110010000000L,11101111111L,11110001100000000L,1101001011111111L,1100011110000000000L,11111111111111111L,BigInteger.Parse("110000010010000000000") };
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
public class A278956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278956Inst Instance=new A278956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278957
{
public static readonly long[] Value={ 1L,0L,3L,8L,3L,62L,10L,232L,23L,964L,51L,4014L,42L,16320L,159L,65248L,399L,261420L,483L,1048568L,1155L,4191678L,3122L,16769996L,2185L,67106430L,10636L,268413987L,23528L,1073688591L,42988L,4294881395L,110504L,17179649295L,98680L,68719410775L,269768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278957Inst : IEnumerable<long>
{
public static readonly long[] Value=A278957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278957.Bytes);
public long this[int i]=>Value[i];

public static A278957Inst Instance=new A278957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278958
{
public static readonly long[] Value={ 1L,0L,6L,1L,24L,31L,40L,23L,464L,143L,1632L,1887L,2688L,255L,31872L,1919L,123648L,54015L,408576L,131071L,1582080L,2059263L,2496512L,3393535L,19013632L,33144831L,25993216L,205742079L,50020352L,1006845951L,468877312L,3456991231L,736821248L,16149446655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278958Inst : IEnumerable<long>
{
public static readonly long[] Value=A278958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278958.Bytes);
public long this[int i]=>Value[i];

public static A278958Inst Instance=new A278958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278959
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,3L,3L,4L,4L,4L,4L,6L,6L,8L,8L,8L,8L,10L,10L,12L,12L,12L,12L,14L,14L,14L,14L,14L,14L,16L,16L,18L,18L,18L,18L,18L,18L,20L,20L,20L,20L,22L,22L,24L,24L,24L,24L,26L,26L,26L,26L,26L,26L,28L,28L,28L,28L,28L,28L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278959Inst : IEnumerable<long>
{
public static readonly long[] Value=A278959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278959.Bytes);
public long this[int i]=>Value[i];

public static A278959Inst Instance=new A278959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278960
{
public static readonly long[] Value={ 4L,6L,7L,9L,43L,53L,67L,69L,123L,178L,201L,448L,649L,658L,1068L,2003L,2584L,4445L,4816L,6322L,8477L,8868L,14500L,24934L,33412L,42504L,87287L,87337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278960Inst : IEnumerable<long>
{
public static readonly long[] Value=A278960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278960.Bytes);
public long this[int i]=>Value[i];

public static A278960Inst Instance=new A278960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278961
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,5L,1L,2L,3L,4L,5L,6L,1L,2L,3L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,8L,1L,3L,4L,6L,7L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,5L,6L,7L,10L,11L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,3L,5L,9L,11L,13L,1L,2L,4L,7L,8L,11L,13L,14L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278961Inst : IEnumerable<long>
{
public static readonly long[] Value=A278961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278961.Bytes);
public long this[int i]=>Value[i];

public static A278961Inst Instance=new A278961Inst();

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