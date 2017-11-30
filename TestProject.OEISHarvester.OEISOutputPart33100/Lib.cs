using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A013806
{
public static readonly BigInteger[] Value={ 17L,1419857L,118587876497L,9904578032905937L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("69091933913008732880827217"),BigInteger.Parse("5770627412348402378939569991057"),BigInteger.Parse("481968572106750915091411825223071697"),BigInteger.Parse("40254497110927943179349807054456171205137") };
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
public class A013806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013806Inst Instance=new A013806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013789
{
public static readonly BigInteger[] Value={ 512L,2097152L,8589934592L,35184372088832L,144115188075855872L,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("2417851639229258349412352"),BigInteger.Parse("9903520314283042199192993792"),BigInteger.Parse("40564819207303340847894502572032"),BigInteger.Parse("166153499473114484112975882535043072") };
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
public class A013789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013789Inst Instance=new A013789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013788
{
public static readonly BigInteger[] Value={ 8L,32768L,134217728L,549755813888L,2251799813685248L,9223372036854775808UL,BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("633825300114114700748351602688"),BigInteger.Parse("2596148429267413814265248164610048"),BigInteger.Parse("10633823966279326983230456482242756608") };
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
public class A013788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013788Inst Instance=new A013788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013787
{
public static readonly BigInteger[] Value={ 343L,823543L,1977326743L,4747561509943L,11398895185373143L,BigInteger.Parse("27368747340080916343"),BigInteger.Parse("65712362363534280139543"),BigInteger.Parse("157775382034845806615042743"),BigInteger.Parse("378818692265664781682717625943"),BigInteger.Parse("909543680129861140820205019889143"),BigInteger.Parse("2183814375991796599109312252753832343") };
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
public class A013787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013787Inst Instance=new A013787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013786
{
public static readonly BigInteger[] Value={ 7L,16807L,40353607L,96889010407L,232630513987207L,558545864083284007L,BigInteger.Parse("1341068619663964900807"),BigInteger.Parse("3219905755813179726837607"),BigInteger.Parse("7730993719707444524137094407"),BigInteger.Parse("18562115921017574302453163671207"),BigInteger.Parse("44567640326363195900190045974568007") };
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
public class A013786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013786Inst Instance=new A013786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013785
{
public static readonly BigInteger[] Value={ 216L,279936L,362797056L,470184984576L,609359740010496L,789730223053602816L,BigInteger.Parse("1023490369077469249536"),BigInteger.Parse("1326443518324400147398656"),BigInteger.Parse("1719070799748422591028658176"),BigInteger.Parse("2227915756473955677973140996096"),BigInteger.Parse("2887378820390246558653190730940416") };
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
public class A013785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013785Inst Instance=new A013785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013784
{
public static readonly BigInteger[] Value={ 6L,7776L,10077696L,13060694016L,16926659444736L,21936950640377856L,BigInteger.Parse("28430288029929701376"),BigInteger.Parse("36845653286788892983296"),BigInteger.Parse("47751966659678405306351616"),BigInteger.Parse("61886548790943213277031694336"),BigInteger.Parse("80204967233062404407033075859456") };
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
public class A013784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013784Inst Instance=new A013784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013783
{
public static readonly BigInteger[] Value={ 125L,78125L,48828125L,30517578125L,19073486328125L,11920928955078125L,7450580596923828125L,BigInteger.Parse("4656612873077392578125"),BigInteger.Parse("2910383045673370361328125"),BigInteger.Parse("1818989403545856475830078125"),BigInteger.Parse("1136868377216160297393798828125") };
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
public class A013783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013783Inst Instance=new A013783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013782
{
public static readonly BigInteger[] Value={ 5L,3125L,1953125L,1220703125L,762939453125L,476837158203125L,298023223876953125L,BigInteger.Parse("186264514923095703125"),BigInteger.Parse("116415321826934814453125"),BigInteger.Parse("72759576141834259033203125"),BigInteger.Parse("45474735088646411895751953125") };
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
public class A013782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013782Inst Instance=new A013782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013781
{
public static readonly BigInteger[] Value={ 64L,16384L,4194304L,1073741824L,274877906944L,70368744177664L,18014398509481984L,4611686018427387904L,BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("77371252455336267181195264"),BigInteger.Parse("19807040628566084398385987584") };
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
public class A013781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013781Inst Instance=new A013781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013780
{
public static readonly BigInteger[] Value={ 4L,1024L,262144L,67108864L,17179869184L,4398046511104L,1125899906842624L,288230376151711744L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("18889465931478580854784"),BigInteger.Parse("4835703278458516698824704"),BigInteger.Parse("1237940039285380274899124224") };
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
public class A013780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013780Inst Instance=new A013780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013779
{
public static readonly BigInteger[] Value={ 27L,2187L,177147L,14348907L,1162261467L,94143178827L,7625597484987L,617673396283947L,50031545098999707L,4052555153018976267L,BigInteger.Parse("328256967394537077627"),BigInteger.Parse("26588814358957503287787"),BigInteger.Parse("2153693963075557766310747") };
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
public class A013779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013779Inst Instance=new A013779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013778
{
public static readonly BigInteger[] Value={ 3L,243L,19683L,1594323L,129140163L,10460353203L,847288609443L,68630377364883L,5559060566555523L,450283905890997363L,BigInteger.Parse("36472996377170786403"),BigInteger.Parse("2954312706550833698643"),BigInteger.Parse("239299329230617529590083"),BigInteger.Parse("19383245667680019896796723") };
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
public class A013778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013778Inst Instance=new A013778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013777
{
public static readonly ulong[] Value={ 8L,128L,2048L,32768L,524288L,8388608L,134217728L,2147483648L,34359738368L,549755813888L,8796093022208L,140737488355328L,2251799813685248L,36028797018963968L,576460752303423488L,9223372036854775808UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013777Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A013777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013777.Bytes);
public ulong this[int i]=>Value[i];

public static A013777Inst Instance=new A013777Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013776
{
public static readonly long[] Value={ 2L,32L,512L,8192L,131072L,2097152L,33554432L,536870912L,8589934592L,137438953472L,2199023255552L,35184372088832L,562949953421312L,9007199254740992L,144115188075855872L,2305843009213693952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013776Inst : IEnumerable<long>
{
public static readonly long[] Value=A013776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013776.Bytes);
public long this[int i]=>Value[i];

public static A013776Inst Instance=new A013776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013775
{
public static readonly BigInteger[] Value={ 576L,7962624L,110075314176L,1521681143169024L,BigInteger.Parse("21035720123168587776"),BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("4019988717840603673710821376"),BigInteger.Parse("55572324035428505185378394701824") };
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
public class A013775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013775Inst Instance=new A013775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013774
{
public static readonly BigInteger[] Value={ 24L,331776L,4586471424L,63403380965376L,876488338465357824L,BigInteger.Parse("12116574790945106558976"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("2315513501476187716057433112576"),BigInteger.Parse("32009658644406818986777955348250624") };
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
public class A013774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013774Inst Instance=new A013774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013757
{
public static readonly BigInteger[] Value={ 225L,759375L,2562890625L,8649755859375L,29192926025390625L,BigInteger.Parse("98526125335693359375"),BigInteger.Parse("332525673007965087890625"),BigInteger.Parse("1122274146401882171630859375"),BigInteger.Parse("3787675244106352329254150390625"),BigInteger.Parse("12783403948858939111232757568359375") };
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
public class A013757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013757Inst Instance=new A013757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013756
{
public static readonly BigInteger[] Value={ 15L,50625L,170859375L,576650390625L,1946195068359375L,6568408355712890625L,BigInteger.Parse("22168378200531005859375"),BigInteger.Parse("74818276426792144775390625"),BigInteger.Parse("252511682940423488616943359375"),BigInteger.Parse("852226929923929274082183837890625"),BigInteger.Parse("2876265888493261300027370452880859375") };
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
public class A013756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013756Inst Instance=new A013756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013755
{
public static readonly BigInteger[] Value={ 196L,537824L,1475789056L,4049565169664L,11112006825558016L,BigInteger.Parse("30491346729331195904"),BigInteger.Parse("83668255425284801560576"),BigInteger.Parse("229585692886981495482220544"),BigInteger.Parse("629983141281877223603213172736"),BigInteger.Parse("1728673739677471101567216945987584"),BigInteger.Parse("4743480741674980702700443299789930496") };
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
public class A013755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013755Inst Instance=new A013755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013754
{
public static readonly BigInteger[] Value={ 14L,38416L,105413504L,289254654976L,793714773254144L,2177953337809371136L,BigInteger.Parse("5976303958948914397184"),BigInteger.Parse("16398978063355821105872896"),BigInteger.Parse("44998795805848373114515226624"),BigInteger.Parse("123476695691247935826229781856256"),BigInteger.Parse("338820052976784335907174521413566464"),BigInteger.Parse("929722225368296217729286886758826377216") };
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
public class A013754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013754Inst Instance=new A013754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013753
{
public static readonly BigInteger[] Value={ 169L,371293L,815730721L,1792160394037L,3937376385699289L,8650415919381337933L,BigInteger.Parse("19004963774880799438801"),BigInteger.Parse("41753905413413116367045797"),BigInteger.Parse("91733330193268616658399616009"),BigInteger.Parse("201538126434611150798503956371773"),BigInteger.Parse("442779263776840698304313192148785281"),BigInteger.Parse("972786042517719014174576083150881262357") };
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
public class A013753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013753Inst Instance=new A013753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013752
{
public static readonly BigInteger[] Value={ 13L,28561L,62748517L,137858491849L,302875106592253L,665416609183179841L,BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("3211838877954855105157369"),BigInteger.Parse("7056410014866816666030739693") };
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
public class A013752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013752Inst Instance=new A013752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013751
{
public static readonly BigInteger[] Value={ 144L,248832L,429981696L,743008370688L,1283918464548864L,2218611106740436992L,BigInteger.Parse("3833759992447475122176"),BigInteger.Parse("6624737266949237011120128"),BigInteger.Parse("11447545997288281555215581184") };
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
public class A013751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013751Inst Instance=new A013751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013750
{
public static readonly BigInteger[] Value={ 12L,20736L,35831808L,61917364224L,106993205379072L,184884258895036416L,BigInteger.Parse("319479999370622926848"),BigInteger.Parse("552061438912436417593344"),BigInteger.Parse("953962166440690129601298432"),BigInteger.Parse("1648446623609512543951043690496") };
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
public class A013750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013750Inst Instance=new A013750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013749
{
public static readonly BigInteger[] Value={ 121L,161051L,214358881L,285311670611L,379749833583241L,505447028499293771L,BigInteger.Parse("672749994932560009201"),BigInteger.Parse("895430243255237372246531"),BigInteger.Parse("1191817653772720942460132761"),BigInteger.Parse("1586309297171491574414436704891"),BigInteger.Parse("2111377674535255285545615254209921") };
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
public class A013749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013749Inst Instance=new A013749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013748
{
public static readonly BigInteger[] Value={ 11L,14641L,19487171L,25937424601L,34522712143931L,45949729863572161L,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("81402749386839761113321"),BigInteger.Parse("108347059433883722041830251"),BigInteger.Parse("144209936106499234037676064081"),BigInteger.Parse("191943424957750480504146841291811") };
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
public class A013748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013748Inst Instance=new A013748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013747
{
public static readonly BigInteger[] Value={ 100L,100000L,100000000L,100000000000L,100000000000000L,100000000000000000L,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("100000000000000000000000"),BigInteger.Parse("100000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000") };
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
public class A013747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013747Inst Instance=new A013747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013746
{
public static readonly BigInteger[] Value={ 10L,10000L,10000000L,10000000000L,10000000000000L,10000000000000000L,10000000000000000000UL,BigInteger.Parse("10000000000000000000000"),BigInteger.Parse("10000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000") };
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
public class A013746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013746Inst Instance=new A013746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013745
{
public static readonly BigInteger[] Value={ 81L,59049L,43046721L,31381059609L,22876792454961L,16677181699666569L,12157665459056928801UL,BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("6461081889226673298932241"),BigInteger.Parse("4710128697246244834921603689"),BigInteger.Parse("3433683820292512484657849089281") };
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
public class A013745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013745Inst Instance=new A013745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013744
{
public static readonly BigInteger[] Value={ 9L,6561L,4782969L,3486784401L,2541865828329L,1853020188851841L,1350851717672992089L,BigInteger.Parse("984770902183611232881"),BigInteger.Parse("717897987691852588770249"),BigInteger.Parse("523347633027360537213511521"),BigInteger.Parse("381520424476945831628649898809") };
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
public class A013744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013744Inst Instance=new A013744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013743
{
public static readonly BigInteger[] Value={ 64L,32768L,16777216L,8589934592L,4398046511104L,2251799813685248L,1152921504606846976L,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("40564819207303340847894502572032") };
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
public class A013743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013743Inst Instance=new A013743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013742
{
public static readonly BigInteger[] Value={ 8L,4096L,2097152L,1073741824L,549755813888L,281474976710656L,144115188075855872L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("9903520314283042199192993792"),BigInteger.Parse("5070602400912917605986812821504") };
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
public class A013742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013742Inst Instance=new A013742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013725
{
public static readonly BigInteger[] Value={ 20L,8000L,3200000L,1280000000L,512000000000L,204800000000000L,81920000000000000L,BigInteger.Parse("32768000000000000000"),BigInteger.Parse("13107200000000000000000"),BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("2097152000000000000000000000") };
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
public class A013725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013725Inst Instance=new A013725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013724
{
public static readonly BigInteger[] Value={ 19L,6859L,2476099L,893871739L,322687697779L,116490258898219L,42052983462257059L,15181127029874798299UL,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("714209495693373205673756419") };
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
public class A013724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013724Inst Instance=new A013724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013723
{
public static readonly BigInteger[] Value={ 18L,5832L,1889568L,612220032L,198359290368L,64268410079232L,20822964865671168L,6746640616477458432L,BigInteger.Parse("2185911559738696531968"),BigInteger.Parse("708235345355337676357632"),BigInteger.Parse("229468251895129407139872768") };
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
public class A013723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013723Inst Instance=new A013723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013722
{
public static readonly BigInteger[] Value={ 17L,4913L,1419857L,410338673L,118587876497L,34271896307633L,9904578032905937L,2862423051509815793L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("239072435685151324847153"),BigInteger.Parse("69091933913008732880827217") };
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
public class A013722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013722Inst Instance=new A013722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013721
{
public static readonly BigInteger[] Value={ 16L,4096L,1048576L,268435456L,68719476736L,17592186044416L,4503599627370496L,1152921504606846976L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("4951760157141521099596496896") };
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
public class A013721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013721Inst Instance=new A013721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013720
{
public static readonly BigInteger[] Value={ 15L,3375L,759375L,170859375L,38443359375L,8649755859375L,1946195068359375L,437893890380859375L,BigInteger.Parse("98526125335693359375"),BigInteger.Parse("22168378200531005859375"),BigInteger.Parse("4987885095119476318359375"),BigInteger.Parse("1122274146401882171630859375") };
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
public class A013720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013720Inst Instance=new A013720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013719
{
public static readonly BigInteger[] Value={ 14L,2744L,537824L,105413504L,20661046784L,4049565169664L,793714773254144L,155568095557812224L,BigInteger.Parse("30491346729331195904"),BigInteger.Parse("5976303958948914397184"),BigInteger.Parse("1171355575953987221848064"),BigInteger.Parse("229585692886981495482220544") };
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
public class A013719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013719Inst Instance=new A013719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013718
{
public static readonly BigInteger[] Value={ 13L,2197L,371293L,62748517L,10604499373L,1792160394037L,302875106592253L,51185893014090757L,8650415919381337933L,BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("247064529073450392704413"),BigInteger.Parse("41753905413413116367045797") };
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
public class A013718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013718Inst Instance=new A013718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013717
{
public static readonly BigInteger[] Value={ 12L,1728L,248832L,35831808L,5159780352L,743008370688L,106993205379072L,15407021574586368L,2218611106740436992L,BigInteger.Parse("319479999370622926848"),BigInteger.Parse("46005119909369701466112"),BigInteger.Parse("6624737266949237011120128") };
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
public class A013717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013717Inst Instance=new A013717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013716
{
public static readonly BigInteger[] Value={ 11L,1331L,161051L,19487171L,2357947691L,285311670611L,34522712143931L,4177248169415651L,505447028499293771L,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("7400249944258160101211"),BigInteger.Parse("895430243255237372246531") };
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
public class A013716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013716Inst Instance=new A013716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013715
{
public static readonly BigInteger[] Value={ 10L,1000L,100000L,10000000L,1000000000L,100000000000L,10000000000000L,1000000000000000L,100000000000000000L,10000000000000000000UL,BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("100000000000000000000000") };
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
public class A013715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013715Inst Instance=new A013715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013714
{
public static readonly BigInteger[] Value={ 9L,729L,59049L,4782969L,387420489L,31381059609L,2541865828329L,205891132094649L,16677181699666569L,1350851717672992089L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("717897987691852588770249"),BigInteger.Parse("58149737003040059690390169") };
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
public class A013714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013714Inst Instance=new A013714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013713
{
public static readonly BigInteger[] Value={ 8L,512L,32768L,2097152L,134217728L,8589934592L,549755813888L,35184372088832L,2251799813685248L,144115188075855872L,9223372036854775808UL,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("2417851639229258349412352") };
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
public class A013713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013713Inst Instance=new A013713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013712
{
public static readonly BigInteger[] Value={ 7L,343L,16807L,823543L,40353607L,1977326743L,96889010407L,4747561509943L,232630513987207L,11398895185373143L,558545864083284007L,BigInteger.Parse("27368747340080916343"),BigInteger.Parse("1341068619663964900807"),BigInteger.Parse("65712362363534280139543"),BigInteger.Parse("3219905755813179726837607") };
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
public class A013712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013712Inst Instance=new A013712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013711
{
public static readonly BigInteger[] Value={ 6L,216L,7776L,279936L,10077696L,362797056L,13060694016L,470184984576L,16926659444736L,609359740010496L,21936950640377856L,789730223053602816L,BigInteger.Parse("28430288029929701376"),BigInteger.Parse("1023490369077469249536"),BigInteger.Parse("36845653286788892983296") };
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
public class A013711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013711Inst Instance=new A013711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013710
{
public static readonly BigInteger[] Value={ 5L,125L,3125L,78125L,1953125L,48828125L,1220703125L,30517578125L,762939453125L,19073486328125L,476837158203125L,11920928955078125L,298023223876953125L,7450580596923828125L,BigInteger.Parse("186264514923095703125") };
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
public class A013710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013710Inst Instance=new A013710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013661
{
public static readonly long[] Value={ 1L,6L,4L,4L,9L,3L,4L,0L,6L,6L,8L,4L,8L,2L,2L,6L,4L,3L,6L,4L,7L,2L,4L,1L,5L,1L,6L,6L,6L,4L,6L,0L,2L,5L,1L,8L,9L,2L,1L,8L,9L,4L,9L,9L,0L,1L,2L,0L,6L,7L,9L,8L,4L,3L,7L,7L,3L,5L,5L,5L,8L,2L,2L,9L,3L,7L,0L,0L,0L,7L,4L,7L,0L,4L,0L,3L,2L,0L,0L,8L,7L,3L,8L,3L,3L,6L,2L,8L,9L,0L,0L,6L,1L,9L,7L,5L,8L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013661Inst : IEnumerable<long>
{
public static readonly long[] Value=A013661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013661.Bytes);
public long this[int i]=>Value[i];

public static A013661Inst Instance=new A013661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013660
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013660Inst : IEnumerable<long>
{
public static readonly long[] Value=A013660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013660.Bytes);
public long this[int i]=>Value[i];

public static A013660Inst Instance=new A013660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013659
{
public static readonly long[] Value={ 4L,2L,1L,8L,14L,4L,36L,18L,2L,9L,28L,6L,64L,32L,338L,16L,3L,392L,46L,8L,100L,50L,14L,25L,20L,3038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013659Inst : IEnumerable<long>
{
public static readonly long[] Value=A013659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013659.Bytes);
public long this[int i]=>Value[i];

public static A013659Inst Instance=new A013659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013658
{
public static readonly long[] Value={ 39L,55L,56L,68L,84L,120L,132L,136L,155L,168L,184L,195L,203L,219L,228L,259L,280L,291L,292L,312L,323L,328L,340L,355L,372L,388L,408L,435L,483L,520L,532L,555L,568L,595L,627L,667L,708L,715L,723L,760L,763L,772L,795L,955L,1003L,1012L,1027L,1227L,1243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013658Inst : IEnumerable<long>
{
public static readonly long[] Value=A013658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013658.Bytes);
public long this[int i]=>Value[i];

public static A013658Inst Instance=new A013658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013657
{
public static readonly long[] Value={ 14L,19L,22L,23L,33L,34L,45L,47L,52L,54L,59L,60L,61L,62L,69L,70L,71L,77L,78L,79L,95L,96L,98L,107L,109L,114L,116L,117L,118L,119L,127L,129L,138L,140L,141L,142L,149L,153L,154L,161L,162L,164L,165L,167L,178L,187L,188L,189L,192L,193L,194L,202L,205L,206L,216L,218L,219L,220L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013657Inst : IEnumerable<long>
{
public static readonly long[] Value=A013657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013657.Bytes);
public long this[int i]=>Value[i];

public static A013657Inst Instance=new A013657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013656
{
public static readonly long[] Value={ 0L,7L,32L,75L,136L,215L,312L,427L,560L,711L,880L,1067L,1272L,1495L,1736L,1995L,2272L,2567L,2880L,3211L,3560L,3927L,4312L,4715L,5136L,5575L,6032L,6507L,7000L,7511L,8040L,8587L,9152L,9735L,10336L,10955L,11592L,12247L,12920L,13611L,14320L,15047L,15792L,16555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013656Inst : IEnumerable<long>
{
public static readonly long[] Value=A013656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013656.Bytes);
public long this[int i]=>Value[i];

public static A013656Inst Instance=new A013656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013655
{
public static readonly long[] Value={ 3L,2L,5L,7L,12L,19L,31L,50L,81L,131L,212L,343L,555L,898L,1453L,2351L,3804L,6155L,9959L,16114L,26073L,42187L,68260L,110447L,178707L,289154L,467861L,757015L,1224876L,1981891L,3206767L,5188658L,8395425L,13584083L,21979508L,35563591L,57543099L,93106690L,150649789L,243756479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013655Inst : IEnumerable<long>
{
public static readonly long[] Value=A013655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013655.Bytes);
public long this[int i]=>Value[i];

public static A013655Inst Instance=new A013655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013654
{
public static readonly long[] Value={ 2L,8L,12L,24L,30L,48L,56L,80L,90L,120L,132L,168L,182L,224L,240L,288L,306L,360L,380L,440L,462L,528L,552L,624L,650L,728L,756L,840L,870L,960L,992L,1088L,1122L,1224L,1260L,1368L,1406L,1520L,1560L,1680L,1722L,1848L,1892L,2024L,2070L,2208L,2256L,2400L,2450L,2600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013654Inst : IEnumerable<long>
{
public static readonly long[] Value=A013654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013654.Bytes);
public long this[int i]=>Value[i];

public static A013654Inst Instance=new A013654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013653
{
public static readonly long[] Value={ 14L,19L,22L,23L,33L,34L,45L,47L,52L,54L,59L,60L,62L,69L,70L,71L,77L,78L,79L,95L,96L,98L,107L,114L,117L,118L,119L,127L,138L,140L,141L,142L,149L,153L,154L,164L,165L,167L,178L,187L,188L,189L,192L,194L,202L,205L,206L,216L,218L,219L,220L,221L,222L,223L,234L,238L,239L,248L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013653Inst : IEnumerable<long>
{
public static readonly long[] Value=A013653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013653.Bytes);
public long this[int i]=>Value[i];

public static A013653Inst Instance=new A013653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013652
{
public static readonly long[] Value={ 7L,13L,21L,31L,32L,43L,44L,46L,57L,58L,61L,67L,73L,74L,75L,76L,86L,88L,91L,92L,93L,94L,97L,103L,106L,108L,109L,111L,112L,113L,115L,116L,124L,129L,133L,134L,135L,136L,137L,139L,151L,157L,158L,159L,160L,161L,162L,163L,166L,172L,179L,181L,183L,184L,185L,186L,190L,191L,193L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013652Inst : IEnumerable<long>
{
public static readonly long[] Value=A013652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013652.Bytes);
public long this[int i]=>Value[i];

public static A013652Inst Instance=new A013652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013651
{
public static readonly long[] Value={ 7L,13L,14L,19L,21L,22L,23L,29L,31L,32L,33L,34L,43L,44L,45L,46L,47L,52L,53L,54L,57L,58L,59L,60L,61L,62L,67L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,85L,86L,88L,91L,92L,93L,94L,95L,96L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013651Inst : IEnumerable<long>
{
public static readonly long[] Value=A013651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013651.Bytes);
public long this[int i]=>Value[i];

public static A013651Inst Instance=new A013651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013650
{
public static readonly long[] Value={ 7L,32L,75L,88L,136L,215L,279L,280L,312L,403L,427L,560L,711L,736L,851L,880L,923L,1007L,1067L,1272L,1311L,1363L,1431L,1495L,1736L,1855L,1887L,1955L,1976L,1995L,2128L,2159L,2184L,2272L,2511L,2567L,2640L,2728L,2880L,3055L,3211L,3560L,3751L,3811L,3927L,3984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013650Inst : IEnumerable<long>
{
public static readonly long[] Value=A013650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013650.Bytes);
public long this[int i]=>Value[i];

public static A013650Inst Instance=new A013650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013649
{
public static readonly long[] Value={ 14L,19L,22L,23L,29L,33L,34L,45L,47L,52L,53L,54L,59L,60L,62L,69L,70L,71L,77L,78L,79L,85L,95L,96L,98L,107L,114L,117L,118L,119L,125L,127L,138L,140L,141L,142L,149L,153L,154L,164L,165L,167L,173L,178L,187L,188L,189L,192L,194L,202L,205L,206L,216L,218L,219L,220L,221L,222L,223L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013649Inst : IEnumerable<long>
{
public static readonly long[] Value=A013649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013649.Bytes);
public long this[int i]=>Value[i];

public static A013649Inst Instance=new A013649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013648
{
public static readonly long[] Value={ 3L,8L,15L,24L,35L,48L,63L,80L,99L,120L,143L,168L,175L,176L,195L,208L,224L,255L,288L,323L,360L,399L,440L,483L,528L,551L,575L,624L,675L,728L,783L,799L,840L,899L,960L,1023L,1035L,1088L,1155L,1224L,1247L,1295L,1368L,1403L,1443L,1520L,1599L,1680L,1763L,1848L,1872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013648Inst : IEnumerable<long>
{
public static readonly long[] Value=A013648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013648.Bytes);
public long this[int i]=>Value[i];

public static A013648Inst Instance=new A013648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013647
{
public static readonly long[] Value={ 2L,5L,6L,10L,11L,12L,17L,18L,20L,26L,27L,28L,30L,37L,38L,39L,40L,41L,42L,50L,51L,55L,56L,65L,66L,68L,72L,82L,83L,84L,87L,89L,90L,101L,102L,104L,105L,110L,122L,123L,126L,128L,130L,131L,132L,145L,146L,147L,148L,150L,152L,155L,156L,170L,171L,174L,177L,180L,182L,197L,198L,200L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013647Inst : IEnumerable<long>
{
public static readonly long[] Value=A013647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013647.Bytes);
public long this[int i]=>Value[i];

public static A013647Inst Instance=new A013647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013646
{
public static readonly long[] Value={ 1L,2L,3L,41L,7L,13L,19L,58L,31L,106L,43L,61L,46L,193L,134L,109L,94L,157L,139L,337L,151L,181L,166L,586L,271L,457L,211L,949L,334L,821L,379L,601L,463L,613L,331L,1061L,478L,421L,619L,541L,526L,1117L,571L,1153L,604L,1249L,694L,1069L,631L,1021L,1051L,1201L,751L,1669L,886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013646Inst : IEnumerable<long>
{
public static readonly long[] Value=A013646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013646.Bytes);
public long this[int i]=>Value[i];

public static A013646Inst Instance=new A013646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013613
{
public static readonly long[] Value={ 1L,1L,6L,1L,12L,36L,1L,18L,108L,216L,1L,24L,216L,864L,1296L,1L,30L,360L,2160L,6480L,7776L,1L,36L,540L,4320L,19440L,46656L,46656L,1L,42L,756L,7560L,45360L,163296L,326592L,279936L,1L,48L,1008L,12096L,90720L,435456L,1306368L,2239488L,1679616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013613Inst : IEnumerable<long>
{
public static readonly long[] Value=A013613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013613.Bytes);
public long this[int i]=>Value[i];

public static A013613Inst Instance=new A013613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013612
{
public static readonly long[] Value={ 1L,1L,5L,1L,10L,25L,1L,15L,75L,125L,1L,20L,150L,500L,625L,1L,25L,250L,1250L,3125L,3125L,1L,30L,375L,2500L,9375L,18750L,15625L,1L,35L,525L,4375L,21875L,65625L,109375L,78125L,1L,40L,700L,7000L,43750L,175000L,437500L,625000L,390625L,1L,45L,900L,10500L,78750L,393750L,1312500L,2812500L,3515625L,1953125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013612Inst : IEnumerable<long>
{
public static readonly long[] Value=A013612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013612.Bytes);
public long this[int i]=>Value[i];

public static A013612Inst Instance=new A013612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013611
{
public static readonly long[] Value={ 1L,1L,4L,1L,8L,16L,1L,12L,48L,64L,1L,16L,96L,256L,256L,1L,20L,160L,640L,1280L,1024L,1L,24L,240L,1280L,3840L,6144L,4096L,1L,28L,336L,2240L,8960L,21504L,28672L,16384L,1L,32L,448L,3584L,17920L,57344L,114688L,131072L,65536L,1L,36L,576L,5376L,32256L,129024L,344064L,589824L,589824L,262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013611Inst : IEnumerable<long>
{
public static readonly long[] Value=A013611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013611.Bytes);
public long this[int i]=>Value[i];

public static A013611Inst Instance=new A013611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013610
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,9L,1L,9L,27L,27L,1L,12L,54L,108L,81L,1L,15L,90L,270L,405L,243L,1L,18L,135L,540L,1215L,1458L,729L,1L,21L,189L,945L,2835L,5103L,5103L,2187L,1L,24L,252L,1512L,5670L,13608L,20412L,17496L,6561L,1L,27L,324L,2268L,10206L,30618L,61236L,78732L,59049L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013610Inst : IEnumerable<long>
{
public static readonly long[] Value=A013610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013610.Bytes);
public long this[int i]=>Value[i];

public static A013610Inst Instance=new A013610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013609
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,6L,12L,8L,1L,8L,24L,32L,16L,1L,10L,40L,80L,80L,32L,1L,12L,60L,160L,240L,192L,64L,1L,14L,84L,280L,560L,672L,448L,128L,1L,16L,112L,448L,1120L,1792L,1792L,1024L,256L,1L,18L,144L,672L,2016L,4032L,5376L,4608L,2304L,512L,1L,20L,180L,960L,3360L,8064L,13440L,15360L,11520L,5120L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013609Inst : IEnumerable<long>
{
public static readonly long[] Value=A013609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013609.Bytes);
public long this[int i]=>Value[i];

public static A013609Inst Instance=new A013609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013608
{
public static readonly long[] Value={ 2L,2L,6L,2L,20L,6L,2L,2L,6L,8L,44L,2L,36L,32L,2L,24L,36L,50L,92L,18L,6L,32L,86L,60L,6L,50L,12L,2L,186L,18L,2L,72L,6L,12L,60L,12L,260L,116L,86L,24L,96L,102L,66L,44L,18L,86L,110L,48L,6L,8L,72L,212L,138L,6L,104L,138L,90L,270L,114L,152L,30L,150L,50L,150L,66L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013608Inst : IEnumerable<long>
{
public static readonly long[] Value=A013608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013608.Bytes);
public long this[int i]=>Value[i];

public static A013608Inst Instance=new A013608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013607
{
public static readonly long[] Value={ 1L,5L,5L,5L,17L,7L,17L,7L,7L,7L,59L,19L,17L,13L,7L,19L,49L,13L,19L,7L,23L,35L,19L,89L,17L,119L,29L,55L,5L,19L,5L,59L,85L,5L,17L,35L,59L,83L,49L,115L,19L,23L,43L,109L,103L,7L,23L,19L,7L,245L,43L,13L,5L,55L,89L,83L,143L,53L,53L,383L,7L,55L,113L,37L,5L,23L,143L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013607Inst : IEnumerable<long>
{
public static readonly long[] Value=A013607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013607.Bytes);
public long this[int i]=>Value[i];

public static A013607Inst Instance=new A013607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013606
{
public static readonly long[] Value={ 1L,3L,3L,5L,3L,3L,3L,15L,5L,3L,3L,3L,5L,57L,35L,5L,41L,5L,45L,87L,11L,17L,21L,59L,27L,47L,33L,5L,27L,93L,57L,59L,5L,23L,35L,93L,35L,15L,11L,65L,57L,35L,35L,299L,33L,83L,3L,17L,51L,15L,33L,17L,117L,59L,21L,75L,11L,3L,5L,119L,3L,59L,137L,159L,5L,347L,45L,113L,105L,27L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013606Inst : IEnumerable<long>
{
public static readonly long[] Value=A013606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013606.Bytes);
public long this[int i]=>Value[i];

public static A013606Inst Instance=new A013606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013605
{
public static readonly long[] Value={ 2L,2L,12L,6L,4L,6L,4L,44L,16L,6L,12L,12L,52L,2L,4L,62L,16L,102L,16L,26L,54L,54L,36L,38L,64L,2L,12L,42L,16L,102L,18L,72L,42L,68L,256L,18L,52L,84L,234L,54L,34L,72L,274L,266L,36L,14L,4L,56L,162L,2L,24L,122L,6L,14L,94L,446L,72L,56L,298L,384L,28L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013605Inst : IEnumerable<long>
{
public static readonly long[] Value=A013605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013605.Bytes);
public long this[int i]=>Value[i];

public static A013605Inst Instance=new A013605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013604
{
public static readonly long[] Value={ 1L,2L,4L,2L,2L,2L,8L,8L,2L,20L,16L,58L,22L,8L,16L,98L,10L,10L,14L,8L,4L,2L,20L,28L,20L,20L,26L,22L,14L,26L,4L,34L,52L,56L,28L,10L,2L,10L,58L,38L,2L,122L,74L,34L,22L,22L,46L,44L,50L,46L,16L,124L,4L,10L,106L,10L,26L,220L,38L,160L,74L,8L,28L,104L,104L,38L,298L,94L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013604Inst : IEnumerable<long>
{
public static readonly long[] Value=A013604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013604.Bytes);
public long this[int i]=>Value[i];

public static A013604Inst Instance=new A013604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013603
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,3L,1L,5L,3L,3L,9L,3L,1L,3L,19L,15L,1L,5L,1L,3L,9L,3L,15L,3L,39L,5L,39L,57L,3L,35L,1L,5L,9L,41L,31L,5L,25L,45L,7L,87L,21L,11L,57L,17L,55L,21L,115L,59L,81L,27L,129L,47L,111L,33L,55L,5L,13L,27L,55L,93L,1L,57L,25L,59L,49L,5L,19L,23L,19L,35L,231L,93L,69L,35L,97L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013603Inst : IEnumerable<long>
{
public static readonly long[] Value=A013603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013603.Bytes);
public long this[int i]=>Value[i];

public static A013603Inst Instance=new A013603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013602
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,7L,3L,27L,1L,3L,7L,15L,43L,15L,3L,3L,15L,25L,31L,7L,15L,15L,7L,15L,21L,55L,21L,159L,81L,69L,33L,135L,13L,9L,33L,25L,15L,37L,15L,7L,13L,9L,3L,27L,7L,133L,25L,129L,61L,7L,277L,267L,111L,99L,33L,27L,25L,43L,33L,25L,451L,277L,67L,7L,51L,169L,67L,27L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013602Inst : IEnumerable<long>
{
public static readonly long[] Value=A013602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013602.Bytes);
public long this[int i]=>Value[i];

public static A013602Inst Instance=new A013602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013601
{
public static readonly long[] Value={ 1L,4L,4L,4L,10L,4L,10L,4L,16L,4L,18L,10L,16L,40L,4L,66L,6L,24L,48L,24L,16L,52L,102L,4L,46L,60L,10L,24L,76L,10L,114L,18L,90L,40L,24L,36L,6L,72L,22L,24L,232L,10L,54L,60L,216L,160L,174L,34L,48L,24L,382L,88L,48L,10L,124L,10L,58L,34L,132L,214L,46L,22L,40L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013601Inst : IEnumerable<long>
{
public static readonly long[] Value=A013601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013601.Bytes);
public long this[int i]=>Value[i];

public static A013601Inst Instance=new A013601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013600
{
public static readonly long[] Value={ 1L,1L,1L,7L,1L,13L,7L,5L,11L,25L,5L,35L,35L,35L,5L,91L,47L,35L,5L,17L,11L,7L,103L,61L,7L,13L,23L,7L,25L,47L,7L,73L,5L,41L,133L,77L,101L,103L,193L,61L,47L,187L,71L,35L,215L,83L,121L,95L,37L,95L,145L,35L,77L,13L,7L,5L,25L,77L,47L,283L,235L,23L,137L,137L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013600Inst : IEnumerable<long>
{
public static readonly long[] Value=A013600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013600.Bytes);
public long this[int i]=>Value[i];

public static A013600Inst Instance=new A013600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013599
{
public static readonly long[] Value={ 1L,2L,4L,2L,6L,12L,4L,12L,22L,26L,4L,14L,58L,6L,12L,42L,24L,2L,12L,56L,48L,24L,18L,38L,58L,14L,12L,38L,34L,62L,28L,92L,214L,122L,102L,168L,136L,18L,48L,102L,108L,126L,18L,126L,76L,108L,22L,204L,52L,122L,96L,114L,94L,14L,52L,38L,58L,248L,64L,56L,16L,102L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013599Inst : IEnumerable<long>
{
public static readonly long[] Value=A013599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013599.Bytes);
public long this[int i]=>Value[i];

public static A013599Inst Instance=new A013599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013598
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,8L,4L,16L,2L,4L,2L,20L,16L,8L,2L,2L,26L,34L,10L,56L,8L,56L,4L,32L,2L,14L,2L,16L,26L,130L,4L,16L,70L,70L,34L,22L,2L,50L,8L,82L,118L,70L,4L,52L,8L,46L,68L,52L,56L,16L,28L,34L,50L,26L,28L,20L,62L,4L,158L,64L,16L,34L,122L,2L,92L,64L,28L,230L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013598Inst : IEnumerable<long>
{
public static readonly long[] Value=A013598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013598.Bytes);
public long this[int i]=>Value[i];

public static A013598Inst Instance=new A013598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013549
{
public static readonly long[] Value={ 1L,2L,4L,10L,41L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013549Inst : IEnumerable<long>
{
public static readonly long[] Value=A013549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013549.Bytes);
public long this[int i]=>Value[i];

public static A013549Inst Instance=new A013549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013548
{
public static readonly BigInteger[] Value={ 1L,-1L,221L,-244939L,1846213L,-526960582373L,23968139993843L,-5189795464140757L,BigInteger.Parse("36594801159269740631"),BigInteger.Parse("-16691319229288614334663751"),BigInteger.Parse("11409300606349966887237659743"),BigInteger.Parse("-198510162914463324156683262269") };
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
public class A013548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013548Inst Instance=new A013548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013547
{
public static readonly BigInteger[] Value={ 1L,1L,-211L,169339L,-205787L,124654123973L,4233334384067L,458968419865477L,460700758945363763L,BigInteger.Parse("1003433160159825045756551"),BigInteger.Parse("1160527066076017343605453327"),BigInteger.Parse("537107192671326620106145350461"),BigInteger.Parse("11100661279966114788004381836713"),BigInteger.Parse("90437772951214017777023420366691881") };
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
public class A013547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013547Inst Instance=new A013547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013546
{
public static readonly BigInteger[] Value={ 1L,1L,-215L,199159L,-4128623L,257347648013L,-111384981593L,1407269115959761L,69849267671401979L,BigInteger.Parse("467410556088873329284747"),BigInteger.Parse("429563383515510620615310131"),BigInteger.Parse("652256640736921402479041889329"),BigInteger.Parse("137438707390027290209533044701"),BigInteger.Parse("432938003151091640246284451153923"),BigInteger.Parse("5720446637387424876679468922735017734533") };
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
public class A013546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013546Inst Instance=new A013546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013545
{
public static readonly BigInteger[] Value={ -1L,13L,29L,397L,74927L,2570951L,495301L,2978520989L,879781928617L,1962442468445621L,4485273725677799419L,17810142018975186977UL };
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
public class A013545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013545Inst Instance=new A013545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013544
{
public static readonly BigInteger[] Value={ -1L,7L,-1013L,64763L,-3009173L,5341411709L,-857007547621L,28828641126011L,-1030088087041163819L,BigInteger.Parse("108508429719458111069"),BigInteger.Parse("-2005462402042629244533103"),BigInteger.Parse("41348510060126079043949299"),BigInteger.Parse("-132583025047910486114666220223") };
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
public class A013544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013544Inst Instance=new A013544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013543
{
public static readonly BigInteger[] Value={ -1L,55L,-95L,18167L,-22118287L,51054985L,-10169116451L,211416785949641L,-36975734097804001L,BigInteger.Parse("764839113579826244863"),BigInteger.Parse("-45988950723178614316250507"),BigInteger.Parse("61286790868827586032169553"),BigInteger.Parse("-25771544562210083470157315437") };
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
public class A013543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013543Inst Instance=new A013543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013542
{
public static readonly BigInteger[] Value={ -1L,53L,3341L,391337L,710371933L,6178130243L,225570264096917L,1546226961439379L,BigInteger.Parse("5665951032145572087083"),BigInteger.Parse("-1602619428542796266047"),BigInteger.Parse("218332153959703843484481031721"),BigInteger.Parse("-149315097238822774731841867") };
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
public class A013542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013542Inst Instance=new A013542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013541
{
public static readonly BigInteger[] Value={ 1L,-1L,217L,-214279L,824071L,-337533513773L,8320611986431L,-2303253020856673L,7111553692366818727L,BigInteger.Parse("-4825610634542923917792887"),BigInteger.Parse("6031202702741413913839327"),BigInteger.Parse("-1707209475196496091030335944673") };
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
public class A013541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013541Inst Instance=new A013541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013540
{
public static readonly BigInteger[] Value={ -1L,7L,-17L,913L,-93959L,9405719L,-8909477L,211410621413L,-6740064210937L,2805742760628347L,-761503407533329723L,BigInteger.Parse("340317674208644677253"),BigInteger.Parse("-38791272133810800467"),BigInteger.Parse("1468818906393936912860264741") };
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
public class A013540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013540Inst Instance=new A013540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013539
{
public static readonly BigInteger[] Value={ -1L,13L,877L,2675L,8260913L,410433607L,223758294041L,27276568423051L,127639993821278611L,10512596641186789291UL,BigInteger.Parse("8302408982767874894797"),BigInteger.Parse("3077103479886222660379217") };
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
public class A013539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013539Inst Instance=new A013539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013538
{
public static readonly BigInteger[] Value={ -1L,53L,73L,45137L,11226497L,129163393L,474807665L,198247921612319L,618559606844489L,BigInteger.Parse("395129918156594369761"),BigInteger.Parse("2883495145728730085501149"),BigInteger.Parse("704455206007099333581073"),BigInteger.Parse("4366595916673463219275798447"),BigInteger.Parse("10742815369857597784418536545975463") };
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
public class A013538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013538Inst Instance=new A013538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013537
{
public static readonly BigInteger[] Value={ -1L,55L,-4219L,802171L,-109684277L,760100160121L,-265779449377027L,417652078505070229L,BigInteger.Parse("-7396136516120375032117"),BigInteger.Parse("1432995839205684739321951"),BigInteger.Parse("-63523043223346003438419401363"),BigInteger.Parse("2351819493900615585072181702093") };
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
public class A013537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013537Inst Instance=new A013537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013536
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,53L,-215L,3341L,199159L,391337L,-4128623L,710371933L,257347648013L,6178130243L,-111384981593L,225570264096917L,1407269115959761L,1546226961439379L,69849267671401979L,BigInteger.Parse("5665951032145572087083"),BigInteger.Parse("467410556088873329284747"),BigInteger.Parse("-1602619428542796266047"),BigInteger.Parse("429563383515510620615310131"),BigInteger.Parse("218332153959703843484481031721") };
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
public class A013536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013536Inst Instance=new A013536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013535
{
public static readonly BigInteger[] Value={ 1L,1L,5L,5449L,6973L,518819753L,1489058191L,293416964947L,2531578641757L,8778884852410565513L,BigInteger.Parse("2503198198587351877067"),BigInteger.Parse("2378459715706347981795671"),BigInteger.Parse("2343990771779851025499037"),BigInteger.Parse("521048260968673067986908628597"),BigInteger.Parse("35145358095152621756454620279473") };
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
public class A013535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013535Inst Instance=new A013535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013534
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-5029L,6697L,-375719873L,186044689L,-1770350411L,102625697881591L,BigInteger.Parse("-15912188224095499151"),BigInteger.Parse("1419184560088744177499"),BigInteger.Parse("-323645955378411578735051"),BigInteger.Parse("935339682040604214800761"),BigInteger.Parse("-36813244507954712597112169117"),BigInteger.Parse("45816041290074218754101655557981") };
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
public class A013534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013534Inst Instance=new A013534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013517
{
public static readonly BigInteger[] Value={ 2L,48L,1280L,129024L,1769472L,81749606400L,4637432217600L,3296144130048000L,BigInteger.Parse("46620662575398912000") };
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
public class A013517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013517Inst Instance=new A013517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013516
{
public static readonly BigInteger[] Value={ 1L,2L,8L,16L,128L,3840L,15360L,92160L,1474560L,185794560L,3715891200L,117964800L,2831155200L,51011754393600L,13603134504960L,8569974738124800L,1371195958099968000L,BigInteger.Parse("46620662575398912000"),BigInteger.Parse("239763407530622976000") };
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
public class A013516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013516Inst Instance=new A013516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013515
{
public static readonly BigInteger[] Value={ 1L,-12L,1568L,6840768L,-41485549312L,-616649036623872L,BigInteger.Parse("51689032519042469888"),BigInteger.Parse("309411873154808535072768") };
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
public class A013515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013515Inst Instance=new A013515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}