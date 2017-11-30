using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A136379
{
public static readonly long[] Value={ 2L,4L,9L,17L,25L,42L,76L,143L,273L,533L,1052L,2072L,4122L,8221L,16417L,32799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136379Inst : IEnumerable<long>
{
public static readonly long[] Value=A136379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136379.Bytes);
public long this[int i]=>Value[i];

public static A136379Inst Instance=new A136379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136380
{
public static readonly BigInteger[] Value={ 24L,160L,11968L,49657088L,837028380268032L,BigInteger.Parse("237269922100748727235760269312"),BigInteger.Parse("18811253173629696438994877569412700111469395859003555753984"),BigInteger.Parse("118178826602781220665226658680265194908312590801831513776333330179329649495708436476846379030238467286212637486694400") };
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
public class A136380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136380Inst Instance=new A136380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136381
{
public static readonly BigInteger[] Value={ 30L,240L,27300L,275332400L,27624273321353000L,BigInteger.Parse("277524424264553332245513535524000"),BigInteger.Parse("27762724550512424245125524562733322130552452655353526564552130000"),BigInteger.Parse("277751305605652455261312526532424241366545132655245452272135533332224427213254552451226545102753535225125262712455250570562640000") };
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
public class A136381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136381Inst Instance=new A136381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136382
{
public static readonly BigInteger[] Value={ 6L,40L,2992L,12414272L,209257095067008L,BigInteger.Parse("59317480525187181808940067328"),BigInteger.Parse("4702813293407424109748719392353175027867348964750888938496"),BigInteger.Parse("29544706650695305166306664670066298727078147700457878444083332544832412373927109119211594757559616821553159371673600") };
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
public class A136382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136382Inst Instance=new A136382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136383
{
public static readonly BigInteger[] Value={ 6L,50L,5660L,57266500L,5745056664272600L,BigInteger.Parse("57725105055132666451322727325000"),BigInteger.Parse("5774565132122505051225325134566664426132512553272725535132426000"),BigInteger.Parse("57772261341352513254262525526505050275531226553251312456427326666445105642653132512245531220572727245225254562513252136134550000") };
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
public class A136383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136383Inst Instance=new A136383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136384
{
public static readonly BigInteger[] Value={ 4L,48L,3360L,14043520L,233515838757120L,BigInteger.Parse("65982595605873500894008888320"),BigInteger.Parse("5233741023536997251047595348728205456443682897303843358720"),BigInteger.Parse("32837130684987081672210288030183520098814938795984162933658101468543499651419210151303128996446334767341864627691520") };
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
public class A136384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136384Inst Instance=new A136384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136385
{
public static readonly BigInteger[] Value={ 4L,60L,6440L,65444600L,6506064447454400L,BigInteger.Parse("65231606066154444716234545546000"),BigInteger.Parse("6527131623634606061431546150644447033623163115454546626154744000"),BigInteger.Parse("65254336276263162310334631144606060326621433115461563064745544444706171303315623163471156340654545471431467134615463624150660000") };
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
public class A136385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136385Inst Instance=new A136385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136386
{
public static readonly BigInteger[] Value={ 4L,8L,352L,3728L,7269662752L,761166466256046848L,BigInteger.Parse("390022035611646394530728097023856870592"),BigInteger.Parse("91600670557117582933643002658167825054614175029432880501373395030525438396928"),BigInteger.Parse("13417853484388319477475698658536993288839029124735549539652836318808118017743106800015257954250357092148394821846783842030516713870361254572407216621548672") };
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
public class A136386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136386Inst Instance=new A136386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136387
{
public static readonly BigInteger[] Value={ 100L,1000L,101100000L,111010010000L,BigInteger.Parse("110110001010011100100000000100000"),BigInteger.Parse("101010010000001101001101111001000100001000011000101100000000"),BigInteger.Parse("100100101011010111000001100000001000110011001010001110000001111101101000000000100010010000010000010100010010010100000010011000000") };
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
public class A136387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136387Inst Instance=new A136387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136388
{
public static readonly long[] Value={ 1L,-2L,2L,1L,-5L,4L,4L,-12L,8L,-1L,13L,-28L,16L,-6L,38L,-64L,32L,1L,-25L,104L,-144L,64L,8L,-88L,272L,-320L,128L,-1L,41L,-280L,688L,-704L,256L,-10L,170L,-832L,1696L,-1536L,512L,1L,-61L,620L,-2352L,4096L,-3328L,1024L,12L,-292L,2072L,-6400L,9728L,-7168L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136388Inst : IEnumerable<long>
{
public static readonly long[] Value=A136388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136388.Bytes);
public long this[int i]=>Value[i];

public static A136388Inst Instance=new A136388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136389
{
public static readonly long[] Value={ 1L,-3L,2L,3L,-7L,4L,-1L,9L,-16L,8L,-5L,25L,-36L,16L,1L,-19L,66L,-80L,32L,7L,-63L,168L,-176L,64L,-1L,33L,-192L,416L,-384L,128L,-9L,129L,-552L,1008L,-832L,256L,1L,-51L,450L,-1520L,2400L,-1792L,512L,11L,-231L,1452L,-4048L,5632L,-3840L,1024L,-1L,73L,-912L,4424L,-10496L,13056L,-8192L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136389Inst : IEnumerable<long>
{
public static readonly long[] Value=A136389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136389.Bytes);
public long this[int i]=>Value[i];

public static A136389Inst Instance=new A136389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136390
{
public static readonly long[] Value={ 1L,-4L,2L,6L,-9L,4L,-4L,16L,-20L,8L,1L,-14L,41L,-44L,16L,6L,-44L,102L,-96L,32L,-1L,26L,-129L,248L,-208L,64L,-8L,96L,-360L,592L,-448L,128L,1L,-42L,321L,-968L,1392L,-960L,256L,10L,-180L,1002L,-2528L,3232L,-2048L,512L,-1L,62L,-681L,2972L,-6448L,7424L,-4352L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136390Inst : IEnumerable<long>
{
public static readonly long[] Value=A136390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136390.Bytes);
public long this[int i]=>Value[i];

public static A136390Inst Instance=new A136390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136391
{
public static readonly long[] Value={ 1L,1L,4L,6L,13L,23L,43L,77L,138L,244L,429L,749L,1301L,2249L,3872L,6642L,11357L,19363L,32927L,55861L,94566L,159776L,269469L,453721L,762793L,1280593L,2147068L,3595422L,6013933L,10048559L,16773139L,27971549L,46605186L,77587084L,129063117L,214531397L,356346557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136391Inst : IEnumerable<long>
{
public static readonly long[] Value=A136391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136391.Bytes);
public long this[int i]=>Value[i];

public static A136391Inst Instance=new A136391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136408
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,27L,55L,107L,211L,427L,859L,1707L,3403L,6827L,13675L,27307L,54571L,109227L,218539L,436907L,873643L,1747627L,3495595L,6990507L,13980331L,27962027L,55925419L,111848107L,223693483L,447392427L,894790315L,1789569707L,3579128491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136408Inst : IEnumerable<long>
{
public static readonly long[] Value=A136408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136408.Bytes);
public long this[int i]=>Value[i];

public static A136408Inst Instance=new A136408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136409
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,18L,19L,20L,20L,21L,22L,22L,23L,23L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,30L,31L,32L,32L,33L,34L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,42L,43L,44L,44L,45L,46L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136409Inst : IEnumerable<long>
{
public static readonly long[] Value=A136409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136409.Bytes);
public long this[int i]=>Value[i];

public static A136409Inst Instance=new A136409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136410
{
public static readonly long[] Value={ 9L,15L,16L,21L,25L,27L,28L,33L,36L,39L,40L,45L,49L,51L,52L,57L,63L,64L,65L,66L,69L,75L,76L,81L,85L,87L,88L,91L,93L,96L,99L,100L,105L,111L,112L,117L,120L,121L,123L,124L,125L,126L,129L,133L,135L,136L,141L,144L,145L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136410Inst : IEnumerable<long>
{
public static readonly long[] Value=A136410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136410.Bytes);
public long this[int i]=>Value[i];

public static A136410Inst Instance=new A136410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136411
{
public static readonly BigInteger[] Value={ 1L,3L,135L,212625L,21097715625L,207248662456171875L,BigInteger.Parse("291128066470548703880859375"),BigInteger.Parse("79746389028864195813528714933837890625"),BigInteger.Parse("5570294521107277357810167397301815834831695556640625") };
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
public class A136411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136411Inst Instance=new A136411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136412
{
public static readonly long[] Value={ 2L,7L,27L,107L,427L,1707L,6827L,27307L,109227L,436907L,1747627L,6990507L,27962027L,111848107L,447392427L,1789569707L,7158278827L,28633115307L,114532461227L,458129844907L,1832519379627L,7330077518507L,29320310074027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136412Inst : IEnumerable<long>
{
public static readonly long[] Value=A136412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136412.Bytes);
public long this[int i]=>Value[i];

public static A136412Inst Instance=new A136412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136413
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,13L,17L,22L,27L,33L,39L,46L,54L,62L,71L,80L,90L,100L,111L,123L,135L,148L,161L,175L,189L,204L,220L,236L,253L,270L,288L,306L,325L,345L,365L,386L,407L,429L,451L,474L,498L,522L,547L,572L,598L,625L,652L,680L,708L,737L,766L,796L,827L,858L,890L,922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136413Inst : IEnumerable<long>
{
public static readonly long[] Value=A136413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136413.Bytes);
public long this[int i]=>Value[i];

public static A136413Inst Instance=new A136413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136414
{
public static readonly long[] Value={ 12L,23L,34L,45L,56L,67L,78L,89L,91L,10L,1L,11L,11L,12L,21L,13L,31L,14L,41L,15L,51L,16L,61L,17L,71L,18L,81L,19L,92L,20L,2L,21L,12L,22L,22L,23L,32L,24L,42L,25L,52L,26L,62L,27L,72L,28L,82L,29L,93L,30L,3L,31L,13L,32L,23L,33L,33L,34L,43L,35L,53L,36L,63L,37L,73L,38L,83L,39L,94L,40L,4L,41L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136414Inst : IEnumerable<long>
{
public static readonly long[] Value=A136414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136414.Bytes);
public long this[int i]=>Value[i];

public static A136414Inst Instance=new A136414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136415
{
public static readonly long[] Value={ 4L,6L,12L,14L,20L,22L,46L,52L,54L,60L,70L,76L,92L,94L,116L,124L,126L,140L,166L,174L,180L,182L,204L,206L,214L,220L,230L,236L,244L,252L,262L,276L,284L,286L,292L,294L,302L,332L,340L,350L,356L,364L,372L,374L,390L,404L,412L,430L,460L,484L,494L,510L,516L,526L,532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136415Inst : IEnumerable<long>
{
public static readonly long[] Value=A136415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136415.Bytes);
public long this[int i]=>Value[i];

public static A136415Inst Instance=new A136415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136416
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,15L,17L,18L,20L,21L,22L,23L,25L,28L,29L,31L,33L,35L,36L,39L,41L,42L,47L,49L,52L,54L,55L,57L,58L,60L,62L,63L,65L,66L,68L,71L,73L,74L,76L,79L,81L,84L,86L,87L,89L,92L,93L,94L,95L,97L,98L,100L,102L,103L,105L,106L,108L,110L,111L,113L,118L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136416Inst : IEnumerable<long>
{
public static readonly long[] Value=A136416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136416.Bytes);
public long this[int i]=>Value[i];

public static A136416Inst Instance=new A136416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136417
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,6L,9L,12L,17L,23L,33L,46L,65L,91L,129L,182L,257L,363L,513L,725L,1025L,1449L,2049L,2897L,4097L,5793L,8193L,11586L,16385L,23171L,32769L,46341L,65537L,92682L,131073L,185364L,262145L,370728L,524289L,741456L,1048577L,1482911L,2097153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136417Inst : IEnumerable<long>
{
public static readonly long[] Value=A136417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136417.Bytes);
public long this[int i]=>Value[i];

public static A136417Inst Instance=new A136417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136418
{
public static readonly long[] Value={ 0L,105L,385L,1365L,1785L,2805L,3135L,10353L,6545L,12155L,21385L,11165L,21505L,10465L,16555L,19285L,37961L,35105L,18445L,24395L,23205L,53669L,11305L,28595L,17255L,36465L,20615L,42315L,123585L,31535L,49335L,39585L,61295L,35805L,72709L,54285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136418Inst : IEnumerable<long>
{
public static readonly long[] Value=A136418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136418.Bytes);
public long this[int i]=>Value[i];

public static A136418Inst Instance=new A136418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136419
{
public static readonly BigInteger[] Value={ 1L,15L,924L,125970L,30045015L,11058116888L,5804731963800L,4116305022165108L,3789648142708598775L,BigInteger.Parse("4393971523180763714190"),BigInteger.Parse("6264034568006128435579200"),BigInteger.Parse("10768081679718351117338193075"),BigInteger.Parse("21964431474217462812712934302044") };
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
public class A136419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136419Inst Instance=new A136419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136420
{
public static readonly long[] Value={ 2357L,1113L,1719L,2329L,3137L,4143L,4753L,5961L,6771L,7379L,8389L,9710L,1103L,1071L,911L,3127L,1311L,3713L,9149L,1511L,5716L,3167L,1731L,7918L,1191L,1931L,9719L,9211L,2232L,2722L,9233L,2392L,4125L,1257L,2632L,6927L,1277L,2812L,8329L,3307L,3113L,1331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136420Inst : IEnumerable<long>
{
public static readonly long[] Value=A136420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136420.Bytes);
public long this[int i]=>Value[i];

public static A136420Inst Instance=new A136420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136421
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,6L,7L,8L,10L,12L,14L,17L,21L,25L,31L,37L,44L,54L,65L,78L,94L,114L,138L,166L,200L,242L,292L,352L,425L,514L,620L,748L,903L,1090L,1316L,1589L,1918L,2315L,2794L,3373L,4072L,4915L,5933L,7162L,8645L,10436L,12597L,15206L,18355L,22156L,26745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136421Inst : IEnumerable<long>
{
public static readonly long[] Value=A136421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136421.Bytes);
public long this[int i]=>Value[i];

public static A136421Inst Instance=new A136421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136422
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,7L,10L,13L,18L,24L,33L,45L,62L,85L,116L,158L,216L,296L,404L,551L,753L,1029L,1406L,1920L,2623L,3583L,4895L,6687L,9134L,12477L,17044L,23283L,31805L,43447L,59349L,81072L,110747L,151283L,206657L,282298L,385626L,526775L,719589L,982976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136422Inst : IEnumerable<long>
{
public static readonly long[] Value=A136422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136422.Bytes);
public long this[int i]=>Value[i];

public static A136422Inst Instance=new A136422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136423
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,13L,19L,29L,43L,65L,97L,146L,219L,328L,493L,739L,1108L,1663L,2494L,3741L,5611L,8417L,12626L,18938L,28408L,42611L,63917L,95876L,143813L,215720L,323580L,485370L,728055L,1092082L,1638123L,2457185L,3685777L,5528666L,8292999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136423Inst : IEnumerable<long>
{
public static readonly long[] Value=A136423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136423.Bytes);
public long this[int i]=>Value[i];

public static A136423Inst Instance=new A136423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136648
{
public static readonly BigInteger[] Value={ 1L,1L,3L,43L,1625L,192785L,73792371L,94005141667L,408909577044065L,6204433373664395569L,BigInteger.Parse("334203804752658372354515"),BigInteger.Parse("64828498485572980097719939179"),BigInteger.Parse("45811084061472137471487315433296153") };
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
public class A136648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136648Inst Instance=new A136648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136649
{
public static readonly BigInteger[] Value={ 1L,3L,11L,81L,2089L,211107L,76211147L,95054910473L,410422012327681L,6211807332775516467L,BigInteger.Parse("334327967114349983723899"),BigInteger.Parse("64835852334793138873642165105"),BigInteger.Parse("45812640033676518721399820389451657") };
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
public class A136649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136649Inst Instance=new A136649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136650
{
public static readonly BigInteger[] Value={ 1L,2L,5L,20L,148L,2208L,67904L,4264960L,541216768L,137984868352L,70507295670272L,72128242290524160L,BigInteger.Parse("147646152060442771456"),BigInteger.Parse("604610628447525580832768"),BigInteger.Parse("4952364915780360673188380672"),BigInteger.Parse("81134591384874923825347187179520") };
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
public class A136650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136650Inst Instance=new A136650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136651
{
public static readonly BigInteger[] Value={ 1L,4L,16L,136L,3900L,410704L,150779216L,189354108224L,819706419291728L,12417873698752685696UL,BigInteger.Parse("668556572391910046409088"),BigInteger.Parse("129665687275486846550512590336"),BigInteger.Parse("91623983383737723477835280780455168"),BigInteger.Parse("238057598315149125515904595621291745671168"),BigInteger.Parse("2291332225550784443587332334013451028612830795776") };
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
public class A136651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136651Inst Instance=new A136651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136652
{
public static readonly BigInteger[] Value={ 1L,3L,19L,223L,4771L,190023L,14441659L,2130394591L,616038609331L,351153716973303L,395928966997611499L,BigInteger.Parse("885010943452285951183"),BigInteger.Parse("3928049212346654960720611"),BigInteger.Parse("34658088824057172975437120103"),BigInteger.Parse("608435145369338712372672919898779"),BigInteger.Parse("21266998855813018955669706360248449471") };
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
public class A136652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136652Inst Instance=new A136652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136653
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,39L,748L,27162L,1880872L,252273611L,66358216668L,34506398937158L,35644762692112792L,BigInteger.Parse("73356520492898454022"),BigInteger.Parse("301274559225693420690360"),BigInteger.Parse("2471654510727312089903896948"),BigInteger.Parse("40527708183358718551543295827536") };
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
public class A136653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136653Inst Instance=new A136653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136654
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,117L,1565L,41663L,2378147L,286991465L,71261033273L,35889915535835L,36421251158141399L,BigInteger.Parse("74222529448186797341"),BigInteger.Parse("303194457634544530959125"),BigInteger.Parse("2480120130065258782050157847"),BigInteger.Parse("40601998283406419045206334661611") };
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
public class A136654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136654Inst Instance=new A136654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136655
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,27L,5L,11L,3L,13L,7L,225L,1L,17L,27L,19L,5L,441L,11L,23L,3L,125L,13L,729L,7L,29L,225L,31L,1L,1089L,17L,1225L,27L,37L,19L,1521L,5L,41L,441L,43L,11L,91125L,23L,47L,3L,343L,125L,2601L,13L,53L,729L,3025L,7L,3249L,29L,59L,225L,61L,31L,250047L,1L,4225L,1089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136655Inst : IEnumerable<long>
{
public static readonly long[] Value=A136655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136655.Bytes);
public long this[int i]=>Value[i];

public static A136655Inst Instance=new A136655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136656
{
public static readonly long[] Value={ 1L,0L,-2L,0L,6L,4L,0L,-24L,-36L,-8L,0L,120L,300L,144L,16L,0L,-720L,-2640L,-2040L,-480L,-32L,0L,5040L,25200L,27720L,10320L,1440L,64L,0L,-40320L,-262080L,-383040L,-199920L,-43680L,-4032L,-128L,0L,362880L,2963520L,5503680L,3764880L,1142400L,163968L,10752L,256L,0L,-3628800L,-36288000L,-82978560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136656Inst : IEnumerable<long>
{
public static readonly long[] Value=A136656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136656.Bytes);
public long this[int i]=>Value[i];

public static A136656Inst Instance=new A136656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136657
{
public static readonly long[] Value={ 1L,3L,2L,12L,18L,4L,60L,150L,72L,8L,360L,1320L,1020L,240L,16L,2520L,12600L,13860L,5160L,720L,32L,20160L,131040L,191520L,99960L,21840L,2016L,64L,181440L,1481760L,2751840L,1882440L,571200L,81984L,5376L,128L,1814400L,18144000L,41489280L,35622720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136657Inst : IEnumerable<long>
{
public static readonly long[] Value=A136657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136657.Bytes);
public long this[int i]=>Value[i];

public static A136657Inst Instance=new A136657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136658
{
public static readonly BigInteger[] Value={ 1L,2L,10L,68L,580L,5912L,69784L,933200L,13912336L,228390560L,4088594464L,79186453568L,1648396356160L,36678170613632L,868239454798720L,21776352497954048L,576629116655862016L,16069766602389885440UL,BigInteger.Parse("470015788927133039104"),BigInteger.Parse("14392014594072635786240") };
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
public class A136658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136658Inst Instance=new A136658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136659
{
public static readonly BigInteger[] Value={ 1L,9L,75L,660L,6300L,65520L,740880L,9072000L,119750400L,1696464000L,25686460800L,414096883200L,7083236160000L,128152088064000L,2445351068160000L,49084865077248000L,1033983353475072000L,BigInteger.Parse("22808456326656000000") };
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
public class A136659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136659Inst Instance=new A136659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136660
{
public static readonly BigInteger[] Value={ 1L,18L,255L,3465L,47880L,687960L,10372320L,164656800L,2754259200L,48518870400L,899026128000L,17495593315200L,356995102464000L,7625049239808000L,170196434343936000L,3963602854987776000L,BigInteger.Parse("96160451873181696000") };
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
public class A136660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136660Inst Instance=new A136660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136661
{
public static readonly BigInteger[] Value={ 1L,30L,645L,12495L,235305L,4452840L,86070600L,1713927600L,35318883600L,754896542400L,16751853518400L,386036370720000L,9235831629024000L,229285008336384000L,5902321642753536000L,BigInteger.Parse("157423965566579712000") };
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
public class A136661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136661Inst Instance=new A136661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136662
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,1L,1L,2L,4L,3L,3L,2L,2L,3L,3L,2L,2L,1L,1L,2L,2L,1L,3L,2L,2L,1L,1L,2L,2L,3L,1L,2L,5L,4L,4L,3L,3L,4L,4L,3L,3L,2L,2L,3L,3L,2L,4L,3L,3L,2L,2L,3L,3L,4L,2L,3L,4L,3L,3L,2L,2L,3L,3L,2L,2L,1L,1L,2L,2L,1L,3L,2L,2L,1L,1L,2L,2L,3L,1L,2L,3L,2L,2L,1L,1L,2L,4L,3L,3L,2L,2L,3L,3L,2L,2L,1L,1L,2L,2L,3L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136662Inst : IEnumerable<long>
{
public static readonly long[] Value=A136662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136662.Bytes);
public long this[int i]=>Value[i];

public static A136662Inst Instance=new A136662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136663
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,2L,-2L,0L,6L,4L,-4L,-8L,4L,16L,8L,-4L,-20L,-20L,20L,40L,16L,0L,-24L,-72L,-40L,72L,96L,32L,8L,0L,-112L,-224L,-56L,224L,224L,64L,16L,64L,-32L,-448L,-624L,0L,640L,512L,128L,16L,144L,288L,-288L,-1584L,-1584L,384L,1728L,1152L,256L,0L,160L,800L,960L,-1600L,-5088L,-3680L,1920L,4480L,2560L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136663Inst : IEnumerable<long>
{
public static readonly long[] Value=A136663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136663.Bytes);
public long this[int i]=>Value[i];

public static A136663Inst Instance=new A136663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136776
{
public static readonly long[] Value={ 1L,2L,6L,17L,48L,135L,379L,1063L,2980L,8352L,23405L,65584L,183769L,514919L,1442785L,4042614L,11327182L,31738101L,88928244L,249171491L,698163131L,1956209807L,5481178344L,15357920824L,43031938457L,120572813012L,337837515853L,946599685919L,2652313383105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136776Inst : IEnumerable<long>
{
public static readonly long[] Value=A136776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136776.Bytes);
public long this[int i]=>Value[i];

public static A136776Inst Instance=new A136776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136777
{
public static readonly long[] Value={ 1L,4L,22L,124L,706L,4036L,23110L,132412L,758866L,4349572L,24931318L,142906108L,819141730L,4695354436L,26913992998L,154272336316L,884296781554L,5068833880324L,29054812882390L,166543662614908L,954636733448194L,5472026253591748L,31365932493907462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136777Inst : IEnumerable<long>
{
public static readonly long[] Value=A136777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136777.Bytes);
public long this[int i]=>Value[i];

public static A136777Inst Instance=new A136777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136778
{
public static readonly long[] Value={ 1L,3L,15L,75L,381L,1947L,9975L,51159L,262497L,1347123L,6913911L,35485779L,182133885L,934823451L,4798101855L,24626900271L,126400914849L,648769995939L,3329901037119L,17091174551835L,87722802540957L,450249343708827L,2310966659437671L,11861354115061383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136778Inst : IEnumerable<long>
{
public static readonly long[] Value=A136778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136778.Bytes);
public long this[int i]=>Value[i];

public static A136778Inst Instance=new A136778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136779
{
public static readonly long[] Value={ 1L,3L,18L,105L,606L,3483L,19986L,114609L,657054L,3766515L,21590418L,123758649L,709393758L,4066287627L,23308182162L,133603718145L,765823377054L,4389738680547L,25162205542674L,144231041494281L,826739659899486L,4738913739770235L,27163694339468562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136779Inst : IEnumerable<long>
{
public static readonly long[] Value=A136779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136779.Bytes);
public long this[int i]=>Value[i];

public static A136779Inst Instance=new A136779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136780
{
public static readonly long[] Value={ 1L,2L,13L,68L,358L,1871L,9757L,50825L,264622L,1377455L,7169434L,37314044L,194200651L,1010706167L,5260139653L,27375923678L,142475405353L,741499470476L,3859061584762L,20084107492055L,104525763472957L,543994053280925L,2831163512738434L,14734511818610939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136780Inst : IEnumerable<long>
{
public static readonly long[] Value=A136780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136780.Bytes);
public long this[int i]=>Value[i];

public static A136780Inst Instance=new A136780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136781
{
public static readonly long[] Value={ 1L,3L,21L,162L,1305L,10719L,88830L,739179L,6162669L,51425010L,429299217L,3584510631L,29932216686L,249957514899L,2087382613509L,17431787135682L,145573937119305L,1215699423313455L,10152411188679774L,84783702198390651L,708036493717628253L,5912878431088447506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136781Inst : IEnumerable<long>
{
public static readonly long[] Value=A136781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136781.Bytes);
public long this[int i]=>Value[i];

public static A136781Inst Instance=new A136781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136782
{
public static readonly long[] Value={ 1L,2L,16L,119L,934L,7463L,60145L,486605L,3943960L,31992446L,259613953L,2107099586L,17103200263L,138830852135L,1126943433241L,9147906485462L,74257943539984L,602788362550355L,4893134369283898L,39720031331092499L,322427514601782961L,2617306853237874173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136782Inst : IEnumerable<long>
{
public static readonly long[] Value=A136782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136782.Bytes);
public long this[int i]=>Value[i];

public static A136782Inst Instance=new A136782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136783
{
public static readonly long[] Value={ 1L,4L,20L,112L,660L,3976L,24180L,147648L,903140L,5528504L,33853220L,207325392L,1269787060L,7777149416L,47633751380L,291750220768L,1786933908740L,10944758154264L,67035370422020L,410583912229872L,2514779283989460L,15402734618128456L,94339983758166580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136783Inst : IEnumerable<long>
{
public static readonly long[] Value=A136783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136783.Bytes);
public long this[int i]=>Value[i];

public static A136783Inst Instance=new A136783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136784
{
public static readonly long[] Value={ 1L,3L,13L,67L,369L,2083L,11869L,67875L,388705L,2227267L,12764973L,73165315L,419377873L,2403873891L,13779078781L,78982269667L,452730133185L,2595071559811L,14875080747085L,85264715699139L,488741675881009L,2801492102959267L,16058295037221021L,92046962959297699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136784Inst : IEnumerable<long>
{
public static readonly long[] Value=A136784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136784.Bytes);
public long this[int i]=>Value[i];

public static A136784Inst Instance=new A136784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136785
{
public static readonly long[] Value={ 1L,5L,30L,182L,1110L,6786L,41530L,254278L,1557190L,9536994L,58411370L,357758662L,2191219510L,13420938626L,82201632730L,503475374598L,3083728434790L,18887481888354L,115683658636170L,708549144071942L,4339782295309910L,26580669235880066L,162803553266871930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136785Inst : IEnumerable<long>
{
public static readonly long[] Value=A136785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136785.Bytes);
public long this[int i]=>Value[i];

public static A136785Inst Instance=new A136785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136786
{
public static readonly long[] Value={ 1L,4L,21L,111L,592L,3171L,17021L,91456L,491641L,2643523L,14215596L,76448559L,411134641L,2211076788L,11891207045L,63951270079L,343932277888L,1849681481203L,9947663349453L,53498950981392L,287719621233865L,1547368337500659L,8321812723167356L,44755063012476127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136786Inst : IEnumerable<long>
{
public static readonly long[] Value=A136786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136786.Bytes);
public long this[int i]=>Value[i];

public static A136786Inst Instance=new A136786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136787
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,4L,4L,1L,9L,9L,9L,7L,1L,21L,21L,21L,21L,11L,1L,51L,51L,51L,51L,46L,16L,1L,127L,127L,127L,127L,127L,92L,22L,1L,323L,323L,323L,323L,323L,309L,169L,29L,1L,835L,835L,835L,835L,835L,835L,709L,289L,37L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136787Inst : IEnumerable<long>
{
public static readonly long[] Value=A136787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136787.Bytes);
public long this[int i]=>Value[i];

public static A136787Inst Instance=new A136787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136788
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,6L,7L,1L,1L,2L,6L,17L,11L,1L,1L,2L,6L,22L,41L,16L,1L,1L,2L,6L,22L,76L,86L,22L,1L,1L,2L,6L,22L,90L,226L,162L,29L,1L,1L,2L,6L,22L,90L,352L,582L,281L,37L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136788Inst : IEnumerable<long>
{
public static readonly long[] Value=A136788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136788.Bytes);
public long this[int i]=>Value[i];

public static A136788Inst Instance=new A136788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136789
{
public static readonly long[] Value={ 1L,0L,2L,1L,-1L,5L,1L,4L,-5L,15L,4L,2L,17L,-23L,52L,11L,17L,2L,79L,-109L,203L,41L,46L,80L,-20L,397L,-544L,877L,162L,198L,208L,418L,-244L,2134L,-2876L,4140L,715L,841L,1031L,994L,2389L,-2053L,12196L,-16113L,21147L,3425L,4014L,4663L,5771L,4950L,14693L,-15859L,73798L,-95495L,115975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136789Inst : IEnumerable<long>
{
public static readonly long[] Value=A136789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136789.Bytes);
public long this[int i]=>Value[i];

public static A136789Inst Instance=new A136789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136790
{
public static readonly long[] Value={ 1L,-1L,2L,4L,-7L,5L,-7L,32L,-35L,15L,37L,-131L,228L,-171L,52L,-94L,646L,-1379L,1540L,-864L,203L,587L,-3146L,8648L,-12483L,10308L,-4588L,877L,-1955L,17464L,-55125L,98923L,-106834L,69951L,-25717L,4140L,13606L,-98053L,367914L,-781241L,1044519L,-898394L,486811L,-152169L,21147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136790Inst : IEnumerable<long>
{
public static readonly long[] Value=A136790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136790.Bytes);
public long this[int i]=>Value[i];

public static A136790Inst Instance=new A136790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136791
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,9L,9L,13L,19L,29L,29L,39L,53L,73L,103L,103L,133L,173L,227L,301L,405L,405L,509L,643L,817L,1045L,1347L,1753L,1753L,2159L,2669L,3313L,4131L,5177L,6525L,8279L,8279L,100033L,12193L,14863L,18177L,22309L,27487L,34013L,42293L,42293L,50573L,60607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136791Inst : IEnumerable<long>
{
public static readonly long[] Value=A136791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136791.Bytes);
public long this[int i]=>Value[i];

public static A136791Inst Instance=new A136791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136824
{
public static readonly long[] Value={ 0L,1L,5L,10L,11L,15L,50L,100L,101L,105L,110L,150L,500L,501L,505L,711L,715L,755L,1000L,1001L,1005L,1010L,1011L,1050L,1100L,1101L,1105L,1255L,1500L,5000L,5001L,5005L,5010L,5011L,5015L,5050L,7110L,7150L,7251L,7550L,10000L,10001L,10005L,10010L,10011L,10050L,10100L,10105L,10110L,10500L,10501L,11000L,11001L,11005L,11010L,11050L,11205L,12550L,15000L,15005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136824Inst : IEnumerable<long>
{
public static readonly long[] Value=A136824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136824.Bytes);
public long this[int i]=>Value[i];

public static A136824Inst Instance=new A136824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136825
{
public static readonly long[] Value={ 0L,1L,5L,10L,11L,15L,50L,100L,101L,105L,110L,150L,151L,285L,500L,501L,505L,1000L,1001L,1005L,1010L,1011L,1050L,1100L,1101L,1105L,1500L,1510L,1585L,2255L,2285L,2850L,2851L,2855L,5000L,5001L,5005L,5010L,5011L,5015L,5050L,10000L,10001L,10005L,10010L,10011L,10050L,10100L,10105L,10110L,10500L,11000L,11001L,11005L,11010L,11050L,11205L,12255L,15000L,15005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136825Inst : IEnumerable<long>
{
public static readonly long[] Value=A136825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136825.Bytes);
public long this[int i]=>Value[i];

public static A136825Inst Instance=new A136825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136826
{
public static readonly long[] Value={ 0L,1L,5L,10L,11L,15L,50L,95L,100L,101L,105L,110L,150L,500L,501L,505L,950L,955L,995L,1000L,1001L,1005L,1010L,1011L,1050L,1095L,1100L,1101L,1105L,1500L,1515L,5000L,5001L,5005L,5010L,5011L,5015L,5050L,5095L,9500L,9550L,9950L,9955L,9995L,10000L,10001L,10005L,10010L,10011L,10050L,10095L,10100L,10105L,10110L,10500L,10950L,10955L,11000L,11001L,11005L,11010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136826Inst : IEnumerable<long>
{
public static readonly long[] Value=A136826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136826.Bytes);
public long this[int i]=>Value[i];

public static A136826Inst Instance=new A136826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136827
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,1000L,1001L,1010L,1011L,1100L,1101L,10000L,10001L,10010L,10011L,10100L,10110L,11000L,11001L,11010L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,110000L,110001L,110010L,110100L,1000000L,1000001L,1000010L,1000011L,1000100L,1000101L,1000110L,1001000L,1001010L,1001100L,1010000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136827Inst : IEnumerable<long>
{
public static readonly long[] Value=A136827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136827.Bytes);
public long this[int i]=>Value[i];

public static A136827Inst Instance=new A136827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136828
{
public static readonly long[] Value={ 0L,1L,10L,11L,26L,100L,101L,110L,260L,276L,776L,1000L,1001L,1010L,1011L,1100L,1101L,2600L,2760L,2776L,7760L,10000L,10001L,10010L,10011L,10100L,10110L,10776L,11000L,11001L,11010L,11076L,26000L,27600L,27760L,77600L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,107760L,110000L,110001L,110010L,110100L,110760L,161761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136828Inst : IEnumerable<long>
{
public static readonly long[] Value=A136828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136828.Bytes);
public long this[int i]=>Value[i];

public static A136828Inst Instance=new A136828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136829
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,261L,1000L,1001L,1010L,1011L,1100L,1101L,2610L,10000L,10001L,10010L,10011L,10100L,10110L,10801L,11000L,11001L,11010L,11261L,26100L,26101L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,108010L,110000L,110001L,110010L,110100L,112610L,261000L,261010L,282881L,816261L,1000000L,1000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136829Inst : IEnumerable<long>
{
public static readonly long[] Value=A136829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136829.Bytes);
public long this[int i]=>Value[i];

public static A136829Inst Instance=new A136829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136830
{
public static readonly long[] Value={ 0L,1L,10L,11L,96L,100L,101L,110L,960L,996L,1000L,1001L,1010L,1011L,1096L,1100L,1101L,1619L,9600L,9960L,9996L,10000L,10001L,10010L,10011L,10096L,10100L,10110L,10960L,10996L,11000L,11001L,11010L,16190L,96000L,96001L,99600L,99960L,99996L,100000L,100001L,100010L,100011L,100096L,100100L,100101L,100110L,100960L,100996L,101000L,101001L,101100L,109600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136830Inst : IEnumerable<long>
{
public static readonly long[] Value=A136830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136830.Bytes);
public long this[int i]=>Value[i];

public static A136830Inst Instance=new A136830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136831
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,1000L,1001L,1010L,1011L,1100L,1101L,10000L,10001L,10010L,10011L,10100L,10110L,11000L,11001L,11010L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,110000L,110001L,110010L,110100L,1000000L,1000001L,1000010L,1000011L,1000100L,1000101L,1000110L,1001000L,1001010L,1001100L,1010000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136831Inst : IEnumerable<long>
{
public static readonly long[] Value=A136831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136831.Bytes);
public long this[int i]=>Value[i];

public static A136831Inst Instance=new A136831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136832
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,1000L,1001L,1010L,1011L,1100L,1101L,10000L,10001L,10010L,10011L,10100L,10110L,11000L,11001L,11010L,87811L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,110000L,110001L,110010L,110100L,878110L,1000000L,1000001L,1000010L,1000011L,1000100L,1000101L,1000110L,1001000L,1001010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136832Inst : IEnumerable<long>
{
public static readonly long[] Value=A136832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136832.Bytes);
public long this[int i]=>Value[i];

public static A136832Inst Instance=new A136832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136833
{
public static readonly long[] Value={ 0L,1L,10L,11L,27L,100L,101L,110L,270L,1000L,1001L,1010L,1011L,1100L,1101L,1127L,2700L,2777L,10000L,10001L,10010L,10011L,10100L,10110L,11000L,11001L,11010L,11270L,11277L,27000L,27770L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,110000L,110001L,110010L,110100L,112700L,112770L,270000L,277700L,1000000L,1000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136833Inst : IEnumerable<long>
{
public static readonly long[] Value=A136833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136833.Bytes);
public long this[int i]=>Value[i];

public static A136833Inst Instance=new A136833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136834
{
public static readonly BigInteger[] Value={ 1L,18L,2180L,2200776L,20355006224L,1801272981919008L,BigInteger.Parse("1560858753560238398528"),BigInteger.Parse("13428038397958481723104394368"),BigInteger.Parse("1157111379933346772804754279450353920"),BigInteger.Parse("1004777133003025735713513459537724394989392384") };
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
public class A136834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136834Inst Instance=new A136834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136835
{
public static readonly long[] Value={ 0L,1L,9L,10L,11L,90L,91L,99L,100L,101L,109L,110L,899L,900L,901L,910L,911L,990L,991L,999L,1000L,1001L,1009L,1010L,1011L,1090L,1091L,1100L,1101L,1109L,8989L,8990L,8999L,9000L,9001L,9010L,9011L,9100L,9101L,9110L,9900L,9901L,9909L,9910L,9990L,9991L,9999L,10000L,10001L,10009L,10010L,10011L,10090L,10091L,10099L,10100L,10109L,10110L,10900L,10910L,10991L,11000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136835Inst : IEnumerable<long>
{
public static readonly long[] Value=A136835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136835.Bytes);
public long this[int i]=>Value[i];

public static A136835Inst Instance=new A136835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136836
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,1000L,1001L,1010L,1011L,1100L,1101L,10000L,10001L,10010L,10011L,10100L,10110L,11000L,11001L,11010L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,110000L,110001L,110010L,110100L,1000000L,1000001L,1000010L,1000011L,1000100L,1000101L,1000110L,1001000L,1001010L,1001100L,1010000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136836Inst : IEnumerable<long>
{
public static readonly long[] Value=A136836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136836.Bytes);
public long this[int i]=>Value[i];

public static A136836Inst Instance=new A136836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136837
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,100000L,100501L,550501L,551501L,1000000L,1005010L,5505010L,5515010L,10000000L,10005001L,10050100L,10055001L,55050100L,55055001L,55150100L,100000000L,100050010L,100501000L,100550010L,550501000L,550550010L,551501000L,1000000000L,1000050001L,1000050501L,1000500100L,1000501451L,1000550001L,1000550501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136837Inst : IEnumerable<long>
{
public static readonly long[] Value=A136837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136837.Bytes);
public long this[int i]=>Value[i];

public static A136837Inst Instance=new A136837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136838
{
public static readonly long[] Value={ 0L,1L,4L,6L,10L,40L,60L,100L,400L,600L,1000L,1146L,4000L,6000L,10000L,10301L,11460L,33631L,40000L,60000L,100000L,103010L,103131L,114600L,336310L,400000L,404306L,600000L,601344L,603444L,660306L,663631L,1000000L,1003001L,1030100L,1031310L,1146000L,1160306L,3336631L,3363100L,3363646L,4000000L,4014304L,4043060L,6000000L,6013440L,6034440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136838Inst : IEnumerable<long>
{
public static readonly long[] Value=A136838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136838.Bytes);
public long this[int i]=>Value[i];

public static A136838Inst Instance=new A136838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136839
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,1071L,10000L,10710L,100000L,107100L,174071L,370771L,1000000L,1071000L,1170771L,1740710L,1743771L,3707710L,10000000L,10710000L,11707710L,17334071L,17407100L,17437710L,37077100L,100000000L,100370001L,107100000L,117077100L,133310701L,173340710L,174071000L,174073071L,174377100L,370771000L,374713771L,414017001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136839Inst : IEnumerable<long>
{
public static readonly long[] Value=A136839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136839.Bytes);
public long this[int i]=>Value[i];

public static A136839Inst Instance=new A136839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136888
{
public static readonly long[] Value={ 0L,5L,6L,25L,50L,55L,60L,225L,235L,250L,255L,256L,500L,505L,506L,550L,566L,600L,605L,2250L,2350L,2500L,2550L,2560L,5000L,5005L,5006L,5025L,5050L,5055L,5060L,5500L,5505L,5525L,5535L,5660L,6000L,6005L,6025L,6050L,6055L,22500L,22506L,23500L,23506L,23566L,23665L,25000L,25005L,25006L,25025L,25225L,25500L,25505L,25506L,25535L,25566L,25600L,50000L,50005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136888Inst : IEnumerable<long>
{
public static readonly long[] Value=A136888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136888.Bytes);
public long this[int i]=>Value[i];

public static A136888Inst Instance=new A136888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136889
{
public static readonly long[] Value={ 0L,5L,50L,55L,235L,500L,505L,550L,755L,2350L,5000L,5005L,5050L,5055L,5500L,5505L,7550L,23500L,50000L,50005L,50050L,50055L,50235L,50500L,50505L,50550L,55000L,55005L,55050L,57055L,57735L,72335L,73055L,75500L,223735L,235000L,235005L,235235L,500000L,500005L,500050L,500055L,500235L,500500L,500505L,500550L,500755L,502350L,505000L,505005L,505050L,505500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136889Inst : IEnumerable<long>
{
public static readonly long[] Value=A136889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136889.Bytes);
public long this[int i]=>Value[i];

public static A136889Inst Instance=new A136889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136890
{
public static readonly long[] Value={ 0L,5L,50L,55L,235L,500L,505L,550L,555L,2255L,2350L,2885L,5000L,5005L,5050L,5055L,5500L,5505L,5550L,5555L,22550L,23500L,28850L,50000L,50005L,50050L,50055L,50235L,50500L,50550L,50555L,55000L,55005L,55050L,55500L,55505L,55550L,225500L,225505L,235000L,235055L,235235L,288500L,500000L,500005L,500050L,500055L,500235L,500500L,500505L,500550L,500555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136890Inst : IEnumerable<long>
{
public static readonly long[] Value=A136890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136890.Bytes);
public long this[int i]=>Value[i];

public static A136890Inst Instance=new A136890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136891
{
public static readonly long[] Value={ 0L,3L,5L,23L,30L,50L,55L,95L,230L,235L,300L,305L,500L,503L,505L,550L,950L,995L,2300L,2350L,3000L,3005L,3050L,3055L,5000L,5003L,5005L,5023L,5030L,5050L,5055L,5095L,5500L,5505L,5523L,9500L,9950L,9995L,23000L,23005L,23500L,30000L,30005L,30050L,30055L,30500L,30505L,30550L,50000L,50003L,50005L,50023L,50030L,50050L,50055L,50095L,50230L,50235L,50300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136891Inst : IEnumerable<long>
{
public static readonly long[] Value=A136891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136891.Bytes);
public long this[int i]=>Value[i];

public static A136891Inst Instance=new A136891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136892
{
public static readonly long[] Value={ 0L,6L,26L,60L,260L,600L,606L,2600L,6000L,6006L,6060L,26000L,60000L,60006L,60060L,60600L,260000L,270606L,600000L,600006L,600060L,600600L,606000L,2600000L,2603326L,2706060L,6000000L,6000006L,6000060L,6000600L,6000606L,6006000L,6060000L,6060006L,26000000L,26033260L,27060600L,60000000L,60000006L,60000060L,60000600L,60000606L,60006000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136892Inst : IEnumerable<long>
{
public static readonly long[] Value=A136892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136892.Bytes);
public long this[int i]=>Value[i];

public static A136892Inst Instance=new A136892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136893
{
public static readonly long[] Value={ 0L,6L,60L,600L,6000L,60000L,600000L,6000000L,60000000L,600000000L,2868603006L,6000000000L,6066368606L,28686030060L,60000000000L,60002363606L,60663686060L,82866388606L,286860300600L,600000000000L,600023636060L,606636860600L,828663886060L,2868603006000L,6000000000000L,6000236360600L,6066368606000L,8286638860600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136893Inst : IEnumerable<long>
{
public static readonly long[] Value=A136893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136893.Bytes);
public long this[int i]=>Value[i];

public static A136893Inst Instance=new A136893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136894
{
public static readonly long[] Value={ 0L,3L,6L,30L,60L,63L,300L,306L,600L,603L,630L,3000L,3006L,3060L,6000L,6003L,6030L,6300L,26323L,30000L,30006L,30060L,30600L,60000L,60003L,60030L,60300L,63000L,263230L,263323L,300000L,300006L,300060L,300600L,306000L,600000L,600003L,600030L,600300L,603000L,630000L,2632300L,2633230L,3000000L,3000006L,3000060L,3000600L,3006000L,3060000L,6000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136894Inst : IEnumerable<long>
{
public static readonly long[] Value=A136894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136894.Bytes);
public long this[int i]=>Value[i];

public static A136894Inst Instance=new A136894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136895
{
public static readonly long[] Value={ 0L,3L,27L,30L,270L,300L,2700L,3000L,27000L,30000L,270000L,300000L,2700000L,3000000L,27000000L,27032203L,27077797L,30000000L,30332997L,270000000L,270322030L,270777970L,300000000L,303329970L,2700000000L,2703220300L,2707779700L,2720293723L,2779023223L,3000000000L,3033299700L,27000000000L,27032203000L,27077797000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136895Inst : IEnumerable<long>
{
public static readonly long[] Value=A136895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136895.Bytes);
public long this[int i]=>Value[i];

public static A136895Inst Instance=new A136895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136896
{
public static readonly long[] Value={ 0L,3L,30L,283L,300L,2830L,2983L,3000L,28300L,29830L,29983L,30000L,30333L,283000L,283203L,283233L,298300L,298803L,299830L,299983L,300000L,303330L,2830000L,2832030L,2832330L,2983000L,2988030L,2998300L,2999830L,2999983L,3000000L,3033300L,28300000L,28320300L,28323300L,29830000L,29880300L,29983000L,29988003L,29998300L,29999830L,29999983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136896Inst : IEnumerable<long>
{
public static readonly long[] Value=A136896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136896.Bytes);
public long this[int i]=>Value[i];

public static A136896Inst Instance=new A136896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136897
{
public static readonly long[] Value={ 0L,2L,5L,20L,45L,50L,200L,205L,450L,500L,502L,505L,2000L,2005L,2050L,2245L,4500L,5000L,5002L,5005L,5020L,5045L,5050L,20000L,20005L,20050L,20500L,20505L,22450L,45000L,45005L,50000L,50002L,50005L,50020L,50045L,50050L,50200L,50205L,50450L,50500L,50502L,200000L,200005L,200050L,200500L,200505L,205000L,205050L,224500L,450000L,450005L,450045L,450050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136897Inst : IEnumerable<long>
{
public static readonly long[] Value=A136897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136897.Bytes);
public long this[int i]=>Value[i];

public static A136897Inst Instance=new A136897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136898
{
public static readonly long[] Value={ 0L,2L,5L,20L,25L,45L,50L,65L,200L,205L,225L,245L,250L,255L,450L,500L,502L,505L,650L,665L,2000L,2005L,2050L,2065L,2242L,2245L,2250L,2450L,2500L,2502L,2550L,4500L,5000L,5002L,5005L,5020L,5025L,5045L,5050L,5065L,6500L,6650L,6665L,20000L,20005L,20050L,20065L,20500L,20505L,20602L,20605L,20650L,22420L,22450L,22500L,24500L,24605L,25000L,25005L,25020L,25025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136898Inst : IEnumerable<long>
{
public static readonly long[] Value=A136898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136898.Bytes);
public long this[int i]=>Value[i];

public static A136898Inst Instance=new A136898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136899
{
public static readonly long[] Value={ 0L,2L,5L,20L,45L,50L,52L,200L,205L,450L,455L,500L,502L,505L,520L,745L,755L,2000L,2005L,2050L,2245L,4500L,4550L,4552L,5000L,5002L,5005L,5020L,5045L,5050L,5052L,5200L,7450L,7455L,7550L,20000L,20005L,20050L,20500L,20505L,22450L,22455L,45000L,45005L,45500L,45505L,45520L,50000L,50002L,50005L,50020L,50045L,50050L,50052L,50200L,50205L,50450L,50455L,50500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136899Inst : IEnumerable<long>
{
public static readonly long[] Value=A136899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136899.Bytes);
public long this[int i]=>Value[i];

public static A136899Inst Instance=new A136899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136900
{
public static readonly long[] Value={ 0L,2L,5L,20L,22L,45L,50L,200L,202L,205L,220L,450L,500L,502L,505L,2000L,2002L,2005L,2020L,2022L,2050L,2200L,2202L,2245L,2255L,4500L,4522L,5000L,5002L,5005L,5020L,5022L,5045L,5050L,20000L,20002L,20005L,20020L,20022L,20050L,20200L,20205L,20220L,20500L,20505L,20555L,22000L,22002L,22005L,22020L,22450L,22550L,24205L,45000L,45005L,45220L,50000L,50002L,50005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136900Inst : IEnumerable<long>
{
public static readonly long[] Value=A136900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136900.Bytes);
public long this[int i]=>Value[i];

public static A136900Inst Instance=new A136900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136901
{
public static readonly long[] Value={ 0L,2L,5L,20L,45L,50L,95L,200L,205L,450L,495L,500L,502L,505L,950L,995L,2000L,2005L,2050L,2245L,4495L,4500L,4505L,4905L,4950L,4955L,4995L,5000L,5002L,5005L,5020L,5045L,5050L,5095L,9500L,9950L,9995L,20000L,20005L,20050L,20495L,20500L,20505L,22450L,44950L,44955L,44995L,45000L,45005L,45045L,45050L,49050L,49500L,49550L,49905L,49950L,49955L,49995L,50000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136901Inst : IEnumerable<long>
{
public static readonly long[] Value=A136901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136901.Bytes);
public long this[int i]=>Value[i];

public static A136901Inst Instance=new A136901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136902
{
public static readonly long[] Value={ 0L,2L,20L,200L,2000L,20000L,20602L,200000L,206020L,2000000L,2006002L,2060200L,20000000L,20060020L,20602000L,200000000L,200060002L,200600200L,206020000L,2000000000L,2000600020L,2006002000L,2060200000L,20000000000L,20000600002L,20006000200L,20060020000L,20602000000L,200000000000L,200006000020L,200060002000L,200600200000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136902Inst : IEnumerable<long>
{
public static readonly long[] Value=A136902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136902.Bytes);
public long this[int i]=>Value[i];

public static A136902Inst Instance=new A136902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136903
{
public static readonly long[] Value={ 0L,2L,20L,26L,200L,260L,474L,2000L,2600L,2602L,4740L,4762L,20000L,20602L,26000L,26020L,26602L,47400L,47620L,77474L,77602L,200000L,206020L,260000L,260200L,266020L,474000L,476200L,476474L,476662L,774740L,776020L,2000000L,2006002L,2060200L,2060762L,2600000L,2602000L,2647026L,2660200L,4474674L,4740000L,4762000L,4764740L,4766620L,7747400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136903Inst : IEnumerable<long>
{
public static readonly long[] Value=A136903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136903.Bytes);
public long this[int i]=>Value[i];

public static A136903Inst Instance=new A136903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137000
{
public static readonly long[] Value={ 1L,2L,9L,11L,12L,21L,22L,29L,91L,122L,141L,212L,221L,222L,288L,441L,911L,921L,1118L,1191L,1488L,2212L,2988L,11141L,11882L,14829L,21212L,22229L,42921L,49441L,49829L,49891L,122182L,141118L,141421L,221911L,491141L,491212L,498891L,498928L,498941L,921911L,992421L,1114891L,1411428L,2211882L,2212288L,2981428L,2988118L,4911122L,4911428L,4921882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137000Inst : IEnumerable<long>
{
public static readonly long[] Value=A137000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137000.Bytes);
public long this[int i]=>Value[i];

public static A137000Inst Instance=new A137000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137001
{
public static readonly long[] Value={ 1L,2L,11L,12L,21L,212L,221911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137001Inst : IEnumerable<long>
{
public static readonly long[] Value=A137001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137001.Bytes);
public long this[int i]=>Value[i];

public static A137001Inst Instance=new A137001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137002
{
public static readonly long[] Value={ 1L,5L,11L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137002Inst : IEnumerable<long>
{
public static readonly long[] Value=A137002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137002.Bytes);
public long this[int i]=>Value[i];

public static A137002Inst Instance=new A137002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137003
{
public static readonly long[] Value={ 1L,5L,11L,15L,16L,25L,125L,511L,515L,516L,1125L,2261L,5125L,12511L,12515L,25525L,51211L,125125L,5162515L,51626211L,125162515L,5162525125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137003Inst : IEnumerable<long>
{
public static readonly long[] Value=A137003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137003.Bytes);
public long this[int i]=>Value[i];

public static A137003Inst Instance=new A137003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137004
{
public static readonly long[] Value={ 1L,5L,11L,15L,16L,25L,26L,75L,76L,125L,165L,166L,275L,276L,511L,515L,516L,525L,526L,715L,716L,725L,1125L,1275L,1665L,1666L,2261L,2275L,2675L,5125L,5165L,7261L,7525L,11215L,11275L,12511L,12515L,12715L,16665L,16666L,25525L,25526L,25715L,25725L,26675L,26761L,27525L,51211L,72261L,72576L,125125L,125165L,125166L,125525L,125526L,127525L,161761L,165125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137004Inst : IEnumerable<long>
{
public static readonly long[] Value=A137004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137004.Bytes);
public long this[int i]=>Value[i];

public static A137004Inst Instance=new A137004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137005
{
public static readonly long[] Value={ 1L,5L,11L,15L,16L,25L,81L,125L,261L,285L,511L,515L,516L,816L,1125L,1285L,1585L,2261L,2285L,2581L,2585L,5125L,11211L,12511L,12515L,12581L,25525L,25615L,26125L,28615L,28665L,51211L,81125L,81585L,112166L,125125L,158816L,256615L,258125L,261125L,261881L,285515L,515615L,811516L,828665L,1118865L,1585125L,1681125L,2261125L,2285216L,5162515L,5185125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137005Inst : IEnumerable<long>
{
public static readonly long[] Value=A137005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137005.Bytes);
public long this[int i]=>Value[i];

public static A137005Inst Instance=new A137005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A137006
{
public static readonly long[] Value={ 1L,5L,11L,15L,16L,25L,96L,125L,161L,511L,515L,516L,1119L,1125L,1515L,1619L,2261L,5125L,9619L,9961L,12296L,12511L,12515L,16215L,16296L,22619L,22925L,25525L,25596L,51211L,96211L,112515L,125125L,126211L,126969L,129215L,161125L,161219L,226961L,256169L,262925L,511969L,516296L,956619L,959961L,1119219L,1121125L,1126925L,1252965L,1261965L,1262125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A137006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A137006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A137006Inst : IEnumerable<long>
{
public static readonly long[] Value=A137006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A137006.Bytes);
public long this[int i]=>Value[i];

public static A137006Inst Instance=new A137006Inst();

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