using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286176
{
public static readonly long[] Value={ 1L,2L,3L,7L,13L,14L,37L,38L,54L,60L,69L,668L,693L,825L,1275L,1566L,3129L,5745L,6439L,21991L,24992L,61947L,96722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286176Inst : IEnumerable<long>
{
public static readonly long[] Value=A286176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286176.Bytes);
public long this[int i]=>Value[i];

public static A286176Inst Instance=new A286176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286177
{
public static readonly long[] Value={ 1L,3L,8L,9L,14L,17L,29L,43L,48L,72L,78L,132L,312L,894L,968L,5030L,5108L,9008L,11989L,12903L,26767L,28159L,30564L,39619L,44250L,54537L,77427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286177Inst : IEnumerable<long>
{
public static readonly long[] Value=A286177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286177.Bytes);
public long this[int i]=>Value[i];

public static A286177Inst Instance=new A286177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286178
{
public static readonly BigInteger[] Value={ 35L,255255L,100280245065L,2152114239059719935L,BigInteger.Parse("1952792905443446363385953865"),BigInteger.Parse("40347439369046572433179287578305731225"),BigInteger.Parse("772786810821609466400679930812513688804332910188025"),BigInteger.Parse("73222791895598040395939625423986137213129917738912050041051075") };
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
public class A286178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286178Inst Instance=new A286178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286179
{
public static readonly BigInteger[] Value={ 32L,484256L,289919598688L,8368036149759509152L,BigInteger.Parse("9542829935669464786892890208"),BigInteger.Parse("237478537202498785375436854135610527328"),BigInteger.Parse("5320823767933620492346565093167366807147013946077792"),BigInteger.Parse("577349384176263735966013123947670534373854750755384636719202336") };
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
public class A286179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286179Inst Instance=new A286179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286180
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,0L,0L,1L,3L,1L,1L,0L,1L,4L,3L,2L,0L,0L,1L,5L,6L,4L,2L,0L,0L,1L,6L,10L,8L,6L,0L,1L,0L,1L,7L,15L,15L,13L,3L,3L,0L,0L,1L,8L,21L,26L,25L,12L,6L,2L,0L,0L,1L,9L,28L,42L,45L,31L,14L,9L,0L,0L,0L,1L,10L,36L,64L,77L,66L,35L,24L,3L,2L,1L,0L,1L,11L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286180Inst : IEnumerable<long>
{
public static readonly long[] Value=A286180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286180.Bytes);
public long this[int i]=>Value[i];

public static A286180Inst Instance=new A286180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286181
{
public static readonly BigInteger[] Value={ 7841L,594278556271608991L,BigInteger.Parse("4259842839142238791410741595983041626644087433") };
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
public class A286181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286181Inst Instance=new A286181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286182
{
public static readonly long[] Value={ 3L,13L,51L,167L,503L,1441L,4007L,10923L,29355L,78037L,205659L,538127L,1399583L,3621289L,9327695L,23931603L,61186131L,155949085L,396369795L,1004904695L,2541896519L,6416348209L,16165610999L,40657256571L,102090514683L,255968753125L,640899345579L,1602640560479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286182Inst : IEnumerable<long>
{
public static readonly long[] Value=A286182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286182.Bytes);
public long this[int i]=>Value[i];

public static A286182Inst Instance=new A286182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286199
{
public static readonly long[] Value={ 1L,1L,0L,3L,16L,7L,0L,15L,448L,31L,1024L,63L,768L,127L,24576L,4351L,68608L,511L,32768L,17407L,12288L,2047L,393216L,69631L,49152L,6299647L,1572864L,278527L,50528256L,8421375L,6291456L,403767295L,67895296L,33685503L,3246391296L,541327359L,271581184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286199Inst : IEnumerable<long>
{
public static readonly long[] Value=A286199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286199.Bytes);
public long this[int i]=>Value[i];

public static A286199Inst Instance=new A286199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286200
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1100L,11L,111100L,1111L,11110110L,1001L,1111110110L,11L,111111110100L,11111L,11111111110000L,11101100L,1111111101110111L,11111100L,111111111100001011L,1100L,11111111111111100011UL,110111110L,BigInteger.Parse("1111111111111010101011"),110111010L };
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
public class A286200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286200Inst Instance=new A286200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286201
{
public static readonly ulong[] Value={ 1L,1L,110L,11L,11000L,1111L,1111000L,1101111L,100100000L,110111111L,11000000000L,1011111111L,1111100000000L,1111111111L,1101110000000L,1110111011111111L,111111000000000L,110100001111111111L,11000000000000000L,11000111111111111111UL,11111011000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286201Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286201.Bytes);
public ulong this[int i]=>Value[i];

public static A286201Inst Instance=new A286201Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286202
{
public static readonly long[] Value={ 1L,2L,3L,12L,3L,60L,15L,246L,9L,1014L,3L,4084L,31L,16368L,236L,65399L,252L,261899L,12L,1048547L,446L,4193963L,442L,16776767L,434L,67108589L,1014L,268435381L,698L,1073740669L,65520L,4294934312L,37559L,17179833308L,4075L,68719440450L,107471L,274877869242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286202Inst : IEnumerable<long>
{
public static readonly long[] Value=A286202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286202.Bytes);
public long this[int i]=>Value[i];

public static A286202Inst Instance=new A286202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286203
{
public static readonly long[] Value={ 1L,1L,6L,3L,24L,15L,120L,111L,288L,447L,1536L,767L,7936L,1023L,7040L,61183L,32256L,214015L,98304L,819199L,1028096L,3497983L,3063808L,16547839L,10158080L,48103423L,58589184L,182452223L,195559424L,800587775L,134184960L,352255999L,7961968640L,4013686783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286203Inst : IEnumerable<long>
{
public static readonly long[] Value=A286203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286203.Bytes);
public long this[int i]=>Value[i];

public static A286203Inst Instance=new A286203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286204
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1111L,11L,111111L,1111L,11111111L,1111L,1111111111L,1111L,111111111111L,1111L,11111111111111L,11001111L,1111111111111111L,11111111L,111111111111111111L,11111111L,11111111111111111111UL,11111111L,BigInteger.Parse("1111111111111111111111"),11110111L };
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
public class A286204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286204Inst Instance=new A286204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286205
{
public static readonly ulong[] Value={ 1L,11L,110L,1111L,11000L,111111L,1111000L,11111111L,111100000L,1111111111L,11110000000L,111111111111L,1111000000000L,11111111111111L,111100110000000L,1111111111111111L,11111111000000000L,111111111111111111L,1111111100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286205Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286205.Bytes);
public ulong this[int i]=>Value[i];

public static A286205Inst Instance=new A286205Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286206
{
public static readonly long[] Value={ 1L,3L,3L,15L,3L,63L,15L,255L,15L,1023L,15L,4095L,15L,16383L,207L,65535L,255L,262143L,255L,1048575L,255L,4194303L,247L,16777215L,255L,67108863L,255L,268435455L,255L,1073741823L,50175L,4294967295L,58367L,17179869183L,62463L,68719476735L,63431L,274877906943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286206Inst : IEnumerable<long>
{
public static readonly long[] Value=A286206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286206.Bytes);
public long this[int i]=>Value[i];

public static A286206Inst Instance=new A286206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286207
{
public static readonly long[] Value={ 1L,3L,6L,15L,24L,63L,120L,255L,480L,1023L,1920L,4095L,7680L,16383L,31104L,65535L,130560L,262143L,522240L,1048575L,2088960L,4194303L,7831552L,16777215L,33423360L,67108863L,133693440L,268435455L,534773760L,1073741823L,2145484800L,4294967295L,8582463488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286207Inst : IEnumerable<long>
{
public static readonly long[] Value=A286207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286207.Bytes);
public long this[int i]=>Value[i];

public static A286207Inst Instance=new A286207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286208
{
public static readonly BigInteger[] Value={ 7853L,594278556271609021L,BigInteger.Parse("4259842839142238791410741595983041626644087509") };
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
public class A286208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286208Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286208.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286208Inst Instance=new A286208Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286209
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,3L,10L,24L,60L,134L,304L,656L,1420L,2996L,6312L,13112L,27167L,55825L,114412L,233282L,474563L,962159L,1947098L,3931288L,7925708L,15952866L,32072580L,64404708L,129213082L,259009006L,518818124L,1038549912L,2077775396L,4154785904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286209Inst : IEnumerable<long>
{
public static readonly long[] Value=A286209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286209.Bytes);
public long this[int i]=>Value[i];

public static A286209Inst Instance=new A286209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286210
{
public static readonly long[] Value={ 0L,4L,17L,62L,238L,912L,3468L,13224L,50655L,194672L,750165L,2897898L,11219322L,43520672L,169113746L,658172740L,2565143148L,10010037116L,39107620002L,152948221004L,598750691827L,2346021879720L,9199672561659L,36102743330922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286210Inst : IEnumerable<long>
{
public static readonly long[] Value=A286210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286210.Bytes);
public long this[int i]=>Value[i];

public static A286210Inst Instance=new A286210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286211
{
public static readonly long[] Value={ 0L,17L,52L,684L,2128L,34896L,123541L,1891998L,7565509L,106100847L,470286934L,6070072444L,29342743563L,352400491431L,1833102380708L,20699165970978L,114576111229319L,1227555854005393L,7163217232141967L,73387852919316000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286211Inst : IEnumerable<long>
{
public static readonly long[] Value=A286211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286211.Bytes);
public long this[int i]=>Value[i];

public static A286211Inst Instance=new A286211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286212
{
public static readonly BigInteger[] Value={ 0L,62L,684L,10056L,141018L,2053994L,30004158L,443275636L,6591532114L,98620717026L,1483077002788L,22402256622648L,339716751362128L,5169528508115318L,78910865975553660L,1207934007828690708L,BigInteger.Parse("18537787151292561428") };
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
public class A286212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286212Inst Instance=new A286212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286213
{
public static readonly BigInteger[] Value={ 0L,238L,2128L,141018L,1656022L,113258929L,1569283128L,97311031516L,1540259241508L,86480812173044L,1526208889551285L,78586854206474282L,1517934653629840928L,BigInteger.Parse("72607979076706778162"),BigInteger.Parse("1512452308916246272882") };
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
public class A286213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286213Inst Instance=new A286213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286214
{
public static readonly BigInteger[] Value={ 1L,912L,34896L,2053994L,113258929L,6553131164L,380797680269L,22418184755710L,1330080388106827L,79466576915681740L,4775393278095153395L,BigInteger.Parse("288397740505442452180"),BigInteger.Parse("17492553727454266741242"),BigInteger.Parse("1065040889415828916901252") };
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
public class A286214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286214Inst Instance=new A286214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286215
{
public static readonly BigInteger[] Value={ 3L,3468L,123541L,30004158L,1569283128L,380797680269L,23594688741164L,5201563721481604L,366234192215237315L,BigInteger.Parse("73710966822498902306"),BigInteger.Parse("5745557094114966956143"),BigInteger.Parse("1070211615398838835193976") };
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
public class A286215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286215Inst Instance=new A286215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286216
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,17L,17L,0L,0L,62L,52L,62L,0L,1L,238L,684L,684L,238L,1L,3L,912L,2128L,10056L,2128L,912L,3L,10L,3468L,34896L,141018L,141018L,34896L,3468L,10L,24L,13224L,123541L,2053994L,1656022L,2053994L,123541L,13224L,24L,60L,50655L,1891998L,30004158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286216Inst : IEnumerable<long>
{
public static readonly long[] Value=A286216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286216.Bytes);
public long this[int i]=>Value[i];

public static A286216Inst Instance=new A286216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286217
{
public static readonly long[] Value={ 1729L,11339L,49321L,146969L,386389L,1089019L,1221191L,3864241L,5171489L,12640949L,18181979L,21243961L,43974269L,51881689L,178433279L,208506509L,230324329L,278421569L,393806449L,849244031L,932539661L,1341880019L,1416207439L,1672403471L,1829232539L,2111885999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286217Inst : IEnumerable<long>
{
public static readonly long[] Value=A286217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286217.Bytes);
public long this[int i]=>Value[i];

public static A286217Inst Instance=new A286217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286218
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,3L,4L,4L,6L,7L,9L,11L,13L,16L,19L,23L,28L,33L,40L,46L,55L,65L,76L,89L,104L,121L,141L,163L,190L,219L,253L,290L,334L,383L,439L,502L,573L,653L,744L,845L,961L,1089L,1234L,1395L,1576L,1780L,2007L,2259L,2544L,2856L,3209L,3598L,4033L,4516L,5051L,5644L,6304L,7033L,7843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286218Inst : IEnumerable<long>
{
public static readonly long[] Value=A286218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286218.Bytes);
public long this[int i]=>Value[i];

public static A286218Inst Instance=new A286218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286219
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,3L,4L,5L,7L,7L,9L,10L,13L,15L,19L,20L,25L,28L,34L,38L,46L,50L,61L,69L,81L,89L,105L,116L,137L,152L,175L,194L,226L,250L,288L,318L,363L,403L,462L,508L,577L,637L,721L,796L,900L,988L,1113L,1228L,1378L,1515L,1696L,1860L,2080L,2287L,2546L,2791L,3106L,3402L,3779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286219Inst : IEnumerable<long>
{
public static readonly long[] Value=A286219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286219.Bytes);
public long this[int i]=>Value[i];

public static A286219Inst Instance=new A286219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286220
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,1L,3L,2L,4L,3L,5L,5L,6L,7L,7L,10L,9L,12L,12L,15L,15L,18L,19L,22L,24L,26L,30L,32L,36L,40L,43L,49L,52L,58L,63L,69L,76L,81L,91L,96L,108L,114L,127L,135L,148L,159L,173L,186L,202L,217L,234L,253L,271L,293L,313L,339L,361L,390L,416L,449L,478L,514L,547L,588L,625L,671L,714L,763L,815L,867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286220Inst : IEnumerable<long>
{
public static readonly long[] Value=A286220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286220.Bytes);
public long this[int i]=>Value[i];

public static A286220Inst Instance=new A286220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286221
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,4L,4L,2L,3L,4L,4L,5L,6L,5L,5L,6L,7L,9L,10L,10L,12L,11L,11L,15L,16L,15L,17L,18L,19L,23L,26L,25L,27L,30L,33L,37L,38L,39L,46L,50L,52L,57L,59L,61L,71L,77L,78L,84L,91L,97L,107L,114L,120L,131L,139L,147L,163L,172L,180L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286221Inst : IEnumerable<long>
{
public static readonly long[] Value=A286221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286221.Bytes);
public long this[int i]=>Value[i];

public static A286221Inst Instance=new A286221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286222
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,2L,2L,1L,3L,2L,3L,4L,3L,5L,4L,5L,7L,6L,10L,8L,10L,12L,10L,15L,14L,16L,20L,18L,25L,25L,28L,32L,31L,38L,38L,44L,49L,51L,59L,61L,68L,75L,79L,89L,93L,103L,113L,120L,137L,141L,157L,168L,176L,200L,205L,229L,245L,260L,289L,303L,332L,356L,376L,411L,433L,470L,507L,535L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286222Inst : IEnumerable<long>
{
public static readonly long[] Value=A286222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286222.Bytes);
public long this[int i]=>Value[i];

public static A286222Inst Instance=new A286222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286223
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,3L,2L,0L,1L,3L,4L,4L,2L,1L,4L,6L,5L,4L,4L,6L,10L,10L,6L,6L,10L,13L,14L,11L,9L,14L,21L,21L,17L,17L,23L,31L,31L,25L,25L,33L,41L,43L,39L,38L,50L,61L,60L,56L,58L,68L,83L,87L,79L,82L,99L,115L,121L,118L,118L,139L,163L,164L,157L,165L,189L,216L,228L,221L,229L,265L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286223Inst : IEnumerable<long>
{
public static readonly long[] Value=A286223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286223.Bytes);
public long this[int i]=>Value[i];

public static A286223Inst Instance=new A286223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286224
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,4L,8L,11L,19L,28L,47L,72L,116L,182L,289L,460L,724L,1153L,1820L,2891L,4572L,7249L,11482L,18190L,28821L,45651L,72338L,114582L,181549L,287597L,455647L,721849L,1143590L,1811753L,2870247L,4547245L,7203933L,11412922L,18080907L,28644799L,45380602L,71894401L,113899027L,180444897L,285870668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286224Inst : IEnumerable<long>
{
public static readonly long[] Value=A286224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286224.Bytes);
public long this[int i]=>Value[i];

public static A286224Inst Instance=new A286224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286225
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,7L,9L,13L,18L,25L,34L,46L,61L,83L,112L,153L,209L,286L,387L,526L,713L,969L,1317L,1794L,2437L,3312L,4497L,6110L,8302L,11290L,15347L,20865L,28354L,38533L,52361L,71167L,96721L,131464L,178672L,242834L,330020L,448532L,609590L,828511L,1126037L,1530418L,2079977L,2826896L,3841998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286225Inst : IEnumerable<long>
{
public static readonly long[] Value=A286225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286225.Bytes);
public long this[int i]=>Value[i];

public static A286225Inst Instance=new A286225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286226
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,3L,2L,6L,7L,10L,18L,22L,39L,54L,81L,127L,179L,282L,412L,620L,940L,1384L,2106L,3129L,4698L,7062L,10531L,15856L,23695L,35541L,53304L,79773L,119723L,179262L,268748L,402832L,603484L,904821L,1355652L,2031963L,3045374L,4563604L,6840316L,10250612L,15363248L,23024904L,34506390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286226Inst : IEnumerable<long>
{
public static readonly long[] Value=A286226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286226.Bytes);
public long this[int i]=>Value[i];

public static A286226Inst Instance=new A286226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286227
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,7L,10L,15L,24L,36L,53L,78L,118L,179L,271L,405L,605L,907L,1366L,2055L,3086L,4628L,6948L,10440L,15689L,23560L,35371L,53110L,79771L,119821L,179958L,270243L,405833L,609495L,915394L,1374780L,2064647L,3100680L,4656676L,6993575L,10503180L,15773877L,23689467L,35577360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286227Inst : IEnumerable<long>
{
public static readonly long[] Value=A286227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286227.Bytes);
public long this[int i]=>Value[i];

public static A286227Inst Instance=new A286227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286228
{
public static readonly long[] Value={ 1L,4L,9L,12L,18L,20L,25L,28L,44L,45L,49L,50L,52L,63L,68L,75L,76L,92L,98L,99L,116L,117L,121L,124L,147L,148L,153L,164L,169L,171L,172L,175L,188L,207L,212L,236L,242L,244L,245L,261L,268L,275L,279L,284L,289L,292L,316L,325L,332L,333L,338L,356L,361L,363L,369L,387L,388L,404L,412L,423L,425L,428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286228Inst : IEnumerable<long>
{
public static readonly long[] Value=A286228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286228.Bytes);
public long this[int i]=>Value[i];

public static A286228Inst Instance=new A286228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286229
{
public static readonly long[] Value={ 1L,9L,4L,1L,1L,8L,1L,6L,9L,8L,3L,2L,6L,3L,3L,7L,9L,2L,2L,9L,9L,5L,8L,7L,4L,8L,4L,9L,1L,1L,3L,8L,0L,8L,3L,7L,4L,5L,1L,8L,7L,7L,0L,1L,8L,4L,5L,2L,7L,9L,2L,1L,9L,7L,7L,3L,5L,0L,4L,3L,4L,9L,4L,0L,4L,1L,0L,3L,8L,0L,8L,7L,4L,2L,0L,5L,7L,9L,2L,5L,2L,6L,3L,3L,9L,3L,9L,5L,3L,9L,8L,7L,7L,6L,5L,4L,3L,5L,3L,6L,7L,8L,8L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286229Inst : IEnumerable<long>
{
public static readonly long[] Value=A286229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286229.Bytes);
public long this[int i]=>Value[i];

public static A286229Inst Instance=new A286229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286230
{
public static readonly long[] Value={ 2L,12L,30L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286230Inst : IEnumerable<long>
{
public static readonly long[] Value=A286230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286230.Bytes);
public long this[int i]=>Value[i];

public static A286230Inst Instance=new A286230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286231
{
public static readonly long[] Value={ 1L,5L,1L,25L,10L,1L,143L,79L,17L,1L,942L,634L,197L,26L,1L,7074L,5462L,2129L,417L,37L,1L,59832L,51214L,23381L,5856L,786L,50L,1L,563688L,523386L,269033L,80053L,13934L,1360L,65L,1L,5858640L,5813892L,3281206L,1111498L,232349L,29728L,2204L,82L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286231Inst : IEnumerable<long>
{
public static readonly long[] Value=A286231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286231.Bytes);
public long this[int i]=>Value[i];

public static A286231Inst Instance=new A286231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286232
{
public static readonly long[] Value={ 1L,5L,1L,19L,10L,1L,75L,57L,17L,1L,323L,285L,145L,26L,1L,1512L,1421L,975L,317L,37L,1L,7630L,7395L,5999L,2865L,616L,50L,1L,41245L,40726L,36183L,22411L,7315L,1094L,65L,1L,237573L,237759L,221689L,163488L,72581L,16630L,1812L,82L,1L,1451359L,1468162L,1405001L,1160764L,649723L,206249L,34425L,2840L,101L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286232Inst : IEnumerable<long>
{
public static readonly long[] Value=A286232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286232.Bytes);
public long this[int i]=>Value[i];

public static A286232Inst Instance=new A286232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286233
{
public static readonly long[] Value={ 579L,639L,14911L,18207L,38575L,47223L,310399L,492855L,16632919L,20238207L,34696495L,37400607L,37852351L,52463103L,84250111L,122992023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286233Inst : IEnumerable<long>
{
public static readonly long[] Value=A286233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286233.Bytes);
public long this[int i]=>Value[i];

public static A286233Inst Instance=new A286233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286234
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,3L,3L,2L,7L,10L,3L,3L,2L,11L,3L,10L,3L,5L,4L,16L,21L,3L,10L,3L,5L,4L,22L,10L,21L,3L,10L,5L,5L,7L,29L,21L,10L,21L,3L,10L,5L,8L,7L,37L,10L,21L,10L,21L,3L,14L,5L,8L,11L,46L,55L,10L,21L,10L,21L,3L,14L,5L,8L,11L,56L,10L,55L,10L,21L,10L,21L,5L,14L,8L,12L,16L,67L,78L,10L,55L,10L,21L,10L,21L,5L,14L,8L,12L,16L,79L,21L,78L,10L,55L,10L,21L,10L,27L,5L,14L,8L,12L,22L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286234Inst : IEnumerable<long>
{
public static readonly long[] Value=A286234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286234.Bytes);
public long this[int i]=>Value[i];

public static A286234Inst Instance=new A286234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286235
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,3L,7L,2L,3L,3L,11L,2L,3L,3L,10L,16L,4L,5L,3L,10L,3L,22L,4L,5L,3L,10L,3L,21L,29L,7L,5L,5L,10L,3L,21L,10L,37L,7L,8L,5L,10L,3L,21L,10L,21L,46L,11L,8L,5L,14L,3L,21L,10L,21L,10L,56L,11L,8L,5L,14L,3L,21L,10L,21L,10L,55L,67L,16L,12L,8L,14L,5L,21L,10L,21L,10L,55L,10L,79L,16L,12L,8L,14L,5L,21L,10L,21L,10L,55L,10L,78L,92L,22L,12L,8L,14L,5L,27L,10L,21L,10L,55L,10L,78L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286235Inst : IEnumerable<long>
{
public static readonly long[] Value=A286235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286235.Bytes);
public long this[int i]=>Value[i];

public static A286235Inst Instance=new A286235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286236
{
public static readonly long[] Value={ 1L,1L,2L,3L,0L,4L,3L,0L,2L,7L,10L,0L,0L,0L,11L,3L,0L,0L,5L,4L,16L,21L,0L,0L,0L,0L,0L,22L,10L,0L,0L,0L,5L,0L,7L,29L,21L,0L,0L,0L,0L,0L,8L,0L,37L,10L,0L,0L,0L,0L,14L,0L,0L,11L,46L,55L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,10L,0L,0L,0L,0L,0L,5L,0L,8L,12L,16L,67L,78L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,0L,0L,0L,0L,0L,0L,27L,0L,0L,0L,0L,22L,92L,36L,0L,0L,0L,0L,0L,0L,0L,0L,0L,19L,0L,17L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286236Inst : IEnumerable<long>
{
public static readonly long[] Value=A286236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286236.Bytes);
public long this[int i]=>Value[i];

public static A286236Inst Instance=new A286236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286237
{
public static readonly long[] Value={ 1L,2L,1L,4L,0L,3L,7L,2L,0L,3L,11L,0L,0L,0L,10L,16L,4L,5L,0L,0L,3L,22L,0L,0L,0L,0L,0L,21L,29L,7L,0L,5L,0L,0L,0L,10L,37L,0L,8L,0L,0L,0L,0L,0L,21L,46L,11L,0L,0L,14L,0L,0L,0L,0L,10L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,55L,67L,16L,12L,8L,0L,5L,0L,0L,0L,0L,0L,10L,79L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,78L,92L,22L,0L,0L,0L,0L,27L,0L,0L,0L,0L,0L,0L,21L,106L,0L,17L,0L,19L,0L,0L,0L,0L,0L,0L,0L,0L,0L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286237Inst : IEnumerable<long>
{
public static readonly long[] Value=A286237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286237.Bytes);
public long this[int i]=>Value[i];

public static A286237Inst Instance=new A286237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286238
{
public static readonly long[] Value={ 1L,2L,1L,4L,0L,3L,7L,0L,2L,3L,11L,0L,0L,0L,10L,16L,0L,0L,4L,5L,3L,22L,0L,0L,0L,0L,0L,21L,29L,0L,0L,0L,7L,0L,5L,10L,37L,0L,0L,0L,0L,0L,8L,0L,21L,46L,0L,0L,0L,0L,11L,0L,0L,14L,10L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,55L,67L,0L,0L,0L,0L,0L,16L,0L,12L,8L,5L,10L,79L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,78L,92L,0L,0L,0L,0L,0L,0L,22L,0L,0L,0L,0L,27L,21L,106L,0L,0L,0L,0L,0L,0L,0L,0L,0L,17L,0L,19L,0L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286238Inst : IEnumerable<long>
{
public static readonly long[] Value=A286238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286238.Bytes);
public long this[int i]=>Value[i];

public static A286238Inst Instance=new A286238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286239
{
public static readonly long[] Value={ 1L,1L,2L,3L,0L,4L,3L,2L,0L,7L,10L,0L,0L,0L,11L,3L,5L,4L,0L,0L,16L,21L,0L,0L,0L,0L,0L,22L,10L,5L,0L,7L,0L,0L,0L,29L,21L,0L,8L,0L,0L,0L,0L,0L,37L,10L,14L,0L,0L,11L,0L,0L,0L,0L,46L,55L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,10L,5L,8L,12L,0L,16L,0L,0L,0L,0L,0L,67L,78L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,27L,0L,0L,0L,0L,22L,0L,0L,0L,0L,0L,0L,92L,36L,0L,19L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286239Inst : IEnumerable<long>
{
public static readonly long[] Value=A286239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286239.Bytes);
public long this[int i]=>Value[i];

public static A286239Inst Instance=new A286239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286240
{
public static readonly long[] Value={ 2L,5L,12L,14L,23L,42L,59L,44L,23L,61L,142L,117L,109L,183L,261L,152L,23L,61L,142L,148L,601L,850L,607L,375L,109L,265L,1093L,939L,473L,765L,1097L,560L,23L,61L,142L,148L,601L,850L,607L,430L,601L,1741L,3946L,2545L,2497L,3463L,2509L,1323L,109L,265L,1093L,1117L,2497L,4525L,5707L,3153L,473L,1105L,4489L,3813L,1969L,3129L,4497L,2144L,23L,61L,142L,148L,601L,850L,607L,430L,601L,1741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286240Inst : IEnumerable<long>
{
public static readonly long[] Value=A286240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286240.Bytes);
public long this[int i]=>Value[i];

public static A286240Inst Instance=new A286240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286241
{
public static readonly long[] Value={ 2L,12L,14L,12L,59L,86L,27L,12L,109L,363L,269L,86L,142L,148L,27L,12L,109L,1093L,1117L,363L,1097L,1517L,489L,86L,601L,1408L,619L,148L,142L,148L,27L,12L,109L,1093L,1117L,1093L,5707L,8587L,2545L,363L,1969L,6153L,4529L,1517L,4489L,4537L,489L,86L,601L,3946L,3976L,1408L,2509L,5719L,2545L,148L,601L,1408L,619L,148L,142L,148L,27L,12L,109L,1093L,1117L,1093L,5707L,8587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286241Inst : IEnumerable<long>
{
public static readonly long[] Value=A286241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286241.Bytes);
public long this[int i]=>Value[i];

public static A286241Inst Instance=new A286241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286242
{
public static readonly long[] Value={ 1L,5L,12L,14L,12L,84L,40L,44L,12L,142L,216L,183L,40L,265L,86L,152L,12L,142L,826L,265L,216L,1860L,607L,489L,40L,832L,607L,1117L,86L,619L,226L,560L,12L,142L,826L,265L,826L,5080L,2497L,619L,216L,2956L,4308L,4155L,607L,8575L,1105L,1533L,40L,832L,2497L,2116L,607L,5731L,4501L,3475L,86L,1402L,1105L,3475L,226L,1759L,698L,2144L,12L,142L,826L,265L,826L,5080L,2497L,619L,826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286242Inst : IEnumerable<long>
{
public static readonly long[] Value=A286242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286242.Bytes);
public long this[int i]=>Value[i];

public static A286242Inst Instance=new A286242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286243
{
public static readonly long[] Value={ 2L,2L,4L,6L,2L,8L,12L,4L,12L,6L,6L,12L,6L,2L,24L,24L,8L,16L,32L,12L,30L,30L,4L,60L,12L,12L,48L,30L,6L,60L,72L,6L,6L,48L,12L,12L,24L,6L,12L,30L,2L,48L,24L,24L,60L,72L,24L,36L,60L,8L,12L,60L,16L,72L,180L,32L,180L,24L,12L,6L,12L,30L,36L,24L,30L,128L,210L,4L,12L,30L,60L,60L,30L,12L,60L,210L,12L,120L,120L,48L,96L,120L,30L,60L,48L,6L,120L,60L,60L,420L,180L,72L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286243Inst : IEnumerable<long>
{
public static readonly long[] Value=A286243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286243.Bytes);
public long this[int i]=>Value[i];

public static A286243Inst Instance=new A286243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286244
{
public static readonly long[] Value={ 1L,3L,2L,3L,3L,4L,10L,3L,5L,7L,3L,10L,3L,5L,11L,21L,3L,10L,5L,8L,16L,3L,21L,3L,10L,5L,8L,22L,36L,3L,21L,3L,14L,5L,12L,29L,10L,36L,3L,21L,3L,14L,8L,12L,37L,21L,10L,36L,3L,21L,5L,14L,8L,17L,46L,3L,21L,10L,36L,3L,21L,5L,14L,8L,17L,56L,78L,3L,21L,10L,36L,3L,27L,5L,19L,12L,23L,67L,3L,78L,3L,21L,10L,36L,3L,27L,5L,19L,12L,23L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286244Inst : IEnumerable<long>
{
public static readonly long[] Value=A286244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286244.Bytes);
public long this[int i]=>Value[i];

public static A286244Inst Instance=new A286244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286245
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,3L,7L,5L,3L,10L,11L,5L,3L,10L,3L,16L,8L,5L,10L,3L,21L,22L,8L,5L,10L,3L,21L,3L,29L,12L,5L,14L,3L,21L,3L,36L,37L,12L,8L,14L,3L,21L,3L,36L,10L,46L,17L,8L,14L,5L,21L,3L,36L,10L,21L,56L,17L,8L,14L,5L,21L,3L,36L,10L,21L,3L,67L,23L,12L,19L,5L,27L,3L,36L,10L,21L,3L,78L,79L,23L,12L,19L,5L,27L,3L,36L,10L,21L,3L,78L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286245Inst : IEnumerable<long>
{
public static readonly long[] Value=A286245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286245.Bytes);
public long this[int i]=>Value[i];

public static A286245Inst Instance=new A286245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286246
{
public static readonly long[] Value={ 1L,3L,2L,3L,0L,4L,10L,0L,5L,7L,3L,0L,0L,0L,11L,21L,0L,0L,5L,8L,16L,3L,0L,0L,0L,0L,0L,22L,36L,0L,0L,0L,14L,0L,12L,29L,10L,0L,0L,0L,0L,0L,8L,0L,37L,21L,0L,0L,0L,0L,5L,0L,0L,17L,46L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,78L,0L,0L,0L,0L,0L,27L,0L,19L,12L,23L,67L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,30L,92L,21L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,17L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286246Inst : IEnumerable<long>
{
public static readonly long[] Value=A286246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286246.Bytes);
public long this[int i]=>Value[i];

public static A286246Inst Instance=new A286246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286263
{
public static readonly long[] Value={ 2L,8L,19L,26L,43L,56L,79L,104L,127L,166L,223L,258L,307L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286263Inst : IEnumerable<long>
{
public static readonly long[] Value=A286263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286263.Bytes);
public long this[int i]=>Value[i];

public static A286263Inst Instance=new A286263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286264
{
public static readonly long[] Value={ 3L,5L,11L,17L,27L,37L,51L,65L,83L,101L,123L,145L,171L,197L,227L,257L,291L,325L,363L,401L,443L,485L,531L,577L,627L,677L,731L,785L,843L,901L,963L,1025L,1091L,1157L,1227L,1297L,1371L,1445L,1523L,1601L,1683L,1765L,1851L,1937L,2027L,2117L,2211L,2305L,2403L,2501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286264Inst : IEnumerable<long>
{
public static readonly long[] Value=A286264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286264.Bytes);
public long this[int i]=>Value[i];

public static A286264Inst Instance=new A286264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286265
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,25L,29L,31L,33L,35L,37L,41L,43L,47L,49L,51L,53L,55L,59L,61L,65L,67L,69L,71L,73L,77L,79L,83L,85L,87L,89L,91L,95L,97L,101L,103L,107L,109L,113L,115L,119L,121L,123L,125L,127L,131L,133L,137L,139L,141L,143L,145L,149L,151L,153L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286265Inst : IEnumerable<long>
{
public static readonly long[] Value=A286265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286265.Bytes);
public long this[int i]=>Value[i];

public static A286265Inst Instance=new A286265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286266
{
public static readonly long[] Value={ 2L,36L,383L,3708L,35731L,347505L,3407290L,33579303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286266Inst : IEnumerable<long>
{
public static readonly long[] Value=A286266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286266.Bytes);
public long this[int i]=>Value[i];

public static A286266Inst Instance=new A286266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286267
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,13L,17L,23L,29L,37L,41L,47L,53L,59L,67L,71L,73L,79L,83L,89L,97L,101L,107L,127L,131L,137L,149L,167L,179L,221L,223L,227L,233L,251L,257L,289L,317L,347L,353L,359L,383L,389L,431L,443L,449L,461L,467L,503L,557L,563L,569L,587L,641L,677L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286267Inst : IEnumerable<long>
{
public static readonly long[] Value=A286267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286267.Bytes);
public long this[int i]=>Value[i];

public static A286267Inst Instance=new A286267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286268
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,17L,83L,137L,257L,2879L,46049L,65537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286268Inst : IEnumerable<long>
{
public static readonly long[] Value=A286268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286268.Bytes);
public long this[int i]=>Value[i];

public static A286268Inst Instance=new A286268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286269
{
public static readonly long[] Value={ 2L,8L,19L,48L,53L,108L,113L,210L,197L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286269Inst : IEnumerable<long>
{
public static readonly long[] Value=A286269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286269.Bytes);
public long this[int i]=>Value[i];

public static A286269Inst Instance=new A286269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286270
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,5L,6L,7L,14L,19L,28L,42L,62L,92L,132L,187L,272L,418L,595L,873L,1272L,1856L,2705L,3945L,5735L,8333L,12218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286270Inst : IEnumerable<long>
{
public static readonly long[] Value=A286270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286270.Bytes);
public long this[int i]=>Value[i];

public static A286270Inst Instance=new A286270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286271
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,16L,24L,35L,53L,78L,118L,176L,266L,401L,611L,927L,1419L,2169L,3333L,5124L,7910L,12215L,18925L,29345L,45609L,70959L,110609L,172576L,269684L,421829L,660647L,1035602L,1625122L,2552322L,4012282L,6312136L,9938336L,15658610L,24689060L,38952138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286271Inst : IEnumerable<long>
{
public static readonly long[] Value=A286271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286271.Bytes);
public long this[int i]=>Value[i];

public static A286271Inst Instance=new A286271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286272
{
public static readonly long[] Value={ 0L,1L,3L,6L,11L,18L,29L,45L,69L,104L,157L,235L,353L,529L,795L,1196L,1807L,2734L,4153L,6322L,9655L,14779L,22689L,34904L,53829L,83174L,128783L,199742L,310351L,482927L,752611L,1174440L,1835087L,2870689L,4495811L,7048133L,11060415L,17372551L,27310887L,42969497L,67658557L,106610695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286272Inst : IEnumerable<long>
{
public static readonly long[] Value=A286272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286272.Bytes);
public long this[int i]=>Value[i];

public static A286272Inst Instance=new A286272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286273
{
public static readonly long[] Value={ 6L,12L,12L,16L,13L,12L,11L,32L,24L,14L,11L,22L,12L,23L,17L,40L,14L,35L,13L,40L,18L,11L,17L,44L,16L,18L,38L,32L,13L,24L,13L,84L,19L,20L,30L,55L,12L,21L,24L,72L,15L,27L,12L,44L,37L,13L,17L,107L,18L,35L,18L,28L,20L,57L,25L,72L,18L,11L,20L,37L,11L,26L,43L,142L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286273Inst : IEnumerable<long>
{
public static readonly long[] Value=A286273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286273.Bytes);
public long this[int i]=>Value[i];

public static A286273Inst Instance=new A286273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286274
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,1L,0L,3L,6L,2L,0L,1L,1L,1L,4L,1L,2L,1L,10L,6L,0L,0L,4L,1L,8L,5L,3L,0L,6L,3L,5L,4L,8L,0L,3L,1L,1L,7L,26L,3L,10L,1L,2L,8L,0L,0L,9L,7L,20L,3L,13L,0L,9L,4L,3L,9L,9L,0L,17L,3L,2L,20L,18L,0L,3L,1L,9L,1L,13L,2L,10L,2L,8L,1L,4L,4L,16L,1L,41L,14L,7L,0L,14L,1L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286274Inst : IEnumerable<long>
{
public static readonly long[] Value=A286274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286274.Bytes);
public long this[int i]=>Value[i];

public static A286274Inst Instance=new A286274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286275
{
public static readonly long[] Value={ 0L,0L,2L,4L,3L,2L,1L,3L,6L,2L,3L,2L,3L,1L,8L,4L,0L,1L,5L,1L,4L,3L,0L,3L,3L,0L,2L,6L,11L,1L,1L,2L,7L,3L,1L,7L,5L,0L,2L,4L,3L,1L,6L,1L,8L,6L,0L,4L,9L,1L,7L,2L,0L,1L,7L,6L,10L,0L,0L,3L,7L,0L,5L,6L,5L,1L,1L,1L,7L,0L,9L,4L,2L,0L,2L,4L,4L,2L,1L,3L,10L,4L,1L,3L,17L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286275Inst : IEnumerable<long>
{
public static readonly long[] Value=A286275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286275.Bytes);
public long this[int i]=>Value[i];

public static A286275Inst Instance=new A286275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286276
{
public static readonly long[] Value={ 5L,12L,15L,15L,19L,20L,19L,41L,40L,22L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286276Inst : IEnumerable<long>
{
public static readonly long[] Value=A286276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286276.Bytes);
public long this[int i]=>Value[i];

public static A286276Inst Instance=new A286276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286277
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,1L,5L,0L,1L,0L,1L,0L,2L,4L,0L,0L,1L,0L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286277Inst : IEnumerable<long>
{
public static readonly long[] Value=A286277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286277.Bytes);
public long this[int i]=>Value[i];

public static A286277Inst Instance=new A286277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286278
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,2L,2L,6L,5L,7L,1L,4L,6L,7L,8L,1L,12L,3L,11L,13L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286278Inst : IEnumerable<long>
{
public static readonly long[] Value=A286278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286278.Bytes);
public long this[int i]=>Value[i];

public static A286278Inst Instance=new A286278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286295
{
public static readonly long[] Value={ 0L,2L,1L,5L,3L,7L,8L,6L,4L,13L,10L,15L,17L,16L,20L,21L,19L,9L,23L,22L,25L,11L,12L,30L,29L,33L,35L,36L,38L,14L,37L,41L,42L,43L,34L,44L,18L,47L,51L,48L,49L,50L,46L,57L,54L,56L,58L,60L,24L,64L,65L,66L,61L,70L,68L,26L,63L,27L,73L,69L,28L,72L,78L,74L,79L,76L,31L,32L,86L,87L,89L,94L,92L,93L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286295Inst : IEnumerable<long>
{
public static readonly long[] Value=A286295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286295.Bytes);
public long this[int i]=>Value[i];

public static A286295Inst Instance=new A286295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286296
{
public static readonly long[] Value={ 4L,4L,3L,5L,7L,11L,17L,17L,37L,23L,47L,37L,29L,19L,47L,59L,19L,37L,71L,59L,31L,67L,239L,101L,739L,409L,43L,367L,167L,251L,73L,71L,419L,1567L,107L,83L,223L,191L,227L,449L,97L,173L,103L,523L,79L,137L,223L,1163L,661L,103L,103L,541L,227L,2383L,433L,71L,1069L,643L,251L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286296Inst : IEnumerable<long>
{
public static readonly long[] Value=A286296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286296.Bytes);
public long this[int i]=>Value[i];

public static A286296Inst Instance=new A286296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286297
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,0L,4L,1L,5L,3L,1L,5L,6L,0L,4L,2L,4L,5L,0L,2L,1L,7L,3L,6L,8L,5L,3L,1L,4L,6L,8L,9L,2L,7L,0L,10L,6L,4L,2L,0L,3L,9L,5L,10L,11L,1L,12L,7L,13L,7L,8L,9L,5L,4L,6L,10L,3L,2L,12L,0L,11L,14L,15L,1L,8L,6L,10L,3L,7L,2L,11L,4L,9L,13L,1L,5L,15L,12L,16L,14L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286297Inst : IEnumerable<long>
{
public static readonly long[] Value=A286297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286297.Bytes);
public long this[int i]=>Value[i];

public static A286297Inst Instance=new A286297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286298
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,5L,4L,3L,5L,6L,7L,6L,5L,6L,5L,4L,6L,7L,8L,7L,8L,9L,8L,7L,6L,7L,8L,7L,6L,7L,6L,5L,7L,8L,9L,8L,9L,10L,9L,8L,9L,10L,11L,10L,9L,10L,9L,8L,7L,8L,9L,8L,9L,10L,9L,8L,7L,8L,9L,8L,7L,8L,7L,6L,8L,9L,10L,9L,10L,11L,10L,9L,10L,11L,12L,11L,10L,11L,10L,9L,10L,11L,12L,11L,12L,13L,12L,11L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286298Inst : IEnumerable<long>
{
public static readonly long[] Value=A286298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286298.Bytes);
public long this[int i]=>Value[i];

public static A286298Inst Instance=new A286298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286299
{
public static readonly long[] Value={ 1L,2L,-1L,2L,1L,-1L,-1L,2L,1L,1L,-1L,-1L,1L,-1L,-1L,2L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,2L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286299Inst : IEnumerable<long>
{
public static readonly long[] Value=A286299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286299.Bytes);
public long this[int i]=>Value[i];

public static A286299Inst Instance=new A286299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286300
{
public static readonly long[] Value={ 1L,5L,6L,2L,5L,4L,24L,9L,3L,10L,11L,11L,19L,12L,34L,4L,42L,9L,13L,32L,11L,15L,18L,18L,5L,16L,27L,17L,17L,48L,19L,18L,56L,18L,55L,6L,61L,59L,37L,20L,12L,18L,18L,12L,65L,8L,28L,22L,7L,45L,34L,15L,55L,65L,75L,16L,24L,72L,23L,40L,13L,16L,19L,8L,16L,26L,24L,41L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286300Inst : IEnumerable<long>
{
public static readonly long[] Value=A286300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286300.Bytes);
public long this[int i]=>Value[i];

public static A286300Inst Instance=new A286300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286301
{
public static readonly BigInteger[] Value={ 12207031L,2141993519227L,178250690949465223L,BigInteger.Parse("2346320474383711003267"),BigInteger.Parse("398341412240537151131351"),BigInteger.Parse("79545183674814239059370551"),BigInteger.Parse("494424256962371823779424877"),BigInteger.Parse("8271964541879648991904246901"),BigInteger.Parse("32142180034067960734115528951"),BigInteger.Parse("91264002187709396686868598317") };
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
public class A286301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286301Inst Instance=new A286301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286302
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,13L,16L,17L,22L,24L,25L,26L,31L,36L,58L,64L,76L,82L,120L,170L,193L,196L,214L,324L,328L,370L,412L,562L,676L,730L,10404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286302Inst : IEnumerable<long>
{
public static readonly long[] Value=A286302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286302.Bytes);
public long this[int i]=>Value[i];

public static A286302Inst Instance=new A286302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286303
{
public static readonly long[] Value={ 1L,4L,6L,9L,14L,20L,23L,25L,30L,33L,49L,56L,60L,248L,270L,280L,302L,385L,474L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286303Inst : IEnumerable<long>
{
public static readonly long[] Value=A286303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286303.Bytes);
public long this[int i]=>Value[i];

public static A286303Inst Instance=new A286303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286304
{
public static readonly long[] Value={ 1L,3L,6L,10L,17L,24L,37L,51L,78L,110L,173L,229L,340L,477L,750L,1024L,1571L,2253L,3616L,5024L,7839L,11356L,18389L,25173L,38740L,55697L,89610L,124870L,195389L,283536L,459829L,636123L,988710L,1429442L,2310905L,3227617L,5061040L,7352817L,11936370L,16526444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286304Inst : IEnumerable<long>
{
public static readonly long[] Value=A286304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286304.Bytes);
public long this[int i]=>Value[i];

public static A286304Inst Instance=new A286304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286305
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,5L,5L,5L,7L,8L,8L,8L,12L,14L,15L,15L,19L,21L,22L,22L,28L,33L,35L,37L,43L,48L,50L,52L,62L,70L,75L,79L,92L,100L,105L,109L,126L,140L,148L,157L,177L,194L,202L,211L,237L,261L,276L,290L,324L,351L,370L,384L,424L,462L,489L,514L,562L,609L,640L,670L,728L,787L,831L,873L,948L,1016L,1071L,1118L,1210L,1296L,1366L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286305Inst : IEnumerable<long>
{
public static readonly long[] Value=A286305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286305.Bytes);
public long this[int i]=>Value[i];

public static A286305Inst Instance=new A286305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286306
{
public static readonly BigInteger[] Value={ 1L,1L,3L,27L,441L,11529L,442827L,23444883L,1636819569L,145703137041L,16106380394643L,2164638920874507L,347592265948756521L,BigInteger.Parse("65724760945840254489"),BigInteger.Parse("14454276753061349098587"),BigInteger.Parse("3658147171522531111996803"),BigInteger.Parse("1055646229815910768764248289"),BigInteger.Parse("344553616791279239828059918881") };
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
public class A286306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286306Inst Instance=new A286306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286307
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,17L,151L,823L,10631L,15871L,1344097L,12731713L,266731133L,3061359593L,15281334539L,1030023060151L,29833932429263L,461929309281059L,15229246883432833L,53257613193371021L,9845267571825141941UL,BigInteger.Parse("191853269052081088769"),BigInteger.Parse("462422990938113014567"),BigInteger.Parse("168922073145947967975799") };
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
public class A286307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286307Inst Instance=new A286307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286308
{
public static readonly long[] Value={ 6L,18L,42L,54L,66L,78L,102L,114L,126L,138L,162L,174L,186L,198L,222L,234L,246L,258L,282L,294L,318L,354L,366L,378L,402L,414L,426L,438L,462L,474L,486L,498L,522L,534L,558L,582L,594L,606L,618L,642L,654L,666L,678L,702L,714L,726L,738L,762L,774L,786L,798L,822L,834L,846L,858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286308Inst : IEnumerable<long>
{
public static readonly long[] Value=A286308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286308.Bytes);
public long this[int i]=>Value[i];

public static A286308Inst Instance=new A286308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286309
{
public static readonly long[] Value={ 2L,8L,2L,8L,2L,22L,25L,2L,2L,15L,10L,15L,7L,17L,5L,5L,2L,15L,7L,10L,22L,5L,17L,17L,5L,10L,7L,5L,5L,5L,2L,10L,17L,5L,10L,2L,5L,15L,12L,17L,10L,12L,5L,22L,17L,5L,5L,2L,5L,10L,5L,12L,5L,5L,12L,5L,5L,2L,10L,5L,5L,2L,10L,5L,5L,7L,5L,5L,17L,5L,12L,5L,5L,7L,5L,5L,5L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286309Inst : IEnumerable<long>
{
public static readonly long[] Value=A286309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286309.Bytes);
public long this[int i]=>Value[i];

public static A286309Inst Instance=new A286309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286310
{
public static readonly BigInteger[] Value={ 1L,2L,14L,102L,944L,10378L,135134L,2026920L,34459410L,654728128L,13749310574L,316234132728L,7905853580624L,213458046541738L,6190283353628416L,191898783960483600L,6332659870762850624L,BigInteger.Parse("221643095476665302070"),BigInteger.Parse("8200794532637891559374"),BigInteger.Parse("319830986772877116086448") };
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
public class A286310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286310Inst Instance=new A286310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286343
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,3L,2L,4L,5L,1L,6L,3L,2L,7L,4L,8L,5L,1L,9L,6L,3L,7L,2L,10L,8L,4L,9L,10L,5L,11L,1L,12L,13L,6L,14L,3L,7L,15L,2L,16L,17L,8L,18L,4L,9L,19L,10L,20L,5L,11L,21L,1L,12L,22L,13L,23L,6L,14L,24L,3L,15L,7L,16L,25L,2L,17L,26L,18L,19L,8L,20L,27L,4L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286343Inst : IEnumerable<long>
{
public static readonly long[] Value=A286343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286343.Bytes);
public long this[int i]=>Value[i];

public static A286343Inst Instance=new A286343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286344
{
public static readonly long[] Value={ 0L,2L,4L,20L,68L,288L,1138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286344Inst : IEnumerable<long>
{
public static readonly long[] Value=A286344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286344.Bytes);
public long this[int i]=>Value[i];

public static A286344Inst Instance=new A286344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286345
{
public static readonly long[] Value={ 0L,3L,17L,151L,955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286345Inst : IEnumerable<long>
{
public static readonly long[] Value=A286345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286345.Bytes);
public long this[int i]=>Value[i];

public static A286345Inst Instance=new A286345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286346
{
public static readonly long[] Value={ 1L,-24L,264L,-1760L,7944L,-25872L,64416L,-133056L,253704L,-472760L,825264L,-1297056L,1938336L,-2963664L,4437312L,-6091584L,8118024L,-11368368L,15653352L,-19822176L,24832944L,-32826112L,42517728L,-51425088L,61903776L,-78146664L,98021616L,-115331264L,133522752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286346Inst : IEnumerable<long>
{
public static readonly long[] Value=A286346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286346.Bytes);
public long this[int i]=>Value[i];

public static A286346Inst Instance=new A286346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286347
{
public static readonly BigInteger[] Value={ 1L,1L,15L,188L,3763L,54368L,790504L,11771179L,176285795L,2627027061L,39172906410L,584774465361L,8725442013820L,130117410190768L,1940656499251689L,28950613608637003L,431889355175650435L,6442566792491842258L,BigInteger.Parse("96102610815876310611"),BigInteger.Parse("1433558139553752297236") };
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
public class A286347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286347Inst Instance=new A286347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286348
{
public static readonly long[] Value={ 0L,3L,4L,7L,16L,17L,59L,283L,311L,383L,499L,521L,541L,599L,1193L,1993L,2671L,7547L,24019L,46301L,48121L,68597L,91283L,131497L,148663L,184463L,341233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286348Inst : IEnumerable<long>
{
public static readonly long[] Value=A286348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286348.Bytes);
public long this[int i]=>Value[i];

public static A286348Inst Instance=new A286348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286349
{
public static readonly long[] Value={ -1L,-1L,0L,-1L,1L,0L,-1L,1L,0L,0L,0L,-1L,1L,1L,0L,0L,0L,0L,-1L,1L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,1L,0L,-1L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286349Inst : IEnumerable<long>
{
public static readonly long[] Value=A286349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286349.Bytes);
public long this[int i]=>Value[i];

public static A286349Inst Instance=new A286349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286350
{
public static readonly long[] Value={ 0L,2L,2L,3L,4L,7L,12L,20L,32L,51L,82L,133L,216L,350L,566L,915L,1480L,2395L,3876L,6272L,10148L,16419L,26566L,42985L,69552L,112538L,182090L,294627L,476716L,771343L,1248060L,2019404L,3267464L,5286867L,8554330L,13841197L,22395528L,36236726L,58632254L,94868979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286350Inst : IEnumerable<long>
{
public static readonly long[] Value=A286350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286350.Bytes);
public long this[int i]=>Value[i];

public static A286350Inst Instance=new A286350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286351
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,6L,3L,0L,1L,1L,3L,0L,4L,1L,2L,1L,2L,2L,8L,0L,0L,0L,7L,3L,10L,1L,4L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286351Inst : IEnumerable<long>
{
public static readonly long[] Value=A286351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286351.Bytes);
public long this[int i]=>Value[i];

public static A286351Inst Instance=new A286351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286352
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,0L,0L,1L,-3L,1L,-1L,0L,1L,-4L,3L,-2L,1L,0L,1L,-5L,6L,-4L,4L,-1L,0L,1L,-6L,10L,-8L,9L,-4L,1L,0L,1L,-7L,15L,-15L,17L,-12L,5L,-1L,0L,1L,-8L,21L,-26L,30L,-28L,15L,-6L,2L,0L,1L,-9L,28L,-42L,51L,-56L,38L,-21L,9L,-2L,0L,1L,-10L,36L,-64L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286352Inst : IEnumerable<long>
{
public static readonly long[] Value=A286352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286352.Bytes);
public long this[int i]=>Value[i];

public static A286352Inst Instance=new A286352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286353
{
public static readonly long[] Value={ 75L,92L,696L,794L,921L,6946L,9211L,9418L,67365L,69446L,73515L,92111L,92592L,584799L,653597L,694446L,921111L,5793295L,6693466L,6944446L,7145554L,7694443L,9211111L,58788989L,61728398L,66733665L,69444446L,72175395L,76445374L,88183426L,89245679L,91721145L,92111111L,92592592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286353Inst : IEnumerable<long>
{
public static readonly long[] Value=A286353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286353.Bytes);
public long this[int i]=>Value[i];

public static A286353Inst Instance=new A286353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286354
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,-1L,0L,1L,-3L,-1L,0L,0L,1L,-4L,0L,2L,0L,0L,1L,-5L,2L,5L,1L,1L,0L,1L,-6L,5L,8L,0L,2L,0L,0L,1L,-7L,9L,10L,-5L,0L,-2L,1L,0L,1L,-8L,14L,10L,-15L,-4L,-7L,0L,0L,0L,1L,-9L,20L,7L,-30L,-6L,-10L,0L,-2L,0L,0L,1L,-10L,27L,0L,-49L,0L,-5L,8L,0L,-2L,0L,0L,1L,-11L,35L,-12L,-70L,21L,11L,25L,9L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286354Inst : IEnumerable<long>
{
public static readonly long[] Value=A286354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286354.Bytes);
public long this[int i]=>Value[i];

public static A286354Inst Instance=new A286354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286355
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,21L,23L,24L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,40L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,57L,58L,59L,61L,62L,64L,65L,67L,68L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,86L,87L,89L,90L,92L,93L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286355Inst : IEnumerable<long>
{
public static readonly long[] Value=A286355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286355.Bytes);
public long this[int i]=>Value[i];

public static A286355Inst Instance=new A286355Inst();

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