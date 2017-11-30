using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A113141
{
public static readonly long[] Value={ 1L,-3L,1L,2L,-5L,1L,-2L,10L,-7L,1L,2L,-14L,22L,-9L,1L,-2L,18L,-46L,38L,-11L,1L,2L,-22L,78L,-106L,58L,-13L,1L,-2L,26L,-118L,230L,-202L,82L,-15L,1L,2L,-30L,166L,-426L,538L,-342L,110L,-17L,1L,-2L,34L,-222L,710L,-1194L,1082L,-534L,142L,-19L,1L,2L,-38L,286L,-1098L,2330L,-2814L,1958L,-786L,178L,-21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113141Inst : IEnumerable<long>
{
public static readonly long[] Value=A113141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113141.Bytes);
public long this[int i]=>Value[i];

public static A113141Inst Instance=new A113141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113142
{
public static readonly long[] Value={ 0L,1L,-5L,10L,-14L,18L,-22L,26L,-30L,34L,-38L,42L,-46L,50L,-54L,58L,-62L,66L,-70L,74L,-78L,82L,-86L,90L,-94L,98L,-102L,106L,-110L,114L,-118L,122L,-126L,130L,-134L,138L,-142L,146L,-150L,154L,-158L,162L,-166L,170L,-174L,178L,-182L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113142Inst : IEnumerable<long>
{
public static readonly long[] Value=A113142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113142.Bytes);
public long this[int i]=>Value[i];

public static A113142Inst Instance=new A113142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113143
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,5L,8L,1L,1L,2L,6L,15L,16L,1L,1L,2L,7L,26L,54L,32L,1L,1L,2L,8L,41L,158L,235L,64L,1L,1L,2L,9L,60L,364L,1282L,1237L,128L,1L,1L,2L,10L,83L,708L,4409L,13158L,7790L,256L,1L,1L,2L,11L,110L,1226L,11428L,67563L,163354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113143Inst : IEnumerable<long>
{
public static readonly long[] Value=A113143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113143.Bytes);
public long this[int i]=>Value[i];

public static A113143Inst Instance=new A113143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113144
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,41L,364L,4409L,67573L,1248626L,26948347L,664414997L,18409263772L,566018365445L,19117946453041L,703533848468330L,28013710891743007L,1199943043040160401L,BigInteger.Parse("55013996422974758476"),BigInteger.Parse("2687888298887895948065"),BigInteger.Parse("139414898768304344206141") };
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
public class A113144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113144Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113144.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113144Inst Instance=new A113144Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113145
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,60L,708L,11428L,232756L,5704964L,163192820L,5331728964L,195776203764L,7978838333188L,357313060904692L,17438518614448580L,921145685670017012L,BigInteger.Parse("52355425184381107332"),BigInteger.Parse("3185815887918686343924"),BigInteger.Parse("206633438251087758833476") };
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
public class A113145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113145Inst Instance=new A113145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113146
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,83L,1226L,24727L,627909L,19169758L,682800001L,27776711627L,1270110048234L,64470498348983L,3596569233141701L,218698213338646702L,14395754017090902609UL,BigInteger.Parse("1019782749198898131883"),BigInteger.Parse("77351848007810972904826") };
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
public class A113146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113146Inst Instance=new A113146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113147
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,110L,1954L,47270L,1437562L,52531310L,2239259266L,109021857446L,5966767051354L,362558298692270L,24214789406313442L,1763062297639690790L,BigInteger.Parse("138975554045857840570"),BigInteger.Parse("11790733617760291994990"),BigInteger.Parse("1071215297856049456744642") };
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
public class A113147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113147Inst Instance=new A113147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113148
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,141L,2928L,82597L,2925973L,124502114L,6179425823L,350316271761L,22326710345256L,1579953165170881L,122905129550802985L,10423661531476766834UL,BigInteger.Parse("957176457621821573987"),BigInteger.Parse("94608465923392572536421") };
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
public class A113148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113148Inst Instance=new A113148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113149
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,176L,4184L,134824L,5451528L,264710536L,14992543432L,969925065992L,70547721068232L,5697913588192520L,505926926171909576L,BigInteger.Parse("48979597517592503560"),BigInteger.Parse("5134435963996172979912"),BigInteger.Parse("579379155027833982679816") };
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
public class A113149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113149Inst Instance=new A113149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113150
{
public static readonly long[] Value={ 838561L,1190821L,2116921L,3318421L,3456721L,3720361L,3776881L,4185121L,5712241L,5811241L,6455521L,6457621L,6793321L,7450501L,7981801L,8321881L,8391001L,9903721L,11420041L,11980921L,12806041L,13311301L,13748521L,14326021L,14566261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113150Inst : IEnumerable<long>
{
public static readonly long[] Value=A113150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113150.Bytes);
public long this[int i]=>Value[i];

public static A113150Inst Instance=new A113150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113151
{
public static readonly long[] Value={ 3L,5L,11L,23L,53L,59L,83L,89L,149L,191L,263L,269L,293L,353L,359L,389L,401L,419L,431L,443L,461L,479L,521L,599L,653L,683L,761L,809L,821L,881L,941L,971L,983L,1013L,1061L,1091L,1103L,1151L,1181L,1193L,1283L,1511L,1571L,1613L,1619L,1931L,1973L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113151Inst : IEnumerable<long>
{
public static readonly long[] Value=A113151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113151.Bytes);
public long this[int i]=>Value[i];

public static A113151Inst Instance=new A113151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113152
{
public static readonly long[] Value={ 2L,79L,1217L,2879L,7121L,152879L,178897L,12781103L,24233953L,25553183L,29147633L,70852367L,1800921329L,3205490207L,6270364129L,30533756207L,39265770209L,52240479791L,68933130209L,73192853807L,74570506193L,78996293183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113152Inst : IEnumerable<long>
{
public static readonly long[] Value=A113152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113152.Bytes);
public long this[int i]=>Value[i];

public static A113152Inst Instance=new A113152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113153
{
public static readonly BigInteger[] Value={ 1L,2L,4L,8L,17L,54L,472L,27216L,84738887L,299164114847940L,BigInteger.Parse("311903053042108587337426568"),BigInteger.Parse("5846720173185251353387753850814872871131756204168") };
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
public class A113153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113153Inst Instance=new A113153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113154
{
public static readonly BigInteger[] Value={ 1L,4L,32L,153L,2798L,197282L,392458839L,68701093784946L,BigInteger.Parse("26589104218033177611804"),BigInteger.Parse("1824800382950333667240931155126914915"),BigInteger.Parse("48519278097695351677170017554626182187607010493656860644716") };
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
public class A113154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113154Inst Instance=new A113154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113155
{
public static readonly long[] Value={ 311L,401L,863L,907L,1117L,1213L,1237L,1399L,1427L,2333L,3299L,3533L,3821L,3967L,4243L,4493L,5273L,5779L,6199L,6521L,7069L,8219L,8369L,8623L,8741L,8837L,8929L,9277L,9613L,10139L,10601L,10631L,10939L,11621L,11779L,12197L,12241L,12343L,12401L,12457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113155Inst : IEnumerable<long>
{
public static readonly long[] Value=A113155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113155.Bytes);
public long this[int i]=>Value[i];

public static A113155Inst Instance=new A113155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113156
{
public static readonly long[] Value={ 181L,443L,557L,661L,967L,1109L,1553L,1951L,2069L,2441L,2551L,3257L,3371L,4001L,4783L,5179L,5987L,6143L,6217L,6473L,6701L,6803L,6841L,7213L,8431L,8663L,8839L,8887L,9283L,9511L,9839L,9883L,10177L,10589L,10771L,10883L,11059L,11093L,11173L,11437L,11657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113156Inst : IEnumerable<long>
{
public static readonly long[] Value=A113156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113156.Bytes);
public long this[int i]=>Value[i];

public static A113156Inst Instance=new A113156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113157
{
public static readonly long[] Value={ 283L,409L,739L,983L,1021L,2213L,2251L,2339L,2663L,2749L,3079L,3821L,3931L,4219L,4463L,4799L,4919L,5413L,5741L,6271L,6917L,7703L,7753L,7873L,8287L,8861L,9013L,10091L,10427L,10709L,11317L,11483L,12421L,12917L,13037L,13693L,13781L,14029L,14759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113157Inst : IEnumerable<long>
{
public static readonly long[] Value=A113157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113157.Bytes);
public long this[int i]=>Value[i];

public static A113157Inst Instance=new A113157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113158
{
public static readonly long[] Value={ 521L,821L,859L,1069L,1459L,1549L,2203L,2411L,2539L,2837L,2969L,3011L,3089L,3359L,3613L,3823L,4259L,4339L,4561L,4643L,4783L,5503L,5557L,6067L,6619L,6967L,7481L,7699L,7741L,8263L,8779L,9419L,10103L,12041L,12379L,12641L,12899L,13417L,13721L,13759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113158Inst : IEnumerable<long>
{
public static readonly long[] Value=A113158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113158.Bytes);
public long this[int i]=>Value[i];

public static A113158Inst Instance=new A113158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113159
{
public static readonly BigInteger[] Value={ 6L,1155L,86822723L,39181802686993L,BigInteger.Parse("35597295809230452047"),BigInteger.Parse("106599435598498872379635683") };
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
public class A113159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113159Inst Instance=new A113159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113160
{
public static readonly long[] Value={ 0L,1L,1L,2L,10L,1L,3L,7L,2L,1L,1L,9L,1L,1L,1L,6L,2L,1L,1L,1L,1L,3L,2L,2L,1L,3L,1L,2L,1L,1L,3L,1L,1L,17L,12L,2L,1L,3L,7L,3L,4L,2L,1L,5L,2L,2L,1L,6L,1L,18L,19L,1L,14L,3L,2L,1L,32L,4L,1L,2L,1L,2L,4L,3L,2L,2L,1L,2L,1L,1L,330L,11L,2L,1L,3L,1L,2L,2L,1L,17L,1L,3L,3L,2L,1L,2L,1L,1L,16L,1L,2L,1L,1L,21L,4L,1L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113160Inst : IEnumerable<long>
{
public static readonly long[] Value=A113160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113160.Bytes);
public long this[int i]=>Value[i];

public static A113160Inst Instance=new A113160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113161
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,17L,23L,31L,37L,47L,53L,61L,73L,83L,97L,113L,127L,139L,157L,173L,193L,211L,233L,257L,281L,307L,331L,359L,383L,409L,439L,467L,499L,523L,557L,593L,619L,653L,691L,727L,761L,797L,839L,883L,919L,953L,997L,1039L,1087L,1129L,1171L,1223L,1259L,1307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113161Inst : IEnumerable<long>
{
public static readonly long[] Value=A113161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113161.Bytes);
public long this[int i]=>Value[i];

public static A113161Inst Instance=new A113161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113162
{
public static readonly long[] Value={ 7L,126L,525L,700L,315L,42L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113162Inst : IEnumerable<long>
{
public static readonly long[] Value=A113162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113162.Bytes);
public long this[int i]=>Value[i];

public static A113162Inst Instance=new A113162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113163
{
public static readonly long[] Value={ 21L,175L,350L,210L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113163Inst : IEnumerable<long>
{
public static readonly long[] Value=A113163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113163.Bytes);
public long this[int i]=>Value[i];

public static A113163Inst Instance=new A113163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113164
{
public static readonly long[] Value={ 1L,36L,225L,400L,225L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113164Inst : IEnumerable<long>
{
public static readonly long[] Value=A113164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113164.Bytes);
public long this[int i]=>Value[i];

public static A113164Inst Instance=new A113164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113165
{
public static readonly long[] Value={ 2L,3L,7L,19L,31L,59L,61L,73L,97L,131L,139L,149L,167L,173L,181L,211L,223L,271L,277L,307L,313L,317L,331L,347L,463L,467L,509L,571L,601L,673L,809L,827L,877L,881L,953L,983L,997L,1031L,1033L,1039L,1051L,1063L,1069L,1109L,1259L,1279L,1283L,1291L,1297L,1361L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113165Inst : IEnumerable<long>
{
public static readonly long[] Value=A113165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113165.Bytes);
public long this[int i]=>Value[i];

public static A113165Inst Instance=new A113165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113166
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,8L,8L,17L,23L,41L,55L,102L,144L,247L,387L,631L,987L,1636L,2584L,4233L,6787L,11011L,17711L,28794L,46380L,75181L,121441L,196685L,317811L,514712L,832040L,1346921L,2178429L,3525581L,5702937L,9229314L,14930352L,24160419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113166Inst : IEnumerable<long>
{
public static readonly long[] Value=A113166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113166.Bytes);
public long this[int i]=>Value[i];

public static A113166Inst Instance=new A113166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113167
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,5L,3L,7L,11L,13L,4L,17L,19L,23L,29L,5L,31L,37L,41L,43L,47L,6L,53L,59L,61L,67L,71L,73L,7L,79L,83L,89L,97L,101L,103L,107L,8L,109L,113L,127L,131L,137L,139L,149L,151L,9L,157L,163L,167L,173L,179L,181L,191L,193L,197L,10L,199L,211L,223L,227L,229L,233L,239L,241L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113167Inst : IEnumerable<long>
{
public static readonly long[] Value=A113167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113167.Bytes);
public long this[int i]=>Value[i];

public static A113167Inst Instance=new A113167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113168
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,47L,51L,57L,65L,75L,87L,101L,117L,135L,137L,140L,144L,149L,155L,162L,170L,179L,189L,200L,204L,209L,215L,222L,230L,239L,249L,260L,272L,285L,291L,298L,306L,315L,325L,336L,348L,361L,375L,390L,398L,407L,417L,428L,440L,453L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113168Inst : IEnumerable<long>
{
public static readonly long[] Value=A113168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113168.Bytes);
public long this[int i]=>Value[i];

public static A113168Inst Instance=new A113168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113169
{
public static readonly long[] Value={ 3L,5L,17L,29L,47L,53L,59L,113L,137L,173L,227L,239L,257L,269L,347L,353L,389L,419L,449L,467L,479L,509L,557L,563L,599L,677L,719L,743L,827L,839L,953L,977L,983L,1013L,1019L,1103L,1109L,1163L,1193L,1217L,1223L,1259L,1277L,1289L,1307L,1373L,1427L,1487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113169Inst : IEnumerable<long>
{
public static readonly long[] Value=A113169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113169.Bytes);
public long this[int i]=>Value[i];

public static A113169Inst Instance=new A113169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113170
{
public static readonly BigInteger[] Value={ 1L,4L,33L,376L,5665L,115356L,3014209L,95722288L,3619661121L,161338248820L,8349617508961L,493959321484584L,33041900704133473L,2479933070973253516L,BigInteger.Parse("207343189445230918785"),BigInteger.Parse("19175058576632809926496"),BigInteger.Parse("1949302342535131018462849"),BigInteger.Parse("216707770770991401785821668") };
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
public class A113170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113170Inst Instance=new A113170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113171
{
public static readonly long[] Value={ 660L,1092L,1140L,1155L,1260L,1320L,1365L,1380L,1428L,1540L,1560L,1740L,1785L,1820L,1860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113171Inst : IEnumerable<long>
{
public static readonly long[] Value=A113171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113171.Bytes);
public long this[int i]=>Value[i];

public static A113171Inst Instance=new A113171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113172
{
public static readonly long[] Value={ 13L,3L,6L,8L,7L,10L,10L,8L,9L,4L,3L,9L,12L,11L,11L,13L,14L,12L,12L,8L,12L,15L,18L,20L,19L,22L,22L,20L,21L,16L,12L,15L,18L,20L,19L,22L,22L,20L,21L,16L,11L,14L,17L,19L,18L,21L,21L,19L,20L,15L,14L,17L,20L,22L,21L,24L,24L,22L,23L,18L,15L,18L,21L,23L,22L,25L,25L,23L,24L,19L,13L,16L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113172Inst : IEnumerable<long>
{
public static readonly long[] Value=A113172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113172.Bytes);
public long this[int i]=>Value[i];

public static A113172Inst Instance=new A113172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113173
{
public static readonly BigInteger[] Value={ 256L,5392L,315361L,11667713L,717360537L,83932270482L,27775696582531L,22260761742531649L,BigInteger.Parse("109563850113131234720"),BigInteger.Parse("2013390472722146301196"),BigInteger.Parse("1899501614194512059559835"),BigInteger.Parse("85600281199526209989968735") };
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
public class A113173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113173Inst Instance=new A113173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113174
{
public static readonly long[] Value={ 1L,3L,11L,44L,184L,792L,3484L,15592L,70745L,324561L,1502511L,7007929L,32892778L,155221536L,735915652L,3503270920L,16737092549L,80218277681L,385574074383L,1858059853316L,8974761939239L,43441619693731L,210682920968681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113174Inst : IEnumerable<long>
{
public static readonly long[] Value=A113174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113174.Bytes);
public long this[int i]=>Value[i];

public static A113174Inst Instance=new A113174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113175
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,13L,1L,4L,5L,89L,2L,233L,13L,10L,1L,1597L,4L,4181L,5L,26L,89L,28657L,2L,25L,233L,8L,13L,514229L,10L,1346269L,1L,178L,1597L,65L,4L,24157817L,4181L,466L,5L,165580141L,26L,433494437L,89L,20L,28657L,2971215073L,2L,169L,25L,3194L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113175Inst : IEnumerable<long>
{
public static readonly long[] Value=A113175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113175.Bytes);
public long this[int i]=>Value[i];

public static A113175Inst Instance=new A113175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113176
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,13L,1L,2L,5L,89L,2L,233L,13L,10L,1L,1597L,2L,4181L,5L,26L,89L,28657L,2L,5L,233L,2L,13L,514229L,10L,1346269L,1L,178L,1597L,65L,2L,24157817L,4181L,466L,5L,165580141L,26L,433494437L,89L,10L,28657L,2971215073L,2L,13L,5L,3194L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113176Inst : IEnumerable<long>
{
public static readonly long[] Value=A113176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113176.Bytes);
public long this[int i]=>Value[i];

public static A113176Inst Instance=new A113176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113177
{
public static readonly long[] Value={ 0L,1L,2L,2L,5L,3L,13L,3L,4L,6L,89L,4L,233L,14L,7L,4L,1597L,5L,4181L,7L,15L,90L,28657L,5L,10L,234L,6L,15L,514229L,8L,1346269L,5L,91L,1598L,18L,6L,24157817L,4182L,235L,8L,165580141L,16L,433494437L,91L,9L,28658L,2971215073L,6L,26L,11L,1599L,235L,53316291173L,7L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113177Inst : IEnumerable<long>
{
public static readonly long[] Value=A113177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113177.Bytes);
public long this[int i]=>Value[i];

public static A113177Inst Instance=new A113177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113178
{
public static readonly long[] Value={ 0L,1L,2L,1L,5L,3L,13L,1L,2L,6L,89L,3L,233L,14L,7L,1L,1597L,3L,4181L,6L,15L,90L,28657L,3L,5L,234L,2L,14L,514229L,8L,1346269L,1L,91L,1598L,18L,3L,24157817L,4182L,235L,6L,165580141L,16L,433494437L,90L,7L,28658L,2971215073L,3L,13L,6L,1599L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113178Inst : IEnumerable<long>
{
public static readonly long[] Value=A113178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113178.Bytes);
public long this[int i]=>Value[i];

public static A113178Inst Instance=new A113178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113179
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,128L,408L,1328L,4384L,14560L,48576L,162816L,547936L,1850048L,6263680L,21257856L,72298240L,246345728L,840775424L,2873802240L,9835840512L,33704557568L,115622041600L,397032488960L,1364610270720L,4694145256448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113179Inst : IEnumerable<long>
{
public static readonly long[] Value=A113179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113179.Bytes);
public long this[int i]=>Value[i];

public static A113179Inst Instance=new A113179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113180
{
public static readonly long[] Value={ 1L,2L,4L,8L,20L,56L,160L,448L,1240L,3440L,9632L,27200L,77216L,219840L,627200L,1793024L,5136480L,14743232L,42390400L,122064640L,351951232L,1015990528L,2936079360L,8493340672L,24591589120L,71262291456L,206666232832L,599778166784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113180Inst : IEnumerable<long>
{
public static readonly long[] Value=A113180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113180.Bytes);
public long this[int i]=>Value[i];

public static A113180Inst Instance=new A113180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113181
{
public static readonly BigInteger[] Value={ 1L,3L,14L,95L,859L,9130L,106039L,1297295L,16428300L,213388961L,2827645453L,38086408002L,520062618300L,7184570776213L,100256059855188L,1411319038583375L,20021022607979629L,285965560309310708L,4109498933510809561L,BigInteger.Parse("59380204746202961953"),BigInteger.Parse("862266486434574492404") };
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
public class A113181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113181Inst Instance=new A113181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113182
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,14L,39L,95L,308L,859L,3013L,9130L,33300L,106039L,394340L,1297295L,4878109L,16428300L,62232321L,213388961L,812825244L,2827645453L,10818489817L,38086408002L,146250545528L,520062618300L,2003199281223L,7184570776213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113182Inst : IEnumerable<long>
{
public static readonly long[] Value=A113182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113182.Bytes);
public long this[int i]=>Value[i];

public static A113182Inst Instance=new A113182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113183
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,18L,58L,155L,546L,1592L,5774L,17798L,65676L,210362L,785248L,2588155L,9743348L,32832290L,124416022L,426685544L,1625465732L,5654938190L,21636274202L,76171463926L,292498386900L,1040120036300L,4006388161846L,14369121494126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113183Inst : IEnumerable<long>
{
public static readonly long[] Value=A113183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113183.Bytes);
public long this[int i]=>Value[i];

public static A113183Inst Instance=new A113183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113184
{
public static readonly long[] Value={ 1L,1L,4L,5L,6L,4L,8L,13L,13L,6L,12L,20L,14L,8L,24L,29L,18L,13L,20L,30L,32L,12L,24L,52L,31L,14L,40L,40L,30L,24L,32L,61L,48L,18L,48L,65L,38L,20L,56L,78L,42L,32L,44L,60L,78L,24L,48L,116L,57L,31L,72L,70L,54L,40L,72L,104L,80L,30L,60L,120L,62L,32L,104L,125L,84L,48L,68L,90L,96L,48L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113184Inst : IEnumerable<long>
{
public static readonly long[] Value=A113184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113184.Bytes);
public long this[int i]=>Value[i];

public static A113184Inst Instance=new A113184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113185
{
public static readonly long[] Value={ 1L,1L,-3L,-2L,1L,1L,6L,-6L,-7L,7L,-3L,12L,-2L,-12L,18L,-2L,9L,-16L,-21L,20L,1L,12L,-36L,-22L,14L,1L,36L,-20L,-6L,30L,6L,32L,-23L,-24L,48L,-6L,7L,-36L,-60L,24L,-7L,42L,-36L,-42L,12L,7L,66L,-46L,-18L,43L,-3L,32L,-12L,-52L,60L,12L,42L,-40L,-90L,60L,-2L,62L,-96L,-42L,41L,-12L,72L,-66L,-16L,44L,18L,72L,-49L,-72L,108L,-2L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113185Inst : IEnumerable<long>
{
public static readonly long[] Value=A113185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113185.Bytes);
public long this[int i]=>Value[i];

public static A113185Inst Instance=new A113185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113186
{
public static readonly long[] Value={ 1L,-1L,-2L,-1L,1L,2L,-6L,-1L,7L,-1L,12L,2L,-12L,6L,-2L,-1L,-16L,-7L,20L,-1L,12L,-12L,-22L,2L,1L,12L,-20L,6L,30L,2L,32L,-1L,-24L,16L,-6L,-7L,-36L,-20L,24L,-1L,42L,-12L,-42L,-12L,7L,22L,-46L,2L,43L,-1L,32L,12L,-52L,20L,12L,6L,-40L,-30L,60L,2L,62L,-32L,-42L,-1L,-12L,24L,-66L,16L,44L,6L,72L,-7L,-72L,36L,-2L,-20L,-72L,-24L,80L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113186Inst : IEnumerable<long>
{
public static readonly long[] Value=A113186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113186.Bytes);
public long this[int i]=>Value[i];

public static A113186Inst Instance=new A113186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113187
{
public static readonly long[] Value={ 1L,-3L,1L,10L,-5L,1L,-35L,21L,-7L,1L,126L,-84L,36L,-9L,1L,-462L,330L,-165L,55L,-11L,1L,1716L,-1287L,715L,-286L,78L,-13L,1L,-6435L,5005L,-3003L,1365L,-455L,105L,-15L,1L,24310L,-19448L,12376L,-6188L,2380L,-680L,136L,-17L,1L,-92378L,75582L,-50388L,27132L,-11628L,3876L,-969L,171L,-19L,1L,352716L,-293930L,203490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113187Inst : IEnumerable<long>
{
public static readonly long[] Value=A113187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113187.Bytes);
public long this[int i]=>Value[i];

public static A113187Inst Instance=new A113187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113188
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,29L,31L,47L,53L,89L,131L,139L,199L,233L,521L,607L,953L,1453L,1597L,2207L,2351L,2579L,3571L,6763L,9349L,10891L,28513L,28649L,28657L,42187L,44771L,46279L,75017L,189653L,317777L,514229L,1981891L,2177699L,3010349L,3206767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113188Inst : IEnumerable<long>
{
public static readonly long[] Value=A113188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113188.Bytes);
public long this[int i]=>Value[i];

public static A113188Inst Instance=new A113188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113189
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,0L,2L,1L,2L,3L,1L,1L,2L,0L,3L,3L,1L,0L,1L,1L,1L,0L,0L,2L,2L,0L,2L,5L,1L,0L,2L,0L,1L,0L,2L,0L,2L,0L,2L,2L,3L,1L,1L,2L,2L,0L,1L,1L,2L,2L,3L,7L,0L,0L,1L,0L,0L,1L,0L,1L,2L,2L,2L,1L,2L,1L,2L,1L,1L,0L,1L,0L,4L,0L,2L,6L,2L,2L,3L,0L,2L,1L,1L,0L,3L,0L,0L,6L,1L,0L,2L,5L,2L,0L,0L,1L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113189Inst : IEnumerable<long>
{
public static readonly long[] Value=A113189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113189.Bytes);
public long this[int i]=>Value[i];

public static A113189Inst Instance=new A113189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113190
{
public static readonly long[] Value={ 14L,22L,26L,30L,31L,34L,38L,40L,42L,44L,46L,54L,61L,62L,64L,65L,67L,78L,80L,82L,88L,92L,94L,95L,98L,102L,103L,109L,112L,113L,117L,119L,121L,122L,125L,126L,127L,134L,135L,138L,139L,142L,143L,152L,154L,155L,158L,166L,167L,170L,172L,174L,175L,176L,182L,188L,190L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113190Inst : IEnumerable<long>
{
public static readonly long[] Value=A113190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113190.Bytes);
public long this[int i]=>Value[i];

public static A113190Inst Instance=new A113190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113191
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,15L,16L,17L,18L,22L,25L,26L,27L,28L,29L,36L,40L,43L,44L,45L,46L,47L,58L,65L,69L,72L,73L,74L,75L,76L,94L,105L,112L,116L,119L,120L,121L,122L,123L,152L,170L,181L,188L,192L,195L,196L,197L,198L,199L,246L,275L,293L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113191Inst : IEnumerable<long>
{
public static readonly long[] Value=A113191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113191.Bytes);
public long this[int i]=>Value[i];

public static A113191Inst Instance=new A113191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113192
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,29L,43L,47L,73L,181L,197L,199L,293L,311L,503L,521L,839L,1361L,2131L,2203L,2207L,3571L,5749L,9349L,13763L,23633L,24469L,24473L,38239L,103483L,103681L,161983L,167759L,271367L,399601L,439081L,439157L,709283L,1692737L,3010349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113192Inst : IEnumerable<long>
{
public static readonly long[] Value=A113192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113192.Bytes);
public long this[int i]=>Value[i];

public static A113192Inst Instance=new A113192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113193
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,1L,1L,2L,0L,1L,0L,1L,3L,1L,0L,2L,2L,1L,3L,1L,0L,1L,0L,3L,3L,0L,1L,2L,1L,1L,2L,1L,0L,2L,1L,0L,4L,2L,1L,3L,0L,1L,2L,1L,0L,1L,0L,2L,0L,1L,2L,1L,3L,0L,2L,1L,2L,1L,0L,0L,2L,3L,0L,1L,1L,3L,0L,1L,0L,1L,0L,0L,4L,1L,1L,1L,2L,1L,0L,1L,0L,3L,1L,1L,0L,2L,4L,1L,1L,0L,3L,0L,0L,5L,0L,1L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113193Inst : IEnumerable<long>
{
public static readonly long[] Value=A113193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113193.Bytes);
public long this[int i]=>Value[i];

public static A113193Inst Instance=new A113193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113194
{
public static readonly long[] Value={ 5L,7L,10L,17L,19L,23L,29L,31L,34L,41L,44L,49L,53L,55L,57L,62L,67L,68L,71L,75L,77L,79L,80L,87L,89L,93L,98L,100L,101L,103L,107L,109L,110L,116L,122L,124L,125L,133L,134L,135L,136L,143L,147L,154L,155L,160L,161L,164L,167L,170L,173L,177L,180L,184L,185L,188L,190L,194L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113194Inst : IEnumerable<long>
{
public static readonly long[] Value=A113194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113194.Bytes);
public long this[int i]=>Value[i];

public static A113194Inst Instance=new A113194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113195
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,2L,13L,21L,34L,5L,89L,6L,233L,13L,10L,987L,1597L,34L,4181L,15L,26L,89L,28657L,42L,75025L,233L,196418L,39L,514229L,10L,1346269L,2178309L,178L,1597L,65L,102L,24157817L,4181L,466L,105L,165580141L,26L,433494437L,267L,170L,28657L,2971215073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113195Inst : IEnumerable<long>
{
public static readonly long[] Value=A113195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113195.Bytes);
public long this[int i]=>Value[i];

public static A113195Inst Instance=new A113195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113196
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,1L,1L,11L,1L,24L,1L,29L,61L,1L,1L,76L,1L,451L,421L,199L,1L,1104L,1L,521L,1L,8149L,1L,83204L,1L,1L,19801L,3571L,141961L,146376L,1L,9349L,135721L,974611L,1L,10304396L,1L,2626999L,6675901L,64079L,1L,2435424L,1L,167761L,6376021L,47140601L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113196Inst : IEnumerable<long>
{
public static readonly long[] Value=A113196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113196.Bytes);
public long this[int i]=>Value[i];

public static A113196Inst Instance=new A113196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113197
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,5L,7L,8L,16L,12L,18L,10L,14L,13L,23L,25L,27L,49L,64L,81L,512L,11L,17L,19L,32L,53L,128L,256L,65536L,36L,26L,46L,50L,54L,98L,125L,162L,2401L,15L,21L,37L,61L,169L,343L,529L,625L,729L,4096L,19683L,262144L,20L,24L,28L,48L,22L,34L,38L,106L,29L,41L,43L,83L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113197Inst : IEnumerable<long>
{
public static readonly long[] Value=A113197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113197.Bytes);
public long this[int i]=>Value[i];

public static A113197Inst Instance=new A113197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113198
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,2L,8L,8L,1L,8L,12L,4L,4L,28L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113198Inst : IEnumerable<long>
{
public static readonly long[] Value=A113198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113198.Bytes);
public long this[int i]=>Value[i];

public static A113198Inst Instance=new A113198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113199
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,5L,7L,8L,16L,12L,18L,10L,14L,13L,23L,25L,27L,49L,64L,81L,512L,11L,17L,19L,32L,53L,128L,256L,65536L,36L,26L,46L,50L,54L,98L,125L,162L,2401L,22L,34L,38L,106L,15L,21L,37L,61L,169L,343L,529L,625L,729L,4096L,19683L,262144L,29L,41L,43L,83L,97L,103L,121L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113199Inst : IEnumerable<long>
{
public static readonly long[] Value=A113199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113199.Bytes);
public long this[int i]=>Value[i];

public static A113199Inst Instance=new A113199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113200
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,2L,8L,8L,1L,8L,4L,12L,28L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113200Inst : IEnumerable<long>
{
public static readonly long[] Value=A113200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113200.Bytes);
public long this[int i]=>Value[i];

public static A113200Inst Instance=new A113200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113201
{
public static readonly long[] Value={ 1L,1L,2L,3L,9L,18L,62L,198L,803L,3378L,15882L,77185L,393075L,2049974L,10938182L,59312272L,326258544L,1815910231L,10213424233L,57974895671L,331820721234L,1913429250439L,11109119321058L,64901418126997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113201Inst : IEnumerable<long>
{
public static readonly long[] Value=A113201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113201.Bytes);
public long this[int i]=>Value[i];

public static A113201Inst Instance=new A113201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113202
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,21L,83L,298L,1339L,6049L,29765L,148842L,770267L,4054539L,21743705L,118237471L,651370528L,3628421181L,20416662314L,115919209155L,663548898942L,3826577783917L,22217382001865L,129800215435088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113202Inst : IEnumerable<long>
{
public static readonly long[] Value=A113202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113202.Bytes);
public long this[int i]=>Value[i];

public static A113202Inst Instance=new A113202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113203
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,3L,16L,26L,99L,256L,895L,2789L,9740L,32799L,115024L,401180L,1421170L,5046539L,18066772L,64940825L,234712099L,851801048L,3104690139L,11358900851L,41710948878L,153684688127L,568079430741L,2106188450292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113203Inst : IEnumerable<long>
{
public static readonly long[] Value=A113203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113203.Bytes);
public long this[int i]=>Value[i];

public static A113203Inst Instance=new A113203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113204
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,4L,3L,15L,25L,92L,234L,803L,2469L,8512L,28290L,98148L,338673L,1188338L,4180854L,14840031L,52904562L,189724510L,683384218L,2472961423L,8984888982L,32772085447L,119963084542L,440623586740L,1623555117611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113204Inst : IEnumerable<long>
{
public static readonly long[] Value=A113204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113204.Bytes);
public long this[int i]=>Value[i];

public static A113204Inst Instance=new A113204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113205
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,2L,12L,16L,59L,133L,445L,1248L,4162L,13014L,43474L,143304L,484444L,1639388L,5617205L,19332596L,67048051L,233691112L,819121608L,2884443024L,10204104900L,36247138920L,129264732757L,462661038926L,1661637913984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113205Inst : IEnumerable<long>
{
public static readonly long[] Value=A113205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113205.Bytes);
public long this[int i]=>Value[i];

public static A113205Inst Instance=new A113205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113206
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,2L,0L,1L,1L,0L,3L,5L,3L,0L,1L,1L,0L,4L,12L,14L,12L,4L,0L,1L,1L,0L,5L,22L,55L,42L,55L,22L,5L,0L,1L,1L,0L,6L,35L,140L,273L,132L,273L,140L,35L,6L,0L,1L,1L,0L,7L,51L,285L,969L,1428L,429L,1428L,969L,285L,51L,7L,0L,1L,1L,0L,8L,70L,506L,2530L,7084L,7752L,1430L,7752L,7084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113206Inst : IEnumerable<long>
{
public static readonly long[] Value=A113206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113206.Bytes);
public long this[int i]=>Value[i];

public static A113206Inst Instance=new A113206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113207
{
public static readonly long[] Value={ 1L,5L,38L,347L,3507L,37788L,425490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113207Inst : IEnumerable<long>
{
public static readonly long[] Value=A113207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113207.Bytes);
public long this[int i]=>Value[i];

public static A113207Inst Instance=new A113207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113208
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,44L,1426L,17592187106356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113208Inst : IEnumerable<long>
{
public static readonly long[] Value=A113208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113208.Bytes);
public long this[int i]=>Value[i];

public static A113208Inst Instance=new A113208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113209
{
public static readonly long[] Value={ 1L,4L,6L,4L,9L,7L,3L,5L,2L,0L,7L,1L,7L,9L,2L,7L,1L,6L,7L,1L,9L,7L,0L,4L,0L,4L,0L,7L,6L,7L,8L,6L,4L,0L,3L,9L,6L,3L,0L,7L,9L,3L,2L,3L,6L,6L,6L,6L,6L,0L,4L,9L,6L,8L,9L,0L,5L,2L,8L,9L,0L,3L,9L,4L,7L,9L,5L,4L,9L,2L,2L,7L,6L,1L,9L,1L,0L,2L,5L,8L,2L,3L,6L,5L,5L,5L,9L,3L,1L,1L,3L,7L,5L,9L,5L,2L,9L,4L,9L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113209Inst : IEnumerable<long>
{
public static readonly long[] Value=A113209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113209.Bytes);
public long this[int i]=>Value[i];

public static A113209Inst Instance=new A113209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113210
{
public static readonly long[] Value={ 1L,8L,9L,2L,7L,8L,9L,2L,6L,0L,7L,1L,4L,3L,7L,2L,3L,1L,1L,2L,9L,8L,5L,8L,1L,3L,4L,3L,0L,2L,8L,2L,8L,2L,5L,6L,2L,8L,9L,8L,7L,5L,6L,9L,2L,0L,3L,9L,5L,6L,4L,1L,2L,8L,3L,6L,1L,1L,9L,6L,4L,8L,3L,1L,5L,1L,6L,0L,5L,5L,6L,0L,4L,1L,4L,2L,7L,4L,4L,4L,1L,5L,1L,8L,3L,5L,1L,8L,0L,6L,5L,6L,4L,8L,3L,5L,5L,2L,3L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113210Inst : IEnumerable<long>
{
public static readonly long[] Value=A113210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113210.Bytes);
public long this[int i]=>Value[i];

public static A113210Inst Instance=new A113210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113211
{
public static readonly long[] Value={ 1L,1L,2L,9L,1L,5L,0L,0L,6L,8L,1L,0L,7L,1L,5L,9L,2L,2L,7L,6L,0L,9L,1L,0L,0L,3L,3L,4L,3L,4L,9L,8L,1L,7L,0L,7L,2L,2L,8L,6L,4L,5L,5L,8L,2L,2L,3L,7L,3L,5L,8L,5L,1L,9L,0L,0L,9L,0L,8L,1L,8L,5L,2L,4L,6L,1L,5L,5L,0L,4L,6L,2L,8L,4L,0L,0L,8L,1L,8L,9L,9L,8L,0L,2L,0L,5L,6L,3L,0L,8L,9L,1L,6L,8L,7L,2L,2L,5L,2L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113211Inst : IEnumerable<long>
{
public static readonly long[] Value=A113211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113211.Bytes);
public long this[int i]=>Value[i];

public static A113211Inst Instance=new A113211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113212
{
public static readonly long[] Value={ 1L,8L,6L,1L,7L,1L,5L,9L,5L,9L,5L,0L,0L,9L,1L,7L,9L,3L,9L,7L,4L,1L,7L,8L,8L,0L,5L,1L,8L,8L,6L,7L,5L,4L,6L,0L,3L,9L,1L,8L,0L,2L,8L,7L,1L,9L,9L,5L,1L,7L,6L,9L,7L,5L,0L,8L,2L,6L,8L,3L,2L,7L,7L,8L,3L,4L,3L,8L,6L,8L,2L,3L,0L,5L,0L,4L,0L,0L,4L,9L,8L,4L,8L,5L,7L,9L,2L,9L,3L,3L,6L,3L,0L,5L,7L,6L,3L,5L,4L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113212Inst : IEnumerable<long>
{
public static readonly long[] Value=A113212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113212.Bytes);
public long this[int i]=>Value[i];

public static A113212Inst Instance=new A113212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113213
{
public static readonly long[] Value={ 0L,1L,3L,3L,9L,3L,21L,15L,9L,15L,21L,3L,45L,135L,75L,15L,99L,93L,99L,315L,105L,105L,15L,75L,339L,117L,261L,183L,351L,453L,1281L,267L,675L,867L,819L,117L,69L,2343L,1995L,1005L,2949L,165L,741L,603L,315L,1287L,1629L,243L,519L,765L,165L,1233L,741L,1797L,339L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113213Inst : IEnumerable<long>
{
public static readonly long[] Value=A113213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113213.Bytes);
public long this[int i]=>Value[i];

public static A113213Inst Instance=new A113213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113214
{
public static readonly long[] Value={ 1L,2L,1L,0L,3L,1L,0L,2L,4L,1L,0L,0L,5L,5L,1L,0L,0L,2L,9L,6L,1L,0L,0L,0L,7L,14L,7L,1L,0L,0L,0L,2L,16L,20L,8L,1L,0L,0L,0L,0L,9L,30L,27L,9L,1L,0L,0L,0L,0L,2L,25L,50L,35L,10L,1L,0L,0L,0L,0L,0L,11L,55L,77L,44L,11L,1L,0L,0L,0L,0L,0L,2L,36L,105L,112L,54L,12L,1L,0L,0L,0L,0L,0L,0L,13L,91L,182L,156L,65L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113214Inst : IEnumerable<long>
{
public static readonly long[] Value=A113214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113214.Bytes);
public long this[int i]=>Value[i];

public static A113214Inst Instance=new A113214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113215
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,3L,3L,3L,3L,5L,5L,5L,5L,5L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113215Inst : IEnumerable<long>
{
public static readonly long[] Value=A113215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113215.Bytes);
public long this[int i]=>Value[i];

public static A113215Inst Instance=new A113215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113216
{
public static readonly long[] Value={ 1L,1L,2L,1L,-6L,-12L,1L,12L,-60L,-120L,1L,-20L,-180L,840L,1680L,1L,30L,-420L,-3360L,15120L,30240L,1L,-42L,-840L,10080L,75600L,-332640L,-665280L,1L,56L,-1512L,-25200L,277200L,1995840L,-8648640L,-17297280L,1L,-72L,-2520L,55440L,831600L,-8648640L,-60540480L,259459200L,518918400L,1L,90L,-3960L,-110880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113216Inst : IEnumerable<long>
{
public static readonly long[] Value=A113216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113216.Bytes);
public long this[int i]=>Value[i];

public static A113216Inst Instance=new A113216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113217
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113217Inst : IEnumerable<long>
{
public static readonly long[] Value=A113217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113217.Bytes);
public long this[int i]=>Value[i];

public static A113217Inst Instance=new A113217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113218
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,10L,13L,12L,15L,14L,17L,16L,20L,18L,22L,19L,24L,21L,26L,23L,29L,25L,31L,27L,33L,28L,35L,30L,38L,32L,40L,34L,42L,36L,44L,37L,47L,39L,49L,41L,51L,43L,53L,45L,56L,46L,58L,48L,60L,50L,62L,52L,65L,54L,67L,55L,69L,57L,71L,59L,74L,61L,76L,63L,78L,64L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113218Inst : IEnumerable<long>
{
public static readonly long[] Value=A113218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113218.Bytes);
public long this[int i]=>Value[i];

public static A113218Inst Instance=new A113218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113219
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,22L,20L,24L,18L,26L,19L,29L,21L,27L,23L,28L,25L,30L,31L,32L,33L,42L,35L,44L,38L,47L,40L,49L,34L,43L,36L,45L,37L,46L,39L,48L,41L,62L,51L,65L,53L,67L,56L,69L,58L,59L,60L,61L,50L,63L,52L,64L,54L,83L,55L,85L,57L,87L,71L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113219Inst : IEnumerable<long>
{
public static readonly long[] Value=A113219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113219.Bytes);
public long this[int i]=>Value[i];

public static A113219Inst Instance=new A113219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113220
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,10L,13L,12L,15L,14L,17L,16L,19L,21L,18L,23L,20L,25L,22L,27L,24L,29L,31L,26L,33L,28L,35L,30L,37L,32L,39L,41L,34L,43L,36L,45L,38L,47L,40L,49L,51L,42L,53L,44L,55L,46L,57L,48L,59L,61L,50L,63L,52L,65L,54L,67L,56L,69L,71L,58L,73L,60L,75L,62L,77L,64L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113220Inst : IEnumerable<long>
{
public static readonly long[] Value=A113220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113220.Bytes);
public long this[int i]=>Value[i];

public static A113220Inst Instance=new A113220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113221
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,21L,23L,19L,25L,18L,27L,20L,29L,22L,26L,28L,24L,30L,31L,32L,33L,41L,35L,43L,45L,37L,47L,39L,49L,34L,42L,36L,44L,46L,38L,48L,40L,61L,51L,63L,53L,65L,67L,55L,69L,57L,58L,59L,60L,50L,62L,64L,52L,81L,54L,83L,56L,85L,71L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113221Inst : IEnumerable<long>
{
public static readonly long[] Value=A113221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113221.Bytes);
public long this[int i]=>Value[i];

public static A113221Inst Instance=new A113221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113222
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,3L,13L,21L,34L,6L,89L,5L,233L,14L,7L,987L,1597L,35L,4181L,8L,15L,90L,28657L,23L,75025L,234L,196418L,16L,514229L,8L,1346269L,2178309L,91L,1598L,18L,37L,24157817L,4182L,235L,26L,165580141L,16L,433494437L,92L,39L,28658L,2971215073L,989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113222Inst : IEnumerable<long>
{
public static readonly long[] Value=A113222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113222.Bytes);
public long this[int i]=>Value[i];

public static A113222Inst Instance=new A113222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113223
{
public static readonly long[] Value={ 7L,5L,0L,3L,8L,7L,0L,8L,2L,1L,6L,4L,1L,9L,8L,5L,1L,4L,7L,9L,5L,3L,1L,9L,7L,3L,6L,8L,0L,9L,3L,2L,9L,3L,3L,6L,9L,8L,6L,8L,1L,0L,3L,0L,2L,1L,0L,9L,4L,4L,4L,7L,7L,9L,8L,1L,8L,2L,2L,9L,6L,1L,1L,7L,1L,1L,9L,6L,5L,8L,3L,2L,4L,2L,5L,8L,7L,0L,4L,6L,9L,9L,8L,8L,4L,4L,8L,5L,6L,6L,6L,8L,9L,4L,2L,6L,4L,9L,8L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113223Inst : IEnumerable<long>
{
public static readonly long[] Value=A113223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113223.Bytes);
public long this[int i]=>Value[i];

public static A113223Inst Instance=new A113223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113224
{
public static readonly long[] Value={ 1L,2L,7L,16L,41L,98L,239L,576L,1393L,3362L,8119L,19600L,47321L,114242L,275807L,665856L,1607521L,3880898L,9369319L,22619536L,54608393L,131836322L,318281039L,768398400L,1855077841L,4478554082L,10812186007L,26102926096L,63018038201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113224Inst : IEnumerable<long>
{
public static readonly long[] Value=A113224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113224.Bytes);
public long this[int i]=>Value[i];

public static A113224Inst Instance=new A113224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113225
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,35L,85L,204L,493L,1189L,2871L,6930L,16731L,40391L,97513L,235416L,568345L,1372105L,3312555L,7997214L,19306983L,46611179L,112529341L,271669860L,655869061L,1583407981L,3822685023L,9228778026L,22280241075L,53789260175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113225Inst : IEnumerable<long>
{
public static readonly long[] Value=A113225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113225.Bytes);
public long this[int i]=>Value[i];

public static A113225Inst Instance=new A113225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113226
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,585L,3669L,25932L,203768L,1761109L,16595757L,169287873L,1857903529L,21823488238L,273130320026L,3627845694283L,50962676849199L,754814462534449L,11754778469338581L,191998054346198680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113226Inst : IEnumerable<long>
{
public static readonly long[] Value=A113226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113226.Bytes);
public long this[int i]=>Value[i];

public static A113226Inst Instance=new A113226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113227
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,105L,549L,3207L,20577L,143239L,1071704L,8555388L,72442465L,647479819L,6083742438L,59885558106L,615718710929L,6595077685263L,73424063891526L,847916751131054L,10138485386085013L,125310003360265231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113227Inst : IEnumerable<long>
{
public static readonly long[] Value=A113227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113227.Bytes);
public long this[int i]=>Value[i];

public static A113227Inst Instance=new A113227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113228
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,632L,4229L,32337L,278204L,2659223L,27959880L,320706444L,3985116699L,53328433923L,764610089967L,11693644958690L,190015358010114L,3269272324528547L,59373764638615449L,1135048629795612125L,BigInteger.Parse("22783668363316052016"),BigInteger.Parse("479111084084119883217") };
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
public class A113228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113228Inst Instance=new A113228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113229
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,631L,4223L,32301L,277962L,2657797L,27954521L,320752991L,3987045780L,53372351265L,765499019221L,11711207065229L,190365226548070L,3276401870322033L,59523410471007913L,1138295039078030599L,BigInteger.Parse("22856576346825690128"),BigInteger.Parse("480807130959249565541") };
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
public class A113229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113229Inst Instance=new A113229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113230
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,4L,1L,1L,5L,1L,1L,6L,1L,1L,7L,1L,1L,8L,1L,1L,9L,1L,2L,0L,2L,2L,1L,2L,2L,2L,2L,2L,3L,2L,2L,4L,2L,2L,5L,2L,2L,6L,2L,2L,7L,2L,2L,8L,2L,2L,9L,2L,3L,0L,3L,3L,1L,3L,3L,2L,3L,3L,3L,3L,3L,4L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113230Inst : IEnumerable<long>
{
public static readonly long[] Value=A113230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113230.Bytes);
public long this[int i]=>Value[i];

public static A113230Inst Instance=new A113230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113231
{
public static readonly BigInteger[] Value={ 1L,4L,34L,956L,106721L,75818480L,490656737694L,22960404169011552L,BigInteger.Parse("7141530219670856270919"),BigInteger.Parse("20319415706020976355219258316"),BigInteger.Parse("1104797870481014132439711155738991604") };
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
public class A113231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113231Inst Instance=new A113231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113232
{
public static readonly long[] Value={ 1L,2L,3L,4L,16L,8L,9L,7L,5L,6L,33L,12L,24L,14L,66L,10L,21L,25L,11L,18L,26L,20L,96L,36L,38L,17L,39L,32L,52L,19L,27L,49L,34L,72L,74L,13L,37L,76L,40L,100L,48L,56L,65L,15L,70L,28L,43L,23L,57L,104L,64L,112L,135L,22L,139L,120L,67L,137L,92L,68L,71L,128L,131L,98L,60L,88L,136L,130L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113232Inst : IEnumerable<long>
{
public static readonly long[] Value=A113232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113232.Bytes);
public long this[int i]=>Value[i];

public static A113232Inst Instance=new A113232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113233
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,16L,5L,10L,7L,20L,12L,26L,14L,28L,8L,13L,11L,22L,19L,24L,30L,39L,17L,33L,36L,41L,44L,51L,54L,76L,15L,18L,25L,43L,21L,37L,34L,48L,23L,31L,60L,80L,46L,57L,85L,104L,27L,66L,62L,71L,64L,90L,83L,109L,68L,88L,100L,102L,74L,112L,107L,162L,29L,35L,32L,45L,42L,61L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113233Inst : IEnumerable<long>
{
public static readonly long[] Value=A113233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113233.Bytes);
public long this[int i]=>Value[i];

public static A113233Inst Instance=new A113233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113234
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,8L,6L,7L,16L,19L,12L,36L,14L,44L,5L,26L,20L,30L,22L,17L,54L,48L,13L,18L,21L,31L,46L,71L,83L,72L,28L,11L,33L,80L,24L,37L,25L,27L,39L,76L,74L,47L,85L,88L,92L,128L,41L,32L,107L,69L,29L,135L,115L,181L,42L,49L,96L,124L,65L,98L,185L,93L,51L,43L,15L,57L,60L,112L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113234Inst : IEnumerable<long>
{
public static readonly long[] Value=A113234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113234.Bytes);
public long this[int i]=>Value[i];

public static A113234Inst Instance=new A113234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113235
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,49L,301L,2281L,21211L,220417L,2528569L,32014801L,442974511L,6638604721L,107089487077L,1849731389689L,34051409587651L,665366551059841L,13751213558077681L,299644435399909537L,6864906328749052759L,BigInteger.Parse("164941239260973870001"),BigInteger.Parse("4146673091958686331421") };
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
public class A113235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113235Inst Instance=new A113235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113236
{
public static readonly BigInteger[] Value={ 1L,1L,3L,7L,49L,321L,2851L,24823L,256257L,2887489L,36759331L,507010791L,7597222513L,122184356737L,2106356007939L,38693238713431L,754792977928321L,15572911248409473L,338800604611562947L,7749991799652960199L,BigInteger.Parse("185934065196259734321"),BigInteger.Parse("4667877395135551746241") };
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
public class A113236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113236Inst Instance=new A113236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113237
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,49L,381L,2971L,26713L,291873L,3262969L,41245651L,569262981L,8433896593L,136060620853L,2342471665899L,42987065380561L,838321137046081L,17272648375895793L,375413770580941603L,8579701021461918589L,BigInteger.Parse("205637099039964274161"),BigInteger.Parse("5158188565847339152621") };
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
public class A113237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A113237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A113237Inst Instance=new A113237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113238
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,9L,11L,12L,17L,20L,22L,23L,31L,37L,40L,42L,43L,57L,68L,74L,77L,79L,80L,105L,125L,136L,142L,145L,147L,148L,193L,230L,250L,261L,267L,270L,272L,273L,355L,423L,460L,480L,491L,497L,500L,502L,503L,653L,778L,846L,883L,903L,914L,920L,923L,925L,926L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113238Inst : IEnumerable<long>
{
public static readonly long[] Value=A113238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113238.Bytes);
public long this[int i]=>Value[i];

public static A113238Inst Instance=new A113238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113239
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,31L,37L,43L,79L,193L,491L,503L,653L,883L,1201L,10607L,19009L,19469L,19489L,34963L,35809L,46499L,223273L,223313L,391231L,409817L,410731L,532159L,634061L,754549L,1383769L,1389533L,2552621L,2555753L,3311233L,4477453L,4700621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113239Inst : IEnumerable<long>
{
public static readonly long[] Value=A113239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113239.Bytes);
public long this[int i]=>Value[i];

public static A113239Inst Instance=new A113239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A113240
{
public static readonly long[] Value={ 1L,2L,5L,6L,13L,14L,25L,30L,49L,50L,97L,98L,165L,186L,325L,326L,621L,622L,1161L,1230L,2257L,2258L,4481L,4498L,8597L,8858L,17125L,17126L,34077L,34078L,66985L,68014L,133553L,133634L,267057L,267058L,529205L,533306L,1058261L,1058262L,2115133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A113240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A113240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A113240Inst : IEnumerable<long>
{
public static readonly long[] Value=A113240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A113240.Bytes);
public long this[int i]=>Value[i];

public static A113240Inst Instance=new A113240Inst();

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