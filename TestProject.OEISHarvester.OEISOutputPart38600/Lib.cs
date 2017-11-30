using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A003842
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003842Inst : IEnumerable<long>
{
public static readonly long[] Value=A003842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003842.Bytes);
public long this[int i]=>Value[i];

public static A003842Inst Instance=new A003842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003841
{
public static readonly long[] Value={ 36L,576L,3600L,14400L,112896L,254016L,518400L,1742400L,4769856L,16646400L,23970816L,46785600L,147476736L,243360000L,386358336L,593409600L,885657600L,1071645696L,2561979456L,4744454400L,6314527296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003841Inst : IEnumerable<long>
{
public static readonly long[] Value=A003841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003841.Bytes);
public long this[int i]=>Value[i];

public static A003841Inst Instance=new A003841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003840
{
public static readonly BigInteger[] Value={ 2L,129600L,50759843097600L,BigInteger.Parse("129182006871144805294080000"),BigInteger.Parse("2154683673871373733440812330742751559680000"),BigInteger.Parse("235766858527753399707968381023024646011879419539171573760000000") };
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
public class A003840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003840Inst Instance=new A003840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003839
{
public static readonly BigInteger[] Value={ 3L,28224L,2317591180800L,BigInteger.Parse("112554991177798901760000"),BigInteger.Parse("52386144472825139642572263782154240000"),BigInteger.Parse("14630778277213500974314928221817819519899234908241920000") };
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
public class A003839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003839Inst Instance=new A003839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003838
{
public static readonly BigInteger[] Value={ 1L,3600L,7254000000L,8911539000000000000L,BigInteger.Parse("6807663884896875000000000000000"),BigInteger.Parse("3246978048053003424316406250000000000000000000"),BigInteger.Parse("967724409898859060146424426078796386718750000000000000000000000") };
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
public class A003838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003838Inst Instance=new A003838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003837
{
public static readonly BigInteger[] Value={ 1L,144L,6065280L,4952179814400L,BigInteger.Parse("1289512799941305139200"),BigInteger.Parse("6762844700608770238252960972800"),BigInteger.Parse("11470635634813395742481912276441576767488000"),BigInteger.Parse("393736985584514548835738283681336315795223487793070080000") };
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
public class A003837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003837Inst Instance=new A003837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003836
{
public static readonly BigInteger[] Value={ 8L,518400L,203039372390400L,BigInteger.Parse("516728027484579221176320000"),BigInteger.Parse("8618734695485494933763249322971006238720000"),BigInteger.Parse("943067434111013598831873524092098584047517678156686295040000000") };
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
public class A003836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003836Inst Instance=new A003836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003835
{
public static readonly BigInteger[] Value={ 7L,254016L,34558531338240L,BigInteger.Parse("19031213036231093492121600"),BigInteger.Parse("42863636354909175368011800612065142374400"),BigInteger.Parse("395357821818670720302212111102866352228895870285434270515200") };
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
public class A003835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003835Inst Instance=new A003835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003834
{
public static readonly BigInteger[] Value={ 6L,112896L,4635182361600L,BigInteger.Parse("450219964711195607040000"),BigInteger.Parse("104772288945650279285144527564308480000"),BigInteger.Parse("58523113108854003897259712887271278079596939632967680000") };
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
public class A003834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003834Inst Instance=new A003834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003833
{
public static readonly long[] Value={ 20L,1L,18L,4L,13L,6L,10L,15L,2L,17L,3L,19L,7L,16L,8L,11L,14L,9L,12L,5L,20L,1L,18L,4L,13L,6L,10L,15L,2L,17L,3L,19L,7L,16L,8L,11L,14L,9L,12L,5L,20L,1L,18L,4L,13L,6L,10L,15L,2L,17L,3L,19L,7L,16L,8L,11L,14L,9L,12L,5L,20L,1L,18L,4L,13L,6L,10L,15L,2L,17L,3L,19L,7L,16L,8L,11L,14L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003833Inst : IEnumerable<long>
{
public static readonly long[] Value=A003833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003833.Bytes);
public long this[int i]=>Value[i];

public static A003833Inst Instance=new A003833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003832
{
public static readonly BigInteger[] Value={ 4L,14400L,29016000000L,BigInteger.Parse("35646156000000000000"),BigInteger.Parse("27230655539587500000000000000000"),BigInteger.Parse("12987912192212013697265625000000000000000000000"),BigInteger.Parse("3870897639595436240585697704315185546875000000000000000000000000") };
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
public class A003832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003832Inst Instance=new A003832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003831
{
public static readonly BigInteger[] Value={ 3L,3600L,987033600L,67010895544320000L,BigInteger.Parse("1154606796534757164318720000"),BigInteger.Parse("5081732431326820541485324550799360000000"),BigInteger.Parse("5722569627753465177061732369386833143098255605760000000") };
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
public class A003831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003831Inst Instance=new A003831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003830
{
public static readonly BigInteger[] Value={ 2L,576L,12130560L,19808719257600L,BigInteger.Parse("2579025599882610278400"),BigInteger.Parse("27051378802435080953011843891200"),BigInteger.Parse("22941271269626791484963824552883153534976000"),BigInteger.Parse("1574947942338058195342953134725345263180893951172280320000") };
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
public class A003830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003830Inst Instance=new A003830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003829
{
public static readonly long[] Value={ 1L,4L,4L,8L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003829Inst : IEnumerable<long>
{
public static readonly long[] Value=A003829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003829.Bytes);
public long this[int i]=>Value[i];

public static A003829Inst Instance=new A003829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003828
{
public static readonly long[] Value={ 422481L,2813001L,8707481L,12197457L,16003017L,16430513L,20615673L,44310257L,68711097L,117112081L,145087793L,156646737L,589845921L,638523249L,873822121L,1259768473L,1679142729L,1787882337L,1871713857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003828Inst : IEnumerable<long>
{
public static readonly long[] Value=A003828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003828.Bytes);
public long this[int i]=>Value[i];

public static A003828Inst Instance=new A003828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003827
{
public static readonly BigInteger[] Value={ 1L,2L,59L,1292L,53862L,3615208L,392961340L,68986099580L,19595297946515L,9048133666290540L,6832278662513786160L,BigInteger.Parse("8489106538840284343800"),BigInteger.Parse("17456177529017536829265000"),BigInteger.Parse("59700294731704834466701403040"),BigInteger.Parse("340945552945616104095546549396336"),BigInteger.Parse("3261527521637774696821080128931389072") };
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
public class A003827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003827Inst Instance=new A003827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003826
{
public static readonly long[] Value={ 6963472309248L,12625136269928L,21131226514944L,26059452841000L,74213505639000L,95773976104625L,159380205560856L,174396242861568L,300656502205416L,376890885439488L,521932420691227L,573880096718136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003826Inst : IEnumerable<long>
{
public static readonly long[] Value=A003826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003826.Bytes);
public long this[int i]=>Value[i];

public static A003826Inst Instance=new A003826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003825
{
public static readonly long[] Value={ 87539319L,119824488L,143604279L,175959000L,327763000L,804360375L,1840667192L,1915865217L,3080802816L,3499524728L,3623721192L,5544709352L,10458523413L,10499580728L,10833628897L,15170835645L,18778674824L,21303180171L,21989186856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003825Inst : IEnumerable<long>
{
public static readonly long[] Value=A003825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003825.Bytes);
public long this[int i]=>Value[i];

public static A003825Inst Instance=new A003825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003824
{
public static readonly long[] Value={ 635318657L,3262811042L,8657437697L,68899596497L,86409838577L,160961094577L,2094447251857L,4231525221377L,26033514998417L,37860330087137L,61206381799697L,76773963505537L,109737827061041L,155974778565937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003824Inst : IEnumerable<long>
{
public static readonly long[] Value=A003824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003824.Bytes);
public long this[int i]=>Value[i];

public static A003824Inst Instance=new A003824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003823
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,1L,1L,-1L,-2L,0L,2L,2L,-1L,-3L,-1L,3L,3L,-2L,-5L,-1L,6L,5L,-3L,-8L,-2L,8L,7L,-5L,-12L,-2L,13L,12L,-7L,-18L,-4L,18L,16L,-11L,-26L,-5L,27L,24L,-14L,-37L,-8L,37L,33L,-21L,-52L,-10L,53L,47L,-29L,-72L,-15L,71L,63L,-40L,-98L,-19L,99L,88L,-53L,-133L,-27L,131L,115L,-73L,-178L,-35L,177L,156L,-95L,-236L,-48L,232L,204L,-127L,-311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003823Inst : IEnumerable<long>
{
public static readonly long[] Value=A003823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003823.Bytes);
public long this[int i]=>Value[i];

public static A003823Inst Instance=new A003823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003822
{
public static readonly long[] Value={ 10L,42L,167L,662L,2670L,10846L,44199L,180438L,737762L,3021000L,12387990L,50864885L,209095841L,860447494L,3544046278L,14608974346L,60261567146L,248726602105L,1027143932653L,4243640251368L,17539577253151L,72518982292559L,299928724501455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003822Inst : IEnumerable<long>
{
public static readonly long[] Value=A003822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003822.Bytes);
public long this[int i]=>Value[i];

public static A003822Inst Instance=new A003822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003821
{
public static readonly BigInteger[] Value={ 1L,1L,2L,65L,37709445313L,BigInteger.Parse("44237187584945316063023352626539792098172619389908174093304834") };
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
public class A003821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003821Inst Instance=new A003821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003820
{
public static readonly BigInteger[] Value={ 1L,1L,2L,33L,19567697L,BigInteger.Parse("86932993422012266622767255572927826") };
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
public class A003820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003820Inst Instance=new A003820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003819
{
public static readonly BigInteger[] Value={ 1L,1L,2L,17L,41761L,178910008847318626L,BigInteger.Parse("24533960352822051755918055684179592096697004630540952679692131057") };
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
public class A003819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003819Inst Instance=new A003819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003818
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,365L,5403014L,432130991537958813L,BigInteger.Parse("14935169284101525874491673463268414536523593057") };
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
public class A003818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003818Inst Instance=new A003818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003817
{
public static readonly long[] Value={ 0L,1L,3L,3L,7L,7L,7L,7L,15L,15L,15L,15L,15L,15L,15L,15L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003817Inst : IEnumerable<long>
{
public static readonly long[] Value=A003817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003817.Bytes);
public long this[int i]=>Value[i];

public static A003817Inst Instance=new A003817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003816
{
public static readonly long[] Value={ 0L,1L,-1L,4L,0L,5L,-1L,8L,0L,9L,-1L,12L,0L,13L,-1L,16L,0L,17L,-1L,20L,0L,21L,-1L,24L,0L,25L,-1L,28L,0L,29L,-1L,32L,0L,33L,-1L,36L,0L,37L,-1L,40L,0L,41L,-1L,44L,0L,45L,-1L,48L,0L,49L,-1L,52L,0L,53L,-1L,56L,0L,57L,-1L,60L,0L,61L,-1L,64L,0L,65L,-1L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003816Inst : IEnumerable<long>
{
public static readonly long[] Value=A003816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003816.Bytes);
public long this[int i]=>Value[i];

public static A003816Inst Instance=new A003816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003815
{
public static readonly long[] Value={ 0L,1L,3L,0L,4L,1L,7L,0L,8L,1L,11L,0L,12L,1L,15L,0L,16L,1L,19L,0L,20L,1L,23L,0L,24L,1L,27L,0L,28L,1L,31L,0L,32L,1L,35L,0L,36L,1L,39L,0L,40L,1L,43L,0L,44L,1L,47L,0L,48L,1L,51L,0L,52L,1L,55L,0L,56L,1L,59L,0L,60L,1L,63L,0L,64L,1L,67L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003815Inst : IEnumerable<long>
{
public static readonly long[] Value=A003815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003815.Bytes);
public long this[int i]=>Value[i];

public static A003815Inst Instance=new A003815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003814
{
public static readonly long[] Value={ 2L,5L,10L,13L,17L,26L,29L,37L,41L,50L,53L,58L,61L,65L,73L,74L,82L,85L,89L,97L,101L,106L,109L,113L,122L,125L,130L,137L,145L,149L,157L,170L,173L,181L,185L,193L,197L,202L,218L,226L,229L,233L,241L,250L,257L,265L,269L,274L,277L,281L,290L,293L,298L,313L,314L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003814Inst : IEnumerable<long>
{
public static readonly long[] Value=A003814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003814.Bytes);
public long this[int i]=>Value[i];

public static A003814Inst Instance=new A003814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003813
{
public static readonly BigInteger[] Value={ BigInteger.Parse("699612310033197642547200"),BigInteger.Parse("124190524600592082795473760093457612800"),BigInteger.Parse("447244452196213365088128369288351077766266880000"),BigInteger.Parse("78616578542037111790447631835937500000000000000000000000"),BigInteger.Parse("13191313011550511408913226688319815618147473583337425366223421440000") };
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
public class A003813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003813Inst Instance=new A003813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003812
{
public static readonly BigInteger[] Value={ 5348063769211699200L,BigInteger.Parse("480860607452861427947598643200"),BigInteger.Parse("78099458182389588115529148326215680000"),BigInteger.Parse("25761093646334667714843750000000000000000000"),BigInteger.Parse("85057500275967538647136529625446531799449748111360000") };
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
public class A003812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003812Inst Instance=new A003812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003811
{
public static readonly BigInteger[] Value={ 163849992929280L,BigInteger.Parse("67034222101339041669120"),BigInteger.Parse("72736898347485916060188672000"),BigInteger.Parse("3376566710423156250000000000000000"),BigInteger.Parse("35832085525362833262818017603275320524800"),BigInteger.Parse("3129044148368792621827017675376367700541440") };
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
public class A003811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003811Inst Instance=new A003811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003810
{
public static readonly BigInteger[] Value={ 20158709760L,21032402889738240L,BigInteger.Parse("361310134959341568000"),BigInteger.Parse("1383059427750000000000000"),BigInteger.Parse("61637759336805268655956377600"),BigInteger.Parse("39841906041871272087686291128320"),BigInteger.Parse("1234219157861100568481165377536000"),BigInteger.Parse("1392357762553459444742198951136000000"),BigInteger.Parse("161092184393918097496815608751014338560") };
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
public class A003810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003810Inst Instance=new A003810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003809
{
public static readonly BigInteger[] Value={ 9999360L,237783237120L,258492255436800L,56653740000000000L,BigInteger.Parse("187035198320488089600"),BigInteger.Parse("4638226007491010887680"),BigInteger.Parse("78660280796419613491200"),BigInteger.Parse("1952052708565059186240000"),BigInteger.Parse("539322992420959314658621440"),BigInteger.Parse("15779626219308347912355840000"),BigInteger.Parse("338200968038818404584356577280"),BigInteger.Parse("4884441266449243967839995916800") };
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
public class A003809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003809Inst Instance=new A003809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003808
{
public static readonly long[] Value={ 20160L,6065280L,987033600L,7254000000L,2317591180800L,34558531338240L,50759843097600L,2069665112592000L,12714519233969280L,1148120010326016000L,712975930219192320L,7568375355962524800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003808Inst : IEnumerable<long>
{
public static readonly long[] Value=A003808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003808.Bytes);
public long this[int i]=>Value[i];

public static A003808Inst Instance=new A003808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003807
{
public static readonly long[] Value={ 168L,5616L,20160L,372000L,1876896L,16482816L,42456960L,212427600L,270178272L,1425715200L,6950204928L,5644682640L,78156525216L,50778000000L,282027786768L,499631102880L,283991644800L,1098404364288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003807Inst : IEnumerable<long>
{
public static readonly long[] Value=A003807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003807.Bytes);
public long this[int i]=>Value[i];

public static A003807Inst Instance=new A003807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003806
{
public static readonly BigInteger[] Value={ BigInteger.Parse("699612310033197642547200"),BigInteger.Parse("124190524600592082795473760093457612800"),BigInteger.Parse("1341733356588640095264385107865053233298800640000"),BigInteger.Parse("78616578542037111790447631835937500000000000000000000000"),BigInteger.Parse("39573939034651534226739680064959446854442420750012276098670264320000") };
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
public class A003806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003806Inst Instance=new A003806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003789
{
public static readonly BigInteger[] Value={ 1L,120L,372000L,29016000000L,56653740000000000L,BigInteger.Parse("2766118855500000000000000"),BigInteger.Parse("3376566710423156250000000000000000"),BigInteger.Parse("103044374585338670859375000000000000000000000") };
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
public class A003789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003789Inst Instance=new A003789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003788
{
public static readonly BigInteger[] Value={ 1L,60L,60480L,987033600L,258492255436800L,BigInteger.Parse("1083930404878024704000"),BigInteger.Parse("72736898347485916060188672000"),BigInteger.Parse("78099458182389588115529148326215680000"),BigInteger.Parse("1341733356588640095264385107865053233298800640000") };
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
public class A003788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003788Inst Instance=new A003788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003787
{
public static readonly BigInteger[] Value={ 1L,24L,5616L,12130560L,237783237120L,42064805779476480L,BigInteger.Parse("67034222101339041669120"),BigInteger.Parse("961721214905722855895197286400"),BigInteger.Parse("124190524600592082795473760093457612800"),BigInteger.Parse("144339416867688029764487130056208182629053235200") };
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
public class A003787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003787Inst Instance=new A003787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003786
{
public static readonly long[] Value={ 1L,8L,15L,22L,29L,5L,12L,19L,26L,4L,11L,18L,25L,1L,8L,15L,22L,29L,6L,13L,20L,27L,3L,10L,17L,24L,1L,8L,15L,22L,29L,5L,12L,19L,26L,2L,9L,16L,23L,30L,7L,14L,21L,28L,4L,11L,18L,25L,2L,9L,16L,23L,30L,6L,13L,20L,27L,3L,10L,17L,24L,3L,10L,17L,24L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003786Inst : IEnumerable<long>
{
public static readonly long[] Value=A003786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003786.Bytes);
public long this[int i]=>Value[i];

public static A003786Inst Instance=new A003786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003785
{
public static readonly long[] Value={ 1L,10L,0L,0L,-88L,-132L,0L,0L,1275L,736L,0L,0L,-8040L,-2880L,0L,0L,24035L,13080L,0L,0L,-14136L,-54120L,0L,0L,-128844L,115456L,0L,0L,389520L,38016L,0L,0L,-256410L,-697950L,0L,0L,-806520L,963160L,0L,0L,1892363L,938400L,0L,0L,-1227600L,-2309120L,0L,0L,-813450L,-2813096L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003785Inst : IEnumerable<long>
{
public static readonly long[] Value=A003785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003785.Bytes);
public long this[int i]=>Value[i];

public static A003785Inst Instance=new A003785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003784
{
public static readonly long[] Value={ 0L,0L,0L,1L,-2L,0L,0L,-16L,36L,0L,0L,99L,-272L,0L,0L,-240L,1056L,0L,0L,-253L,-1800L,0L,0L,2736L,-1464L,0L,0L,-4284L,12544L,0L,0L,-6816L,-19008L,0L,0L,27270L,-4554L,0L,0L,-6864L,39880L,0L,0L,-66013L,-26928L,0L,0L,44064L,12544L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003784Inst : IEnumerable<long>
{
public static readonly long[] Value=A003784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003784.Bytes);
public long this[int i]=>Value[i];

public static A003784Inst Instance=new A003784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003783
{
public static readonly long[] Value={ 1L,0L,0L,56L,366L,0L,0L,14016L,33156L,0L,0L,260712L,462392L,0L,0L,1987392L,2998638L,0L,0L,9090984L,12799080L,0L,0L,31997376L,41846952L,0L,0L,89282144L,113936064L,0L,0L,222509952L,271647108L,0L,0L,482553936L,583789398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003783Inst : IEnumerable<long>
{
public static readonly long[] Value=A003783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003783.Bytes);
public long this[int i]=>Value[i];

public static A003783Inst Instance=new A003783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003782
{
public static readonly long[] Value={ 1L,0L,0L,-88L,-330L,0L,0L,-4224L,-7524L,0L,0L,-30600L,-46552L,0L,0L,-130944L,-169290L,0L,0L,-355080L,-464904L,0L,0L,-899712L,-1052040L,0L,0L,-1732192L,-2099328L,0L,0L,-3421440L,-3859812L,0L,0L,-5593104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003782Inst : IEnumerable<long>
{
public static readonly long[] Value=A003782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003782.Bytes);
public long this[int i]=>Value[i];

public static A003782Inst Instance=new A003782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003781
{
public static readonly long[] Value={ 1L,0L,0L,56L,126L,0L,0L,576L,756L,0L,0L,1512L,2072L,0L,0L,4032L,4158L,0L,0L,5544L,7560L,0L,0L,12096L,11592L,0L,0L,13664L,16704L,0L,0L,24192L,24948L,0L,0L,27216L,31878L,0L,0L,44352L,39816L,0L,0L,41832L,55944L,0L,0L,72576L,66584L,0L,0L,67536L,76104L,0L,0L,100800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003781Inst : IEnumerable<long>
{
public static readonly long[] Value=A003781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003781.Bytes);
public long this[int i]=>Value[i];

public static A003781Inst Instance=new A003781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003780
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,296L,0L,0L,0L,70420L,0L,0L,0L,16391166L,0L,0L,0L,3816021084L,0L,0L,0L,888375830566L,0L,0L,0L,206814474641944L,0L,0L,0L,48146529005876746L,0L,0L,0L,11208539472498838244UL,0L,0L,0L,BigInteger.Parse("2609354391828066201746"),0L,0L,0L };
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
public class A003780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003780Inst Instance=new A003780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003779
{
public static readonly BigInteger[] Value={ 1L,209L,30305L,4140081L,557568000L,74795194705L,10021992194369L,1342421467113969L,179796299139278305L,BigInteger.Parse("24080189412483072000"),BigInteger.Parse("3225041354570508955681"),BigInteger.Parse("431926215138756947267505"),BigInteger.Parse("57847355494807961811035009"),BigInteger.Parse("7747424602888405489208931601") };
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
public class A003779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003779Inst Instance=new A003779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003778
{
public static readonly long[] Value={ 1L,22L,132L,1006L,4324L,26996L,109722L,602804L,2434670L,12287118L,49852352L,237425498L,969300694L,4434629912L,18203944458L,80978858522L,333840165288L,1456084764388L,6021921661718L,25904211802080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003778Inst : IEnumerable<long>
{
public static readonly long[] Value=A003778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003778.Bytes);
public long this[int i]=>Value[i];

public static A003778Inst Instance=new A003778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003777
{
public static readonly long[] Value={ 1L,11L,35L,79L,149L,251L,391L,575L,809L,1099L,1451L,1871L,2365L,2939L,3599L,4351L,5201L,6155L,7219L,8399L,9701L,11131L,12695L,14399L,16249L,18251L,20411L,22735L,25229L,27899L,30751L,33791L,37025L,40459L,44099L,47951L,52021L,56315L,60839L,65599L,70601L,75851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003777Inst : IEnumerable<long>
{
public static readonly long[] Value=A003777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003777.Bytes);
public long this[int i]=>Value[i];

public static A003777Inst Instance=new A003777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003776
{
public static readonly long[] Value={ 3L,54L,1140L,24360L,521064L,11146656L,238452456L,5101047216L,109123156248L,2334395822496L,49938107061384L,1068291209653392L,22853211220567416L,488882861126970624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003776Inst : IEnumerable<long>
{
public static readonly long[] Value=A003776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003776.Bytes);
public long this[int i]=>Value[i];

public static A003776Inst Instance=new A003776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003775
{
public static readonly BigInteger[] Value={ 1L,8L,95L,1183L,14824L,185921L,2332097L,29253160L,366944287L,4602858719L,57737128904L,724240365697L,9084693297025L,113956161827912L,1429438110270431L,17930520634652959L,224916047725262248L,2821291671062267585L,BigInteger.Parse("35389589910135145793"),BigInteger.Parse("443918325373278904936") };
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
public class A003775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003775Inst Instance=new A003775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003774
{
public static readonly long[] Value={ 4L,48L,672L,8496L,106944L,1349760L,17032800L,214925952L,2712031104L,34221651456L,431824387584L,5448956749824L,68757417818112L,867612411420672L,10947928532312064L,138145948088696832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003774Inst : IEnumerable<long>
{
public static readonly long[] Value=A003774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003774.Bytes);
public long this[int i]=>Value[i];

public static A003774Inst Instance=new A003774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003757
{
public static readonly long[] Value={ 0L,1L,1L,6L,13L,49L,132L,433L,1261L,3942L,11809L,36289L,109824L,335425L,1018849L,3104934L,9443629L,28756657L,87504516L,266383153L,810723277L,2467770054L,7510988353L,22861948801L,69584925696L,211799836801L,644660351425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003757Inst : IEnumerable<long>
{
public static readonly long[] Value=A003757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003757.Bytes);
public long this[int i]=>Value[i];

public static A003757Inst Instance=new A003757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003756
{
public static readonly long[] Value={ 1L,0L,24L,54L,492L,1944L,11976L,57024L,313440L,1587168L,8417472L,43483392L,227995008L,1185394176L,6192642048L,32263570944L,168350991360L,877689686016L,4578049517568L,23872537976832L,124504626978816L,649282059657216L,3386128302882816L,17658788068196352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003756Inst : IEnumerable<long>
{
public static readonly long[] Value=A003756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003756.Bytes);
public long this[int i]=>Value[i];

public static A003756Inst Instance=new A003756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003755
{
public static readonly BigInteger[] Value={ 1L,54L,2240L,89964L,3596725L,143700480L,5740732439L,229334969304L,9161621922880L,365994298083150L,14620972301965259L,584087869159280640L,BigInteger.Parse("23333512405041243469"),BigInteger.Parse("932141942728566562746"),BigInteger.Parse("37237797134599264280000"),BigInteger.Parse("1487599121840339002010544"),BigInteger.Parse("59427552583207598523644161") };
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
public class A003755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003755Inst Instance=new A003755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003754
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,10L,11L,13L,14L,15L,21L,22L,23L,26L,27L,29L,30L,31L,42L,43L,45L,46L,47L,53L,54L,55L,58L,59L,61L,62L,63L,85L,86L,87L,90L,91L,93L,94L,95L,106L,107L,109L,110L,111L,117L,118L,119L,122L,123L,125L,126L,127L,170L,171L,173L,174L,175L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003754Inst : IEnumerable<long>
{
public static readonly long[] Value=A003754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003754.Bytes);
public long this[int i]=>Value[i];

public static A003754Inst Instance=new A003754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003753
{
public static readonly BigInteger[] Value={ 4L,384L,31500L,2558976L,207746836L,16864848000L,1369080572444L,111141302329344L,9022397309950500L,732433860440996736L,BigInteger.Parse("59458627396289740076"),BigInteger.Parse("4826822683620921984000"),BigInteger.Parse("391839136544897998002484"),BigInteger.Parse("31809312044806091140235904"),BigInteger.Parse("2582264604005182130741437500") };
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
public class A003753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003753Inst Instance=new A003753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003752
{
public static readonly long[] Value={ 4L,72L,584L,4016L,24656L,140624L,761960L,3976704L,20173280L,100097008L,488003448L,2345542720L,11142878992L,52426883056L,244682331976L,1134222633280L,5227498311360L,23975219772016L,109500177006104L,498322800625728L,2260840364623472L,10230065398683632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003752Inst : IEnumerable<long>
{
public static readonly long[] Value=A003752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003752.Bytes);
public long this[int i]=>Value[i];

public static A003752Inst Instance=new A003752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003751
{
public static readonly BigInteger[] Value={ 125L,300125L,663552000L,1464514260125L,3232184906328125L,7133430745792512000L,BigInteger.Parse("15743478429512478120125"),BigInteger.Parse("34745849760772636969860125"),BigInteger.Parse("76684074678559433693601792000"),BigInteger.Parse("169241718069731503830237768828125"),BigInteger.Parse("373516395095822778319979141039280125") };
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
public class A003751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003751Inst Instance=new A003751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003750
{
public static readonly BigInteger[] Value={ 60L,8760L,617400L,36021240L,1871009400L,90539967480L,4181860331640L,187073020183800L,8181829090755960L,352081040138505720L,14972983484769861240UL,BigInteger.Parse("631272829225942738680"),BigInteger.Parse("26446059244840564688760"),BigInteger.Parse("1102721870861189212971000"),BigInteger.Parse("45821243162927769017364600") };
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
public class A003750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003750Inst Instance=new A003750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003749
{
public static readonly BigInteger[] Value={ 12L,480L,13440L,382080L,10859520L,308651520L,8772556800L,249335408640L,7086662123520L,201418564362240L,5724759747624960L,162710295705845760L,4624585396735180800L,BigInteger.Parse("131440914657055211520"),BigInteger.Parse("3735840635158368092160") };
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
public class A003749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003749Inst Instance=new A003749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003748
{
public static readonly BigInteger[] Value={ 12L,814L,41278L,2169266L,113488662L,5940718514L,310952704838L,16276223002786L,851946706852182L,44593472067545554L,2334157405518854758L,BigInteger.Parse("122176869250651741826"),BigInteger.Parse("6395107433748612174582"),BigInteger.Parse("334739295101566253176754"),BigInteger.Parse("17521268695699930046150918"),BigInteger.Parse("917116278846033398175880546") };
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
public class A003748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003748Inst Instance=new A003748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003747
{
public static readonly BigInteger[] Value={ 56L,4181L,313501L,23508376L,1762814681L,132187592681L,9912306636376L,743290810135501L,55736898453526181L,4179524093204328056L,BigInteger.Parse("313408570091871078001"),BigInteger.Parse("23501463232797126522001"),BigInteger.Parse("1762296333889692618072056"),BigInteger.Parse("132148723578494149228882181"),BigInteger.Parse("9909391972053171499548091501") };
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
public class A003747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003747Inst Instance=new A003747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003746
{
public static readonly BigInteger[] Value={ 540L,1751352L,5386703316L,16582103036544L,51045000577926816L,BigInteger.Parse("157132783947988296192"),BigInteger.Parse("483704801377335372564480"),BigInteger.Parse("1488997578825205151673656448"),BigInteger.Parse("4583609224965381313988566950144") };
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
public class A003746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003746Inst Instance=new A003746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003745
{
public static readonly BigInteger[] Value={ 75L,128625L,199065600L,307147367625L,473862674071875L,731065883885568000L,BigInteger.Parse("1127873690900648512275"),BigInteger.Parse("1740060755637940344737625"),BigInteger.Parse("2684530596730102104276172800") };
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
public class A003745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003745Inst Instance=new A003745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003744
{
public static readonly BigInteger[] Value={ 36L,3960L,197172L,8372376L,313590732L,10961493288L,364496212992L,11715923002644L,367218115613412L,11297962590845364L,342721436917704060L,10284809936813182116UL,BigInteger.Parse("306078425919342660924") };
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
public class A003744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003744Inst Instance=new A003744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003743
{
public static readonly BigInteger[] Value={ 6L,204L,4152L,90012L,1916640L,41086080L,878480688L,18801691584L,402251873664L,8607198763968L,184162678606848L,3940493249544192L,84313290894281472L,1804026190433055744L,BigInteger.Parse("38600161433802577920"),BigInteger.Parse("825915469757893794816"),BigInteger.Parse("17671849531462458580992") };
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
public class A003743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003743Inst Instance=new A003743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003742
{
public static readonly BigInteger[] Value={ 6L,327L,11040L,406731L,14683587L,532938234L,19313709882L,700238873703L,25384576377228L,920260033555854L,33361543878231264L,1209436952734137963L,BigInteger.Parse("43844979765366718719"),BigInteger.Parse("1589485790652572990865"),BigInteger.Parse("57622670964678806649843"),BigInteger.Parse("2088960040762846005003294") };
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
public class A003742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003742Inst Instance=new A003742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003725
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,9L,-4L,-95L,414L,49L,-10088L,55521L,-13870L,-2024759L,15787188L,-28612415L,-616876274L,7476967905L,-32522642896L,-209513308607L,4924388011050L,-38993940088199L,11731860520780L,3807154270837281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003725Inst : IEnumerable<long>
{
public static readonly long[] Value=A003725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003725.Bytes);
public long this[int i]=>Value[i];

public static A003725Inst Instance=new A003725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003724
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,12L,37L,128L,457L,1872L,8169L,37600L,188685L,990784L,5497741L,32333824L,197920145L,1272660224L,8541537105L,59527313920L,432381471509L,3252626013184L,25340238127989L,204354574172160L,1699894200469849L,14594815769038848L,129076687233903673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003724Inst : IEnumerable<long>
{
public static readonly long[] Value=A003724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003724.Bytes);
public long this[int i]=>Value[i];

public static A003724Inst Instance=new A003724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003723
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-7L,-3L,97L,275L,-2063L,-15015L,53409L,968167L,-752343L,-77000363L,-166831871L,7433044411L,43685848289L,-843598411471L,-9398558916159L,107426835190735L,2116926930779225L,-14072980460605907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003723Inst : IEnumerable<long>
{
public static readonly long[] Value=A003723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003723.Bytes);
public long this[int i]=>Value[i];

public static A003723Inst Instance=new A003723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003722
{
public static readonly BigInteger[] Value={ 1L,0L,-8L,-56L,64L,12672L,309376L,2917888L,-163782656L,-12716052480L,-495644917760L,-4004259037184L,1359174582304768L,153146435763437568L,9620207941273255936UL,BigInteger.Parse("142966118908253962240"),BigInteger.Parse("-62984506636368191946752") };
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
public class A003722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003722Inst Instance=new A003722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003721
{
public static readonly BigInteger[] Value={ 1L,0L,-8L,112L,-128L,-109824L,8141824L,-353878016L,-9666461696L,5151942574080L,-825073851170816L,76429076694827008L,2051308253366714368L,BigInteger.Parse("-2361338488910424047616"),BigInteger.Parse("171581865952588387581952") };
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
public class A003721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003721Inst Instance=new A003721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003720
{
public static readonly BigInteger[] Value={ 1L,6L,168L,10672L,1198080L,208521728L,51874413568L,17449541107712L,7622674735988736L,4193561606973095936L,BigInteger.Parse("2836052065377836597248"),BigInteger.Parse("2312174256451088534208512"),BigInteger.Parse("2236165580390456719589769216"),BigInteger.Parse("2530976708469616321520834969600"),BigInteger.Parse("3314110602212685014002135203840000") };
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
public class A003720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003720Inst Instance=new A003720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003719
{
public static readonly BigInteger[] Value={ 1L,5L,41L,685L,19921L,887765L,56126201L,4776869245L,526589630881L,72989204937125L,12424192360405961L,2547879762929443405L,BigInteger.Parse("619570064016825283441"),BigInteger.Parse("176273806836039238900085"),BigInteger.Parse("58010159408189457446855321"),BigInteger.Parse("21864887814006548202566779165") };
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
public class A003719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003719Inst Instance=new A003719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003718
{
public static readonly BigInteger[] Value={ 1L,4L,72L,2896L,203904L,22112000L,3412366336L,709998153728L,191483931951104L,64956739430973440L,BigInteger.Parse("27065724289967718400"),BigInteger.Parse("13588059904833174896640"),BigInteger.Parse("8089418253144660155301888"),BigInteger.Parse("5634743143901240164716904448"),BigInteger.Parse("4539998748622480932947483426816") };
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
public class A003718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003718Inst Instance=new A003718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003717
{
public static readonly BigInteger[] Value={ 1L,-3L,37L,-959L,41641L,-2693691L,241586893L,-28607094455L,4315903789009L,-807258131578995L,183184249105857781L,BigInteger.Parse("-49548882107764546223"),BigInteger.Parse("15742588857552887269753"),BigInteger.Parse("-5802682207845642276301995") };
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
public class A003717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003717Inst Instance=new A003717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003716
{
public static readonly BigInteger[] Value={ 1L,3L,37L,1015L,47881L,3459819L,354711853L,48961863007L,8754050024209L,1967989239505875L,543326939019354421L,BigInteger.Parse("180718022989699819207"),BigInteger.Parse("71275877445849484090393"),BigInteger.Parse("32890432371345908634652347"),BigInteger.Parse("17555593768891213894861569085") };
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
public class A003716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003716Inst Instance=new A003716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003715
{
public static readonly BigInteger[] Value={ 1L,-3L,33L,-731L,25857L,-1311379L,89060065L,-7778778091L,849264442881L,-113234181108643L,18073465545032353L,-3395124358886313595L,BigInteger.Parse("740061366713642835201"),BigInteger.Parse("-185005977382236600650035") };
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
public class A003715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003715Inst Instance=new A003715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003714
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,9L,10L,16L,17L,18L,20L,21L,32L,33L,34L,36L,37L,40L,41L,42L,64L,65L,66L,68L,69L,72L,73L,74L,80L,81L,82L,84L,85L,128L,129L,130L,132L,133L,136L,137L,138L,144L,145L,146L,148L,149L,160L,161L,162L,164L,165L,168L,169L,170L,256L,257L,258L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003714Inst : IEnumerable<long>
{
public static readonly long[] Value=A003714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003714.Bytes);
public long this[int i]=>Value[i];

public static A003714Inst Instance=new A003714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003713
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,35L,228L,1834L,17582L,195866L,2487832L,35499576L,562356672L,9794156448L,186025364016L,3826961710272L,84775065603888L,2011929826983504L,50929108873336320L,1369732445916318336L,BigInteger.Parse("39005083331889816960") };
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
public class A003713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003713Inst Instance=new A003713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003712
{
public static readonly BigInteger[] Value={ 1L,-2L,12L,-128L,1872L,-37600L,990784L,-32333824L,1272660224L,-59527313920L,3252626013184L,-204354574172160L,14594815769038848L,-1174376539738169344L,BigInteger.Parse("105595092426069327872"),BigInteger.Parse("-10530693390637550272512") };
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
public class A003712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003712Inst Instance=new A003712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003711
{
public static readonly BigInteger[] Value={ 1L,-1L,9L,-177L,6097L,-325249L,24807321L,-2558036145L,342232522657L,-57569080467073L,11879658510739497L,-2948163649552594737L,BigInteger.Parse("865683568087537789297"),BigInteger.Parse("-296699416391356495667713"),BigInteger.Parse("117330699580950022391960505") };
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
public class A003711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003711Inst Instance=new A003711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003710
{
public static readonly BigInteger[] Value={ 1L,-1L,-7L,-97L,-2063L,-53409L,-752343L,166831871L,43685848289L,9398558916159L,2116926930779225L,524586454143030495L,BigInteger.Parse("144620290378876829905"),BigInteger.Parse("44287070229737735633567"),BigInteger.Parse("14954349885478653319004041") };
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
public class A003710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003710Inst Instance=new A003710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003661
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,10L,13L,15L,19L,19L,21L,23L,27L,28L,31L,34L,39L,38L,39L,40L,43L,44L,47L,50L,55L,55L,57L,59L,63L,65L,69L,73L,79L,77L,77L,77L,79L,79L,81L,83L,87L,87L,89L,91L,95L,97L,101L,105L,111L,110L,111L,112L,115L,116L,119L,122L,127L,128L,131L,134L,139L,142L,147L,152L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003661Inst : IEnumerable<long>
{
public static readonly long[] Value=A003661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003661.Bytes);
public long this[int i]=>Value[i];

public static A003661Inst Instance=new A003661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003660
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,5L,7L,5L,6L,8L,8L,9L,11L,11L,12L,15L,14L,14L,15L,14L,14L,15L,15L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003660Inst : IEnumerable<long>
{
public static readonly long[] Value=A003660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003660.Bytes);
public long this[int i]=>Value[i];

public static A003660Inst Instance=new A003660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003659
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,26L,152L,1144L,10742L,122772L,1673856L,26780972L,496090330L,10519217930L,252851833482L,6832018188414L,205985750827854L,6885220780488694L,253685194149119818L,10250343686634687424UL,BigInteger.Parse("452108221967363310278"),BigInteger.Parse("21676762640915055856716") };
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
public class A003659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A003659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A003659Inst Instance=new A003659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003658
{
public static readonly long[] Value={ 1L,5L,8L,12L,13L,17L,21L,24L,28L,29L,33L,37L,40L,41L,44L,53L,56L,57L,60L,61L,65L,69L,73L,76L,77L,85L,88L,89L,92L,93L,97L,101L,104L,105L,109L,113L,120L,124L,129L,133L,136L,137L,140L,141L,145L,149L,152L,156L,157L,161L,165L,168L,172L,173L,177L,181L,184L,185L,188L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003658Inst : IEnumerable<long>
{
public static readonly long[] Value=A003658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003658.Bytes);
public long this[int i]=>Value[i];

public static A003658Inst Instance=new A003658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003657
{
public static readonly long[] Value={ 3L,4L,7L,8L,11L,15L,19L,20L,23L,24L,31L,35L,39L,40L,43L,47L,51L,52L,55L,56L,59L,67L,68L,71L,79L,83L,84L,87L,88L,91L,95L,103L,104L,107L,111L,115L,116L,119L,120L,123L,127L,131L,132L,136L,139L,143L,148L,151L,152L,155L,159L,163L,164L,167L,168L,179L,183L,184L,187L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003657Inst : IEnumerable<long>
{
public static readonly long[] Value=A003657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003657.Bytes);
public long this[int i]=>Value[i];

public static A003657Inst Instance=new A003657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003656
{
public static readonly long[] Value={ 5L,8L,12L,13L,17L,21L,24L,28L,29L,33L,37L,41L,44L,53L,56L,57L,61L,69L,73L,76L,77L,88L,89L,92L,93L,97L,101L,109L,113L,124L,129L,133L,137L,141L,149L,152L,157L,161L,172L,173L,177L,181L,184L,188L,193L,197L,201L,209L,213L,217L,233L,236L,237L,241L,248L,249L,253L,268L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003656Inst : IEnumerable<long>
{
public static readonly long[] Value=A003656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003656.Bytes);
public long this[int i]=>Value[i];

public static A003656Inst Instance=new A003656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003655
{
public static readonly long[] Value={ 5L,8L,13L,17L,29L,37L,41L,53L,61L,73L,89L,97L,101L,109L,113L,137L,149L,157L,173L,181L,193L,197L,233L,241L,269L,277L,281L,293L,313L,317L,337L,349L,353L,373L,389L,397L,409L,421L,433L,449L,457L,461L,509L,521L,541L,557L,569L,593L,601L,613L,617L,641L,653L,661L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003655Inst : IEnumerable<long>
{
public static readonly long[] Value=A003655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003655.Bytes);
public long this[int i]=>Value[i];

public static A003655Inst Instance=new A003655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003654
{
public static readonly long[] Value={ 2L,5L,10L,13L,17L,26L,29L,37L,41L,53L,58L,61L,65L,73L,74L,82L,85L,89L,97L,101L,106L,109L,113L,122L,130L,137L,145L,149L,157L,170L,173L,181L,185L,193L,197L,202L,218L,226L,229L,233L,241L,257L,265L,269L,274L,277L,281L,290L,293L,298L,313L,314L,317L,337L,346L,349L,353L,362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003654Inst : IEnumerable<long>
{
public static readonly long[] Value=A003654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003654.Bytes);
public long this[int i]=>Value[i];

public static A003654Inst Instance=new A003654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003653
{
public static readonly long[] Value={ 5L,8L,13L,17L,29L,37L,40L,41L,53L,61L,65L,73L,85L,89L,97L,101L,104L,109L,113L,137L,145L,149L,157L,173L,181L,185L,193L,197L,229L,232L,233L,241L,257L,265L,269L,277L,281L,293L,296L,313L,317L,328L,337L,349L,353L,365L,373L,389L,397L,401L,409L,421L,424L,433L,445L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003653Inst : IEnumerable<long>
{
public static readonly long[] Value=A003653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003653.Bytes);
public long this[int i]=>Value[i];

public static A003653Inst Instance=new A003653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003652
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,4L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,3L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,3L,4L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003652Inst : IEnumerable<long>
{
public static readonly long[] Value=A003652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003652.Bytes);
public long this[int i]=>Value[i];

public static A003652Inst Instance=new A003652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003651
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,2L,2L,3L,4L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,4L,1L,1L,2L,1L,3L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,4L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,4L,1L,2L,2L,1L,4L,1L,1L,2L,2L,4L,2L,3L,8L,1L,2L,4L,6L,2L,1L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003651Inst : IEnumerable<long>
{
public static readonly long[] Value=A003651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003651.Bytes);
public long this[int i]=>Value[i];

public static A003651Inst Instance=new A003651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003650
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,1L,5L,1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,1L,2L,3L,3L,2L,2L,1L,2L,1L,1L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003650Inst : IEnumerable<long>
{
public static readonly long[] Value=A003650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003650.Bytes);
public long this[int i]=>Value[i];

public static A003650Inst Instance=new A003650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003649
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,1L,4L,1L,1L,1L,1L,2L,1L,1L,3L,2L,4L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003649Inst : IEnumerable<long>
{
public static readonly long[] Value=A003649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003649.Bytes);
public long this[int i]=>Value[i];

public static A003649Inst Instance=new A003649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003648
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,4L,2L,4L,4L,2L,4L,4L,2L,2L,2L,4L,4L,2L,2L,2L,4L,2L,4L,2L,2L,4L,6L,4L,2L,2L,4L,4L,2L,4L,4L,2L,2L,2L,4L,4L,4L,4L,2L,4L,2L,4L,2L,4L,2L,2L,4L,2L,6L,4L,4L,2L,4L,4L,2L,4L,2L,2L,2L,4L,4L,4L,2L,4L,4L,4L,4L,4L,2L,4L,8L,2L,2L,4L,2L,8L,2L,2L,4L,2L,8L,4L,6L,8L,2L,4L,8L,12L,4L,2L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003648Inst : IEnumerable<long>
{
public static readonly long[] Value=A003648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003648.Bytes);
public long this[int i]=>Value[i];

public static A003648Inst Instance=new A003648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A003647
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,4L,1L,1L,2L,2L,1L,2L,4L,1L,1L,2L,4L,1L,2L,1L,2L,1L,1L,2L,4L,2L,2L,2L,4L,3L,1L,2L,1L,2L,2L,3L,2L,1L,4L,1L,1L,4L,1L,2L,4L,2L,1L,1L,6L,2L,1L,2L,4L,1L,1L,4L,2L,1L,4L,2L,4L,1L,2L,1L,5L,1L,2L,2L,1L,4L,1L,2L,4L,1L,2L,1L,1L,4L,6L,6L,2L,2L,2L,2L,2L,2L,8L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A003647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A003647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A003647Inst : IEnumerable<long>
{
public static readonly long[] Value=A003647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A003647.Bytes);
public long this[int i]=>Value[i];

public static A003647Inst Instance=new A003647Inst();

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